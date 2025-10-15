using System.Text;

using System;
namespace Bai04
{
    public class Date
    {
        // Hàm đếm số ngày trong tháng
        static int Count(int thang, int nam)
        {
            if (thang < 1 || thang > 12 ) return -1;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
            }
            return -1;
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int thang, nam;
            Console.Write("Nhập tháng: ");
            while (!int.TryParse(Console.ReadLine(), out thang))
            {
                Console.Write("Tháng không hợp lệ! Vui lòng nhập lại");
            }
            Console.Write("Nhập năm: ");
            while (!int.TryParse(Console.ReadLine(), out nam))
            {
                Console.Write("Năm không hợp lệ! Vui lòng nhập lại");
            }
            if (Count(thang, nam) != -1) Console.WriteLine("Tháng " + thang + " năm "+nam+ " có " + Count(thang, nam) + " ngày");
            else Console.WriteLine("Bạn nhập không hợp lệ");
            Console.ReadLine();
        }
    }
}
