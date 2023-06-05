using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Galaxy_Cinema
{
    public partial class UCFilm : UserControl
    {
        private string pic { get; set; }
        private string cinema { get; set; }
        private string time { get; set; }

        private ResourceManager resource;
        public UCFilm(string pic)
        {
            InitializeComponent();
            this.pic = pic;
            this.resource = new ResourceManager("Galaxy_Cinema.Properties.Resources", typeof(UCFilm).Assembly);
        }
        private void button_Click(object sender, EventArgs e)
        {
            cinema = comboBox3.Text;
            time = dateTimePicker1.Value.ToString("dddd, dd/M/yyyy");
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            time = btn.Text + " | " + time;
            foreach (Control control in Homepage.Instance.pnlContain.Controls)
            {
                Homepage.Instance.pnlContain.Controls.Remove(control);
            }
            UCBookSeat seat = new UCBookSeat(this.pic, this.cinema, this.time);
            seat.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(seat);
            Homepage.Instance.pnlContain.Controls["UCBookSeat"]?.BringToFront();
        }

        List<Movie> data = new List<Movie>();
        Dictionary<string, int> movie = new Dictionary<string, int>();
        List<System.Windows.Forms.Button> dataScreening = new List<System.Windows.Forms.Button>();

        private void UCFilm_Load(object sender, EventArgs e)
        {

            loadDictionary(this.movie);
            data = loadData();
            dataScreening = loadScreening();

            var film = data.ElementAt(this.movie[this.pic]);
            picPicture.Image = film.Picture;
            lbName.Text = film.Name.ToUpper();
            lbNameVN.Text = film.NameVN;
            lbPoint.Text = film.Point;
            lbAge.Text = film.AgeToWatch;
            lbDuration.Text = film.Duration;
            lbCategories.Text = film.Categories;
            lbActor.Text = film.Actor;
            lbProducer.Text = film.Producer;
            lbDirector.Text = film.Director;
            lbNation.Text = film.Country;
            lbStart.Text = film.StartScreening;
            lbDescription.Text = film.Description;
            lbName.Text = lbName.Text.ToUpper();
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
            movie.Add("pic11", 10);
            movie.Add("pic12", 11);
            movie.Add("pic13", 12);
            movie.Add("pic14", 13);
            movie.Add("pic15", 14);
            movie.Add("pic16", 15);
            movie.Add("pic17", 16);
            movie.Add("pic18", 17);
            movie.Add("pic19", 18);
            movie.Add("pic20", 19);
            movie.Add("pic21", 20);
            movie.Add("pic22", 21);
            movie.Add("pic23", 22);
            movie.Add("pic24", 23);
            movie.Add("pic25", 24);
            movie.Add("pic26", 25);
            movie.Add("pic27", 26);
            movie.Add("pic28", 27);
            return true;
        }

        private List<Movie> loadData() 
        {
            List<Movie> data = new List<Movie>();
            Movie pic1 = new Movie((Image) resource.GetObject("inTien-ca"), 
                                    "THE LITTLE MERMAID", 
                                    "Nàng Tiên cá", 
                                    "5.3/10",
                                    "K", 
                                    "135 phút", 
                                    "Thể loại: Tâm lý, Giả Tưởng, Thần Thoại, Phiêu Lưu",
                                    "Diễn viên: Jonah Hauer-King, Javier Bardem, William Moseley, Poppy Drayton,\n Melissa McCarthy, Halle Bailey",
                                    "Nhà sản xuất: Conglomerate Media, Walt Disney Pictures", 
                                    "Đạo diễn: Rob Marshall, Blake Harris",
                                    "Quốc gia: Mỹ", 
                                    "Ngày khởi chiếu: 26/5/2023",
                                    "“Nàng Tiên Cá” là câu chuyện được yêu thích về Ariel - một nàng tiên cá trẻ xinh đẹp và mạnh mẽ với khát \n" +
                                    "khao phiêu lưu.Ariel là con gái út của Vua Triton và cũng là người ngang ngạnh nhất, nàng khao khát khám \n" +
                                    "phá về thế giới bên kia đại dương.Trong một lần ghé thăm đất liền, nàng đã phải lòng Hoàng tử Eric bảnh \n" +
                                    "bao.Trong khi tiên cá bị cấm tiếp xúc với con người, Ariel đã làm theo trái tim mình.Nàng đã thỏa thuận \n" +
                                    "với phù thủy biển Ursula hung ác để cơ hội sống cuộc sống trên đất liền.Nhưng cuối cùng việc này lại đe \n" +
                                    "dọa tới mạng sống của Ariel và vương miện của cha nàng. \n\n" +
                                    "Phim mới The Little Mermaid khởi chiếu 21.04.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic2 = new Movie((Image)resource.GetObject("inFast-X"),
                                    "FAST X",
                                    "Fast && Furious",
                                    "8.8/10",
                                    "T16",
                                    "141 phút",
                                    "Thể loại:  Hành Động, Tội Phạm",
                                    "Diễn viên:  Helen Mirren, Scott Eastwood, Vin Diesel, Mayte Michelle Rodríguez,\n Jason Momoa, Charlize Theron, Brie Larson , Jason Statham",
                                    "Nhà sản xuất:  Universal Pictures",
                                    "Đạo diễn:  Louis Leterrier",
                                    "Quốc gia:  Mỹ",
                                    "Ngày khởi chiếu: 19/5/2023",
                                    "Trong Fast Five (2011), Dom và nhóm của anh đã tiêu diệt trùm ma túy người Brazil Hernan Reyes ở Rio De \n" +
                                    "Janeiro. Điều họ không biết là con trai của Reyes, Dante đã chứng kiến tất cả và dành 12 năm qua để lên một \n" +
                                    "kế hoạch “hoàn hảo” sẽ khiến gia đình Dom phải trả giá đắt.  \n\n" +
                                    "Trải qua nhiều nhiệm vụ khó khăn tưởng chừng như bất khả thi nhưng Dom Toretto và gia đình của anh ấy đều \n" +
                                    "đã vượt qua. Họ đánh bại mọi kẻ thù trên hành trình hơn 20 năm qua. Nhưng giờ đây, Dante được đánh giá là \n" +
                                    "kẻ nguy hiểm nhất mà họ sẽ đối mặt: một mối đe dọa đáng sợ xuất hiện từ bóng tối của quá khứ, một kẻ thù \n" +
                                    "đẫm máu, với quyết tâm phá tan gia đình và phá hủy mọi thứ mà Dom yêu thương mãi mãi. \n\n" +
                                    "Phim mới Fast & Furious 10 ra mắt tại các rạp chiếu phim từ 19.05.2023.");
            Movie pic3 = new Movie((Image)resource.GetObject("inDoraemon-utopia"),
                                    "DORAEMON: NOBITA's SKY UTOPIA 2023",
                                    "Phim Điện Ảnh Doraemon: Nobita và Vùng Đất Lý Tưởng Trên Bầu Trời",
                                    "9.1/10",
                                    "P",
                                    "108 phút",
                                    "Thể loại: Hoạt Hình",
                                    "Diễn viên: Mizuta Wasabi, Megumi Oohara",
                                    "Nhà sản xuất: Shin-Ei Animation",
                                    "Đạo diễn: Douyama Takumi",
                                    "Quốc gia: Nhật Bản",
                                    "Ngày khởi chiếu: 19/5/2023",
                                    "Doraemon: Nobita’s Sky Utopia 2023 kể về chuyến phiêu lưu của Doraemon, Nobita và những người bạn \n" +
                                    "thân tới Paradapia - một hòn đảo hình trăng lưỡi liềm lơ lửng trên bầu trời. Ở nơi đó, tất cả đều \n" +
                                    "hoàn hảo… đến mức cậu nhóc Nobita mê ngủ ngày cũng có thể trở thành một thần đồng toán học, một \n" +
                                    "siêu sao thể thao. \n\n" +
                                    "Cả hội Doraemon cùng sử dụng một món bảo bối độc đáo chưa từng xuất hiện trước đây để đến với vương \n" +
                                    "quốc tuyệt vời này.Cùng với những người bạn ở đây, đặc biệt là chàng robot mèo Sonya, nhóm Doraemon \n" +
                                    "đã có chuyến hành trình tới vương quốc trên mây tuyệt vời… cho đến khi những bí mật đằng sau vùng đất \n" +
                                    "lý tưởng này được hé lộ. \n\n" +
                                    "Phim Điện Ảnh Doraemon: Nobita và Vùng Đất Lý Tưởng Trên Bầu Trời ra mắt tại các rạp chiếu phim từ \n" +
                                    "26.05.2023");
            Movie pic4 = new Movie((Image)resource.GetObject("inLat-mat-6"),
                                    "LẬT MẶT 6:TẤM VÉ ĐỊNH MỆNH",
                                    "",
                                    "9.1/10",
                                    "T16",
                                    "132 phút",
                                    "Thể loại: Hài, Tình Cảm, Tâm Lý, Hành Động",
                                    "Diễn viên: Hoàng Mèo, Trần Kim Hải, Thanh Thức, Huy Khánh, Quốc Cường, \n" +
                                    "Trung Dũng",
                                    "Nhà sản xuất: Không có",
                                    "Đạo diễn: Lý Hải",
                                    "Quốc gia: Việt Nam",
                                    "Ngày khởi chiếu: 26/4/2023",
                                    "Tấm vé có mệnh giá 10.000 đồng và sở hữu những con số định mệnh: 10, 16, 18, 20, 27, 28 - ngày sinh \n" +
                                    "của hội bạn thân sáu người do Trung Dũng, Quốc Cường, Thanh Thức, Huy Khánh, Hoàng Mèo, Trần Kim Hải \n" +
                                    "đảm nhận. Tuy nhiên, nhân vật do Thanh Thức thủ vai, cũng là người giữ tấm vé trúng giải độc đắc lại \n" +
                                    "không may bị tai nạn và qua đời, từ đây, những người còn lại phải dùng đủ mọi cách để tìm lại tấm vé \n" +
                                    "đổi đời. Liệu nhóm bạn có thành công và giải mã được cái chết bị ẩn người người bạn thân? Cùng chờ đón \n" +
                                    "đến 28.04 để biết được câu trả lời nha!\n\n" +
                                    "Phim mới Lật Mặt 6: Tấm Vé Định Mệnh ra mắt tại các rạp chiếu phim từ 28.04.2023.");
            Movie pic5 = new Movie((Image)resource.GetObject("inKhanzab"),
                                    "KHANZAB",
                                    "Tiếng gọi âm binh",
                                    "7.8/10",
                                    "T18",
                                    "88 phút",
                                    "Thể loại: Kinh Dị",
                                    "Diễn viên: Yasamin Jasem, Tika Bravani",
                                    "Nhà sản xuất: PT Umbara Brothers Film",
                                    "Đạo diễn: Anggy Umbara",
                                    "Quốc gia: Indonesia",
                                    "Ngày khởi chiếu: 26/5/2023",
                                    "Chuyện phim theo chân Rahayu - cô gái từng chứng kiến cha mình bị giết hại trong vụ thảm sát Banyuwangi \n" +
                                    "năm 1998.Tại đây, những thầy cúng bị nghi ngờ thực hành ma thuật đen sẽ bị người dân giả dạng ninja để \n" +
                                    "sát hại.Sau sự cố này, Rahayu cùng gia đình quyết định rời khỏi Banyuwangi để chuyển đến quê hương của \n" +
                                    "họ ở Jetis, Yogyakarta. \n\n" +
                                    "Phim mới Tiếng Gọi Âm Binh khởi chiếu 26.05.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic6 = new Movie((Image)resource.GetObject("inCreeping"),
                                    "The Creeping",
                                    "Oán hồn",
                                    "6.0/10",
                                    "T18",
                                    "94 phút",
                                    "Thể loại: Kinh Dị, Tâm Lý",
                                    "Diễn viên: Sophie Thompson, Taliyah Blair, Riann Steele",
                                    "Nhà sản xuất: Cryptoscope Films",
                                    "Đạo diễn: Jamie Hooper",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 26/5/2023",
                                    "Trải nghiệm thời thơ ấu đau thương, Anna trở  về căn nhà xưa để chăm sóc người bà ốm yếu. Từ đó, những \n" +
                                    "điều kỳ lạ bắt đầu xảy ra và các sự kiện kỳ quái dần xuất hiện cho đến khi Anna phát hiện ra mọi việc có \n" +
                                    "liên quan đến một quá khứ bi thảm đã ám lên các thành viên trong gia đình.Điều gì sẽ xảy ra với Anna khi \n" +
                                    "mọi oán niệm được ẩn giấu phía sau ngôi nhà và người bà kỳ lạ ? \n\n" +
                                    "Phim mới Oán Hồn khởi chiếu 26.05.2023 tại các rạp chiếu phim toàn quốc.");
            Movie pic7 = new Movie((Image)resource.GetObject("inGuardians"),
                                    "Guardians Of The Galaxy Vol.3",
                                    "Vệ binh giải ngân hà 3",
                                    "9.4/10",
                                    "T13",
                                    "149 phút",
                                    "Thể loại: Hành Động, Phiêu Lưu, Hài",
                                    "Diễn viên: Bradley Cooper, Vin Diesel, Chris Pratt, Karen Gillan, \n" +
                                    "Zoe Saldana, Dave Bautista",
                                    "Nhà sản xuất: Marvel Studios",
                                    "Đạo diễn: James Gunn",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 3/5/2023",
                                    "Cho dù vũ trụ này có bao la đến đâu, các Vệ Binh của chúng ta cũng không thể trốn chạy mãi mãi. \n\n" +
                                    "Phim mới Vệ Binh Dải Ngân Hà 3 ra mắt tại các rạp chiếu phim từ 03.05.2023.");
            Movie pic8 = new Movie((Image)resource.GetObject("inCon-nhot"),
                                    "CON NHÓT MÓT CHỒNG",
                                    "",
                                    "8.6/10",
                                    "T16",
                                    "112 phút",
                                    "Thể loại: Hài, Tâm Lý",
                                    "Diễn viên: Tiến Luật, Thái Hòa, Thu Trang",
                                    "Nhà sản xuất: Galaxy Studio, Thu Trang Entertainment, Galaxy Play",
                                    "Đạo diễn: Vũ Ngọc Đăng",
                                    "Quốc gia: Việt Nam",
                                    "Ngày khởi chiếu: 26/4/2023",
                                    "Lấy cảm hứng từ web drama Chuyện Xóm Tui, phiên bản điện ảnh sẽ mang một màu sắc hoàn toàn khác: \n" +
                                    "hài hước hơn, gần gũi và nhiều cảm xúc hơn.Bộ phim là câu chuyện của Nhót - người phụ nữ chưa kịp \n" +
                                    "già đã sắp bị mãn kinh, vội vàng đi tìm chồng.Nhưng sâu thẳm trong cô là khao khát muốn có một đứa \n" +
                                    "con, và luôn muốn hàn gắn với người cha suốt ngày say xỉn của mình. \n\n" +
                                    "Phim mới Con Nhót Mót Chồng ra mắt tại các rạp chiếu phim từ 28.04.2023.");
            Movie pic9 = new Movie((Image)resource.GetObject("inRound-up"),
                                    "Round Up: No Way Out",
                                    "Vây Hãm: Ngoài Vòng Pháp Luật",
                                    "8.3/10",
                                    "T18",
                                    "105 phút",
                                    "Thể loại: Tội Phạm, Hành Động",
                                    "Diễn viên: Munetake Aoki, Ma Dong Seok, Lee Joon Hyuk",
                                    "Nhà sản xuất: BA Entertainment",
                                    "Đạo diễn: Lee Sang Young",
                                    "Quốc gia: Hàn Quốc",
                                    "khởi chiếu: 31/5/2023",
                                    "Quái vật cơ bắp Seok-do (Ma Dong Seok) dẫn đầu đội hình sự truy lùng đường dây buôn chất cấm của \n" +
                                    "thiếu gia Joo Seong Cheol. Cuộc truy đuổi càng thêm gay cấn khi cú đấm công lý \"chú Ma\" chạm \n" +
                                    "trán thanh kiếm lừng lẫy chốn giang hồ Nhật Bản.  \n\n" +
                                    "Phim mới Vây Hãm: Ngoài Vòng Pháp Luật khởi chiếu 02.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic10 = new Movie((Image)resource.GetObject("inSpider-man"),
                                    "Spider-Man: Across The Spider-Verse",
                                    "Người Nhện: Du Hành Vũ Trụ Nhện",
                                    "8.8/10",
                                    "K",
                                    "140 phút",
                                    "Thể loại: Hoạt Hình, Giả Tưởng",
                                    "Diễn viên: Oscar Isaac, Shameik Moore, Hailee Steinfeld, Jake Johnson",
                                    "Nhà sản xuất: Columbia Pictures, Marvel Studios, Sony Pictures",
                                    "Đạo diễn: Justin K. Thompson, Kemp Powers, Joaquim Dos Santos",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 1/6/2023",
                                    "Miles Morales tái xuất trong phần tiếp theo của bom tấn hoạt hình từng đoạt giải Oscar - Spider-Man: \n" +
                                    "Across the Spider-Verse. Sau khi gặp lại Gwen Stacy, chàng Spider-Man thân thiện đến từ Brooklyn phải \n" +
                                    "du hành qua đa vũ trụ và gặp một nhóm Người Nhện chịu trách nhiệm bảo vệ các thế giới song song. \n" +
                                    "Nhưng khi nhóm siêu anh hùng xung đột về cách xử lý một mối đe dọa mới, Miles buộc phải đọ sức với \n" +
                                    "các Người Nhện khác và phải xác định lại ý nghĩa của việc trở thành một người hùng để có thể cứu \n" +
                                    "những người cậu yêu thương nhất. \n\n" +
                                    "Phim mới Người Nhện: Du Hành Vũ Trụ Nhện dự kiến khởi chiếu 01.06.2023 tại các rạp chiếu phim toàn quốc.");
            Movie pic11 = new Movie((Image)resource.GetObject("inThe-Boogeyman"),
                                    "The Boogeyman",
                                    "Ông Kẹ",
                                    "6.6/10",
                                    "T16",
                                    "98 phút",
                                    "Thể loại: Kinh Dị",
                                    "Diễn viên: David Dastmalchian, Chris Messina, Sophie Thatcher",
                                    "Nhà sản xuất: 20th Century Studios",
                                    "Đạo diễn: Rob Savage",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 2/6/2023",
                                    "Ông Kẹ kể về câu chuyện của gia đình Harper khi một thực thể siêu nhiên bám theo và liên tục phá rối \n" +
                                    "gia đình họ. Khi mà con quái vật này lấp ló trong bóng tối và chực chờ làm hại cô bé Sawyer như chực \n" +
                                    "chờ một con mồi, chị gái Sadie và bố Will sẽ phải hành động để ngăn chặn điều này trước khi quá muộn. \n\n" +
                                    "Phim mới Ông Kẹ khởi chiếu 02.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic12 = new Movie((Image)resource.GetObject("inHoon-Payon"),
                                    "Hoon Payon",
                                    "Hoon Payon: Bùa Hình Nhân",
                                    "9.1/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Kinh Dị",
                                    "Diễn viên: Phuwin Tangsakyuen, Amy Thasorn Klinnium",
                                    "Nhà sản xuất: Noori Pictures",
                                    "Đạo diễn: Phontharis Chotkijsadarsopon",
                                    "Quốc gia: Thái Lan",
                                    "Ngày khởi chiếu: 2/6/2023",
                                    "Phim được lấy cảm hứng từ loại bùa hình nhân hộ mệnh có thật ở Thái Lan tên Hoon Payon, phim theo chân \n" +
                                    "Tham trong hành trình đến một hòn đảo hẻo lánh để tìm người anh trai của mình đang tu hành ở đó. Tham \n" +
                                    "phát hiện ra anh trai đã bị sát hại sau khi bị buộc tội giết người và trộm cắp. Quyết tâm ở lại hòn đảo \n" +
                                    "để điều tra cũng như minh oan cho anh trai nhưng Tham lại vô tình khám phá ra nhiều cái chết bí ẩn khác \n" +
                                    "tại ngôi làng bên cạnh. \n\n" +
                                    "Phim mới Hoon Payon: Bùa Hình Nhân khởi chiếu 02.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic13 = new Movie((Image)resource.GetObject("inTransformers"),
                                    "Transformers: Rise Of The Beasts",
                                    "Transformers: Quái Thú Trỗi Dậy",
                                    "8.7/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Giả Tưởng, Hành Động",
                                    "Diễn viên: Ron Perlman, Dominique Fishback, Dương Tử Quỳnh",
                                    "Nhà sản xuất: Paramount Pictures",
                                    "Đạo diễn: Steven Caple Jr.",
                                    "Quốc gia  Mỹ",
                                    "Ngày khởi chiếu: 9/6/2023",
                                    "Transfromers: Rise Of The Beasts lấy bối cảnh vào năm 1994, khoảng thời gian tiếp sau khi Bumblebee \n" +
                                    "xuất hiện. Như tựa đề đã thể hiện, phần phim này dựa theo bộ truyện Beast Wars cực kỳ ăn khách vào thập \n" +
                                    "niên 1990. Đây cũng là lần đầu tiên, một nhóm robot mới xuất hiện, có khả năng biến mình thành động vật \n" +
                                    "thay vì ôtô như trước đó. \n\n" +
                                    "Phim mới Transformers: Quái Thú Trỗi Dậy dự kiến khởi chiếu 09.06.2023 tại các rạp chiếu phim toàn quốc.");
            Movie pic14 = new Movie((Image)resource.GetObject("inFlash"),
                                    "Flash",
                                    "The Flash",
                                    "8.8/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Giả Tưởng, Hành Động",
                                    "Diễn viên: Ben Affleck, Ezra Miller",
                                    "Nhà sản xuất: Warner Bros",
                                    "Đạo diễn: James Gunn",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 16/6/2023",
                                    "Câu chuyện của Flash bắt đầu khi Barry Allen (Ezra Miller thủ vai) sử dụng siêu năng lực của mình để du \n" +
                                    "hành thời gian nhằm thay đổi những sự kiện trong quá khứ. Nhưng khi nỗ lực cứu lấy gia đình mình vô tình \n" +
                                    "thay đổi tương lai, Barry bị kẹt lại trong một thực tại, nơi tướng Zod tái xuất và đe dọa hủy diệt tất cả, \n" +
                                    "nhưng không có bất cứ siêu anh hùng nào đứng ra giải cứu… Trừ khi Barry có thể thuyết phục một Batman rất \n" +
                                    "khác và giải cứu một cư dân Kryptonian đang bị cầm tù… dẫu có thể đó không phải người mà anh thực sự tìm \n" +
                                    "kiếm. Để giải cứu thế giới hiện tại cũng như trở lại tương lai mình từng biết, niềm hy vọng duy nhất của \n" +
                                    "Barry là phải chạy đua vì cuộc đời mình. Vậy nhưng, sự hy sinh tuyệt đối đó có là đủ để đưa thế giới về lại \n" +
                                    "như ban đầu? \n\n" +
                                    "Phim mới The Flash ra mắt tại các rạp chiếu phim từ 06.2023.");
            Movie pic15 = new Movie((Image)resource.GetObject("inElemental"),
                                    "Elemental",
                                    "Xứ Sở Các Nguyên Tố",
                                    "8.6/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Phiêu Lưu, Hài, Hoạt Hình",
                                    "Diễn viên: Mamoudou Athie, Leah Lewis, Wendi McLendon-Covey",
                                    "Nhà sản xuất: Walt Disney Pictures, PIXAR",
                                    "Đạo diễn: Peter Sohn",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 16/6/2023",
                                    "Bộ phim sẽ là hành trình xoay quanh mối quan hệ giữa cô nàng guyên tố lửa, Ember (do Lewis lồng tiếng) \n" +
                                    "và chàng trai nguyên tố nước, Wade (do Athie lồng tiếng), những cá thể không thể chạm được đến nhau; \n" +
                                    "nhưng cùng nhau khám phá xem họ có bao nhiêu điểm chung giống nhau. \n\n" +
                                    "Phim mới Xứ Sở Các Nguyên Tố dự kiến khởi chiếu 16.06.2023 tại các rạp chiếu phim toàn quốc.");
            Movie pic16 = new Movie((Image)resource.GetObject("inJ-hope"),
                                    "j-hope IN THE BOX",
                                    "BTS: Hành Trình Solo - J-Hope In The Box",
                                    "9.3/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Tài Liệu",
                                    "Diễn viên: J-Hope",
                                    "Nhà sản xuất: Disney Media Distribution (DMD)",
                                    "Đạo diễn: Park Jun Soo",
                                    "Quốc gia: Hàn Quốc",
                                    "Ngày khởi chiếu: 17/6/2023",
                                    "Để chào mừng BTS FESTA 2023, bộ phim tài liệu solo J-Hope IN THE BOX sẽ được chiếu tại các rạp chiếu phim \n" +
                                    "trên toàn thế giới với suất chiếu giới hạn. \n\n" +
                                    "I'm your HOPE. You're my HOPE. I'm J-Hope. \n\n" +
                                    "J-Hope là nghệ sĩ Hàn Quốc đầu tiên biểu diễn trên sân khấu chính của lễ hội âm nhạc lớn nhất thế giới \n" +
                                    "Lollapalooza ở Chicago. Jung Hoseok thuở nhỏ giờ được biết đến với nghệ danh J-Hope, là dancer kiêm rapper \n" +
                                    "của nhóm nhạc nổi tiếng thế giới BTS. Sau thành công vang dội của Dynamite và Butter, anh ấy bắt đầu thực \n" +
                                    "hiện album solo chính thức đầu tiên của mình. \n\n" +
                                    "J-Hope In The Box là bộ phim ghi lại cuộc sống 200 ngày của Hobi, từ quá trình sản xuất \"Jack In The Box\" \n" +
                                    "đến quá trình chuẩn bị và xuất hiện trên sân khấu \"Lollapalooza\". Giữa những lo lắng và băn khoăn, J-Hope \n" +
                                    "đã có một bước nhảy vọt, chuẩn bị bước ra khỏi chiếc hộp và chào đón thế giới.  \n\n" +
                                    "Phim mới BTS: Hành Trình Solo - J-Hope IN THE BOX khởi chiếu 17.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic17 = new Movie((Image)resource.GetObject("inSuga"),
                                    "SUGA: Road To D-Day",
                                    "BTS: Hành Trình Solo - SUGA: Road To D-Day",
                                    "9.3/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Tài Liệu",
                                    "Diễn viên: Suga",
                                    "Nhà sản xuất: Disney Media Distribution (DMD)",
                                    "Đạo diễn: Park Jun Soo",
                                    "Quốc gia: Hàn Quốc",
                                    "Ngày khởi chiếu: 17/6/2023",
                                    "Để chào mừng BTS FESTA 2023, bộ phim tài liệu SUGA: Road To D-Day sẽ có mặt tại các rạp chiếu phim trên \n" +
                                    "toàn thế giới với suất chiếu giới hạn. \n\n" +
                                    "Min Yoongi, người có rất nhiều hoài bão và ước mơ, đã trở thành nghệ sĩ nổi tiếng thế giới - SUGA của \n" +
                                    "BTS - ở tuổi hai mươi tám. Cùng với sự chăm chỉ và thành công rực rỡ của mình, SUGA đã thực hiện một album \n" +
                                    "solo với tên Agust D, bắt đầu hành trình khám phá những câu chuyện mới. Từ Las Vegas, Malibu, San Francisco \n" +
                                    "và Tokyo, đến Chuncheon,Pyeongchang và Seoul, SUGA lên đường tìm lại ước mơ của mình một lần nữa. \n\n" +
                                    "Phim mới BTS: Hành Trình Solo - SUGA: Road To D-Day khởi chiếu 17.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic18 = new Movie((Image)resource.GetObject("inNo-hard"),
                                    "No Hard Feelings",
                                    "Vú Em Dạy “Yêu”",
                                    "6.3/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Hài",
                                    "Diễn viên: Ebon Moss-Bachrach, Natalie Morales, Jennifer Lawrence",
                                    "Nhà sản xuất: Sony Pictures",
                                    "Đạo diễn: Genedy Tartakovsky",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 23/6/2023",
                                    "Trong phim, Jennifer Lawrence thủ vai một cô gái lẳng lơ, sống này đây mai đó với đủ loại công việc. \n" +
                                    "Cho tới một ngày, một cặp vợ chồng trung niên tìm tới và thuê cô quyến rũ cậu con trai 19 tuổi của mình. \n" +
                                    "Thế là hành trình của bà cô U40 đi cò cưa trai trẻ bắt đầu, đầy khó khăn với biết bao tình huống khó \n" +
                                    "đỡ, éo le.\n\n" +
                                    "Phim mới Vú Em Dạy “Yêu” ra mắt tại các rạp chiếu phim từ 23.06.2023.");
            Movie pic19 = new Movie((Image)resource.GetObject("inThe-childe"),
                                    "The Childe",
                                    "Quý Công Tử",
                                    "10.0/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Hành Động, Tâm Lý",
                                    "Diễn viên: Kim Seon Ho, Kang Tae Ju, Go Ara",
                                    "Nhà sản xuất: Goldmoon Film",
                                    "Đạo diễn: Park Hoon Jung",
                                    "Quốc gia: Hàn Quốc",
                                    "Ngày khởi chiếu: 23/6/2023",
                                    "Quý Công Tử xoay quanh người đàn ông bí ẩn được biết đến với tên gọi “Quý Công Tử”. Gã đột nhiên xuất \n" +
                                    "hiện trước mắt Marco, một thanh niên người Philippines mơ ước trở thành vận động viên boxing chuyên \n" +
                                    "nghiệp, lang thang khắp các sàn đấu bất hợp pháp tại đây. Nhằm chi trả cho viện phí của mẹ, Marco \n" +
                                    "đến Hàn Quốc để tìm người cha đã bỏ rơi hai mẹ con cậu từ lâu. Đụng độ Quý Công Tử cùng hàng loạt \n" +
                                    "những con người bí hiểm trong thế giới ngầm, Marco trở thành mục tiêu duy nhất của những thế lực \n" +
                                    "mang nhiều mục đích khác nhau. Cuộc truy sát điên cuồng đã bắt đầu.\n\n" +
                                    "Phim mới Quý Công Tử khởi chiếu 23.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic20 = new Movie((Image)resource.GetObject("inIndiana-Jones"),
                                    "Indiana Jones And The Dial Of Destiny",
                                    "Indiana Jones Và Vòng Quay Định Mệnh",
                                    "7.5/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Hành Động, Phiêu Lưu",
                                    "Diễn viên: Antonio Banderas, Harrison Ford, Mads Mikkelseny",
                                    "Nhà sản xuất: Lucasfilm",
                                    "Đạo diễn: James Mangold",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 30/6/2023",
                                    "Trong chuyến phiêu lưu cuối cùng này, Indiana Jones cùng con gái nuôi Helena sẽ phải đối đầu với những \n" +
                                    "tên phát xít hiểm ác. Indiana Jones 5 cũng sẽ là phần phim cuối cùng mà Harrison Ford hóa thân thành \n" +
                                    "nhà khảo cổ học Indiana Jones - vai diễn làm nên tên tuổi và gắn liền với ông trong suốt hơn 40 năm.\n\n" +
                                    "Phim mới Indiana Jones Và Vòng Quay Định Mệnh dự kiến khởi chiếu 30.06.2023 tại các rạp chiếu phim \n" +
                                    "toàn quốc.");
            Movie pic21 = new Movie((Image)resource.GetObject("inRuby-Gillman"),
                                    "Ruby Gillman, Teenage Kraken",
                                    "Ruby Thủy Quái Tuổi Teen",
                                    "7.0/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Hành Động, Phiêu Lưu, Hoạt Hình",
                                    "Diễn viên: Toni Collette, Sam Richardson, Jane Fonda",
                                    "Nhà sản xuất: Universal Pictures, DreamWorks Animation",
                                    "Đạo diễn: Faryn Pearl, Kirk DeMicco",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 30/6/2023",
                                    "Ruby Thủy Quái Tuổi Teen là một bộ phim hài hành động, xoay quanh cô bé Ruby Gillman 16 tuổi, ngọt \n" +
                                    "ngào và vụng về. Cô bé luôn muốn hòa nhập với bạn bè tại trường học Oceanside, nhưng lại quá nhút \n" +
                                    "nhát để có thể chủ động gặp gỡ và làm quen kết bạn với nhiều người. Thậm chí, cô bé còn bị ngăn cản \n" +
                                    "đi chơi với những đứa trẻ ở bãi biển vì người mẹ bảo vệ quá mức cấm Ruby xuống nước. Nhưng ở độ tuổi \n" +
                                    "này, càng cấm cô bé càng muốn làm. Trong một lần cô bé phá vỡ quy tắc, thử nhảy xuống biển, Ruby đã \n" +
                                    "phát hiện ra những thay đổi kỳ lạ của bản thân. Không chỉ thở được bình thường dưới nước, tứ chi cũng \n" +
                                    "biến thành những xúc tu khổng lồ và còn phát sáng. Ruby còn gặp được người bà - một chỉ huy đại tài ở \n" +
                                    "dưới đại dương sâu thẳm. Bà chính là người tiết lộ cho Ruby về thân thế hậu duệ của hoàng tộc giới \n" +
                                    "Kraken - những chiến binh bảo vệ đại dương, và còn giới thiệu cô bé chính là công chúa trước rất nhiều \n" +
                                    "thần dân Kraken.\n\n" +
                                    "Một Ruby nhút nhát đáng thương bất ngờ đối mặt với một cuộc đời mới, một trọng trách mới, cao cả hơn \n" +
                                    "rất nhiều, đã khiến cô bé phát hoảng. Cố gắng tự huyễn hoặc bản thân quay trở về cuộc sống học đường \n" +
                                    "như cũ, nhưng thủy quái Kraken bên trong Ruby lại không hề muốn vậy. Đặc biệt là khi bước vào tầm ngắm \n" +
                                    "của cô hotgirl “xéo sắc” của trường, vốn là một nàng tiên cá xấu xa, kẻ thù truyền kiếp với Kraken. Và \n" +
                                    "từ đây cô bé cần phải cố gắng hết sức, làm quen với một bản thân hoàn toàn mới. Những buổi huấn luyện \n" +
                                    "khó nhằn liên tiếp diễn ra, một cuộc chiến nhiều hiểm nguy cũng đang đợi Ruby ở phía trước. \n\n" +
                                    "Phim mới Ruby Thủy Quái Tuổi Teen khởi chiếu 30.06.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic22 = new Movie((Image)resource.GetObject("inInsidious"),
                                    "Insidious: The Red Door",
                                    "Quỷ Quyệt: Cửa Đỏ Vô Định",
                                    "9.5/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Kinh Dị",
                                    "Diễn viên: Rose Byrne, Ty Simpkins, Patrick Wilson",
                                    "Nhà sản xuất: Sony Pictures Releasing",
                                    "Đạo diễn: Patrick Wilson",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 7/7/2023",
                                    "Quỷ Quyệt 5: Cửa Đỏ Vô Định – Insidious 5: The Red Door lấy bối cảnh sau mười năm kể từ hai phần phim \n" +
                                    "đầu tiên, Josh Lambert (Patrick Wilson) đang chuyển đến sinh sống tại phía Đông để đưa cậu con trai \n" +
                                    "Dalton (Ty Simpkins) đến học tại một trường đại học bình dị, phủ đầy cây thường xuân. Tuy nhiên, giấc \n" +
                                    "mơ đại học của Dalton lại trở lại một ác mộng khi những con quỷ bị kìm hãm trong quá khứ bằng một cách \n" +
                                    "nào đó đã quay trở lại và tiếp tục ám hai cha con.\n\n" +
                                    "Phim mới Quỷ Quyệt: Cửa Đỏ Vô Định khởi chiếu 07.07.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic23 = new Movie((Image)resource.GetObject("inMission"),
                                    "Mission: Impossible Dead Reckoning Part One",
                                    "Nhiệm Vụ: Bất Khả Thi Nghiệp Báo Phần Một",
                                    "9.4/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Phiêu Lưu, Ly Kì, Hành Động",
                                    "Diễn viên: Tom Cruise, Vanessa Kirby, Rebecca Ferguson",
                                    "Nhà sản xuất: Paramount Pictures",
                                    "Đạo diễn: Christopher McQuarrie",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 14/7/2023",
                                    "Trailer chỉ vỏn vẹn hơn 2 phút nhưng đã mở ra một cuộc chiến không kém phần kịch tính so với các mùa \n" +
                                    "trước, từ sa mạc, xa lộ đến cuộc chiến trên không hay trong tầng hầm tăm tối. Những pha rượt đuổi gay \n" +
                                    "cấn đến nghẹt thở của đặc vụ Ethan Hunt hứa hẹn sẽ bùng nổ rạp chiếu phim sắp tới.\n\n" +
                                    "Phim mới Nhiệm Vụ: Bất Khả Thi Nghiệp Báo Phần Một khởi chiếu 14.07.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic24 = new Movie((Image)resource.GetObject("inBarbie"),
                                    "Barbie",
                                    "",
                                    "8.4/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Giả Tưởng, Phiêu Lưu, Hài",
                                    "Diễn viên: Simu Liu, Emma Mackey, Ryan Gosling, Margot Robbiee",
                                    "Nhà sản xuất: Warner Bros",
                                    "Đạo diễn: Greta Gerwig",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 21/7/2023",
                                    "Nàng Barbie là phim điện ảnh thuộc thể loại hài lãng mạn. Bộ phim do Greta Gerwig làm đạo diễn kiêm \n" +
                                    "viết kịch bản với Noah Baumbach. Đây là tác phẩm điện ảnh đầu tiên về búp bê Barbie do người thật \n" +
                                    "đóng, với sự kết hợp bởi nữ diên viên Margot Robbie và nam thần Ryan Gosling hóa thân thành 2 nhân \n" +
                                    "vật chính Barbie và Ken.\n\n" +
                                    "Phim mới Barbie dự kiến khởi chiếu 21.07.2023 tại các rạp chiếu phim toàn quốc.");
            Movie pic25 = new Movie((Image)resource.GetObject("inDetective-conan"),
                                    "Detective Conan: Black Iron Submarine",
                                    "Thám Tử Lừng Danh Conan: Tàu Ngầm Sắt Màu Đen.",
                                    "9.7/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Hoạt Hình",
                                    "Diễn viên: Yamazaki Wakana, Hayashibara Megumi, Takayama Minami",
                                    "Nhà sản xuất: Toho Company, Ltd.",
                                    "Đạo diễn: Tachikawa Yuzuru",
                                    "Quốc gia: Nhật Bản",
                                    "Ngày khởi chiếu: 21/7/2023",
                                    "Thám Tử Lừng Danh Conan: Tàu Ngầm Sắt Màu Đen là phần phim đang đạt doanh thu ấn tượng của loạt phim \n" +
                                    "về cậu bé thám tử. \n" +
                                    "Lấy bối cảnh tại Pacific Buoy - một trụ sở hàng hải của Interpol có nhiệm vụ kết nối các camera an \n" +
                                    "ninh trên toàn thế giới. Theo lời mời của Sonoko, nhóm Conan đến Hachijojima để xem cá voi. Tại đây, \n" +
                                    "Conan nhận được thông tin về một nhân viên Europol bị ám sát. Cùng với đó, tính mạng Haibara bị đe \n" +
                                    "dọa, phải chăng thân phận của cô đã bị bại lộ trước Gin - nhân vật nguy hiểm hàng đầu của tổ chức áo \n" +
                                    "đen…  \n\n" +
                                    "Tàu Ngầm Sắt Màu Đen đang đứng đầu doanh thu phòng vé tại Nhật Bản, phá vỡ hàng loạt kỉ lục của những \n" +
                                    "người anh em trước. Phim đạt doanh thu hơn 3 tỷ yên chỉ trong cuối tuần mở màn đầu tiên.\n\n" +
                                    "Phim mới Thám Tử Lừng Danh Conan: Tàu Ngầm Sắt Màu Đen ra mắt tại các rạp chiếu phim từ 21.07.2023");
            Movie pic26 = new Movie((Image)resource.GetObject("inOppenheimer"),
                                    "OPPENHEIMER",
                                    "Oppenheimer",
                                    "8.9/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Tiểu Sử, Lịch Sử, Tâm Lý",
                                    "Diễn viên: Matt Damon, Robert Downey Jr., Cillian Murphy, Emily Blunt, \n" +
                                    "Rami Malek, Florence Pugh",
                                    "Nhà sản xuất:Universal Pictures",
                                    "Đạo diễn: Christopher Nolan",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 21/7/2023",
                                    "Câu chuyện kể về nhà khoa học người Mỹ J. Robert Oppenheimer và vai trò của ông trong việc phát triển \n" +
                                    "bom nguyên tử.\n\n" +
                                    "Phim mới Oppenheimer khởi chiếu 21.07.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic27 = new Movie((Image)resource.GetObject("inMeg-2"),
                                    "Meg 2: The Trench",
                                    "Cá Mập Siêu Bạo Chúa 2: Vực Sâu",
                                    "8.9/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Kinh Dị, Giả Tưởng",
                                    "Diễn viên: Sienna Guillory, Jason Statham, Ngô Kinh",
                                    "Nhà sản xuất: Warner Brosh",
                                    "Đạo diễn: Ben Wheatley",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 4/8/2023",
                                    "Tiếp tục nhiệm vụ đã được đề cập trong phần phim trước, nhóm của Jonas Taylor (Jason Statham thủ vai) \n" +
                                    "tiếp cận gần khu vực Rãnh Mariana, nơi họ đụng độ một quái vật bí ẩn, khiến một thành viên trong nhóm \n" +
                                    "thiệt mạng ngay sau đó. Cái chết của người đồng đội báo hiệu cho cả nhóm về một mối đe dọa to lớn đang \n" +
                                    "giấu mình trong những vách đá tối tăm. Thế nhưng, trong cả những viễn cảnh hoang đường nhất, họ cũng \n" +
                                    "không thể ngờ những mối nguy đang chực chờ đe dọa họ có thể tàn ác đến mức nào.\n\n" +
                                    "Phim mới Cá Mập Siêu Bạo Chúa 2: Vực Sâu dự kiến khởi chiếu 04.08.2023 tại rạp chiếu phim toàn quốc.");
            Movie pic28 = new Movie((Image)resource.GetObject("inGran-turismo"),
                                    "Gran Turismo",
                                    "Gran Turismo: Tay Đua Cự Phách",
                                    "7.0/10",
                                    "",
                                    "0 phút",
                                    "Thể loại: Hành Động, Tiểu Sử",
                                    "Diễn viên: Archie Madekwe, Orlando Bloom, David Harbour",
                                    "Nhà sản xuất: Columbia Pictures, PlayStation Productions",
                                    "Đạo diễn: Neill Blomkamp",
                                    "Quốc gia: Mỹ",
                                    "Ngày khởi chiếu: 11/8/2023",
                                    "Nội dung bộ phim dựa trên câu chuyện có thật về Jann Mardenborough, một tay đua nổi tiếng tới từ Anh \n" +
                                    "quốc. Vào năm 2011, anh đã đánh bại 90.000 đối thủ để trở thành nhà vô địch thứ ba, đồng thời là nhà \n" +
                                    "vô địch trẻ tuổi nhất trong  giải đấu GT Academy. Phần thưởng của Jann là cơ hội được đại diện cho \n" +
                                    "Nissan tại giải đua Dubai 24-Hour.\n\n" +
                                    "Phim mới Gran Turismo: Tay Đua Cự Phách khởi chiếu 11.08.2023 tại rạp chiếu phim toàn quốc.");
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
            data.Add(pic11);
            data.Add(pic12);
            data.Add(pic13);
            data.Add(pic14);
            data.Add(pic15);
            data.Add(pic16);
            data.Add(pic17);
            data.Add(pic18);
            data.Add(pic19);
            data.Add(pic20);
            data.Add(pic21);
            data.Add(pic22);
            data.Add(pic23);
            data.Add(pic24);
            data.Add(pic25);
            data.Add(pic26);
            data.Add(pic27);
            data.Add(pic28);
            return data;
        }

        private List<System.Windows.Forms.Button> loadScreening()
        {
            List<System.Windows.Forms.Button> dataScreening = new List<System.Windows.Forms.Button>();
            dataScreening.Add(button1);
            dataScreening.Add(button2);
            dataScreening.Add(button3);
            dataScreening.Add(button4);
            dataScreening.Add(button5);
            dataScreening.Add(button6);
            dataScreening.Add(button7);
            dataScreening.Add(button8);
            dataScreening.Add(button9);
            dataScreening.Add(button10);
            dataScreening.Add(button11);
            dataScreening.Add(button12);
            dataScreening.Add(button13);
            dataScreening.Add(button14);
            dataScreening.Add(button15);
            dataScreening.Add(button16);
            dataScreening.Add(button17);
            dataScreening.Add(button18);
            dataScreening.Add(button19);
            return dataScreening;
        }
        private Dictionary<string, string> loadScreeningWithCinema()
        {
            Dictionary<string, string> listCinema = new Dictionary<string, string>();
            string arr1 = "0110111100100000111";
            string arr2 = "0110100100111000101";
            string arr3 = "0100010110110110001";
            string arr4 = "0101101000000010000";
            string arr5 = "1000111010100101011";
            string arr6 = "0001111001011011000";
            string arr7 = "1110110100110011100";
            string arr8 = "0001111011001010000";
            string arr9 = "1010111110001100101";
            string arr10 = "0010111100100010000";
            string arr11 = "0101100101100001011";
            string arr12 = "1001010111011000010";
            string arr13 = "1010100110110100000";
            string arr14 = "1101110001101001001";
            string arr15 = "0101101100100000111";
            string arr16 = "0110110100111000101";
            string arr17 = "0101110110110110001";
            string arr18 = "0101111111000010000";
            listCinema.Add("Galaxy Nguyễn Du", arr1);
            listCinema.Add("Galaxy Tân Bình", arr2);
            listCinema.Add("Galaxy Kinh Dương Vương", arr3);
            listCinema.Add("Galaxy Quang Trung", arr4);
            listCinema.Add("Galaxy Trung Chánh", arr5);
            listCinema.Add("Galaxy Phạm Văn Chí", arr6);
            listCinema.Add("Galaxy Huỳnh Tấn Phát", arr7);
            listCinema.Add("Galaxy Nguyễn Văn Quá", arr8);
            listCinema.Add("Galaxy Linh Trung Thủ Đức", arr9);
            listCinema.Add("Galaxy MIPEC Long Biên", arr10);
            listCinema.Add("Galaxy Tràng Thi", arr11);
            listCinema.Add("Galaxy Bến Tre", arr12);
            listCinema.Add("Galaxy Đà Nẵng", arr13);
            listCinema.Add("Galaxy Cà Mau", arr14);
            listCinema.Add("Galaxy Vinh", arr15);
            listCinema.Add("Galaxy Hải Phòng", arr16);
            listCinema.Add("Galaxy Buôn Ma Thuột", arr17);
            listCinema.Add("Galaxy Long Xuyên", arr18);
            return listCinema;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Tp. Hồ Chí Minh")
            {
                string[] items = { "Galaxy Nguyễn Du", "Galaxy Tân Bình", "Galaxy Kinh Dương Vương" , "Galaxy Quang Trung",
                                    "Galaxy Trung Chánh", "Galaxy Phạm Văn Chí", "Galaxy Huỳnh Tấn Phát", "Galaxy Nguyễn Văn Quá",
                                    "Galaxy Linh Trung Thủ Đức"};
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if(comboBox1.Text == "Hà Nội")
            {
                string[] items = { "Galaxy MIPEC Long Biên", "Galaxy Tràng Thi" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if(comboBox1.Text == "Bến Tre")
            {
                string[] items = { "Galaxy Bến Tre" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if (comboBox1.Text == "Đà Nẵng")
            {
                string[] items = { "Galaxy Đà Nẵng" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if (comboBox1.Text == "Cà Mau")
            {
                string[] items = { "Galaxy Cà Mau" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if (comboBox1.Text == "Nghệ An")
            {
                string[] items = { "Galaxy Vinh" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if (comboBox1.Text == "Hải Phòng")
            {
                string[] items = { "Galaxy Hải Phòng" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if (comboBox1.Text == "Đắk Lắk")
            {
                string[] items = { "Galaxy Buôn Ma Thuột" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
            else if (comboBox1.Text == "An Giang")
            {
                string[] items = { "Galaxy Long Xuyên" };
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(items);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string npic = this.pic.Substring(3);
            if(int.Parse(npic) < 11)
                flp1.Visible = true;
            Dictionary<string, string> listScreening = loadScreeningWithCinema();
            string directCinema = listScreening[comboBox3.Text];
            for(int i=0; i<dataScreening.Count; i++)
            {
                if (directCinema[i] == '0')
                {
                    dataScreening.ElementAt(i).Visible = false;
                }
                else
                {
                    dataScreening.ElementAt(i).Visible = true;
                }
            }
        }
    }
}
