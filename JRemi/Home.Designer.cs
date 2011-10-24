namespace JRemi
{
    partial class Home
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimeChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch_Nihongo = new System.Windows.Forms.TextBox();
            this.lblSearch_Nihongo = new System.Windows.Forms.Label();
            this.txtSearch_Romaji = new System.Windows.Forms.TextBox();
            this.lblSearch_Romaji = new System.Windows.Forms.Label();
            this.txtSearch_Betonamugo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch_ID = new System.Windows.Forms.TextBox();
            this.lblSearch_ID = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ka = new System.Windows.Forms.Label();
            this.txtNouto_Add = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRomaji_Add = new System.Windows.Forms.TextBox();
            this.txtBetonamugo_Add = new System.Windows.Forms.TextBox();
            this.txtNihon_Add = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNouto_Edit = new System.Windows.Forms.RichTextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtRomaji_Edit = new System.Windows.Forms.TextBox();
            this.txtBetonamugo_Edit = new System.Windows.Forms.TextBox();
            this.txtNihon_Edit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID_Edit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.noIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 50);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(6, 18);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(197, 23);
            this.btnHide.TabIndex = 1;
            this.btnHide.Text = "Ẩn xuống Taskbar";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(717, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "lamhaianh@gmail.com";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimeChange);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTimeShow);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(716, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấu hình";
            // 
            // txtTimeChange
            // 
            this.txtTimeChange.Location = new System.Drawing.Point(120, 60);
            this.txtTimeChange.Name = "txtTimeChange";
            this.txtTimeChange.Size = new System.Drawing.Size(84, 20);
            this.txtTimeChange.TabIndex = 2;
            this.txtTimeChange.TextChanged += new System.EventHandler(this.txtTimeChange_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoảng cách 2 từ (s)";
            // 
            // txtTimeShow
            // 
            this.txtTimeShow.Location = new System.Drawing.Point(120, 35);
            this.txtTimeShow.Name = "txtTimeShow";
            this.txtTimeShow.Size = new System.Drawing.Size(84, 20);
            this.txtTimeShow.TabIndex = 2;
            this.txtTimeShow.TextChanged += new System.EventHandler(this.txtTimeShow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian hiển thị (s)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(146, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Khởi động cùng windows";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataTable);
            this.groupBox4.Location = new System.Drawing.Point(6, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(686, 237);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Từ vựng";
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToOrderColumns = true;
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable.Location = new System.Drawing.Point(3, 16);
            this.dataTable.MultiSelect = false;
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.Size = new System.Drawing.Size(680, 218);
            this.dataTable.TabIndex = 0;
            this.dataTable.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.txtSearch_Nihongo);
            this.groupBox5.Controls.Add(this.lblSearch_Nihongo);
            this.groupBox5.Controls.Add(this.txtSearch_Romaji);
            this.groupBox5.Controls.Add(this.lblSearch_Romaji);
            this.groupBox5.Controls.Add(this.txtSearch_Betonamugo);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtSearch_ID);
            this.groupBox5.Controls.Add(this.lblSearch_ID);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(686, 69);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(586, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 46);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch_Nihongo
            // 
            this.txtSearch_Nihongo.Location = new System.Drawing.Point(80, 39);
            this.txtSearch_Nihongo.Name = "txtSearch_Nihongo";
            this.txtSearch_Nihongo.Size = new System.Drawing.Size(193, 20);
            this.txtSearch_Nihongo.TabIndex = 2;
            this.txtSearch_Nihongo.TextChanged += new System.EventHandler(this.txtSearch_Nihongo_TextChanged);
            // 
            // lblSearch_Nihongo
            // 
            this.lblSearch_Nihongo.AutoSize = true;
            this.lblSearch_Nihongo.Location = new System.Drawing.Point(10, 42);
            this.lblSearch_Nihongo.Name = "lblSearch_Nihongo";
            this.lblSearch_Nihongo.Size = new System.Drawing.Size(60, 13);
            this.lblSearch_Nihongo.TabIndex = 0;
            this.lblSearch_Nihongo.Text = "Tiếng Nhật";
            // 
            // txtSearch_Romaji
            // 
            this.txtSearch_Romaji.Location = new System.Drawing.Point(381, 39);
            this.txtSearch_Romaji.Name = "txtSearch_Romaji";
            this.txtSearch_Romaji.Size = new System.Drawing.Size(193, 20);
            this.txtSearch_Romaji.TabIndex = 4;
            this.txtSearch_Romaji.TextChanged += new System.EventHandler(this.txtSearch_Romaji_TextChanged);
            // 
            // lblSearch_Romaji
            // 
            this.lblSearch_Romaji.AutoSize = true;
            this.lblSearch_Romaji.Location = new System.Drawing.Point(290, 42);
            this.lblSearch_Romaji.Name = "lblSearch_Romaji";
            this.lblSearch_Romaji.Size = new System.Drawing.Size(39, 13);
            this.lblSearch_Romaji.TabIndex = 0;
            this.lblSearch_Romaji.Text = "Romaji";
            // 
            // txtSearch_Betonamugo
            // 
            this.txtSearch_Betonamugo.Location = new System.Drawing.Point(381, 13);
            this.txtSearch_Betonamugo.Name = "txtSearch_Betonamugo";
            this.txtSearch_Betonamugo.Size = new System.Drawing.Size(193, 20);
            this.txtSearch_Betonamugo.TabIndex = 3;
            this.txtSearch_Betonamugo.TextChanged += new System.EventHandler(this.txtSearch_Betonamugo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nghĩa tiếng Việt";
            // 
            // txtSearch_ID
            // 
            this.txtSearch_ID.Location = new System.Drawing.Point(80, 13);
            this.txtSearch_ID.Name = "txtSearch_ID";
            this.txtSearch_ID.Size = new System.Drawing.Size(193, 20);
            this.txtSearch_ID.TabIndex = 1;
            this.txtSearch_ID.TextChanged += new System.EventHandler(this.txtSearch_ID_TextChanged);
            // 
            // lblSearch_ID
            // 
            this.lblSearch_ID.AutoSize = true;
            this.lblSearch_ID.Location = new System.Drawing.Point(10, 16);
            this.lblSearch_ID.Name = "lblSearch_ID";
            this.lblSearch_ID.Size = new System.Drawing.Size(18, 13);
            this.lblSearch_ID.TabIndex = 0;
            this.lblSearch_ID.Text = "ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 110);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ka);
            this.tabPage1.Controls.Add(this.txtNouto_Add);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtRomaji_Add);
            this.tabPage1.Controls.Add(this.txtBetonamugo_Add);
            this.tabPage1.Controls.Add(this.txtNihon_Add);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 84);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ka
            // 
            this.ka.AutoSize = true;
            this.ka.Location = new System.Drawing.Point(296, 11);
            this.ka.Name = "ka";
            this.ka.Size = new System.Drawing.Size(54, 13);
            this.ka.TabIndex = 4;
            this.ka.Text = "Chú thích";
            // 
            // txtNouto_Add
            // 
            this.txtNouto_Add.Location = new System.Drawing.Point(356, 8);
            this.txtNouto_Add.Name = "txtNouto_Add";
            this.txtNouto_Add.Size = new System.Drawing.Size(241, 72);
            this.txtNouto_Add.TabIndex = 9;
            this.txtNouto_Add.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(603, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 64);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRomaji_Add
            // 
            this.txtRomaji_Add.Location = new System.Drawing.Point(94, 35);
            this.txtRomaji_Add.Name = "txtRomaji_Add";
            this.txtRomaji_Add.Size = new System.Drawing.Size(200, 20);
            this.txtRomaji_Add.TabIndex = 7;
            // 
            // txtBetonamugo_Add
            // 
            this.txtBetonamugo_Add.Location = new System.Drawing.Point(94, 60);
            this.txtBetonamugo_Add.Name = "txtBetonamugo_Add";
            this.txtBetonamugo_Add.Size = new System.Drawing.Size(200, 20);
            this.txtBetonamugo_Add.TabIndex = 8;
            // 
            // txtNihon_Add
            // 
            this.txtNihon_Add.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtNihon_Add.Location = new System.Drawing.Point(94, 9);
            this.txtNihon_Add.Name = "txtNihon_Add";
            this.txtNihon_Add.Size = new System.Drawing.Size(200, 20);
            this.txtNihon_Add.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nghĩa tiếng Việt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Romaji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiếng Nhật";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtNouto_Edit);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Controls.Add(this.txtRomaji_Edit);
            this.tabPage2.Controls.Add(this.txtBetonamugo_Edit);
            this.tabPage2.Controls.Add(this.txtNihon_Edit);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtID_Edit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 84);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(606, 44);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chú thích";
            // 
            // txtNouto_Edit
            // 
            this.txtNouto_Edit.Location = new System.Drawing.Point(358, 6);
            this.txtNouto_Edit.Name = "txtNouto_Edit";
            this.txtNouto_Edit.Size = new System.Drawing.Size(241, 72);
            this.txtNouto_Edit.TabIndex = 14;
            this.txtNouto_Edit.Text = "";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(607, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 29);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtRomaji_Edit
            // 
            this.txtRomaji_Edit.Location = new System.Drawing.Point(92, 33);
            this.txtRomaji_Edit.Name = "txtRomaji_Edit";
            this.txtRomaji_Edit.Size = new System.Drawing.Size(200, 20);
            this.txtRomaji_Edit.TabIndex = 12;
            // 
            // txtBetonamugo_Edit
            // 
            this.txtBetonamugo_Edit.Location = new System.Drawing.Point(92, 58);
            this.txtBetonamugo_Edit.Name = "txtBetonamugo_Edit";
            this.txtBetonamugo_Edit.Size = new System.Drawing.Size(200, 20);
            this.txtBetonamugo_Edit.TabIndex = 13;
            // 
            // txtNihon_Edit
            // 
            this.txtNihon_Edit.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtNihon_Edit.Location = new System.Drawing.Point(92, 7);
            this.txtNihon_Edit.Name = "txtNihon_Edit";
            this.txtNihon_Edit.Size = new System.Drawing.Size(200, 20);
            this.txtNihon_Edit.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nghĩa tiếng Việt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Romaji";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tiếng Nhật";
            // 
            // txtID_Edit
            // 
            this.txtID_Edit.Location = new System.Drawing.Point(377, 53);
            this.txtID_Edit.Name = "txtID_Edit";
            this.txtID_Edit.Size = new System.Drawing.Size(25, 20);
            this.txtID_Edit.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 454);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnExit);
            this.groupBox6.Controls.Add(this.btnHide);
            this.groupBox6.Location = new System.Drawing.Point(717, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 84);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // noIcon
            // 
            this.noIcon.ContextMenuStrip = this.menu;
            this.noIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("noIcon.Icon")));
            this.noIcon.Text = "JRemi";
            this.noIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.noIcon_MouseDoubleClick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(118, 54);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "&Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(938, 488);
            this.MinimumSize = new System.Drawing.Size(938, 488);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JRemi";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch_Nihongo;
        private System.Windows.Forms.Label lblSearch_Nihongo;
        private System.Windows.Forms.TextBox txtSearch_Romaji;
        private System.Windows.Forms.Label lblSearch_Romaji;
        private System.Windows.Forms.TextBox txtSearch_Betonamugo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch_ID;
        private System.Windows.Forms.Label lblSearch_ID;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label ka;
        private System.Windows.Forms.RichTextBox txtNouto_Add;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRomaji_Add;
        private System.Windows.Forms.TextBox txtBetonamugo_Add;
        private System.Windows.Forms.TextBox txtNihon_Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtNouto_Edit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtRomaji_Edit;
        private System.Windows.Forms.TextBox txtBetonamugo_Edit;
        private System.Windows.Forms.TextBox txtNihon_Edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NotifyIcon noIcon;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.TextBox txtID_Edit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTimeChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimeShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;

    }
}

