using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApp.DataAccess;

namespace WinformApp
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }
        Prn211ProjectContext projectContext = new Prn211ProjectContext();
        public Ticket ticketInfor { get; set; }
        public bool IsUpDate { get; set; }
        private void TicketForm_Load(object sender, EventArgs e)
        {
            foreach (Category category in projectContext.Categories)
            {
                comboBoxTheLoaiVe.Items.Add(category.CategoryName);
            }
            comboBoxTheLoaiVe.SelectedIndex = 0;

            if (IsUpDate)
            {
                textBoxID.Text = ticketInfor.TicketId.ToString();
                textBoxID.Enabled = false;
                textBoxTenTranDau.Text = ticketInfor.TenTranDau;
                textBoxSoLuongVe.Text = ticketInfor.Quantity.ToString();
                textBoxGiaVe.Text = ticketInfor.Price.ToString();
                textBoxDesc.Text = ticketInfor.Description;
                dateTimePicker1.Text = ticketInfor.Time.ToString();
                int index = 0;
                foreach (Category category in projectContext.Categories)
                {
                    if (category.CategoryId == ticketInfor.CategoryId)
                    {
                        comboBoxTheLoaiVe.SelectedIndex = index;
                    }
                    index++;
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int categoryID = 1;

            foreach (Category category in projectContext.Categories)
            {
                if (category.CategoryName.Equals(comboBoxTheLoaiVe.Text))
                {
                    categoryID = category.CategoryId; break;
                }
            }



            Ticket ticket = null;
            try
            {
                ticket = new Ticket

                {
                    TicketId = int.Parse(textBoxID.Text),
                    TenTranDau = textBoxTenTranDau.Text,
                    Quantity = int.Parse(textBoxSoLuongVe.Text),
                    Description = textBoxDesc.Text,
                    Price = decimal.Parse(textBoxGiaVe.Text),
                    CategoryId = categoryID,
                    Time = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy/MM/dd")),

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (!IsUpDate)
            {

                projectContext.Tickets.Add(ticket);
                projectContext.SaveChanges();
                Close();
            }
            else
            {
                projectContext.Tickets.Update(ticket);
                projectContext.SaveChanges();
                Close();
            }

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        ///
        private void textBoxSoLuongVe_TextChanged(object sender, EventArgs e)
        {
            labelChecksoluong.Text = "";
            if (textBoxSoLuongVe.Text != null)
            {

                try
                {
                    int soluong = int.Parse(labelChecksoluong.Text);
                    labelChecksoluong.Text = "";
                    if (soluong <= 0)
                    {
                        labelChecksoluong.Text = "phai > 0";

                    }
                    else
                    {
                        labelChecksoluong.Text = "";

                    }


                }
                catch (Exception)
                {
                }

                labelChecksoluong.Text = "Must be >0";
            }
            else if (textBoxSoLuongVe.Text != null && int.Parse(textBoxSoLuongVe.Text) > 0)
            {
                labelChecksoluong.Text = "";
            }


        }

        private void textBoxGiaVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
