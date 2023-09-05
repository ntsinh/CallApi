using CallAPI;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            subMenu();
        }
        private void subMenu()
        {
            pnlSubMenuKho.Visible = false;
            pnlSubMenuDssp.Visible = false;
            pnlSubmenuDonHang.Visible = false;
        }
        private void hideSubmenu()
        {
            if (pnlSubMenuKho.Visible == true)
            {
                pnlSubMenuKho.Visible = false;
                pbArrowDsKho.Image = Properties.Resources.DownArrow;
            }
            if (pnlSubMenuDssp.Visible == true)
            {
                pnlSubMenuDssp.Visible = false;
                pbArrowDssp.Image = Properties.Resources.DownArrow;
            }
            if (pnlSubmenuDonHang.Visible == true)
            {
                pnlSubmenuDonHang.Visible = false;
                pbArrowVitri.Image = Properties.Resources.DownArrow;
            }
        }
        private void showSubmenu(Panel subMenu, PictureBox pb)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
                pb.Image = Properties.Resources.UpArrow;
            }
            else
            {
                subMenu.Visible = false;
                pb.Image = Properties.Resources.DownArrow;
            }
        }

        private void btnDsKho_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuKho, pbArrowDsKho);
        }

        private void btnDssp_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuDssp, pbArrowDssp);
        }
        public void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            tblShowForm.Controls.Add(childForm);
            tblShowForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { Environment.Exit(0); }
        }


        private void btnDonHang_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuDonHang, pbArrowVitri);
        }

        private void pbArrowDsKho_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuKho, pbArrowDsKho);
        }

        private void pbArrowDssp_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubMenuDssp, pbArrowDssp);
        }

        private void pbArrowVitri_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubmenuDonHang, pbArrowVitri);
        }

        private void btnSpkd_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSPKD());
        }
    }
}
