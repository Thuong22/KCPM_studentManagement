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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Transparent_Form.Models;
using MySqlX.XDevAPI.Relational;
using System.Collections;
using System.Threading;
using System.Reflection;

namespace Transparent_Form
{
    public partial class PrintStudentForm : Form
    {
        Student student = new Student();

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void PrintStudent_Load(object sender, EventArgs e)
        {
            cbbGender.Items.Add("All");
            cbbGender.Items.Add("Male");
            cbbGender.Items.Add("Female");
            cbbGender.SelectedIndex = -1;
            cbbGender.Text = "Gender";
            cbbGender.Font = new Font(cbbGender.Font, FontStyle.Italic);
            dtgvStudent.AllowUserToResizeRows = false;

            LoadStudentList("SELECT * FROM `student`");
        }

        public void LoadStudentList(string query)
        {
            dtgvStudent.DataSource = student.GetStudentList(query);
            dtgvStudent.Columns[7].GetType();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dtgvStudent.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void cbbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            if (cbbGender.Text == "All")
                query = "SELECT* FROM `student`";
            else
                query = "SELECT * FROM `student` WHERE `Gender`='" + cbbGender.Text + "'";

            LoadStudentList(query);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var t = new Thread((ThreadStart)(() =>
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "OWLY Students List";
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
                printer.PrintDataGridView(dtgvStudent);
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
        }
    }
}
