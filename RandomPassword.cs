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
            char[] matKhau = new char[doDai];
            int seed =(int)DateTime.Now.Ticks%100000;
            for (int i = 0; i < doDai; i++) { 
            seed =(seed*1103515245+12345)&int .MaxValue;
                int index = seed % tapKyTu.Length;
                //Tranh trung ki tu
                bool trung = false;
                for(int j = 0; j < i; j++)
                {
                    if (matKhau[j] == tapKyTu[index])
                    {
                        trung = true; break;
                    }
                }
                if (trung) {
                    i--;
                    continue;
                }
                matKhau[i] = tapKyTu[index];
            }
            // ghép mảng ký tự thành chuỗi
            string ketQua = "";
            for (int i = 0; i < doDai; i++)
            {
                ketQua += matKhau[i];
            }

            return ketQua;
        }
    }
}
