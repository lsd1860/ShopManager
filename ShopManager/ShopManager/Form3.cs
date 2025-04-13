using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBClassLibrary;
using System.Data.SqlClient;

namespace ShopManager
{
    public partial class Form3 : frmBase
    {

        public int WORK_ID = 5;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Control_Init();
        }

        private void Control_Init()
        {
            getContents();
        }

        private void getContents()
        {
            

            DataSet ds = new DataSet();
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    SqlParameter[] param = { 
                                           new SqlParameter("@WORK_ID", WORK_ID)                                           
                                           };
                    ds = biz.ExecuteDataset(param, "USP_TB_WORK_SELECT");
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["WORK_DT"]);
                            txtAmt2.Text = Convert.ToInt32(ds.Tables[0].Rows[0]["WORK_AMT"]).ToString("#,###");
                        }

                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            int sum = 0;
                            dataGridView1.Rows.Clear();
                            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(
                                    ds.Tables[1].Rows[i]["CLINIC_NAME"].ToString(),
                                    ds.Tables[1].Rows[i]["PRICE"],
                                    ds.Tables[1].Rows[i]["QTY"],
                                    ds.Tables[1].Rows[i]["AMT"]
                                );

                                sum += Convert.ToInt32(ds.Tables[1].Rows[i]["AMT"]);
                            }
                            txtAmt1.Text = sum.ToString("#,###");
                        }
                    }

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPopupClinic frm = new frmPopupClinic();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < frm.dvClinic.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell colSelectYn = frm.dvClinic.Rows[i].Cells["colSelectYn"] as DataGridViewCheckBoxCell;

                    bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                    if (USE_YN)
                    {
                        dataGridView1.Rows.Add(
                            frm.dvClinic.Rows[i].Cells["CLINIC_NAME"].Value.ToString(),
                            frm.dvClinic.Rows[i].Cells["CLINIC_PRICE"].Value,
                            1,
                            frm.dvClinic.Rows[i].Cells["CLINIC_PRICE"].Value
                        );
                    }
                    
                }
                for (int i = 0; i < frm.dvProduct.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell colSelectYn2 = frm.dvProduct.Rows[i].Cells["colSelectYn2"] as DataGridViewCheckBoxCell;

                    bool USE_YN = Convert.ToBoolean(colSelectYn2.Value == DBNull.Value ? false : colSelectYn2.Value);

                    if (USE_YN)
                    {
                        dataGridView1.Rows.Add(
                            frm.dvProduct.Rows[i].Cells["PRODUCT_NAME"].Value.ToString(),
                            frm.dvProduct.Rows[i].Cells["PRODUCT_PRICE"].Value,
                            1,
                            frm.dvProduct.Rows[i].Cells["PRODUCT_PRICE"].Value
                        );
                    }

                }
                
                setAmtCalc();

                txtAmt2.Focus();

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }                
            }

            setAmtCalc();

        }

        private void setAmtCalc()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["AMT"].Value);
            }
            txtAmt1.Text = sum.ToString("#,###");
            txtAmt2.Text = sum.ToString("#,###");

            txtAmt2.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            int rtn = 0;

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("클리닉을 추가하세요.");
                return;
            }
            if (txtMemberID.Text == "")
            {
                MessageBox.Show("회원번호가 없습니다.");
                return;
            }

            using (DB_Biz biz = new DB_Biz())
            {
                DataSet ds = new DataSet();
                SqlParameter[] param = {
                                  new SqlParameter("@WORK_ID", WORK_ID),                                  
                                  new SqlParameter("@MEMBER_ID", txtMemberID.Text),
                                  new SqlParameter("@WORK_DT", dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                                  new SqlParameter("@CLINIC_AMT", txtAmt2.Text.Replace(",",""))
                                };

                ds = biz.ExecuteDataset(param, "USP_TB_WORK_SAVE");

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (WORK_ID == 0)
                        {
                            WORK_ID = Convert.ToInt32(ds.Tables[0].Rows[0]["WORK_ID"]);
                        }

                        cnt++;
                    }
                }

                if (WORK_ID != 0)
                {                    

                    dataGridView1.EndEdit();

                    using (DB_Biz biz2 = new DB_Biz())
                    {
                        SqlParameter[] param2 = {
                                            new SqlParameter("@WORK_ID", WORK_ID)
                                        };

                        biz2.ExecuteNonQuery(param2, "USP_TB_WORK_CLINIC_DELETE");
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            string CLINIC_NAME = dataGridView1.Rows[i].Cells["CLINIC_NAME"].Value.ToString();
                            int Price = Convert.ToInt32(dataGridView1.Rows[i].Cells["PRICE"].Value);
                            int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells["QTY"].Value);
                            SqlParameter[] param3 = {
                                                    new SqlParameter("@WORK_ID", WORK_ID),
                                                    new SqlParameter("@CLINIC_NAME", CLINIC_NAME),
                                                    new SqlParameter("@PRICE", Price),
                                                    new SqlParameter("@QTY", Qty),

                                                };

                            rtn = biz2.ExecuteNonQuery(param3, "USP_TB_WORK_CLINIC_INSERT");
                            if (rtn == 1)
                            {
                                cnt++;
                            }

                        }
                    
                    }                   

                }

                if (cnt > 0)
                {
                    MessageBox.Show("저장되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }


            
        }

        private void txtAmt1_DoubleClick(object sender, EventArgs e)
        {
            txtAmt2.Text = txtAmt1.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 항목을 삭제합니다.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (WORK_ID == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = {
                        new SqlParameter("@WORK_ID", WORK_ID),
                    };

                    biz.ExecuteNonQuery(param, "USP_TB_WORK_DELETE");
                    MessageBox.Show("삭제되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            if (e.ColumnIndex == 2)
            {
                string CLINIC_NAME = dataGridView1.Rows[e.RowIndex].Cells["CLINIC_NAME"].Value.ToString();
                int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PRICE"].Value);
                int qty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QTY"].Value);

                dataGridView1.Rows[e.RowIndex].Cells["AMT"].Value = price * qty;

                setAmtCalc();
            }
        }

    }
}
