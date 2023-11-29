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
    public partial class FormBooking : Form
    {
        public FormBooking()
        {
            InitializeComponent();
        }
        public Ticket Ticketinfor { get; set; }
        Prn211ProjectContext Prn211ProjectContext = new Prn211ProjectContext();
        public Account AccountInfor { get; set; }
        
        private void FormBooking_Load(object sender, EventArgs e)
        {
            labelTenTranDau.Text = Ticketinfor.TenTranDau;
            labelTime.Text = Ticketinfor.Time.ToString();
            labelPrice.Text = Ticketinfor.Price.ToString();
            foreach (Category cat in Prn211ProjectContext.Categories)
            {
                if (cat.CategoryId == Ticketinfor.CategoryId)
                {
                    labelLoaiVe.Text = cat.CategoryName;
                    break;

                }
            }

            textBoxSoLuong.Text = "1";
            labelTongTien.Text = Ticketinfor.Price.ToString();
        }

        private void textBoxSoLuong_TextChanged(object sender, EventArgs e)
        {
            int soluongve = int.Parse(textBoxSoLuong.Text);
            if (soluongve < 0)
            {
                MessageBox.Show("Must be greater than 0");
            }
            labelTongTien.Text = soluongve * Ticketinfor.Price + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int orderid = 0;
            foreach (Order order in Prn211ProjectContext.Orders)
            {
                if (orderid < order.OrderId)
                {
                    orderid = order.OrderId;
                }
            }
            int? quantity = Prn211ProjectContext.Tickets.SingleOrDefault(t => t.TicketId == Ticketinfor.TicketId).Quantity;

            if (quantity < int.Parse(textBoxSoLuong.Text))
            {
                MessageBox.Show("Too Much");
            }
            //else if (quantity < 0) {
              //  MessageBox.Show("Het ve roi");
            //}
            else
            {
                Order order = new Order
                {
                    OrderId = ++orderid,
                    Code = GetConfirmCode(),
                    Username = AccountInfor.Username,
                    Orderdate = DateTime.Now
                };
                Prn211ProjectContext.Orders.Add(order);
                Prn211ProjectContext.OrderDetails.Add(new OrderDetail
                {
                    OrderId = orderid,
                    Price = decimal.Parse(labelPrice.Text),
                    Quantity = int.Parse(textBoxSoLuong.Text),
                    TicketId = Ticketinfor.TicketId,
                });
                Ticket ticket = Prn211ProjectContext.Tickets.SingleOrDefault(x => x.TicketId == Ticketinfor.TicketId);
                ticket.Quantity = ticket.Quantity - int.Parse(textBoxSoLuong.Text);
                Prn211ProjectContext.Tickets.Update(ticket);
                MessageBox.Show(order.Code, "Your Code");

                
                //var LastCode = Prn211ProjectContext.ConfirmCodes.Max(x => x.ID);

                //ConfirmCode confirmCode = new ConfirmCode
                //{
                 //   ID = orderid,
                 //   TicketId = Ticketinfor.TicketId,
                 //   Username=AccountInfor.Username,
                 //   Code = GetConfirmCode()
                //};
                //Prn211ProjectContext.ConfirmCodes.Add(confirmCode);
                Prn211ProjectContext.SaveChanges();

                
                FormUser formUser = new FormUser { acc = AccountInfor };
                
                Close();
            }
        }

        public string GetConfirmCode()
        {
            string c = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string code = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                code += c[random.Next(36)];
            }
            return code;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormUser formUser = new FormUser( acc = acc);
            //formUser.Show();
            this.Close();
        }
    }
}
