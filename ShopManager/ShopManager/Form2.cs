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
    public partial class Form2 : frmBase
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    SqlParameter[] param = { 
                                           new SqlParameter("@FRDATE", dateTimePicker1.Value.ToString("yyyy-MM-dd")),
                                           new SqlParameter("@TODATE", dateTimePicker2.Value.ToString("yyyy-MM-dd")),
                                           new SqlParameter("@KEYWORD", txtKeyWord.Text),
                                           new SqlParameter("@KEYWORD2", txtKeyWord2.Text),
                                           };
                    ds = biz.ExecuteDataset(param, "USP_GETDATA");
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds.Tables.Count>1)
                    {
                        txtTot.Text = Convert.ToInt32(ds.Tables[1].Rows[0]["TOT"]).ToString("#,###");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            int AOM_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AOM_ID"].Value);
            int MEMBER_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MEMBER_ID"].Value);
            string sMEMBER_NAME = dataGridView1.Rows[e.RowIndex].Cells["MEMBER_NAME"].Value.ToString();

            Form3 frm = new Form3();
            frm.WORK_ID = AOM_ID;
            frm.txtMemberID.Text = MEMBER_ID.ToString();
            frm.txtMemberName.Text = sMEMBER_NAME;
            frm.ShowDialog();

            //if (sKUBUN == "클리닉")
            //{
               
            //}
            //else
            //{
            //    Form4 frm = new Form4();
            //    frm.SALE_ID = AOM_ID;
            //    frm.txtMemberID.Text = MEMBER_ID.ToString();
            //    frm.txtMemberName.Text = sMEMBER_NAME;
            //    frm.ShowDialog();
            //}
      
        }
    }
}
