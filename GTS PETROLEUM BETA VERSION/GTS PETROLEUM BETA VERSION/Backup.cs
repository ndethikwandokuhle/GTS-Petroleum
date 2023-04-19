using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTS_PETROLEUM_BETA_VERSION
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            //getting current and latest SALES records
            string tankname = "Petrol_1";
            string tankname1 = "Petrol_2";
            string tankname2 = "Diesel_1";
            string tankname3 = "Diesel_2";
            DbConn.DisplayAndSearch("SELECT date, tankname, pumpname, dipquantity, totalsales, amount, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, prepaid, postpaid, station FROM sales WHERE tankname LIKE '%" + tankname + "%' ORDER BY id DESC LIMIT 1", petrol1_dgv);
            DbConn.DisplayAndSearch("SELECT date, tankname, pumpname, dipquantity, totalsales, amount, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, prepaid, postpaid, station FROM sales WHERE tankname LIKE '%" + tankname1 + "%' ORDER BY id DESC LIMIT 1", petrol2_dgv);
            DbConn.DisplayAndSearch("SELECT date, tankname, pumpname, dipquantity, totalsales, amount, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, prepaid, postpaid, station FROM sales WHERE tankname LIKE '%" + tankname2 + "%' ORDER BY id DESC LIMIT 1", diesel1_dgv);
            DbConn.DisplayAndSearch("SELECT date, tankname, pumpname, dipquantity, totalsales, amount, dipopenl, dipclosel, dipmovement, pumpstock, dipstock, variation, cashsubmitted, cashshort, cashtotal, prepaid, postpaid, station FROM sales WHERE tankname LIKE '%" + tankname3 + "%' ORDER BY id DESC LIMIT 1", diesel2_dgv);


            //getting latest DELIVERIES records
            string petrol = "Petrol";
            string diesel = "Diesel";
            DbConn.DisplayAndSearch("SELECT deliverydate, fueltype,invoiceno, dnoteno, dnoteqty, lorryqty, lorryvar, t1received, t2received, qtyreceived, variation, station FROM deliveries WHERE fueltype LIKE '%" + petrol + "%' ORDER BY id DESC LIMIT 1", petrol_dgv);
            DbConn.DisplayAndSearch("SELECT deliverydate, fueltype,invoiceno, dnoteno, dnoteqty, lorryqty, lorryvar, t1received, t2received, qtyreceived, variation, station FROM deliveries WHERE fueltype LIKE '%" + diesel + "%' ORDER BY id DESC LIMIT 1", diesel_dgv);


            //getting latest READING records
            DbConn.DisplayAndSearch("SELECT readingdate, tankname, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres, station FROM reading WHERE tankname LIKE '%" + tankname + "%' ORDER BY id DESC LIMIT 1", tp1_dgv);
            DbConn.DisplayAndSearch("SELECT readingdate, tankname, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres, station FROM reading WHERE tankname LIKE '%" + tankname1 + "%' ORDER BY id DESC LIMIT 1", tp2_dgv);
            DbConn.DisplayAndSearch("SELECT readingdate, tankname, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres, station FROM  reading WHERE tankname LIKE '%" + tankname2 + "%' ORDER BY id DESC LIMIT 1", td1_dgv);
            DbConn.DisplayAndSearch("SELECT readingdate, tankname, autoopenlitres, variationlitres, closedipmeters, closediplitres, movementlitres, station FROM  reading WHERE tankname LIKE '%" + tankname3 + "%' ORDER BY id DESC LIMIT 1", td2_dgv);


            //getting latest Users
            DbConn.DisplayAndSearch("SELECT ID, fullname, dob, sex, position, idnumber, phone, email FROM employee", employee_dgv);

            timer1.Start();
            //*********************************************************************************************************************
        }

        private void Excelfiles()
        {
            //sales
            Petrol_1sales();
            Petrol_2sales();
            Diesel_1sales();
            Diesel_2sales();

            //deliveries
            Petrol_deliveries();
            Diesel_deliveries();

            //readings
            Tp1();
            Tp2();
            Td1();
            Td2();
        }

        private void panel4_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = progressBar1.Value.ToString() + "%";
            progressBar1.Value += 1;
            if (progressBar1.Value == 15)
                label2.Text = "Identifying and filtering backup data...";

            if (progressBar1.Value == 24)
                label2.Text = "Sales table data extraction...";

            if (progressBar1.Value == 28)
                label2.Text = "Dip read table data extraction...";

            if (progressBar1.Value == 34)
                label2.Text = "Deliveries table data extraction...";

            if (progressBar1.Value == 38)
                label2.Text = "Accounts table data extraction...";

            if (progressBar1.Value == 54)
                label2.Text = "Starting export...";

            if (progressBar1.Value == 61)
                label2.Text = "Preparing data...";

            if (progressBar1.Value == 74)
                label2.Text = "Starting Excel...";

            if (progressBar1.Value == 84)
                label2.Text = "Moving data...";

            if (progressBar1.Value == 92)
                label2.Text = "Fnishing up...";
 
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label2.Text = "Done";
                label4.Text = "100%";
                Excelfiles();
                MessageBox.Show("Backup Completed Successfully. \n\rRaw data has been exported to Ms Excel", "Backup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        //***********************************************************************************************************************************************
        //**********************************************************************************************************************************************
        //*********************************************************************************************************************************************
        //********************************************************************************************************************************************
        
        private void Petrol_1sales()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < petrol1_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = petrol1_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < petrol1_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < petrol1_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = petrol1_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Petrol_1 Sales " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void Petrol_2sales()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < petrol2_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = petrol2_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < petrol2_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < petrol2_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = petrol2_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Petrol_2 Sales " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void Diesel_1sales()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < diesel1_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = diesel1_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < diesel1_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < diesel1_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = diesel1_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Diesel_1 Sales " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void Diesel_2sales()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < diesel2_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = diesel2_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < diesel2_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < diesel2_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = diesel2_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Diesel_2 Sales " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        //************************************************************************************************************
        //****************************************************************************************************************
        private void Petrol_deliveries()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < petrol_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = petrol_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < petrol_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < petrol_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = petrol_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Petrol deliveries " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }


        private void Diesel_deliveries()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < diesel_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = diesel_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < diesel_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < diesel_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = diesel_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Diesel deliveries " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }


        //********************************************************************************************************
        //********************************************************************************************************
        //********************************************************************************************************
        private void Tp1()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < tp1_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = tp1_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < tp1_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < tp1_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = tp1_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Petrol_1 Readings " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void Tp2()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < tp2_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = tp2_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < tp2_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < tp2_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = tp2_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Petrol_2 Readings " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void Td1()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < td1_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = td1_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < td1_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < td1_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = td1_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Diesel_1 Readings " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        private void Td2()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "GTSSales";

            for (int i = 1; i < td2_dgv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = td2_dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < td2_dgv.Rows.Count; i++)
            {
                for (int j = 0; j < td2_dgv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = td2_dgv.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            DateTime now = DateTime.Now;
            string x = now.ToString("dddd, MMMM dd");
            saveFileDialoge.FileName = "Diesel_2 Readings " + x;
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
