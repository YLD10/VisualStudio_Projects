namespace Form_SC
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.labLogout = new System.Windows.Forms.Label();
            this.tabcMain = new System.Windows.Forms.TabControl();
            this.tabpAdmin = new System.Windows.Forms.TabPage();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.btDeleteAdmin = new System.Windows.Forms.Button();
            this.btUpdateAdmin = new System.Windows.Forms.Button();
            this.btAddAdmin = new System.Windows.Forms.Button();
            this.tabpStudent = new System.Windows.Forms.TabPage();
            this.btSeeAllStudents = new System.Windows.Forms.Button();
            this.btSeeStuCou = new System.Windows.Forms.Button();
            this.btSearchByStuID = new System.Windows.Forms.Button();
            this.tbStuID = new System.Windows.Forms.TextBox();
            this.labStuID = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.btDeleteStudent = new System.Windows.Forms.Button();
            this.btUpdateStudent = new System.Windows.Forms.Button();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.tabpTeacher = new System.Windows.Forms.TabPage();
            this.btSeeTeaCou = new System.Windows.Forms.Button();
            this.btSeeAllTeachers = new System.Windows.Forms.Button();
            this.btSearchByTeaName = new System.Windows.Forms.Button();
            this.tbTeaName = new System.Windows.Forms.TextBox();
            this.labTeaName = new System.Windows.Forms.Label();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btDeleteTeacher = new System.Windows.Forms.Button();
            this.btUpdateTeacher = new System.Windows.Forms.Button();
            this.btAddTeacher = new System.Windows.Forms.Button();
            this.tabpCourse = new System.Windows.Forms.TabPage();
            this.btSeeAllCourses = new System.Windows.Forms.Button();
            this.btSearchByCouName = new System.Windows.Forms.Button();
            this.tbCouName = new System.Windows.Forms.TextBox();
            this.labCouName = new System.Windows.Forms.Label();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.btSeeCouTea = new System.Windows.Forms.Button();
            this.btDeleteCourse = new System.Windows.Forms.Button();
            this.btUpdateCourse = new System.Windows.Forms.Button();
            this.btAddCourse = new System.Windows.Forms.Button();
            this.bwMain = new System.ComponentModel.BackgroundWorker();
            this.gbMain.SuspendLayout();
            this.tabcMain.SuspendLayout();
            this.tabpAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.tabpStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tabpTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.tabpCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.labLogout);
            this.gbMain.Controls.Add(this.tabcMain);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(768, 478);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "系统(&A)";
            // 
            // labLogout
            // 
            this.labLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labLogout.AutoSize = true;
            this.labLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labLogout.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLogout.Location = new System.Drawing.Point(706, 9);
            this.labLogout.Name = "labLogout";
            this.labLogout.Size = new System.Drawing.Size(56, 20);
            this.labLogout.TabIndex = 4;
            this.labLogout.Text = "登出(&X)";
            this.labLogout.Click += new System.EventHandler(this.labLogout_Click);
            // 
            // tabcMain
            // 
            this.tabcMain.Controls.Add(this.tabpAdmin);
            this.tabcMain.Controls.Add(this.tabpStudent);
            this.tabcMain.Controls.Add(this.tabpTeacher);
            this.tabcMain.Controls.Add(this.tabpCourse);
            this.tabcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcMain.Location = new System.Drawing.Point(3, 22);
            this.tabcMain.Name = "tabcMain";
            this.tabcMain.SelectedIndex = 0;
            this.tabcMain.Size = new System.Drawing.Size(762, 453);
            this.tabcMain.TabIndex = 0;
            // 
            // tabpAdmin
            // 
            this.tabpAdmin.Controls.Add(this.dgvAdmin);
            this.tabpAdmin.Controls.Add(this.btDeleteAdmin);
            this.tabpAdmin.Controls.Add(this.btUpdateAdmin);
            this.tabpAdmin.Controls.Add(this.btAddAdmin);
            this.tabpAdmin.Location = new System.Drawing.Point(4, 29);
            this.tabpAdmin.Name = "tabpAdmin";
            this.tabpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabpAdmin.Size = new System.Drawing.Size(754, 420);
            this.tabpAdmin.TabIndex = 0;
            this.tabpAdmin.Text = "系统用户管理";
            this.tabpAdmin.UseVisualStyleBackColor = true;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Location = new System.Drawing.Point(6, 81);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowTemplate.Height = 23;
            this.dgvAdmin.Size = new System.Drawing.Size(742, 333);
            this.dgvAdmin.TabIndex = 3;
            this.dgvAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btDeleteAdmin
            // 
            this.btDeleteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteAdmin.Location = new System.Drawing.Point(282, 41);
            this.btDeleteAdmin.Name = "btDeleteAdmin";
            this.btDeleteAdmin.Size = new System.Drawing.Size(89, 23);
            this.btDeleteAdmin.TabIndex = 2;
            this.btDeleteAdmin.Text = "删除系统用户";
            this.btDeleteAdmin.UseVisualStyleBackColor = true;
            this.btDeleteAdmin.Click += new System.EventHandler(this.btDeleteAdmin_Click);
            // 
            // btUpdateAdmin
            // 
            this.btUpdateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdateAdmin.Location = new System.Drawing.Point(156, 41);
            this.btUpdateAdmin.Name = "btUpdateAdmin";
            this.btUpdateAdmin.Size = new System.Drawing.Size(89, 23);
            this.btUpdateAdmin.TabIndex = 1;
            this.btUpdateAdmin.Text = "修改系统用户";
            this.btUpdateAdmin.UseVisualStyleBackColor = true;
            this.btUpdateAdmin.Click += new System.EventHandler(this.btUpdateAdmin_Click);
            // 
            // btAddAdmin
            // 
            this.btAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddAdmin.Location = new System.Drawing.Point(28, 41);
            this.btAddAdmin.Name = "btAddAdmin";
            this.btAddAdmin.Size = new System.Drawing.Size(91, 23);
            this.btAddAdmin.TabIndex = 0;
            this.btAddAdmin.Text = "添加系统用户";
            this.btAddAdmin.UseVisualStyleBackColor = true;
            this.btAddAdmin.Click += new System.EventHandler(this.btAddAdmin_Click);
            // 
            // tabpStudent
            // 
            this.tabpStudent.Controls.Add(this.btSeeAllStudents);
            this.tabpStudent.Controls.Add(this.btSeeStuCou);
            this.tabpStudent.Controls.Add(this.btSearchByStuID);
            this.tabpStudent.Controls.Add(this.tbStuID);
            this.tabpStudent.Controls.Add(this.labStuID);
            this.tabpStudent.Controls.Add(this.dgvStudent);
            this.tabpStudent.Controls.Add(this.btDeleteStudent);
            this.tabpStudent.Controls.Add(this.btUpdateStudent);
            this.tabpStudent.Controls.Add(this.btAddStudent);
            this.tabpStudent.Location = new System.Drawing.Point(4, 29);
            this.tabpStudent.Name = "tabpStudent";
            this.tabpStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabpStudent.Size = new System.Drawing.Size(754, 420);
            this.tabpStudent.TabIndex = 1;
            this.tabpStudent.Text = "学生信息管理";
            this.tabpStudent.UseVisualStyleBackColor = true;
            // 
            // btSeeAllStudents
            // 
            this.btSeeAllStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeAllStudents.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeAllStudents.Location = new System.Drawing.Point(407, 35);
            this.btSeeAllStudents.Name = "btSeeAllStudents";
            this.btSeeAllStudents.Size = new System.Drawing.Size(89, 23);
            this.btSeeAllStudents.TabIndex = 7;
            this.btSeeAllStudents.Text = "查看所有学生";
            this.btSeeAllStudents.UseVisualStyleBackColor = true;
            this.btSeeAllStudents.Click += new System.EventHandler(this.btSeeAllStudents_Click);
            // 
            // btSeeStuCou
            // 
            this.btSeeStuCou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeStuCou.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeStuCou.Location = new System.Drawing.Point(407, 93);
            this.btSeeStuCou.Name = "btSeeStuCou";
            this.btSeeStuCou.Size = new System.Drawing.Size(89, 23);
            this.btSeeStuCou.TabIndex = 11;
            this.btSeeStuCou.Text = "查看选课情况";
            this.btSeeStuCou.UseVisualStyleBackColor = true;
            this.btSeeStuCou.Click += new System.EventHandler(this.btSeeStuCou_Click);
            // 
            // btSearchByStuID
            // 
            this.btSearchByStuID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchByStuID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearchByStuID.Location = new System.Drawing.Point(278, 35);
            this.btSearchByStuID.Name = "btSearchByStuID";
            this.btSearchByStuID.Size = new System.Drawing.Size(89, 23);
            this.btSearchByStuID.TabIndex = 6;
            this.btSearchByStuID.Text = "查找学生";
            this.btSearchByStuID.UseVisualStyleBackColor = true;
            this.btSearchByStuID.Click += new System.EventHandler(this.btSearchByStuID_Click);
            // 
            // tbStuID
            // 
            this.tbStuID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStuID.Location = new System.Drawing.Point(73, 35);
            this.tbStuID.Name = "tbStuID";
            this.tbStuID.Size = new System.Drawing.Size(199, 23);
            this.tbStuID.TabIndex = 5;
            // 
            // labStuID
            // 
            this.labStuID.AutoSize = true;
            this.labStuID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStuID.Location = new System.Drawing.Point(23, 38);
            this.labStuID.Name = "labStuID";
            this.labStuID.Size = new System.Drawing.Size(44, 17);
            this.labStuID.TabIndex = 4;
            this.labStuID.Text = "学号：";
            // 
            // dgvStudent
            // 
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(6, 133);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.Size = new System.Drawing.Size(742, 281);
            this.dgvStudent.TabIndex = 12;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btDeleteStudent
            // 
            this.btDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteStudent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteStudent.Location = new System.Drawing.Point(278, 93);
            this.btDeleteStudent.Name = "btDeleteStudent";
            this.btDeleteStudent.Size = new System.Drawing.Size(89, 23);
            this.btDeleteStudent.TabIndex = 10;
            this.btDeleteStudent.Text = "删除学生";
            this.btDeleteStudent.UseVisualStyleBackColor = true;
            this.btDeleteStudent.Click += new System.EventHandler(this.btDeleteStudent_Click);
            // 
            // btUpdateStudent
            // 
            this.btUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateStudent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdateStudent.Location = new System.Drawing.Point(152, 93);
            this.btUpdateStudent.Name = "btUpdateStudent";
            this.btUpdateStudent.Size = new System.Drawing.Size(89, 23);
            this.btUpdateStudent.TabIndex = 9;
            this.btUpdateStudent.Text = "修改学生";
            this.btUpdateStudent.UseVisualStyleBackColor = true;
            this.btUpdateStudent.Click += new System.EventHandler(this.btUpdateStudent_Click);
            // 
            // btAddStudent
            // 
            this.btAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddStudent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddStudent.Location = new System.Drawing.Point(24, 93);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(91, 23);
            this.btAddStudent.TabIndex = 8;
            this.btAddStudent.Text = "添加学生";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // tabpTeacher
            // 
            this.tabpTeacher.Controls.Add(this.btSeeTeaCou);
            this.tabpTeacher.Controls.Add(this.btSeeAllTeachers);
            this.tabpTeacher.Controls.Add(this.btSearchByTeaName);
            this.tabpTeacher.Controls.Add(this.tbTeaName);
            this.tabpTeacher.Controls.Add(this.labTeaName);
            this.tabpTeacher.Controls.Add(this.dgvTeacher);
            this.tabpTeacher.Controls.Add(this.btDeleteTeacher);
            this.tabpTeacher.Controls.Add(this.btUpdateTeacher);
            this.tabpTeacher.Controls.Add(this.btAddTeacher);
            this.tabpTeacher.Location = new System.Drawing.Point(4, 29);
            this.tabpTeacher.Name = "tabpTeacher";
            this.tabpTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabpTeacher.Size = new System.Drawing.Size(754, 420);
            this.tabpTeacher.TabIndex = 2;
            this.tabpTeacher.Text = "教师信息管理";
            this.tabpTeacher.UseVisualStyleBackColor = true;
            // 
            // btSeeTeaCou
            // 
            this.btSeeTeaCou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeTeaCou.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeTeaCou.Location = new System.Drawing.Point(407, 93);
            this.btSeeTeaCou.Name = "btSeeTeaCou";
            this.btSeeTeaCou.Size = new System.Drawing.Size(89, 23);
            this.btSeeTeaCou.TabIndex = 20;
            this.btSeeTeaCou.Text = "查看所教课程";
            this.btSeeTeaCou.UseVisualStyleBackColor = true;
            this.btSeeTeaCou.Click += new System.EventHandler(this.btSeeTeaCou_Click);
            // 
            // btSeeAllTeachers
            // 
            this.btSeeAllTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeAllTeachers.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeAllTeachers.Location = new System.Drawing.Point(407, 35);
            this.btSeeAllTeachers.Name = "btSeeAllTeachers";
            this.btSeeAllTeachers.Size = new System.Drawing.Size(89, 23);
            this.btSeeAllTeachers.TabIndex = 16;
            this.btSeeAllTeachers.Text = "查看所有教师";
            this.btSeeAllTeachers.UseVisualStyleBackColor = true;
            this.btSeeAllTeachers.Click += new System.EventHandler(this.btSeeAllTeachers_Click);
            // 
            // btSearchByTeaName
            // 
            this.btSearchByTeaName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchByTeaName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearchByTeaName.Location = new System.Drawing.Point(278, 35);
            this.btSearchByTeaName.Name = "btSearchByTeaName";
            this.btSearchByTeaName.Size = new System.Drawing.Size(89, 23);
            this.btSearchByTeaName.TabIndex = 15;
            this.btSearchByTeaName.Text = "查找教师";
            this.btSearchByTeaName.UseVisualStyleBackColor = true;
            this.btSearchByTeaName.Click += new System.EventHandler(this.btSearchByTeaName_Click);
            // 
            // tbTeaName
            // 
            this.tbTeaName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTeaName.Location = new System.Drawing.Point(97, 35);
            this.tbTeaName.Name = "tbTeaName";
            this.tbTeaName.Size = new System.Drawing.Size(175, 23);
            this.tbTeaName.TabIndex = 14;
            // 
            // labTeaName
            // 
            this.labTeaName.AutoSize = true;
            this.labTeaName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTeaName.Location = new System.Drawing.Point(23, 38);
            this.labTeaName.Name = "labTeaName";
            this.labTeaName.Size = new System.Drawing.Size(68, 17);
            this.labTeaName.TabIndex = 13;
            this.labTeaName.Text = "教师姓名：";
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(6, 133);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowTemplate.Height = 23;
            this.dgvTeacher.Size = new System.Drawing.Size(742, 283);
            this.dgvTeacher.TabIndex = 21;
            this.dgvTeacher.TabStop = false;
            this.dgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btDeleteTeacher
            // 
            this.btDeleteTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteTeacher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteTeacher.Location = new System.Drawing.Point(278, 93);
            this.btDeleteTeacher.Name = "btDeleteTeacher";
            this.btDeleteTeacher.Size = new System.Drawing.Size(89, 23);
            this.btDeleteTeacher.TabIndex = 19;
            this.btDeleteTeacher.Text = "删除教师";
            this.btDeleteTeacher.UseVisualStyleBackColor = true;
            this.btDeleteTeacher.Click += new System.EventHandler(this.btDeleteTeacher_Click);
            // 
            // btUpdateTeacher
            // 
            this.btUpdateTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateTeacher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdateTeacher.Location = new System.Drawing.Point(152, 93);
            this.btUpdateTeacher.Name = "btUpdateTeacher";
            this.btUpdateTeacher.Size = new System.Drawing.Size(89, 23);
            this.btUpdateTeacher.TabIndex = 18;
            this.btUpdateTeacher.Text = "修改教师";
            this.btUpdateTeacher.UseVisualStyleBackColor = true;
            this.btUpdateTeacher.Click += new System.EventHandler(this.btUpdateTeacher_Click);
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddTeacher.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddTeacher.Location = new System.Drawing.Point(24, 93);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(91, 23);
            this.btAddTeacher.TabIndex = 17;
            this.btAddTeacher.Text = "添加教师";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            this.btAddTeacher.Click += new System.EventHandler(this.btAddTeacher_Click);
            // 
            // tabpCourse
            // 
            this.tabpCourse.Controls.Add(this.btSeeAllCourses);
            this.tabpCourse.Controls.Add(this.btSearchByCouName);
            this.tabpCourse.Controls.Add(this.tbCouName);
            this.tabpCourse.Controls.Add(this.labCouName);
            this.tabpCourse.Controls.Add(this.dgvCourse);
            this.tabpCourse.Controls.Add(this.btSeeCouTea);
            this.tabpCourse.Controls.Add(this.btDeleteCourse);
            this.tabpCourse.Controls.Add(this.btUpdateCourse);
            this.tabpCourse.Controls.Add(this.btAddCourse);
            this.tabpCourse.Location = new System.Drawing.Point(4, 29);
            this.tabpCourse.Name = "tabpCourse";
            this.tabpCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCourse.Size = new System.Drawing.Size(754, 420);
            this.tabpCourse.TabIndex = 3;
            this.tabpCourse.Text = "课程管理";
            this.tabpCourse.UseVisualStyleBackColor = true;
            // 
            // btSeeAllCourses
            // 
            this.btSeeAllCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeAllCourses.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeAllCourses.Location = new System.Drawing.Point(407, 35);
            this.btSeeAllCourses.Name = "btSeeAllCourses";
            this.btSeeAllCourses.Size = new System.Drawing.Size(89, 23);
            this.btSeeAllCourses.TabIndex = 25;
            this.btSeeAllCourses.Text = "查看所有课程";
            this.btSeeAllCourses.UseVisualStyleBackColor = true;
            this.btSeeAllCourses.Click += new System.EventHandler(this.btSeeAllCourses_Click);
            // 
            // btSearchByCouName
            // 
            this.btSearchByCouName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchByCouName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSearchByCouName.Location = new System.Drawing.Point(278, 35);
            this.btSearchByCouName.Name = "btSearchByCouName";
            this.btSearchByCouName.Size = new System.Drawing.Size(89, 23);
            this.btSearchByCouName.TabIndex = 24;
            this.btSearchByCouName.Text = "查找课程";
            this.btSearchByCouName.UseVisualStyleBackColor = true;
            this.btSearchByCouName.Click += new System.EventHandler(this.btSearchByCouName_Click);
            // 
            // tbCouName
            // 
            this.tbCouName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCouName.Location = new System.Drawing.Point(97, 35);
            this.tbCouName.Name = "tbCouName";
            this.tbCouName.Size = new System.Drawing.Size(175, 23);
            this.tbCouName.TabIndex = 23;
            // 
            // labCouName
            // 
            this.labCouName.AutoSize = true;
            this.labCouName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCouName.Location = new System.Drawing.Point(23, 38);
            this.labCouName.Name = "labCouName";
            this.labCouName.Size = new System.Drawing.Size(68, 17);
            this.labCouName.TabIndex = 22;
            this.labCouName.Text = "课程名称：";
            // 
            // dgvCourse
            // 
            this.dgvCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Location = new System.Drawing.Point(6, 133);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.RowTemplate.Height = 23;
            this.dgvCourse.Size = new System.Drawing.Size(742, 283);
            this.dgvCourse.TabIndex = 30;
            this.dgvCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btSeeCouTea
            // 
            this.btSeeCouTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSeeCouTea.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSeeCouTea.Location = new System.Drawing.Point(407, 93);
            this.btSeeCouTea.Name = "btSeeCouTea";
            this.btSeeCouTea.Size = new System.Drawing.Size(89, 23);
            this.btSeeCouTea.TabIndex = 29;
            this.btSeeCouTea.Text = "查看任课老师";
            this.btSeeCouTea.UseVisualStyleBackColor = true;
            this.btSeeCouTea.Click += new System.EventHandler(this.btSeeCouTea_Click);
            // 
            // btDeleteCourse
            // 
            this.btDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeleteCourse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDeleteCourse.Location = new System.Drawing.Point(278, 93);
            this.btDeleteCourse.Name = "btDeleteCourse";
            this.btDeleteCourse.Size = new System.Drawing.Size(89, 23);
            this.btDeleteCourse.TabIndex = 28;
            this.btDeleteCourse.Text = "删除课程";
            this.btDeleteCourse.UseVisualStyleBackColor = true;
            this.btDeleteCourse.Click += new System.EventHandler(this.btDeleteCourse_Click);
            // 
            // btUpdateCourse
            // 
            this.btUpdateCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdateCourse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUpdateCourse.Location = new System.Drawing.Point(152, 93);
            this.btUpdateCourse.Name = "btUpdateCourse";
            this.btUpdateCourse.Size = new System.Drawing.Size(89, 23);
            this.btUpdateCourse.TabIndex = 27;
            this.btUpdateCourse.Text = "修改课程";
            this.btUpdateCourse.UseVisualStyleBackColor = true;
            this.btUpdateCourse.Click += new System.EventHandler(this.btUpdateCourse_Click);
            // 
            // btAddCourse
            // 
            this.btAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddCourse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddCourse.Location = new System.Drawing.Point(24, 93);
            this.btAddCourse.Name = "btAddCourse";
            this.btAddCourse.Size = new System.Drawing.Size(91, 23);
            this.btAddCourse.TabIndex = 26;
            this.btAddCourse.Text = "添加课程";
            this.btAddCourse.UseVisualStyleBackColor = true;
            this.btAddCourse.Click += new System.EventHandler(this.btAddCourse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 478);
            this.Controls.Add(this.gbMain);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.tabcMain.ResumeLayout(false);
            this.tabpAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.tabpStudent.ResumeLayout(false);
            this.tabpStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tabpTeacher.ResumeLayout(false);
            this.tabpTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.tabpCourse.ResumeLayout(false);
            this.tabpCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.TabControl tabcMain;
        private System.Windows.Forms.TabPage tabpAdmin;
        private System.Windows.Forms.TabPage tabpStudent;
        private System.Windows.Forms.TabPage tabpTeacher;
        private System.Windows.Forms.TabPage tabpCourse;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Button btDeleteAdmin;
        private System.Windows.Forms.Button btUpdateAdmin;
        private System.Windows.Forms.Button btAddAdmin;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btDeleteStudent;
        private System.Windows.Forms.Button btUpdateStudent;
        private System.Windows.Forms.Button btAddStudent;
        private System.ComponentModel.BackgroundWorker bwMain;
        private System.Windows.Forms.Button btSearchByStuID;
        private System.Windows.Forms.TextBox tbStuID;
        private System.Windows.Forms.Label labStuID;
        private System.Windows.Forms.Button btSearchByTeaName;
        private System.Windows.Forms.TextBox tbTeaName;
        private System.Windows.Forms.Label labTeaName;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btDeleteTeacher;
        private System.Windows.Forms.Button btUpdateTeacher;
        private System.Windows.Forms.Button btAddTeacher;
        private System.Windows.Forms.Button btSearchByCouName;
        private System.Windows.Forms.TextBox tbCouName;
        private System.Windows.Forms.Label labCouName;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.Button btDeleteCourse;
        private System.Windows.Forms.Button btUpdateCourse;
        private System.Windows.Forms.Button btAddCourse;
        private System.Windows.Forms.Button btSeeCouTea;
        private System.Windows.Forms.Button btSeeTeaCou;
        private System.Windows.Forms.Button btSeeAllCourses;
        private System.Windows.Forms.Button btSeeAllTeachers;
        private System.Windows.Forms.Button btSeeAllStudents;
        private System.Windows.Forms.Button btSeeStuCou;
        private System.Windows.Forms.Label labLogout;
    }
}