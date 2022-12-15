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
using System.Threading;

namespace Transparent_Form
{
    public partial class PrintScoreForm : Form
    {
        Score score = new Score();

        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            LoadScore();
        }

        public void LoadScore()
        {
            dtgvScore.DataSource = score.GetScoreList(
                "SELECT score.StudentId,student.StdFirstName,student.StdLastName,course.CourseName,score.Score,score.Description " +
                "FROM student INNER JOIN score INNER JOIN course ON score.StudentId=student.StdId AND score.CourseId=course.CourseId");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox);
            if (txt.Text.Length == 0)
                LoadScore();
            else
            {
                dtgvScore.DataSource = score.GetScoreList(
                $@"SELECT score.StudentId, student.StdFirstName, student.StdLastName, course.CourseName, score.Score, score.Description 
                FROM student INNER JOIN score INNER JOIN course ON score.StudentId = student.StdId AND score.CourseId = course.CourseId 
                WHERE CONCAT(student.StdFirstName, student.StdLastName, course.CourseName)LIKE '%{txtSearch.Text}%'");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() =>
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "OWLY Student Report";
                printer.TitleColor = Color.FromArgb(0, 71, 160);
                printer.TitleSpacing = 10;
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.SubTitleSpacing = 10;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "OWLY Student Management System";
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dtgvScore);
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
