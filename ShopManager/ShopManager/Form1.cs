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
using DBClassLibrary;
using System.Data.SqlClient;

namespace ShopManager
{
    public partial class Form1 : frmBase
    {
        DataTable _m_dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control_Init();
        }

        private void Control_Init()
        {
            getMembers();
            getTodayMember();

            //dvWork.Columns["PRICE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dvWorkClinic.Columns["PRICE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dvWorkClinic.Columns["QTY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dvWorkClinic.Columns["AMT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void getMembers()
        {
            DataSet ds = new DataSet();
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    SqlParameter[] param = { };
                    ds = biz.ExecuteDataset(param, "USP_TB_MEMBER_SELECT_ALL");

                    _m_dt = ds.Tables[0];
                    dvMember.DataSource = _m_dt;
                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            dvMember.Rows[0].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        
        private void getMemberInfo(int memberID)
        {
            using (DB_Biz biz = new DB_Biz())
            {
                DataSet ds = new DataSet();
                SqlParameter[] param = {
                      new SqlParameter("@MEMBER_ID", memberID),
                    };

                ds = biz.ExecuteDataset(param, "USP_TB_MEMBER_SELECT");

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtMemberID.Text = ds.Tables[0].Rows[0]["MEMBER_ID"].ToString();
                        txtMemberName.Text = ds.Tables[0].Rows[0]["MEMBER_NAME"].ToString();
                        txtTelNo.Text = ds.Tables[0].Rows[0]["TELNO"].ToString();
                        txtAddress.Text = ds.Tables[0].Rows[0]["ADDRESS"].ToString();
                        txtEtc.Text = ds.Tables[0].Rows[0]["ETC"].ToString();
                    }
                }

            }
        }

