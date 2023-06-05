using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy_Cinema
{
    public partial class UCBookSeat : UserControl
    {
        private string pic { get; set; }
        private string cinema { get; set; }
        private string time { get; set; }
        private int price { get; set; }
        private string seat { set; get; }
        public UCBookSeat(string pic, string cinema, string time)
        {
            InitializeComponent();
            this.pic = pic;
            this.cinema = cinema;
            this.time = time;
        }

        string[] VipSeat = { "C6" , "C7", "C8", "C9", "C10", "C11", "C12", "C13",
                            "D6" , "D7", "D8", "D9", "D10", "D11", "D12", "D13",
                            "E6" , "E7", "E8", "E9", "E10", "E11", "E12", "E13"};
        string[] CoupleSeat = { "Couple1", "Couple2", "Couple3", "Couple4", "Couple5",
                                "Couple6", "Couple7", "Couple8"};

        string total = "Tổng: ";
        int totalPrice = 0;

        int count = 0;
        int tempCount = 0;
        int tempTotalPrice = 0;

        private async void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            var isChoose = Color.FromArgb(255, 143, 0);
            if(btn.BackColor != isChoose)
            {
                count++;
                if (VipSeat.Contains(btn.Name))
                {
                    totalPrice += 120000;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";
                }
                else if (CoupleSeat.Contains(btn.Name))
                {
                    count++;
                    totalPrice += 210000;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";
                }
                else
                {
                    totalPrice += 95000;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";
                }
                if (count > 8)
                {
                    count = tempCount;
                    totalPrice = tempTotalPrice;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";

                    pnlBookSeat.Visible = true;
                    await Task.Delay(1000);
                    pnlBookSeat.Visible = false;
                }
                else 
                {
                    lbSeatChosing.Text = lbSeatChosing.Text + " " + btn.Name;

                    btn.BackColor = isChoose;
                    tempCount = count;
                    tempTotalPrice = totalPrice;
                }
            }
            else
            {
                count--;
                if (VipSeat.Contains(btn.Name))
                {
                    btn.BackColor = Color.FromArgb(233, 54, 54);
                    totalPrice -= 120000;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";
                }
                else if (CoupleSeat.Contains(btn.Name)) 
                {
                    count--;
                    btn.BackColor = Color.FromArgb(100, 145, 249);
                    totalPrice -= 210000;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";
                }
                else
                {
                    btn.BackColor = Color.FromArgb(163, 182, 169);
                    totalPrice -= 95000;
                    lbTotalPrice.Text = total + totalPrice + " VNĐ";
                }

                if (lbSeatChosing.Text.Contains(btn.Name))
                {
                    lbSeatChosing.Text = lbSeatChosing.Text.Remove(lbSeatChosing.Text.IndexOf(btn.Name) -1 , btn.Name.Length + 1);
                }
            }
            if (count > 0)
                btnContinue.Visible = true;
            else btnContinue.Visible = false;
            price = totalPrice;
            seat = lbSeatChosing.Text.Replace("Bạn đang đặt ghế: ", "");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            foreach (Control control in Homepage.Instance.pnlContain.Controls)
            {
                Homepage.Instance.pnlContain.Controls.Remove(control);
            }
            UCCombo combo = new UCCombo(this.pic, this.cinema, this.time, this.price, this.seat);
            combo.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(combo);
            Homepage.Instance.pnlContain.Controls["UCCombo"]?.BringToFront();
        }

        private void UCBookSeat_Load(object sender, EventArgs e)
        {
            foreach(Control control in pnlSeat.Controls)
            {
                if(control is Button && control.BackColor == Color.FromArgb(52, 50, 52))
                {
                    control.Enabled = false;
                }
            }
            lbTotalPrice.Text = total + totalPrice + " VNĐ"; 
        }
    }
}
