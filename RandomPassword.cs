using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassword
{
    internal class RandomPassword
    {
        private readonly Random random = new Random();
        private const string chuThuong = "abcdefghijklmnopqrstuvwxyz";
        private const string chuHoa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string so = "0123456789";
        private const string kyTu = "!@#$%^&*()-_=+[{]};:<>|./?";
        //Hàm tạo mật khẩu ngẫu nhiên không trùng ký tự
        public string TaoMatKhau(int doDai, bool coThuong, bool coHoa, bool coSo, bool coKyTu)
        {
            string tapKyTu = "";
            if (coThuong)
                tapKyTu += chuThuong;
            if (coHoa)
                tapKyTu += chuHoa;
            if (coSo)
                tapKyTu += so;
            if (coKyTu)
                tapKyTu += kyTu;
            //Nếu không chọn gì mặc định chữ thường
            if (tapKyTu == "")
                tapKyTu = chuThuong;

           
            StringBuilder matKhau = new StringBuilder();
            for (int i = 0; i < doDai; i++)
            {
                int index = this.random.Next(0, tapKyTu.Length);
                matKhau.Append(tapKyTu[index]);
            }
            return matKhau.ToString();
        }
    }
}

