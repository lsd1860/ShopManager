namespace ShopManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dvWork = new System.Windows.Forms.DataGridView();
            this.WORK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvWorkClinic = new System.Windows.Forms.DataGridView();
            this.WORK_ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLINIC_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnWorkAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEtc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvMember = new System.Windows.Forms.DataGridView();
            this.MEMBER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMBER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dvToday = new System.Windows.Forms.DataGridView();
            this.MEMBER_ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMBER_NAME2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실적조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클리닉등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상품등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlRight.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWorkClinic)).BeginInit();
            this.panel4.SuspendLayout();
            this.btnAdd.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMember)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvToday)).BeginInit();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.tabControl2);
            this.pnlRight.Controls.Add(this.btnAdd);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(225, 24);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.pnlRight.Size = new System.Drawing.Size(715, 476);
            this.pnlRight.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(10, 218);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(695, 258);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer1);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(687, 232);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "클리닉 내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dvWork);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dvWorkClinic);
            this.splitContainer1.Size = new System.Drawing.Size(681, 194);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 2;
            // 
            // dvWork
            // 
            this.dvWork.AllowUserToAddRows = false;
            this.dvWork.AllowUserToDeleteRows = false;
            this.dvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WORK_ID,
            this.WORK_DT,
            this.WORK_AMT});
            this.dvWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWork.Location = new System.Drawing.Point(0, 0);
            this.dvWork.Name = "dvWork";
            this.dvWork.ReadOnly = true;
            this.dvWork.RowTemplate.Height = 23;
            this.dvWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvWork.Size = new System.Drawing.Size(219, 194);
            this.dvWork.TabIndex = 0;
            this.dvWork.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvWork_CellDoubleClick);
            this.dvWork.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvWork_RowPostPaint);
            this.dvWork.SelectionChanged += new System.EventHandler(this.dvWork_SelectionChanged);
            // 
            // WORK_ID
            // 
            this.WORK_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORK_ID.DataPropertyName = "WORK_ID";
            this.WORK_ID.HeaderText = "작업번호";
            this.WORK_ID.Name = "WORK_ID";
            this.WORK_ID.ReadOnly = true;
            this.WORK_ID.Visible = false;
            // 
            // WORK_DT
            // 
            this.WORK_DT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WORK_DT.DataPropertyName = "WORK_DT";
            this.WORK_DT.HeaderText = "방문일자";
            this.WORK_DT.Name = "WORK_DT";
            this.WORK_DT.ReadOnly = true;
            // 
            // WORK_AMT
            // 
            this.WORK_AMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WORK_AMT.DataPropertyName = "WORK_AMT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.WORK_AMT.DefaultCellStyle = dataGridViewCellStyle1;
            this.WORK_AMT.HeaderText = "결제금액";
            this.WORK_AMT.Name = "WORK_AMT";
            this.WORK_AMT.ReadOnly = true;
            this.WORK_AMT.Width = 78;
            // 
            // dvWorkClinic
            // 
            this.dvWorkClinic.AllowUserToAddRows = false;
            this.dvWorkClinic.AllowUserToDeleteRows = false;
            this.dvWorkClinic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvWorkClinic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WORK_ID2,
            this.CLINIC_NAME,
            this.PRICE,
            this.QTY,
            this.AMT});
            this.dvWorkClinic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWorkClinic.Location = new System.Drawing.Point(0, 0);
            this.dvWorkClinic.Name = "dvWorkClinic";
            this.dvWorkClinic.ReadOnly = true;
            this.dvWorkClinic.RowTemplate.Height = 23;
            this.dvWorkClinic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvWorkClinic.Size = new System.Drawing.Size(458, 194);
            this.dvWorkClinic.TabIndex = 1;
            this.dvWorkClinic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvWorkClinic_CellContentClick);
            this.dvWorkClinic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvWorkClinic_CellDoubleClick);
            this.dvWorkClinic.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvWorkClinic_RowPostPaint);
            // 
            // WORK_ID2
            // 
            this.WORK_ID2.DataPropertyName = "WORK_ID";
            this.WORK_ID2.HeaderText = "작업번호";
            this.WORK_ID2.Name = "WORK_ID2";
            this.WORK_ID2.ReadOnly = true;
            this.WORK_ID2.Visible = false;
            // 
            // CLINIC_NAME
            // 
            this.CLINIC_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLINIC_NAME.DataPropertyName = "CLINIC_NAME";
            this.CLINIC_NAME.HeaderText = "클리닉";
            this.CLINIC_NAME.Name = "CLINIC_NAME";
            this.CLINIC_NAME.ReadOnly = true;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRICE.DataPropertyName = "PRICE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRICE.HeaderText = "가격";
            this.PRICE.Name = "PRICE";
            this.PRICE.ReadOnly = true;
            this.PRICE.Width = 54;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QTY.DataPropertyName = "QTY";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.QTY.DefaultCellStyle = dataGridViewCellStyle3;
            this.QTY.HeaderText = "수량";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 54;
            // 
            // AMT
            // 
            this.AMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AMT.DataPropertyName = "AMT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.AMT.DefaultCellStyle = dataGridViewCellStyle4;
            this.AMT.HeaderText = "금액";
            this.AMT.Name = "AMT";
            this.AMT.ReadOnly = true;
            this.AMT.Width = 54;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnWorkAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 32);
            this.panel4.TabIndex = 1;
            // 
            // btnWorkAdd
            // 
            this.btnWorkAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkAdd.Location = new System.Drawing.Point(3, 6);
            this.btnWorkAdd.Name = "btnWorkAdd";
            this.btnWorkAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWorkAdd.TabIndex = 0;
            this.btnWorkAdd.Text = "신규등록";
            this.btnWorkAdd.UseVisualStyleBackColor = false;
            this.btnWorkAdd.Click += new System.EventHandler(this.btnWorkAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Controls.Add(this.btnNew);
            this.btnAdd.Controls.Add(this.btnDelete);
            this.btnAdd.Controls.Add(this.btnSave);
            this.btnAdd.Controls.Add(this.txtEtc);
            this.btnAdd.Controls.Add(this.label5);
            this.btnAdd.Controls.Add(this.txtMemberName);
            this.btnAdd.Controls.Add(this.label4);
            this.btnAdd.Controls.Add(this.txtAddress);
            this.btnAdd.Controls.Add(this.label3);
            this.btnAdd.Controls.Add(this.txtTelNo);
            this.btnAdd.Controls.Add(this.label2);
            this.btnAdd.Controls.Add(this.txtMemberID);
            this.btnAdd.Controls.Add(this.label1);
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(10, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(695, 208);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "기본정보";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(414, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "신규회원";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(585, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEtc
            // 
            this.txtEtc.Location = new System.Drawing.Point(91, 119);
            this.txtEtc.Multiline = true;
            this.txtEtc.Name = "txtEtc";
            this.txtEtc.Size = new System.Drawing.Size(569, 70);
            this.txtEtc.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "기타";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(91, 54);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(100, 21);
            this.txtMemberName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "회원명*";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(286, 21);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "주소";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(277, 54);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 21);
            this.txtTelNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "전화번호*";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(91, 25);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(100, 21);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원번호";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.tabControl1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 24);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(225, 476);
            this.pnlLeft.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(225, 476);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvMember);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(217, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "회원목록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvMember
            // 
            this.dvMember.AllowUserToAddRows = false;
            this.dvMember.AllowUserToDeleteRows = false;
            this.dvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MEMBER_ID,
            this.MEMBER_NAME,
            this.TELNO});
            this.dvMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMember.Location = new System.Drawing.Point(3, 51);
            this.dvMember.MultiSelect = false;
            this.dvMember.Name = "dvMember";
            this.dvMember.ReadOnly = true;
            this.dvMember.RowTemplate.Height = 23;
            this.dvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMember.Size = new System.Drawing.Size(211, 396);
            this.dvMember.TabIndex = 0;
            this.dvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMember_CellContentClick);
            this.dvMember.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvMember_RowPostPaint);
            this.dvMember.SelectionChanged += new System.EventHandler(this.dvMember_SelectionChanged);
            // 
            // MEMBER_ID
            // 
            this.MEMBER_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MEMBER_ID.DataPropertyName = "MEMBER_ID";
            this.MEMBER_ID.HeaderText = "회원ID";
            this.MEMBER_ID.Name = "MEMBER_ID";
            this.MEMBER_ID.ReadOnly = true;
            this.MEMBER_ID.Visible = false;
            // 
            // MEMBER_NAME
            // 
            this.MEMBER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEMBER_NAME.DataPropertyName = "MEMBER_NAME";
            this.MEMBER_NAME.HeaderText = "회원명";
            this.MEMBER_NAME.Name = "MEMBER_NAME";
            this.MEMBER_NAME.ReadOnly = true;
            // 
            // TELNO
            // 
            this.TELNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TELNO.DataPropertyName = "TELNO";
            this.TELNO.HeaderText = "전화번호";
            this.TELNO.Name = "TELNO";
            this.TELNO.ReadOnly = true;
            this.TELNO.Width = 78;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 48);
            this.panel3.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(51, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "찾기";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dvToday);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(217, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "당일방문";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dvToday
            // 
            this.dvToday.AllowUserToAddRows = false;
            this.dvToday.AllowUserToDeleteRows = false;
            this.dvToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MEMBER_ID2,
            this.MEMBER_NAME2,
            this.TELNO2});
            this.dvToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvToday.Location = new System.Drawing.Point(3, 29);
            this.dvToday.MultiSelect = false;
            this.dvToday.Name = "dvToday";
            this.dvToday.ReadOnly = true;
            this.dvToday.RowTemplate.Height = 23;
            this.dvToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvToday.Size = new System.Drawing.Size(211, 418);
            this.dvToday.TabIndex = 3;
            this.dvToday.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvToday_CellContentClick);
            this.dvToday.SelectionChanged += new System.EventHandler(this.dvToday_SelectionChanged);
            // 
            // MEMBER_ID2
            // 
            this.MEMBER_ID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MEMBER_ID2.DataPropertyName = "MEMBER_ID";
            this.MEMBER_ID2.HeaderText = "회원ID";
            this.MEMBER_ID2.Name = "MEMBER_ID2";
            this.MEMBER_ID2.ReadOnly = true;
            this.MEMBER_ID2.Visible = false;
            // 
            // MEMBER_NAME2
            // 
            this.MEMBER_NAME2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MEMBER_NAME2.DataPropertyName = "MEMBER_NAME";
            this.MEMBER_NAME2.HeaderText = "회원명";
            this.MEMBER_NAME2.Name = "MEMBER_NAME2";
            this.MEMBER_NAME2.ReadOnly = true;
            // 
            // TELNO2
            // 
            this.TELNO2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TELNO2.DataPropertyName = "TELNO";
            this.TELNO2.HeaderText = "전화번호";
            this.TELNO2.Name = "TELNO2";
            this.TELNO2.ReadOnly = true;
            this.TELNO2.Width = 78;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 26);
            this.panel6.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(940, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.실적조회ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 실적조회ToolStripMenuItem
            // 
            this.실적조회ToolStripMenuItem.Name = "실적조회ToolStripMenuItem";
            this.실적조회ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.실적조회ToolStripMenuItem.Text = "실적조회";
            this.실적조회ToolStripMenuItem.Click += new System.EventHandler(this.실적조회ToolStripMenuItem_Click);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.클리닉등록ToolStripMenuItem,
            this.상품등록ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 클리닉등록ToolStripMenuItem
            // 
            this.클리닉등록ToolStripMenuItem.Name = "클리닉등록ToolStripMenuItem";
            this.클리닉등록ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.클리닉등록ToolStripMenuItem.Text = "클리닉등록";
            this.클리닉등록ToolStripMenuItem.Click += new System.EventHandler(this.클리닉등록ToolStripMenuItem_Click);
            // 
            // 상품등록ToolStripMenuItem
            // 
            this.상품등록ToolStripMenuItem.Name = "상품등록ToolStripMenuItem";
            this.상품등록ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.상품등록ToolStripMenuItem.Text = "상품등록";
            this.상품등록ToolStripMenuItem.Click += new System.EventHandler(this.상품등록ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 522);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "회원관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRight.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWorkClinic)).EndInit();
            this.panel4.ResumeLayout(false);
            this.btnAdd.ResumeLayout(false);
            this.btnAdd.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMember)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvToday)).EndInit();
            this.panel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvMember;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEtc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvWork;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnWorkAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dvWorkClinic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dvToday;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMBER_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMBER_NAME2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELNO2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMBER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMBER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELNO;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클리닉등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상품등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 실적조회ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_DT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_AMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLINIC_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMT;
    }
}

