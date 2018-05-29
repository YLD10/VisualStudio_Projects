using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab5
{
    public partial class Lab5_Form : Form
    {
        public Lab5_Form()
        {
            InitializeComponent();
        }

        //抽象基类
        public abstract class Student
        {
            protected string name;
            protected int age;
            public static int number;
            public Student (string name, int age)
            {
                this.name = name;
                this.age = age;
                ++ number;
            }
            public string Name {get {return name;}}
            public abstract double Average ();
        }

        //派生子类：小学生类&大学生类
        public class Pupil : Student
        {
            protected double chinese;
            protected double math;
            public Pupil (string name, int age, double chinese, double math)
                : base (name, age)
            {
                this.chinese = chinese;
                this.math = math;
            }
            public override double Average()
            {
                //throw new NotImplementedException();
                return (chinese + math) / 2;
            }
        }

        //派生子类：中学生类
        public class Middle : Pupil
        {
            protected double english;
            public Middle(string name, int age, double chinese, double math, double english)
                : base (name,age,chinese,math)
            {
                this.english = english;
            }
            public override double Average()
            {
                //throw new NotImplementedException();
                return (chinese + math + english) / 3;
            }
        }

        private void btPupil_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (tbName.Text == "" || tbAge.Text == "" || tbChinese.Text == "" || tbMath.Text == "")
            {
                MessageBox.Show("不能为空！", "警告", MessageBoxButtons.OK);
            }
            else
            {
                if (bt.Text == "中学生")
                {
                    if (tbEnglish.Text == "")
                    {
                        MessageBox.Show("英语不能为空！", "警告", MessageBoxButtons.OK);
                        return;
                    }
                }
                
                string name = tbName.Text;
                int age = Convert.ToInt32(tbAge.Text);
                double chinese = Convert.ToDouble(tbChinese.Text);
                double math = Convert.ToDouble(tbMath.Text);

                if (age > 0 && age <= 150 && chinese >= 0 && chinese <= 100 && math >= 0 && math <= 100)
                {
                    if (bt.Text == "中学生")
                    {
                        double english = Convert.ToDouble(tbEnglish.Text);
                        Middle middle = new Middle(name, age, chinese, math, english);
                        tbManifest.Text += string.Format("总人数：{0}，姓名：{1}，中学生，平均成绩为：{2}{3}",
                                            Middle.number, middle.Name, middle.Average(), System.Environment.NewLine);
                    }
                    else
                    {
                        Pupil pupil = new Pupil(name, age, chinese, math);
                        tbManifest.Text += string.Format("总人数：{0}，姓名：{1}，{2}，平均成绩为：{3}{4}",
                                            Pupil.number, pupil.Name, bt.Text, pupil.Average(), System.Environment.NewLine);

                    }
                }
                
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            textBox.Text = "";
        }
    }
}
