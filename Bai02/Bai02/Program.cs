
using System;
using System.Text;
namespace Th_Buoi1
    {
        public class Bai2
        {
            // Kiểm tra a có phải số nguyên tố không
            static bool SNT(int a)
            {
                if (a < 2) return false;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0) return false;
                }
                return true;
            }
            // Tính tổng các số nguyên tố nhỏ hơn n
            static int SoNguyenTo(int n)
            {
                int Sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (SNT(i))
                    {
                        Sum += i;
                    }
                }
                return Sum;
            }
            static void Main()
            {
                Console.OutputEncoding = Encoding.UTF8;
                int n;
                Console.WriteLine("Nhập một số nguyên dương");
                while (!int.TryParse(Console.ReadLine(),out n) || n<1)
                {
                Console.WriteLine("Nhập sai hãy nhập lại");
                }
                Console.WriteLine("Tổng các số nguyên tố bé hơn " + n + " : " + SoNguyenTo(n));
            }
        }
    }


