using CallAPI;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void userControl11__TextChanged(object sender, EventArgs e)
        {
            if (userControl11.textBox1_Text.Length >= 5)
            {
                label1.Text = "";
                if (userControl11.textBox1_Text.Contains(" "))
                {
                    userControl11.BorderColor = Color.Red;
                    label1.Text = "Username không được có khoảng trắng";
                }
                else
                {
                    userControl11.BorderColor = Color.Orange;
                }
            }
            else
            {
                userControl11.BorderColor = Color.Red;
                label1.Text = "UserName Phải từ 5 kí tự";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl12__TextChanged(object sender, EventArgs e)
        {

            if (userControl12.textBox1_Text.Length >= 8 && userControl12.textBox1_Text.Length <= 20)
            {
                label4.Text = "";
                if (userControl12.textBox1_Text.Contains(" "))
                {
                    label4.Text = "Password không được chứa khoảng trắng";
                    userControl12.BorderColor = Color.Red;
                }
                else
                {
                    label4.Text = "";
                    userControl12.BorderColor = Color.Orange;
                }
            }
            else
            {
                userControl12.BorderColor = Color.Red;
                label4.Text = "Password phải từ 8 - 20 kí tự";
            }
            if (eyeHurt > 3)
            {
                if (userControl12.textBox1_Text.Equals("sorry"))
                {
                    eyeHurt = 0;
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (userControl11.textBox1_Text.Equals("admin") && userControl12.textBox1_Text.Equals("12345678"))
            {
                //MessageBox.Show("Đăng nhập thành công");
                //Form1 form1 = new Form1();
                //form1.Show();
                //this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai UserName hoặc Password");
            }
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            eyeOpen();
        }
        Boolean EyeOpen = false;
        int eyeHurt = 0;
        private void eyeOpen()
        {
            if (EyeOpen == false)
            {
                EyeOpen = true;
                pbEye.Image = GUI.Properties.Resources.open_eye;
                userControl12.PasswordChar = false;
                eyeHurt += 1;

            }
            else
            {
                EyeOpen = false;
                pbEye.Image = GUI.Properties.Resources.close_eye;
                userControl12.PasswordChar = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(GUI.Properties.Resources.tomScream);
                player.Play();
            }
        }

        private void pbEye_MouseEnter(object sender, EventArgs e)
        {
            if (eyeHurt > 3)
            {
                pbEye.Location = new Point(550, 225);
            }
        }

        private void pbEye_MouseLeave(object sender, EventArgs e)
        {
            pbEye.Location = new Point(601, 225);
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                customButton1_Click(sender, e);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
