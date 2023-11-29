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

namespace WinformApp
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        Prn211ProjectContext projectContext = new Prn211ProjectContext();
        public Account acc { get; set; }
        public Ticket GetTicket()
        {
            Prn211ProjectContext projectContext = new Prn211ProjectContext();
            int rowIndex = dataGridView1.CurrentRow.Index;
            var ticketList = projectContext.Tickets.ToList();

            return ticketList.ElementAt(rowIndex);
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }


        public void LoadTickets()
        {
            List<Category> categories = projectContext.Categories.ToList();
            comboBox1.Items.Clear();
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

            }
            catch (Exception ex)
            {
            }
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
            foreach (Category category in projectContext.Categories)
            {
                comboBox1.Items.Add(category.CategoryName);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Ticket> ticketList = new List<Ticket>();
            List<Category> categories = projectContext.Categories.ToList();
            string name = textBox1.Text;
            string categoryname = comboBox1.Text;
            int index = 0;
            foreach (Category cat in projectContext.Categories)
            {
                if (cat.CategoryName.Equals(categoryname))
                {
                    index = cat.CategoryId; break;
                }
            }
            foreach (Ticket ticket in projectContext.Tickets)
            {
                if (ticket.TenTranDau.ToUpper().Contains(name.ToUpper()) && ticket.CategoryId == index)
                {
                    ticketList.Add(ticket);
                }
            }
            try
            {
                dataGridView1.Rows.Clear(); dataGridView1.Columns.Clear();
            }
            catch (Exception ex) { }
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Ticket ID";
            dataGridView1.Columns[1].Name = "Ten tran dau";
            dataGridView1.Columns[2].Name = "Thoi gian";
            dataGridView1.Columns[3].Name = "Gia ve";
            dataGridView1.Columns[4].Name = "Loai ve";
            dataGridView1.Columns[5].Name = "Mo ta";
            dataGridView1.Columns[6].Name = "So Luong";
            string[] row = new string[7];
            foreach (Ticket ticket in ticketList)
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
            //dataGridView1.DataSource=ticketList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBooking formBooking = new FormBooking
            {
                Text = "Booking",
                Ticketinfor = GetTicket(),
                AccountInfor = acc



            };
            
            formBooking.Show();
            

        }

        private void buttonLichsu_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory { acc = acc };
            formHistory.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }
    }
}
