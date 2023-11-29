using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApp.DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Office.Interop.Excel;
using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;

namespace WinformApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            LoadTickets();

        }

        public void LoadTickets()

        {
            Prn211ProjectContext projectContext = new Prn211ProjectContext();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            List<Category> categories = projectContext.Categories.ToList();

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Ticket ID";
            dataGridView1.Columns[1].Name = "Ten tran dau";
            dataGridView1.Columns[2].Name = "Thoi gian";
            dataGridView1.Columns[3].Name = "Gia ve";
            dataGridView1.Columns[4].Name = "Loai ve";
            dataGridView1.Columns[5].Name = "Mo ta";
            dataGridView1.Columns[6].Name = "So Luong";
            string[] row = new string[7];
            foreach (Ticket ticket in projectContext.Tickets.ToList())
            {
                row[0] = ticket.TicketId + "";
                row[1] = ticket.TenTranDau + "";
                row[2] = ticket.Time + "";
                foreach (Category category in categories)
                {
                    if (category.CategoryId == ticket.CategoryId)
                    {
                        row[4] = category.CategoryName + "";
                    }
                }
                row[3] = ticket.Price + "";
                row[5] = ticket.Description + "";
                row[6] = ticket.Quantity + "";
                dataGridView1.Rows.Add(row);

            }

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm
            {
                Text = "Add New Ticket"
            };
            ticketForm.Show();


        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm
            {
                Text = "edit tickets",
                ticketInfor = GetTicket(),
                IsUpDate = true

            };
            ticketForm.Show();
        }

        public Ticket GetTicket()
        {
            Prn211ProjectContext projectContext = new Prn211ProjectContext();
            int rowIndex = dataGridView1.CurrentRow.Index;
            var ticketList = projectContext.Tickets.ToList();

            return ticketList.ElementAt(rowIndex);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Ticket ticket = GetTicket();
            var confirmResult = MessageBox.Show("are you sure ??",
                                     "Chắc!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Prn211ProjectContext projectContext = new Prn211ProjectContext();
                projectContext.Tickets.Remove(ticket);
                projectContext.SaveChanges();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Ticket> listsearch = new List<Ticket>();
            dataGridView1.DataSource = null;
            Prn211ProjectContext projectContext = new Prn211ProjectContext();
            var tickets = projectContext.Tickets.ToList();
            foreach (var ticketsItem in tickets)
            {
                if (ticketsItem.TenTranDau.ToUpper().Contains(textBoxSearch.Text.ToUpper()))
                {
                    listsearch.Add(ticketsItem);
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = listsearch;
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "XLS (.xls)|.xls|" +
                "XLT (.xlt)|.xlt|" +
                "XLSX (.xlsx)|.xlsx|" +
                "XLSM (.xlsm)|.xlsm|" +
                "XLTX (.xltx)|.xltx|" +
                "XLTM (.xltm)|.xltm|" +
                "ODS (.ods)|.ods|" +
                "OTS (.ots)|.ots|" +
                "CSV (.csv)|.csv|" +
                "TSV (.tsv)|.tsv|" +
                "HTML (.html)|.html|" +
                "MHTML (.mhtml)|*.mhtml|" +
                "PDF (.pdf)|.pdf|" +
                "XPS (.xps)|.xps|" +
                "BMP (.bmp)|.bmp|" +
                "GIF (.gif)|.gif|" +
                "JPEG (.jpg)|.jpg|" +
                "PNG (.png)|.png|" +
                "TIFF (.tif)|.tif|" +
                "WMP (.wdp)|.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dataGridView1,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true });

                workbook.Save(saveFileDialog.FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
