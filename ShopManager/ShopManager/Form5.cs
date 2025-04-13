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
    public partial class Form5 : frmBase
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Control_Init();
        }

        private void Control_Init()
        {
            getContents();
            dataGridView1.RowHeadersWidth = 50;
            //            dataGridView1.Rows[0].HeaderCell.Value = "C";

        }

        private void getContents()
        {
            DataSet ds = new DataSet();
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {                    
                    SqlParameter[] param = {};
                    ds = biz.ExecuteDataset(param, "USP_TB_CLINIC_SELECT");

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            dataGridView1.Rows[e.RowIndex].HeaderCell.Value = "C";
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                Clipboard.SetDataObject(dataGridView1.GetClipboardContent().GetText(TextDataFormat.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 항목을 삭제합니다.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string colClinicID = dataGridView1.CurrentRow.Cells["colClinicID"].Value.ToString();


            if (colClinicID == "")
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
                      new SqlParameter("@CLINIC_ID", colClinicID),
                    };

                    int rtn = biz.ExecuteNonQuery(param, "USP_TB_CLINIC_DELETE");

                    if (rtn == 1)
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                        MessageBox.Show("삭제되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int cnt = 0;

            dataGridView1.EndEdit();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewHeaderCell hc = new DataGridViewHeaderCell();

                hc = dataGridView1.Rows[i].HeaderCell;
                if (hc.Value != null)
                {

                    if (hc.Value.ToString() == "C")
                    {
                        string colClinicID = dataGridView1.Rows[i].Cells["colClinicID"].Value.ToString();
                        string ClinicName = dataGridView1.Rows[i].Cells["colClinicName"].Value.ToString();
                        int Price = Convert.ToInt32(dataGridView1.Rows[i].Cells["colPrice"].Value);

                        DataGridViewCheckBoxCell colUseYn = dataGridView1.Rows[i].Cells["colUseYn"] as DataGridViewCheckBoxCell;

                        bool USE_YN = Convert.ToBoolean(colUseYn.Value == DBNull.Value ? false : colUseYn.Value);

                        if (string.IsNullOrEmpty(ClinicName) ||
                            dataGridView1.Rows[i].Cells["colPrice"].Value == DBNull.Value
                        )
                        {
                            MessageBox.Show("입력되지 않은 항목이 있습니다..", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            return;
                        }


                        try
                        {
                            using (DB_Biz biz = new DB_Biz())
                            {
                                DataSet ds = new DataSet();
                                SqlParameter[] param = {
                                  new SqlParameter("@CLINIC_ID", colClinicID == "" ? "0" : colClinicID),
                                  new SqlParameter("@CLINIC_NAME", ClinicName),
                                  new SqlParameter("@PRICE", Price),
                                  new SqlParameter("@USE_YN", USE_YN)
                                };
                                ds = biz.ExecuteDataset(param, "USP_TB_CLINIC_SAVE");

                                if (ds.Tables.Count > 0)
                                {
                                    if (ds.Tables[0].Rows.Count > 0)
                                    {
                                        if (colClinicID == "")
                                        {
                                            dataGridView1.Rows[i].Cells["colClinicID"].Value = ds.Tables[0].Rows[0]["CLINIC_ID"].ToString();
                                        }
                                        dataGridView1.Rows[i].HeaderCell.Value = "";
                                        cnt++;
                                    }
                                }

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }

                }
            }

            if (cnt > 0)
            {
                MessageBox.Show("저장되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
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
    }
}
