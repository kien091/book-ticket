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
    public partial class Homepage : Form
    {
        static Homepage _obj;

        public static Homepage Instance
        {
            get
            {
                if (_obj is null)
                {
                    _obj = new Homepage();
                }
                return _obj;
            }
        }
        public Panel pnlContain
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }
        public Homepage()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            pnlHome.BackColor = Color.FromArgb(244, 209, 0);
            pnlShowing.BackColor = Color.FromArgb(25, 30, 48);
            pnlComing.BackColor = Color.FromArgb(25, 30, 48);
            if (btnShowing.Visible == false)
            {
                btnShowing.Visible = true;
                btnShowing.SendToBack();
                pBShowing.Visible = true;
                pnlShowing.Visible = true;
                btnComing.Visible = true;
                btnComing.SendToBack();
                pBComing.Visible = true;
                pnlComing.Visible = true;
            }
            else
            {
                btnShowing.Visible = false;
                pBShowing.Visible = false;
                pnlShowing.Visible = false;
                btnComing.Visible = false;
                pBComing.Visible = false;
                pnlComing.Visible = false;
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            _obj = this;
            UCLoadFilm loadFilm = new UCLoadFilm();
            loadFilm.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(loadFilm);
            Homepage.Instance.pnlContain.Controls["UCLoadFilm"]?.BringToFront();
        }

        private void btnShowing_Click(object sender, EventArgs e)
        {
            foreach (Control control in Homepage.Instance.pnlContain.Controls)
            {
                Homepage.Instance.pnlContain.Controls.Remove(control);
            }
            UCLoadFilm loadFilm = new UCLoadFilm();
            loadFilm.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(loadFilm);
            Homepage.Instance.pnlContain.Controls["UCLoadFilm"]?.BringToFront();
            pnlShowing.BackColor = Color.FromArgb(244, 209, 0);
            pnlHome.BackColor = Color.FromArgb(25, 30, 48);
            pnlComing.BackColor = Color.FromArgb(25, 30, 48);
        }

        private void btnComing_Click(object sender, EventArgs e)
        {
            foreach (Control control in Homepage.Instance.pnlContain.Controls)
            {
                Homepage.Instance.pnlContain.Controls.Remove(control);
            }
            UCComing coming = new UCComing();
            coming.Dock = DockStyle.Fill;
            Homepage.Instance.pnlContain.Controls.Add(coming);
            Homepage.Instance.pnlContain.Controls["UCComing"]?.BringToFront();
            pnlComing.BackColor = Color.FromArgb(244, 209, 0);
            pnlHome.BackColor = Color.FromArgb(25, 30, 48);
            pnlShowing.BackColor = Color.FromArgb(25, 30, 48);
        }
    }
}
