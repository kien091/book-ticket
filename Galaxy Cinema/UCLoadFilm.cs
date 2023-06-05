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
    public partial class UCLoadFilm : UserControl
    {
        public UCLoadFilm()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox) sender;
            foreach (Control control in Homepage.Instance.pnlContain.Controls)
            {
                Homepage.Instance.pnlContain.Controls.Remove(control);
            }
            UCFilm film = new UCFilm(pic.Name);
            film.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(film);
            Homepage.Instance.pnlContain.Controls["UCFilm"]?.BringToFront();
        }

        private void UCLoadFilm_Load(object sender, EventArgs e)
        {
            panel21.BackColor = Color.FromArgb(244, 209, 0);
            panel22.BackColor = Color.FromArgb(25, 30, 48);
        }
    }
}
