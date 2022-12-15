using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Threading;

namespace Transparent_Form
{
    public partial class PrintCourseForm : Form
    {
        Course course = new Course();

        public PrintCourseForm()
        {
            InitializeComponent();
        }
        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            dtgvCourse.DataSource = course.GetCourseList("SELECT * FROM `course`");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox);
            if (txt.Text.Length == 0)
                dtgvCourse.DataSource = course.GetCourseList("SELECT * FROM `course`");
            else
                dtgvCourse.DataSource = course.GetCourseList($"SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%{txtSearch.Text}%'");
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() =>
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "OWLY Course List";
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
                printer.PrintDataGridView(dtgvCourse);
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
