using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTinHoc
{
    internal class RandomPassword
    {
        private const string chuThuong = "abcdefghijklmnopqrstuvwxyz";
        private const string chuHoa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string so = "0123456789";
        private const string kiTu = "!@#$%^&*()-_=+[{]};:<>|./?";
        //Ham tao mat khau ngau nhien khong trung ki tu
        public string TaoMatKhau(int doDai, bool coThuong, bool coHoa, bool coSo, bool coKiTu)
        {
            string tapKyTu = "";
            if (coThuong) tapKyTu += chuThuong;
            if (coHoa) tapKyTu += chuHoa;
            if (coSo) tapKyTu += so;
            if (coKiTu) tapKyTu += kiTu;
            //Neu khong chon gi mac dinh chu thuong
            if (tapKyTu == "") tapKyTu = chuThuong;
            Random random = new Random();
            StringBuilder matKhau = new StringBuilder();
            for(int i = 0; i < doDai; i++)
            {
                int index = random.Next(0, tapKyTu.Length);
                matKhau.Append(tapKyTu[index]);
            }
            return matKhau.ToString();
        }
    }
}
