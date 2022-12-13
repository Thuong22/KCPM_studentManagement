using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;


namespace Transparent_Form
{
    public partial class PrintScoreForm : Form
    {
        Score score = new Score();
        DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_score.DataSource = score.getList(new MySqlCommand(
                "SELECT score.StudentId, student.StdFirstName, student.StdLastName, course.CourseName, score.Score, score.Description " +
                "FROM student INNER JOIN score INNER JOIN course ON score.StudentId = student.StdId AND score.CourseId = course.CourseId " +
                "WHERE CONCAT(student.StdFirstName, student.StdLastName, course.CourseName)LIKE '%" + textBox_search.Text + "%'"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "OWLY Student Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "OWLY Student Management System";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_score);
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScore();
        }

        public void showScore()
        {
            DataGridView_score.DataSource = score.getList(new MySqlCommand(
                "SELECT score.StudentId,student.StdFirstName,student.StdLastName,course.CourseName,score.Score,score.Description " +
                "FROM student INNER JOIN score INNER JOIN course ON score.StudentId=student.StdId AND score.CourseId=course.CourseId"));
        }
    }
}
