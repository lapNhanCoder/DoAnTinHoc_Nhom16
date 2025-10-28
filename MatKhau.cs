using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTinHoc
{
    public partial class MatKhau : Form
    {
        public MatKhau()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MatKhau_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRandomPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomPassword rp = new RandomPassword();
            int doDauMatKhau = 0;
            if (!int.TryParse(txtDoDai.Text, out doDauMatKhau) || doDauMatKhau <= 0)
            {
                MessageBox.Show("Vui long nhap do dai mat khau la mot so nguyen duong",
                    "Thieu tuy chon", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool coChuThuong = checkabc.Checked;
            bool coChuHoa = checkBox2.Checked;
            bool coSo = checkBox3.Checked;
            bool coKyTuDB = checkBox1.Checked;
            try
            {
                string matKhauMoi = rp.TaoMatKhau(doDauMatKhau, coChuThuong, coChuHoa, coSo, coKyTuDB);
                txtRandomPassword.Text = matKhauMoi;
            }
            catch (Exception ex) {
                MessageBox.Show($"Da xay ra loi trong qua trinh tao mat khau: {ex.Message}", 
                    "Loi he thong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDoDai.Text = "";
            txtRandomPassword.Text = "";
            checkabc.Checked =false;
            checkBox2.Checked=false;
            checkBox3.Checked=false;
           checkBox1.Checked = false;
            txtDoDai.Focus();
        }

        private void btnManh_Click(object sender, EventArgs e)
        {
            try
            {
          Random random = new Random();
                int doDai = random.Next(12, 15);                          
                    txtDoDai.Text = doDai.ToString();
                    checkabc.Checked = true;
                    checkBox2.Checked = true;
                    checkBox3.Checked = true;
                    checkBox1.Checked = true;
               
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnKha_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int doDai = random.Next(9, 12);
                txtDoDai.Text = doDai.ToString();
                checkabc.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;              

            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnTrungbinh_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int doDai = random.Next(5, 10);
                txtDoDai.Text = doDai.ToString();
                checkabc.Checked = true;
                checkBox2.Checked = true;                            
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnYeu_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int doDai = random.Next(0, 5);
                txtDoDai.Text = doDai.ToString();
                checkabc.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
        }
    }
}
