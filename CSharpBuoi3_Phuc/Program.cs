using System;
using System.Text;
namespace CSharpBuoi3_Phuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Xin chào thầy!");
            Console.WriteLine("Em là Phúc, năm 2 CNTT.\n");

            // Gọi các hàm
            InThongTinCaNhan();
            TaoNhanVatCoAtk();

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        // Hàm in thông tin cá nhân
        static void InThongTinCaNhan()
        {
            string hoVaTen = "Đoàn Văn Phúc";
            int tuoi = 20;
            string mucTieu = "Trở thành Game Dev thành công trong tương lai!";
            string truongHoc = "Đại học Công nghệ Thông tin";

            Console.WriteLine("--- Thông tin cá nhân ---");
            Console.WriteLine($"Họ và tên: {hoVaTen}");
            Console.WriteLine($"Tuổi: {tuoi}");
            Console.WriteLine($"Mục tiêu: {mucTieu}");
            Console.WriteLine($"Trường: {truongHoc}\n");
        }

        // Hàm quản lý nhân vật (có nhập liệu)
        static void InThongTinNhanVat()
        {
            Console.Write("Nhập tên nhân vật của bạn: ");
            string tenNV = Console.ReadLine();

            Console.Write("Nhập HP ban đầu: ");
            int hp = int.Parse(Console.ReadLine());

            Console.Write("Nhập tốc độ: ");
            float speed = float.Parse(Console.ReadLine());

            Console.WriteLine("\n=== NHÂN VẬT ĐÃ ĐƯỢC TẠO ===");
            Console.WriteLine($"Tên nhân vật: {tenNV}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Speed: {speed}");
        }
        static void TaoNhanVatCoAtk()
        {
            Console.Write("Nhập chỉ số tấn công cho nhân vật của bạn: ");
            int atk = int.Parse(Console.ReadLine());
            InThongTinNhanVat();
            Console.WriteLine($"Atk: {atk}");
        }
    }
}