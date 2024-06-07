using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMFruit
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.hover_start;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.hover_exit;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.normal_start;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image= Properties.Resources.normal_exit;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Hide();
            gamestart gameon = new gamestart();
            gameon.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
