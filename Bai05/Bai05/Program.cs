using System;
using System.Text;
namespace Bai05
{
    public class Date
    {
                //Hàm kiểm trả ngày hợp lệ
            static bool check(int ngay, int thang, int nam)
            {
                if (thang < 1 || thang > 12 || ngay < 0) return false;
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (ngay < 32) return true;
                        return false;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (ngay < 31) return true;
                        return false;
                    case 2:
                        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
                        {
                            if (ngay < 30) return true;
                            return false;
                        }
                        else
                        {
                            if (ngay < 29) return true;
                            return false;
                        }
                }
                return false;
            }

            //Hàm tính thứ trong tuần theo công thức zeller
            static string DayInWeekZeller(int day, int month, int year)
        {
            // Nếu là tháng 1 hoặc 2 thì tính thành tháng 13, 14 của năm trước
            if (month == 1)
            {
                month = 13;
                year--;
            }
            else if (month == 2)
            {
                month = 14;
                year--;
            }

            int q = day;
            int m = month;
            int K = year % 100;   // năm trong thế kỷ
            int J = year / 100;   // thế kỷ

            int h = (q + (13 * (m + 1)) / 5 + K + K / 4 + J / 4 + 5 * J) % 7;
            string[] thuVN = {
            "Thứ Bảy",   // 0
            "Chủ Nhật",  // 1
            "Thứ Hai",   // 2
            "Thứ Ba",    // 3
            "Thứ Tư",    // 4
            "Thứ Năm",   // 5
            "Thứ Sáu"    // 6
        };

            return thuVN[h];
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int ngay, thang, nam;
            Console.Write("Nhập ngày: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm: ");
            nam = int.Parse(Console.ReadLine());
            if (check(ngay, thang, nam))
            {
                Console.WriteLine("Ngày " + ngay + " tháng " + thang + " năm " + nam + " là " + DayInWeekZeller(ngay, thang, nam));
            }
            else Console.WriteLine("Ngày bạn nhập không hợp lệ");
        }
    }
}

