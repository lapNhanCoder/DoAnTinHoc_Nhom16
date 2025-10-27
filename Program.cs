using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoAnTinHoc
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Khởi tạo và chạy Form MatKhau
            // Tên class MatKhau phải khớp với tên file Form của bạn
            Application.Run(new MatKhau());
        }
    }
}
