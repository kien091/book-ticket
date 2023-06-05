using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galaxy_Cinema
{
    public partial class UCCombo : UserControl
    {
        private string pic { get; set; }
        private string cinema { get; set; }
        private string time { get; set; }
        private int price { get; set; }
        private string seat { get; set; }
        private int tempPrice { get; set; }
        private ResourceManager resource;
        public UCCombo(string pic, string cinema, string time, int price, string seat)
        {
            InitializeComponent();
            this.pic = pic;
            this.cinema = cinema;
            this.time = time;
            this.price = price;
            this.seat = seat;
            tempPrice = price;
            this.resource = new ResourceManager("Galaxy_Cinema.Properties.Resources", typeof(UCFilm).Assembly);
        }

        private async void btnBook_Click(object sender, EventArgs e)
        {
            pnlBook.Visible = true ;
            pnlBook.BringToFront();
            await Task.Delay(1000);
            pnlBook.Visible = false ;
            pnlBook.SendToBack();

            foreach (Control control in Homepage.Instance.pnlContain.Controls)
            {
                Homepage.Instance.pnlContain.Controls.Remove(control);
            }
            UCLoadFilm loadFilm = new UCLoadFilm();
            loadFilm.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(loadFilm);
            Homepage.Instance.pnlContain.Controls["UCLoadFilm"]?.BringToFront();
        }

        int price1 = 0;
        int price2 = 0;
        int price3 = 0;
        int price4 = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RichTextBox rtxt = txt[btnAdd.IndexOf(btn)];
            int val = int.Parse(rtxt.Text);
            val++;
            rtxt.Text = val.ToString();
            if(btn.Name == "btnAdd1")
            {
                price1 += 459000;
                price += 459000;
                lb1.Text = price1 + " VNĐ";
            }
            else if (btn.Name == "btnAdd2")
            {
                price2 += 489000;
                price += 489000;
                lb2.Text = price2 + " VNĐ";
            }
            else if (btn.Name == "btnAdd3")
            {
                price3 += 99000;
                price += 99000;
                lb3.Text = price3 + " VNĐ";
            }
            else if (btn.Name == "btnAdd4")
            {
                price4 += 79000;
                price += 79000;
                lb4.Text = price4 + " VNĐ";
            }
            else if (btn.Name == "btnAdd5")
            {
                price -= 1000;
            }
            tempPrice = price;
            lbTotal.Text = "Tổng: " + this.price + " VNĐ";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            RichTextBox rtxt = txt[btnMinus.IndexOf(btn)];
            int val = int.Parse(rtxt.Text);
            val--;
            if (val < 0) val = 0;
            else
            {
                rtxt.Text = val.ToString();
                if (btn.Name == "btnMinus1")
                {
                    price1 -= 459000;
                    price -= 459000;
                    lb1.Text = price1 + " VNĐ";
                }
                else if (btn.Name == "btnMinus2")
                {
                    price2 -= 489000;
                    price -= 489000;
                    lb2.Text = price2 + " VNĐ";
                }
                else if (btn.Name == "btnMinus3")
                {
                    price3 -= 99000;
                    price -= 99000;
                    lb3.Text = price3 + " VNĐ";
                }
                else if (btn.Name == "btnMinus4")
                {
                    price4 -= 79000;
                    price -= 79000;
                    lb4.Text = price4 + " VNĐ";
                }
                else if (btn.Name == "btnMinus5")
                {
                    price += 1000;
                }
                tempPrice = price;
                lbTotal.Text = "Tổng: " + this.price + " VNĐ";
            }
        }

        List<Button> btnAdd = new List<Button>();
        List<Button> btnMinus = new List<Button>();
        List<RichTextBox> txt = new List<RichTextBox>();

        List<Movie> data = new List<Movie>();
        Dictionary<string, int> movie = new Dictionary<string, int>();
        private void UCCombo_Load(object sender, EventArgs e)
        {
            btnAdd.Add(btnAdd1);
            btnAdd.Add(btnAdd2);
            btnAdd.Add(btnAdd3);
            btnAdd.Add(btnAdd4);
            btnAdd.Add(btnAdd5);

            btnMinus.Add(btnMinus1);
            btnMinus.Add(btnMinus2);
            btnMinus.Add(btnMinus3);
            btnMinus.Add(btnMinus4);
            btnMinus.Add(btnMinus5);

            txt.Add(txt1);
            txt.Add(txt2);
            txt.Add(txt3);
            txt.Add(txt4);
            txt.Add(txt5);

            loadDictionary(this.movie);
            loadFilm(data);
            var film = data.ElementAt(this.movie[this.pic]);

            pbFilm.Image = film.Picture;
            lbName.Text = film.Name;
            lbNameVN.Text = film.NameVN;
            lbAge.Text = film.AgeToWatch;
            if(lbAge.Text == "P")
            {
                lbDetail.Text = "Phố biến dành cho mọi lứa tuổi";
            }
            else if(lbAge.Text == "K")
            {
                lbDetail.Text = "Cho phép người dưới 13 tuổi xem nhưng phải đi \n" +
                    "cùng với người giám hộ";
            }
            else if (lbAge.Text == "T13")
            {
                lbDetail.Text = "Chỉ dành cho khán giả từ 13 tuổi trở lên.";
            }
            else if (lbAge.Text == "T16")
            {
                lbDetail.Text = "Chỉ dành cho khán giả từ 16 tuổi trở lên.";
            }
            else if (lbAge.Text == "T18")
            {
                lbDetail.Text = "Chỉ dành cho khán giả từ 18 tuổi trở lên.";
            }

            lbCinema.Text = "Rạp: " + this.cinema;
            lbScreening.Text = "Suất chiếu: " + this.time;
            lbSeat.Text = "Ghế: " + this.seat;
            lbTotal.Text = "Tổng: " + this.price + " VNĐ";
        }
        private bool loadDictionary(Dictionary<string, int> movie)
        {
            movie.Add("pic1", 0);
            movie.Add("pic2", 1);
            movie.Add("pic3", 2);
            movie.Add("pic4", 3);
            movie.Add("pic5", 4);
            movie.Add("pic6", 5);
            movie.Add("pic7", 6);
            movie.Add("pic8", 7);
            movie.Add("pic9", 8);
            movie.Add("pic10", 9);
            return true;
        }
        private bool loadFilm(List<Movie> data)
        {
            Movie pic1 = new Movie((Image)resource.GetObject("Tien-ca"),
                                    "THE LITTLE MERMAID",
                                    "NÀNG TIÊN CÁ",
                                    "K");
            Movie pic2 = new Movie((Image)resource.GetObject("Fast-X"),
                                    "FAST X",
                                    "FAST && FURIOUS",
                                    "T16");
            Movie pic3 = new Movie((Image)resource.GetObject("Doraemon-utopia"),
                                   "Doraemon: Nobita’s Sky...",
                                   "Phim Điện Ảnh Doraemon: Nobita và Vùng Đất Lý Tưởng...",
                                   "P");
            Movie pic4 = new Movie((Image)resource.GetObject("Lat-mat-6"),
                                    "LẬT MẶT 6:TẤM VÉ ĐỊNH MỆNH",
                                    "",
                                    "T16");
            Movie pic5 = new Movie((Image)resource.GetObject("Khanzab"),
                                    "Khanzab",
                                    "TIẾNG GỌI ÂM BINH",
                                    "T18");
            Movie pic6 = new Movie((Image)resource.GetObject("Creeping"),
                                    "The Creeping",
                                    "OÁN HỒN",
                                    "T18");
            Movie pic7 = new Movie((Image)resource.GetObject("Guardians"),
                                    "Guardians Of The Galaxy Vol.3",
                                    "VỆ BINH DẢI NGÂN HÀ 3",
                                    "T13");
            Movie pic8 = new Movie((Image)resource.GetObject("Con-nhot"),
                                    "CON NHÓT MÓT CHỒNG",
                                    "",
                                    "T16");
            Movie pic9 = new Movie((Image)resource.GetObject("Round-up"),
                                    "Round Up: No Way Out",
                                    "Vây Hãm: Ngoài Vòng Pháp Luật",
                                    "T18");
            Movie pic10 = new Movie((Image)resource.GetObject("Spider-man"),
                                    "Spider-Man: Across The Spider-Verse",
                                    "Người Nhện: Du Hành Vũ Trụ Nhện",
                                    "K");
            data.Add(pic1);
            data.Add(pic2);
            data.Add(pic3);
            data.Add(pic4);
            data.Add(pic5);
            data.Add(pic6);
            data.Add(pic7);
            data.Add(pic8);
            data.Add(pic9);
            data.Add(pic10);
            return true;
        }
        

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            int number;
            if(!int.TryParse(txt5.Text, out number))
            {
                txt5.Text = "";
            }
            /*else
            {
                price -= number*1000;
                lbTotal.Text = "Tổng: " + this.price + " VNĐ";
            }*/

            if(number == 0)
            {
                price = tempPrice;
                lbTotal.Text = "Tổng: " + this.price + " VNĐ";
            }
        }

        int check = 0;
        private async void button12_Click(object sender, EventArgs e)
        {
            if(check != 2)
            {
                if(txtDiscount.Text == "Galaxy10%")
                {
                    price = (price / 10 * 9);
                    lbTotal.Text = "Tổng: " + this.price + " VNĐ";
                    check++;
                }
                else if(txtDiscount.Text == "Galaxy100k")
                {
                    price = price - 100000;
                    lbTotal.Text = "Tổng: " + this.price + " VNĐ";
                    check++;
                }
                else
                {
                    panel2.Visible = true;
                    panel2.BringToFront();
                    await Task.Delay(1000);
                    panel2.Visible = false;
                    panel2.SendToBack();

                }
            }
        }
    }
}
