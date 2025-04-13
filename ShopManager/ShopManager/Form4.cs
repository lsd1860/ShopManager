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
    public partial class Form4 : frmBase
    {

        public int SALE_ID = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
                                           new SqlParameter("@SALE_ID", SALE_ID)                                           
                                           };
                    ds = biz.ExecuteDataset(param, "USP_TB_SALE_SELECT");
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            dateTimePicker1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["SALE_DT"]);
                            txtAmt2.Text = Convert.ToInt32(ds.Tables[0].Rows[0]["SALE_AMT"]).ToString("#,###");
                        }

                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            int sum = 0;
                            dataGridView1.Rows.Clear();
                            for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(
                                    ds.Tables[1].Rows[i]["PRODUCT_NAME"].ToString(),
                                    ds.Tables[1].Rows[i]["PRICE"],
                                    ds.Tables[1].Rows[i]["QTY"],
                                    ds.Tables[1].Rows[i]["AMT"]
                                );

                                sum += Convert.ToInt32(ds.Tables[1].Rows[0]["AMT"]);
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
            frmPopupProduct frm = new frmPopupProduct();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < frm.dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell colSelectYn = frm.dataGridView1.Rows[i].Cells["colSelectYn"] as DataGridViewCheckBoxCell;

                    bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                    if (USE_YN)
                    {
                        string PRODUCT_NAME = frm.dataGridView1.Rows[i].Cells["PRODUCT_NAME"].Value.ToString();
                        int price = Convert.ToInt32(frm.dataGridView1.Rows[i].Cells["PRICE"].Value);

                        dataGridView1.Rows.Add(PRODUCT_NAME, price, 1, price);                           
                            
                    }

                }

                setAmtCalc();

                txtAmt2.Focus();

            }

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
                MessageBox.Show("상품을 추가하세요.");
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
                                  new SqlParameter("@WORK_ID", SALE_ID),                                  
                                  new SqlParameter("@MEMBER_ID", txtMemberID.Text),
                                  new SqlParameter("@SALE_DT", dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                                  new SqlParameter("@SALE_AMT", txtAmt2.Text.Replace(",",""))
                                };

                ds = biz.ExecuteDataset(param, "USP_TB_SALE_SAVE");

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (SALE_ID == 0)
                        {
                            SALE_ID = Convert.ToInt32(ds.Tables[0].Rows[0]["SALE_ID"]);
                        }

                        cnt++;
                    }
                }

                if (SALE_ID != 0)
                {

                    dataGridView1.EndEdit();

                    using (DB_Biz biz2 = new DB_Biz())
                    {
                        SqlParameter[] param2 = {
                                            new SqlParameter("@SALE_ID", SALE_ID)
                                        };

                        biz2.ExecuteNonQuery(param2, "USP_TB_SALE_PRODUCT_DELETE");
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            string PRODUCT_NAME = dataGridView1.Rows[i].Cells["PRODUCT_NAME"].Value.ToString();
                            int Price = Convert.ToInt32(dataGridView1.Rows[i].Cells["PRICE"].Value);
                            int Qty = Convert.ToInt32(dataGridView1.Rows[i].Cells["QTY"].Value);

                            SqlParameter[] param3 = {
                                                    new SqlParameter("@SALE_ID", SALE_ID),
                                                    new SqlParameter("@PRODUCT_NAME", PRODUCT_NAME),
                                                    new SqlParameter("@PRICE", Price),
                                                    new SqlParameter("@QTY", Qty)
                                                };

                            rtn = biz2.ExecuteNonQuery(param3, "USP_TB_SALE_PRODUCT_INSERT");
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
            if (MessageBox.Show("선택한 구매내역을 삭제합니다.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (SALE_ID == 0)
            {
                MessageBox.Show("삭제할 항목이 없습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = {
                        new SqlParameter("@SALE_ID", SALE_ID),
                    };

                    biz.ExecuteNonQuery(param, "USP_TB_SALE_DELETE");

                    MessageBox.Show("삭제되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AllowNumberOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumberOnly;
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += AllowNumberOnly;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            if (e.ColumnIndex == 2)
            {
                string PRODUCT_NAME = dataGridView1.Rows[e.RowIndex].Cells["PRODUCT_NAME"].Value.ToString();
                int price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PRICE"].Value);
                int qty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["QTY"].Value);

                dataGridView1.Rows[e.RowIndex].Cells["AMT"].Value = price * qty;

                setAmtCalc();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
