using BLL;
using DTO;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Runtime.Serialization.Json;
using UserControl2;

namespace CallAPI
{

    public partial class Form1 : Form
    {

        List<KhoHang>? listKho;
        public Form1()
        {
            InitializeComponent();
            dgvKho.AutoGenerateColumns = false;
        }
        int indexRow;
        private void Form1_Load(object sender, EventArgs e)
        {

            HienThi();
        }

        public void HienThi()
        {
            ApiBLL apiBll = new();
            var data = apiBll.getDataForGUI();
            //KhoHang[] danhsach = (KhoHang[])data;
            listKho = (List<KhoHang>)data;
            dgvKho.DataSource = listKho;
        }


        private void dgvKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvKho.Rows[e.RowIndex];
            string maKho = row.Cells[0].Value.ToString();
            string tenKho = row.Cells[1].Value.ToString();
            txtMaKho.textBox1_Text = maKho;
            txtTenKho.textBox1_Text = tenKho;
            if (row.Cells[2].Value != null)
            {
                string moTa = row.Cells[2].Value.ToString();
                txtMoTa.textBox1_Text = moTa;
            }
            else { txtMoTa.textBox1_Text = ""; }
        }


        public void resetDataGrid()
        {
            dgvKho.DataSource = null;
        }


        public void Clear()
        {
            txtMaKho.textBox1_Text = "";
            txtTenKho.textBox1_Text = "";
            txtMoTa.textBox1_Text = "";

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Boolean check = false;
            if (txtMaKho.textBox1_Text != "")
            {
                for (int i = 0; i < listKho.Count; i++)
                {
                    DataGridViewRow row = dgvKho.Rows[i];
                    string maKho = row.Cells[0].Value.ToString();
                    if (maKho.Equals(txtMaKho.textBox1_Text))
                    {
                        check = true;
                        MessageBox.Show("Ma kho da ton tai");
                        break;
                    }
                }
                if (check == false)
                {
                    KhoHang kh = new KhoHang();
                    kh.maKhoXuat = txtMaKho.textBox1_Text;
                    kh.tenKhoXuat = txtTenKho.textBox1_Text;
                    kh.moTa = txtMoTa.textBox1_Text;
                    listKho.Add(kh);
                    resetDataGrid();
                    dgvKho.DataSource = listKho;
                    Clear();
                }
                {

                }
            }
            else { MessageBox.Show("Chua nhap ma kho xuat"); }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Boolean check = false;
            for (int i = 0; i < listKho.Count; i++)
            {
                DataGridViewRow newDataRow = dgvKho.Rows[i];
                string maKho = newDataRow.Cells[0].Value.ToString();
                if (maKho.Equals(txtMaKho.textBox1_Text))
                {
                    check = true;
                    newDataRow.Cells[0].Value = txtMaKho.textBox1_Text;
                    newDataRow.Cells[1].Value = txtTenKho.textBox1_Text;
                    newDataRow.Cells[2].Value = txtMoTa.textBox1_Text;
                    Clear();
                }


            }
            if (check == false) { MessageBox.Show("Mã kho không tồn tại"); }
            /* indexRow = dgvKho.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dgvKho.Rows[indexRow];
            newDataRow.Cells[0].Value = txtMaKho.Text;
            newDataRow.Cells[1].Value = txtTenKho.Text;
            newDataRow.Cells[2].Value = txtMoTa.Text;
            Clear(); */
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            /* listKho.RemoveAt(indexRow);
             resetDataGrid();
             dgvKho.DataSource = listKho;
             Clear(); */
            int j = 0;
            Boolean check = false;
            for (int i = 0; i < listKho.Count; i++)
            {
                DataGridViewRow row = dgvKho.Rows[i];
                string maKho = row.Cells[0].Value.ToString();
                if (maKho.Equals(txtMaKho.textBox1_Text))
                {
                    check = true;
                    j = i;
                }


            }
            if (check == false) { MessageBox.Show("Mã kho không tồn tại"); }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa Id " + txtMaKho.textBox1_Text + " ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    listKho.RemoveAt(j);
                    resetDataGrid();
                    dgvKho.DataSource = listKho;
                    Clear();
                }
                else { return; }
            }


        }

        //private void Form1_FormClosing(object sender, CancelEventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //    else { Environment.Exit(0); }
        //}

        private void txtMaKho__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKho__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoTa__TextChanged(object sender, EventArgs e)
        {

        }
    }
}