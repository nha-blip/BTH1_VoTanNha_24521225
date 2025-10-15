using System;
using System.Text;
namespace Bai03
{
    public class Date
    {
        //Hàm kiểm trả ngày hợp lệ
        static bool check(int ngay, int thang,int nam)
        {
            if (thang < 1 || thang > 12 || ngay<0)  return false;
            switch (thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    if (ngay < 32) return true;
                    return false;
                case 4: case 6: case 9: case 11:
                    if (ngay < 31) return true;
                    return false;
                case 2:
                    if((nam%4==0 && nam%100!=0) || nam % 400 == 0)
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
        static void Main()
        {
            Console.OutputEncoding= Encoding.UTF8;
            int ngay, thang, nam;
            Console.Write("Nhập ngày: ");
            while(!int.TryParse(Console.ReadLine(),out ngay))
            {
                Console.WriteLine("Nhập sai định dạng hãy nhập lại");
            }
            Console.Write("Nhập tháng: ");
            while(!int.TryParse(Console.ReadLine(), out thang))
            {
                Console.WriteLine("Nhập sai định dạng hãy nhập lại");
            }
            Console.Write("Nhập năm: ");
            while(!int.TryParse(Console.ReadLine(), out nam))
            {
                Console.WriteLine("Nhập sai định dạng hãy nhập lại");
            }
            if (check(ngay, thang, nam)) Console.WriteLine("Bạn nhập hợp lệ");
            else Console.WriteLine("Bạn Nhập không hợp lệ");
        }
    }
}
