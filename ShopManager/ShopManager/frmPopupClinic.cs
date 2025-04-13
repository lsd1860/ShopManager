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
    public partial class frmPopupClinic : frmBase
    {
        public frmPopupClinic()
        {
            InitializeComponent();
        }

        private void frmPopupClinic_Load(object sender, EventArgs e)
        {
            Control_Init();
        }

        private void Control_Init()
        {
            getClinic();
            getProduct();
        }

        private void getClinic()
        {
            DataSet ds = new DataSet();
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    SqlParameter[] param = { };
                    ds = biz.ExecuteDataset(param, "USP_TB_CLINIC_SELECT_AVAIL");

                    dvClinic.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void getProduct()
        {
            DataSet ds = new DataSet();
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    SqlParameter[] param = { };
                    ds = biz.ExecuteDataset(param, "USP_TB_PRODUCT_SELECT_AVAIL");

                    dvProduct.DataSource = ds.Tables[0];
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

        private void dvClinic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;

            dvClinic.EndEdit();

            for (int i = 0; i < dvClinic.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell colSelectYn = dvClinic.Rows[i].Cells["colSelectYn"] as DataGridViewCheckBoxCell;

                bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                if (USE_YN)
                {
                    sum += Convert.ToInt32(dvClinic.Rows[i].Cells["CLINIC_PRICE"].Value.ToString());

                }
                
            }

            dvProduct.EndEdit();

            for (int i = 0; i < dvProduct.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell colSelectYn = dvProduct.Rows[i].Cells["colSelectYn2"] as DataGridViewCheckBoxCell;

                bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                if (USE_YN)
                {
                    sum += Convert.ToInt32(dvProduct.Rows[i].Cells["PRODUCT_PRICE"].Value.ToString());

                }                
            }

            txtSelectPrice.Text = sum.ToString("#,###");
        }

        private void dvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;

            dvClinic.EndEdit();

            for (int i = 0; i < dvClinic.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell colSelectYn = dvClinic.Rows[i].Cells["colSelectYn"] as DataGridViewCheckBoxCell;

                bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                if (USE_YN)
                {
                    sum += Convert.ToInt32(dvClinic.Rows[i].Cells["CLINIC_PRICE"].Value.ToString());

                }

            }

            dvProduct.EndEdit();

            for (int i = 0; i < dvProduct.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell colSelectYn = dvProduct.Rows[i].Cells["colSelectYn2"] as DataGridViewCheckBoxCell;

                bool USE_YN = Convert.ToBoolean(colSelectYn.Value == DBNull.Value ? false : colSelectYn.Value);

                if (USE_YN)
                {
                    sum += Convert.ToInt32(dvProduct.Rows[i].Cells["PRODUCT_PRICE"].Value.ToString());

                }
            }

            txtSelectPrice.Text = sum.ToString("#,###");
        }
    }
}
