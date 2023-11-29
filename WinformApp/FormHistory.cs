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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        public Account acc { get;  set; }
        private void FormHistory_Load(object sender, EventArgs e)
        {
            Prn211ProjectContext prn211ProjectContext = new Prn211ProjectContext();
            List<Order> orders = prn211ProjectContext.Orders.Where(x => x.Username == acc.Username).ToList();   
            
        
            OrderDetail orderDetails = new OrderDetail();
            string[] row = new string[6];
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name= "Date ordered";
            dataGridView1.Columns[1].Name = "Ticket ID";
            dataGridView1.Columns[2].Name = "So luong";
            dataGridView1.Columns[3].Name = "Gia Ve";
            dataGridView1.Columns[4].Name = "Tong tien";
            dataGridView1.Columns[5].Name = "Code";
            foreach (Order order in orders)
            {

                orderDetails = prn211ProjectContext.OrderDetails.SingleOrDefault(x => x.OrderId == order.OrderId);
                if (orderDetails != null)
                {
                    row[0] = order.Orderdate.ToString();
                    row[1] = orderDetails.TicketId.ToString();
                    row[2] = orderDetails.Quantity.ToString();
                    row[3] = orderDetails.Price.ToString();
                    row[4] = orderDetails.Price * orderDetails.Quantity+"";
                    row[5] = order.Code;
                    //ConfirmCode c = prn211ProjectContext.ConfirmCodes.SingleOrDefault
                    //    (x => x.ID == order.OrderId);
                    //if (c != null)
                    //{
                    //    row[5] = c.Code;
                    //}
                    //else
                    //{
                    //    row[5] = "";
                    //}
                dataGridView1.Rows.Add(row);
                
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //FormBooking formBooking = new FormBooking();
            //formBooking.Show();
            Close();
        }
    }
}
