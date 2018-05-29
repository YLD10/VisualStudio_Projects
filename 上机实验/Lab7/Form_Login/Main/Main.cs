using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_SC
{
    public partial class Main : Form
    {
        #region 一些字段属性
        private int sortOrder = 0;
        private static DataSet _dsAdmin = new DataSet();
        private static DataSet _dsStudent = new DataSet();
        private static DataSet _dsTeacher = new DataSet();
        private static DataSet _dsCourse = new DataSet();

        public static DataSet dsAdmin
        {
            get
            {
                return _dsAdmin;
            }
            set
            {
                _dsAdmin = value;
            }
        }

        public static DataSet dsStudent
        {
            get
            {
                return _dsStudent;
            }
            set
            {
                _dsStudent = value;
            }
        }

        public static DataSet dsTeacher
        {
            get
            {
                return _dsTeacher;
            }
            set
            {
                _dsTeacher = value;
            }
        }

        public static DataSet dsCourse
        {
            get
            {
                return _dsCourse;
            }
            set
            {
                _dsCourse = value;
            }
        }
        #endregion

        #region 控件加载，数据加载
        public Main()
        {
            InitializeComponent();
            Init();
            LoadData();
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag.ToString() == "Out")
            {
                Login login = (Login)this.Owner;
                login.Dispose();
                login.Close();
            }
        }

        private void Init()
        {
            this.Tag = "Out";
            tabcMain.Visible = false;
            tabcMain.Controls.Clear();
            switch (Maticsoft.Common.StaticDataClass.userType)
            {
                case "管理员":
                    gbMain.Text = "系统(&A)";
                    tabcMain.Controls.Add(tabpAdmin);
                    tabcMain.Controls.Add(tabpStudent);
                    tabcMain.Controls.Add(tabpTeacher);
                    tabcMain.Controls.Add(tabpCourse);
                    tabcMain.SelectTab(tabpAdmin);
                    tabcMain.Visible = true;
                    break;
                case "学生":
                    gbMain.Text = "学生(&S)";
                    tabcMain.Controls.Add(tabpStudent);
                    tabcMain.Controls.Add(tabpCourse);
                    tabcMain.SelectTab(tabpStudent);
                    labStuID.Visible = false;
                    tbStuID.Visible = false;
                    btSearchByStuID.Visible = false;
                    btSeeAllStudents.Visible = false;
                    btAddStudent.Visible = false;
                    btUpdateStudent.Location = new Point(50, 35);
                    btUpdateStudent.Text = "修改信息";
                    btDeleteStudent.Visible = false;
                    btSeeStuCou.Location = new Point(200, 35);
                    dgvStudent.Location = new Point(6, 93);
                    dgvStudent.Size = new System.Drawing.Size(742, 323);
                    CoursePageInit();
                    tabcMain.Visible = true;
                    break;
                case "教师":
                    gbMain.Text = "教师(&T)";
                    tabcMain.Controls.Add(tabpTeacher);
                    tabcMain.Controls.Add(tabpCourse);
                    tabcMain.SelectTab(tabpTeacher);
                    labTeaName.Visible = false;
                    tbTeaName.Visible = false;
                    btSearchByTeaName.Visible = false;
                    btSeeAllTeachers.Visible = false;
                    btAddTeacher.Visible = false;
                    btUpdateTeacher.Location = new Point(50, 35);
                    btUpdateTeacher.Text = "修改信息";
                    btDeleteTeacher.Visible = false;
                    btSeeTeaCou.Location = new Point(200, 35);
                    dgvTeacher.Location = new Point(6, 93);
                    dgvTeacher.Size = new System.Drawing.Size(742, 323);
                    CoursePageInit();
                    tabcMain.Visible = true;
                    break;
            }
        }

        private void CoursePageInit()
        {
            btAddCourse.Visible = false;
            btUpdateCourse.Visible = false;
            btDeleteCourse.Visible = false;
            btSeeCouTea.Location = new Point(537, 35);
            dgvCourse.Location = new Point(6, 93);
            dgvCourse.Size = new System.Drawing.Size(742, 323);
        }

        private void LoadData()
        {
            switch (Maticsoft.Common.StaticDataClass.userType)
            {
                case "管理员":
                    LoadData_Admin();
                    bwMain.DoWork += new DoWorkEventHandler(bwMain_STC_DoWork);
                    bwMain.RunWorkerAsync();
                    break;
                case "学生":
                    LoadData_Student();
                    bwMain.DoWork += new DoWorkEventHandler(bwMain_C_DoWork);
                    bwMain.RunWorkerAsync();
                    break;
                case "教师":
                    LoadData_Teacher();
                    bwMain.DoWork += new DoWorkEventHandler(bwMain_C_DoWork);
                    bwMain.RunWorkerAsync();
                    break;
                default:
                    MessageBox.Show("登录出错！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    break;
            }
        }

        private void bwMain_STC_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadData_Student();
            LoadData_Teacher();
            LoadData_Course();
        }

        private void bwMain_C_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadData_Course();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                switch (dgv.Name)
                {
                    case "dgvAdmin":
                        Maticsoft.Common.StaticDataClass.admin.ID = int.Parse(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                        Maticsoft.Common.StaticDataClass.admin.userName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        break;
                    case "dgvStudent":
                        Maticsoft.Common.StaticDataClass.student.ID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Maticsoft.Common.StaticDataClass.student.stuName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Maticsoft.Common.StaticDataClass.student.stuSex = dgv.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("男") ? 1 : 0;
                        Maticsoft.Common.StaticDataClass.student.stuCollege = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        Maticsoft.Common.StaticDataClass.student.stuMajor = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                        Maticsoft.Common.StaticDataClass.student.stuClass = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                        break;
                    case "dgvTeacher":
                         Maticsoft.Common.StaticDataClass.teacher.ID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                         Maticsoft.Common.StaticDataClass.teacher.teaName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                         Maticsoft.Common.StaticDataClass.teacher.teaSex = dgv.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("男") ? 1 : 0;
                         Maticsoft.Common.StaticDataClass.teacher.teaTitle = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        break;
                    case "dgvCourse":
                        Maticsoft.Common.StaticDataClass.course.ID = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Maticsoft.Common.StaticDataClass.course.couName = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Maticsoft.Common.StaticDataClass.course.couTime = int.Parse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString());
                        Maticsoft.Common.StaticDataClass.course.couPoint = decimal.Parse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
                        break;
                }
            }
            else
            {
                Maticsoft.Common.StaticDataClass.admin.userName = "";
                Maticsoft.Common.StaticDataClass.student.ID = "";
                Maticsoft.Common.StaticDataClass.teacher.ID = "";
                Maticsoft.Common.StaticDataClass.course.ID = "";
                if (sortOrder == 0)
                {
                    dgv.Sort(dgv.Columns[e.ColumnIndex], ListSortDirection.Descending);
                    sortOrder++;
                }
                else
                {
                    dgv.Sort(dgv.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                    sortOrder--;
                }
            }
        }

        private void labLogout_Click(object sender, EventArgs e)
        {
            Login login = (Login)this.Owner;
            login.Init();
            login.Show();

            this.Tag = "Logout";
            this.Dispose();
            this.Close();
        }
        #endregion
    }     
}
