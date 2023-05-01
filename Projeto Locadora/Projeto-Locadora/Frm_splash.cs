using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Locadora
{
    public partial class Frm_splash : Form
    {
        public Frm_splash()
        {
            InitializeComponent();
        }

        private void Frm_splash_Load(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pgrbar.Value < 100)
            {
                pgrbar.Value = pgrbar.Value + 3;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                Frm_login novo = new Frm_login();
                //Frm_menu novo = new Frm_menu();
                novo.Show();
            }
        }
    }
}
