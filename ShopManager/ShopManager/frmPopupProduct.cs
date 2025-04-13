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
    public partial class frmPopupProduct : frmBase
    {
        public frmPopupProduct()
        {
            InitializeComponent();
        }

        private void frmPopupProduct_Load(object sender, EventArgs e)
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
                    SqlParameter[] param = { };
                    ds = biz.ExecuteDataset(param, "USP_TB_PRODUCT_SELECT_AVAIL");

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;

            dataGridView1.EndEdit();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell colSelectYn = dataGridView1.Rows[i].Cells["colSelectYn"] as DataGridViewCheckBoxCell;

                bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                if (USE_YN)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["PRICE"].Value.ToString());

                }
                txtSelectPrice.Text = sum.ToString("#,###");
            }



        }

    }
}
