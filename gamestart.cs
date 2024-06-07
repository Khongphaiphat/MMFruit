using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMFruit
{
    public partial class gamestart : Form
    {
        Random random = new Random();
        List<Point> points = new List<Point>();
        PictureBox firstclick;
        PictureBox secondclick;
        int count = 0;
        public gamestart()
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {
            timer4.Start();
            button1.Enabled = false;
            label2.Text = "4";
            foreach (PictureBox picture in panel1.Controls)//xác định vị trí của picturebox
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in panel1.Controls)//set random tất cả picturebox
            {
                int randomNumber = random.Next(points.Count);
                Point p = points[randomNumber];
                picture.Location = p;
                points.Remove(p);
            }
            timer2.Start();
            #region add image in picturebox
            pictureBox1.Image = Properties.Resources.avocado;
            pictureBox2.Image = Properties.Resources.avocado;
            pictureBox3.Image = Properties.Resources.banana;
            pictureBox4.Image = Properties.Resources.banana;
            pictureBox5.Image = Properties.Resources.melon;
            pictureBox6.Image = Properties.Resources.melon;
            pictureBox7.Image = Properties.Resources.berry;
            pictureBox8.Image = Properties.Resources.berry;
            pictureBox9.Image = Properties.Resources.cherry;
            pictureBox10.Image = Properties.Resources.cherry;
            pictureBox11.Image = Properties.Resources.dragonfruit;
            pictureBox12.Image = Properties.Resources.dragonfruit;
            pictureBox13.Image = Properties.Resources.grape;
            pictureBox14.Image = Properties.Resources.grape;
            pictureBox15.Image = Properties.Resources.mango;
            pictureBox16.Image = Properties.Resources.mango;
            pictureBox17.Image = Properties.Resources.pear;
            pictureBox18.Image = Properties.Resources.pear;
            pictureBox19.Image = Properties.Resources.pineapple;
            pictureBox20.Image = Properties.Resources.pineapple;
            #endregion
        }

            private void timer2_Tick(object sender, EventArgs e)//countdown ẩn hình
            {
                int timer = Convert.ToInt32(label2.Text);
                timer = timer - 1;
                label2.Text = Convert.ToString(timer);
                if (timer == 0)
                {
                    timer2.Stop();
                foreach (PictureBox picture in panel1.Controls)// ẩn hình và thay bằng ảnh khác
                {
                    picture.Enabled = true;
                    picture.Cursor = Cursors.Hand;//hiện ngón tay khi chọn picturebox
                    picture.Image = Properties.Resources.Question;
                }
            }
            }
        #region add event click in picturebox
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.avocado;
            if (firstclick == null)
            {
                firstclick = pictureBox1;
                pictureBox1.Enabled = false;

            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox1;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.avocado;
            if (firstclick == null)
            {
                firstclick = pictureBox2;
                pictureBox2.Enabled = false;

            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox2;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.banana;
            if (firstclick == null)
            {
                firstclick = pictureBox3;
                pictureBox3.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox3;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.banana;
            if (firstclick == null)
            {
                firstclick = pictureBox4;
                pictureBox4.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox4;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.melon;
            if (firstclick == null)
            {
                firstclick = pictureBox5;
                pictureBox5.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox5;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.melon;
            if (firstclick == null)
            {
                firstclick = pictureBox6;
                pictureBox6.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox6;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.berry;
            if (firstclick == null)
            {
                firstclick = pictureBox7;
                pictureBox7.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox7;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.berry;
            if (firstclick == null)
            {
                firstclick = pictureBox8;
                pictureBox8.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox8;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    count++;

                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.cherry;
            if (firstclick == null)
            {
                firstclick = pictureBox9;
                pictureBox9.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox9;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.cherry;
            if (firstclick == null)
            {
                firstclick = pictureBox10;
                pictureBox10.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox10;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.dragonfruit;
            if (firstclick == null)
            {
                firstclick = pictureBox11;
                pictureBox11.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox11;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.dragonfruit;
            if (firstclick == null)
            {
                firstclick = pictureBox12;
                pictureBox12.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox12;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.grape;
            if (firstclick == null)
            {
                firstclick = pictureBox13;
                pictureBox13.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox13;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.grape;
            if (firstclick == null)
            {
                firstclick = pictureBox14;
                pictureBox14.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox14;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox13.Enabled = false;
                    pictureBox14.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.mango;
            if (firstclick == null)
            {
                firstclick = pictureBox15;
                pictureBox15.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox15;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.mango;
            if (firstclick == null)
            {
                firstclick = pictureBox16;
                pictureBox16.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox16;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox15.Enabled = false;
                    pictureBox16.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.pear;
            if (firstclick == null)
            {
                firstclick = pictureBox17;
                pictureBox17.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox17;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Properties.Resources.pear;
            if (firstclick == null)
            {
                firstclick = pictureBox18;
                pictureBox18.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox18;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox17.Enabled = false;
                    pictureBox18.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Properties.Resources.pineapple;
            if (firstclick == null)
            {
                firstclick = pictureBox19;
                pictureBox19.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox19;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox19.Enabled = false;
                    pictureBox20.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Properties.Resources.pineapple;
            if (firstclick == null)
            {
                firstclick = pictureBox20;
                pictureBox20.Enabled = false;
            }
            else if (firstclick != null && secondclick == null)
            {
                secondclick = pictureBox20;
            }
            if (firstclick != null && secondclick != null)
            {
                if (firstclick.Tag == secondclick.Tag)
                {
                    firstclick = null;
                    secondclick = null;
                    pictureBox19.Enabled = false;
                    pictureBox20.Enabled = false;
                    count++;
                }
                else
                {
                    timer3.Start();
                }
                if (count == 10)
                {
                    MessageBox.Show("You Win", "Congratulation");
                    Game_Load(sender, e);
                    count = 0;
                }
            }
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e) //xác định 2 hình giống nhau
        {
            timer3.Stop();
            firstclick.Image = Properties.Resources.Question;
            secondclick.Image = Properties.Resources.Question;
            firstclick = null;
            secondclick = null;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e) //reset màn chơi
        {
            Game_Load(sender, e);
            count-= count;

        }

        private void timer4_Tick(object sender, EventArgs e) //cài đặt thời gian làm mới
        {
            timer4.Stop();
            button1.Enabled = true;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Hide();
            menu menugame = new menu();
            menugame.ShowDialog();
            System.Windows.Forms.Application.Exit();
        }

        private void Back_btn_MouseHover(object sender, EventArgs e)
        {
            Back_btn.Image = Properties.Resources.back;
        }

        private void Back_btn_MouseLeave(object sender, EventArgs e)
        {
            Back_btn.Image = Properties.Resources.normal_back;
        }
    }
}
