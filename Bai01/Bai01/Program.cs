using System;
using System.Text;
namespace Hello
{
    class Bai1
    {
        // hàm tính tổng
        static int Tong(int[] Arr, int n)
        {
            int Sum = 0;
            foreach (int i in Arr)
            {
                if (i % 2 != 0) Sum += i;
            }
            return Sum;
        }
        // Hàm kiểm tra một số nguyên tố
        static bool SNT(int a)
        {
            if (a < 2) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        // Hàm đếm số nguyên tố
        static int SoNguyenTo(int[] Arr, int n)
        {
            int count = 0;
            foreach (int i in Arr)
            {
                if (SNT(i))
                {
                    count++;
                }
            }
            return count;
        }
        // Hàm kiểm tra số chính phương
        static bool ChinhPhuong(int a)
        {
            if (a < 0) return false;
            if ((int)Math.Sqrt(a) == Math.Sqrt(a)) return true;
            return false;
        }
        // Hàm tìm số chính phương lớn nhất
        static int SoChinhPhuong(int[] Arr, int n)
        {
            int Min = int.MaxValue;
            bool flag = false;
            foreach (int i in Arr)
            {
                if (ChinhPhuong(i) && i < Min)
                {
                    Min = i;
                    flag = true;
                }
            }
            if (flag) return Min;
            return -1;
        }
        // Hàm phát sinh ngẫu nhiên mãng số nguyên
        static void Random(int n, int[] Arr)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = rd.Next(-100, 100);
                Console.Write(Arr[i] + " ");
            }
            Console.Write('\n');
        }
        static void Main()
        {
            Console.OutputEncoding=Encoding.UTF8;
            int n;
            Console.WriteLine("Nhập số phần tử của mảng");
            while (!int.TryParse(Console.ReadLine(), out n) || n<1)
            {
                Console.WriteLine("Nhập sai, hãy nhập lại"); 
            }
            int[] Arr = new int[n];
            Random(n, Arr);
            Console.WriteLine("tổng số lẻ trong mảng: " + Tong(Arr, n));
            Console.WriteLine("Số lượng số nguyên tố trong mảng: " + SoNguyenTo(Arr, n));
            if (SoChinhPhuong(Arr, n) != -1)
            {
                Console.WriteLine("Số chính phương nhỏ nhất: " + SoChinhPhuong(Arr, n));
            }
            else
            {
                Console.WriteLine("Mảng không có số chính phương"); 
            }        
        }
    }
}