        private void getWorkInfo(int memberID)
        {

            using (DB_Biz biz = new DB_Biz())
            {
                DataSet ds = new DataSet();
                SqlParameter[] param = {
                      new SqlParameter("@MEMBER_ID", memberID),
                    };

                ds = biz.ExecuteDataset(param, "USP_TB_WORK_SELECT_MEMBER_ID");
                dvWork.DataSource = ds.Tables[0];

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        getWorkClinicInfo(0);
                    }
                }

            }
        }

        //private void getSaleInfo(int memberID)
        //{

        //    using (DB_Biz biz = new DB_Biz())
        //    {
        //        DataSet ds = new DataSet();
        //        SqlParameter[] param = {
        //              new SqlParameter("@MEMBER_ID", memberID),
        //            };

        //        ds = biz.ExecuteDataset(param, "USP_TB_SALE_SELECT_MEMBER_ID");
        //        dvSale.DataSource = ds.Tables[0];

        //        if (ds.Tables.Count > 0)
        //        {
        //            if (ds.Tables[0].Rows.Count == 0)
        //            {
        //                getSaleProductInfo(0);
        //            }
        //        }

        //    }
        //}

        private void getWorkClinicInfo(int workID)
        {
            using (DB_Biz biz = new DB_Biz())
            {
                DataSet ds = new DataSet();
                SqlParameter[] param = {
                      new SqlParameter("@WORK_ID", workID),
                    };

                ds = biz.ExecuteDataset(param, "USP_TB_WORK_CLINIC_SELECT");
                dvWorkClinic.DataSource = ds.Tables[0];


            }
        }
        //private void getSaleProductInfo(int saleID)
        //{
        //    using (DB_Biz biz = new DB_Biz())
        //    {
        //        DataSet ds = new DataSet();
        //        SqlParameter[] param = {
        //              new SqlParameter("@SALE_ID", saleID),
        //            };

        //        ds = biz.ExecuteDataset(param, "USP_TB_SALE_PRODUCT_SELECT");
        //        dvSaleProduct.DataSource = ds.Tables[0];


        //    }
        //}
        private void dvMember_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnWorkAdd_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text == "" || txtMemberID.Text == "0")
            {
                MessageBox.Show("회원등록후 등록가능합니다.");
                return;
            }

            Form3 frm = new Form3();
            frm.WORK_ID = 0;
            frm.txtMemberID.Text = this.txtMemberID.Text;
            frm.txtMemberName.Text = this.txtMemberName.Text;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int MemberID = Convert.ToInt32(dvMember.Rows[dvMember.CurrentCell.RowIndex].Cells["MEMBER_ID"].Value);
                getWorkInfo(MemberID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMemberName.Text == "")
            {
                MessageBox.Show("회원명을 입력하세요");
                return;
            }
            if (txtTelNo.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요");
                return;
            }

            int cnt = 0;
            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = {
                                  new SqlParameter("@MEMBER_ID", txtMemberID.Text),
                                  new SqlParameter("@MEMBER_NAME", txtMemberName.Text),
                                  new SqlParameter("@TELNO", txtTelNo.Text),
                                  new SqlParameter("@ADDRESS",txtAddress.Text),
                                  new SqlParameter("@ETC", txtEtc.Text),
                                };

                    ds = biz.ExecuteDataset(param, "USP_TB_MEMBER_SAVE");

                    if (ds.Tables.Count > 0)
                    {
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (txtMemberID.Text == "0")
                            {
                                txtMemberID.Text = ds.Tables[0].Rows[0]["MEMBER_ID"].ToString();
                            }
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

            if (cnt > 0)
            {
                MessageBox.Show("저장되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                getMembers();
            }
        }

        private void dvWork_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dvWorkClinic_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
        
        
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _m_dt.DefaultView.RowFilter = string.Format("MEMBER_NAME LIKE '%{0}%' OR TELNO LIKE '%{0}%'", txtSearch.Text);

        }

        private void dvMember_SelectionChanged(object sender, EventArgs e)
        {
            if (dvMember.CurrentCell == null) return;

            int MemberID = Convert.ToInt32(dvMember.Rows[dvMember.CurrentCell.RowIndex].Cells["MEMBER_ID"].Value);

            getMemberInfo(MemberID);
            getWorkInfo(MemberID);
            //getSaleInfo(MemberID);
        }

        private void dvWork_SelectionChanged(object sender, EventArgs e)
        {
            if (dvWork.CurrentCell == null) return;


            try
            {
                int workID = Convert.ToInt32(dvWork.Rows[dvWork.CurrentCell.RowIndex].Cells["WORK_ID"].Value);

                getWorkClinicInfo(workID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getTodayMember();
        }

        private void getTodayMember()
        {
            string WORK_DT = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (DB_Biz biz = new DB_Biz())
            {
                DataSet ds = new DataSet();
                SqlParameter[] param = {
                      new SqlParameter("@WORK_DT", WORK_DT),
                    };

                ds = biz.ExecuteDataset(param, "USP_TB_MEMBER_SELECT_TODAY");
                dvToday.DataSource = ds.Tables[0];

            }
        }
        
        private void dvToday_SelectionChanged(object sender, EventArgs e)
        {
            if (dvToday.CurrentCell == null) return;

            int MemberID = Convert.ToInt32(dvToday.Rows[dvToday.CurrentCell.RowIndex].Cells["MEMBER_ID2"].Value);
            getMemberInfo(MemberID);
            getWorkInfo(MemberID);
            //getSaleInfo(MemberID);
        }

        

        private void dvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            int MemberID = Convert.ToInt32(dvMember.Rows[dvMember.CurrentCell.RowIndex].Cells["MEMBER_ID"].Value);
            getMemberInfo(MemberID);
            getWorkInfo(MemberID);
            //getSaleInfo(MemberID);
        }

        //private void btnSaleAdd_Click(object sender, EventArgs e)
        //{
        //    if (txtMemberID.Text == "" || txtMemberID.Text == "0")
        //    {
        //        MessageBox.Show("회원등록후 등록가능합니다.");
        //        return;
        //    }


        //    Form4 frm = new Form4();
        //    frm.SALE_ID = 0;
        //    frm.txtMemberID.Text = this.txtMemberID.Text;
        //    frm.txtMemberName.Text = this.txtMemberName.Text;
        //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        int MemberID = Convert.ToInt32(txtMemberID.Text);
        //        //getSaleInfo(MemberID);
        //    }
        //}

        private void dvSale_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dvSaleProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        //private void dvSale_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dvSale.CurrentCell == null) return;

        //    int saleID = Convert.ToInt32(dvSale.Rows[dvSale.CurrentCell.RowIndex].Cells["SALE_ID"].Value);

        //    getSaleProductInfo(saleID);
        //}

        private void dvToday_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            int MemberID = Convert.ToInt32(dvToday.Rows[dvToday.CurrentCell.RowIndex].Cells["MEMBER_ID2"].Value);
            getMemberInfo(MemberID);
            getWorkInfo(MemberID);
            //getSaleInfo(MemberID);
        }

        private void dvWork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            int workID = Convert.ToInt32(dvWork.Rows[e.RowIndex].Cells["WORK_ID"].Value);

            setWorkUpdate(workID);

        }

        private void dvWorkClinic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex < 0) return;

            int workID = Convert.ToInt32(dvWorkClinic.Rows[e.RowIndex].Cells["WORK_ID2"].Value);

            setWorkUpdate(workID);
        }

        private void setWorkUpdate(int workID)
        {
            Form3 frm = new Form3();
            frm.WORK_ID = workID;
            frm.txtMemberID.Text = this.txtMemberID.Text;
            frm.txtMemberName.Text = this.txtMemberName.Text;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int memberid = Convert.ToInt32(this.txtMemberID.Text);
                getWorkInfo(memberid);
            }
        }

        //private void dvSale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;
        //    if (e.ColumnIndex < 0) return;

        //    int saleID = Convert.ToInt32(dvSale.Rows[e.RowIndex].Cells["SALE_ID"].Value);

        //    setSaleUpdate(saleID);
        //}

        //private void dvSaleProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;
        //    if (e.ColumnIndex < 0) return;

        //    int saleID = Convert.ToInt32(dvSaleProduct.Rows[e.RowIndex].Cells["SALE_ID2"].Value);

        //    setSaleUpdate(saleID);
        //}

        //private void setSaleUpdate(int saleID)
        //{
        //    Form4 frm = new Form4();
        //    frm.SALE_ID = saleID;
        //    frm.txtMemberID.Text = this.txtMemberID.Text;
        //    frm.txtMemberName.Text = this.txtMemberName.Text;
        //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        int memberid = Convert.ToInt32(this.txtMemberID.Text);
        //        getSaleInfo(memberid);
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            if (MessageBox.Show("회원정보을 삭제합니다.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (txtMemberID.Text == "" || txtMemberID.Text == "0")
            {
                MessageBox.Show("삭제할 회원이 없습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (DB_Biz biz = new DB_Biz())
                {
                    DataSet ds = new DataSet();
                    SqlParameter[] param = {
                      new SqlParameter("@MEMBER_ID", txtMemberID.Text),
                    };

                    biz.ExecuteNonQuery(param, "USP_TB_MEMBER_DELETE");

                    cnt++;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnt > 0)
            {
                MessageBox.Show("삭제되었습니다.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                getMembers();
                getTodayMember();


            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMemberID.Text = "0";
            txtMemberName.Text = "";
            txtTelNo.Text = "";
            txtAddress.Text = "";
            txtEtc.Text = "";

            getWorkInfo(0);
            //getSaleInfo(0);

            txtMemberName.Focus();

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("시스템을 종료합니다.", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {               
                Application.Exit();
            }
        }

        private void 클리닉등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void 상품등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void 실적조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void dvWorkClinic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


    }
}
