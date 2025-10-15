using System;
using System.Text;
namespace Bai06
{
    public class Matran
    {
        // Phát sinh ngẫu nhiên ma trận
        static void RandomMatrix(int[,] matrix, int n, int m)
        {
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rd.Next(0, 100);
                }
            }
        }
        // a. Xuất ma trận
        static void Out(int[,] matrix, int n, int m)
        {            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        // b. Tìm phần tử lớn nhất, nhỏ nhất
        static int MinMax(int[,] matrix, int n, int m)
        {
            int Min, Max,index=0;
            Min = Max = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < Min) Min = matrix[i, j];
                    if (matrix[i, j] > Max)
                    {
                        Max = matrix[i, j];
                        index = j;
                    }
                }
            }
            Console.WriteLine("Phần tử lớn nhất của ma trân là " + Max);
            Console.WriteLine("Phần tử nhỏ nhất của ma trân là " + Min);
            return index;
        }
        // c.Tìm dòng có tổng lớn nhất
        static void MaxSumRow(int[,] matrix, int n, int m)
        {
            int sum = int.MinValue, index = 0;
            for (int i = 0; i < n; i++)
            {
                int temp = 0;
                for (int j = 0; j < m; j++)
                {
                    temp += matrix[i, j];
                }
                if (temp > sum)
                {
                    sum=temp;
                    index = i;
                }
            }
            Console.WriteLine("Dòng " + index + " có tổng " + sum + " là lớn nhất");
        }
        // hàm kiểm tra số nguyên tố
        static bool SNT(int a)
        {
            if (a < 2) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        // d.Tính tổng các số không phải nguyên tố
        static void SumPrime(int[,] matrix, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(!SNT(matrix[i, j])) sum+= matrix[i, j];
                }
            }
            Console.WriteLine("Tổng các số không phải số nguyên tố trong mảng là " + sum);
        }
        // e. Xóa dòng thứ k trong ma trận 
        static void DeleteRow(ref int[,] matrix, ref int n, int m)
        {
            Console.Write("Nhập dòng cần xóa(0 đến {0}): ", n - 1);
            int k;
            while (!int.TryParse(Console.ReadLine(), out k) || k < 0 || k >= n)
            {
                Console.Write("Dòng không hợp lệ! Vui lòng nhập lại (0 đến {0}): ", n - 1);
            }

            int[,] newMatrix = new int[n - 1, m];
            int newRow = 0;

            for (int i = 0; i < n; i++)
            {
                if (i == k) continue;
                for (int j = 0; j < m; j++)
                {
                    newMatrix[newRow, j] = matrix[i, j];
                }
                newRow++;
            }

            matrix = newMatrix;
            n--;
            Console.WriteLine("Ma trận sau khi xóa hàng " + k);
            Out(matrix, n, m);
            
        }
        static void DeleteColumn(ref int[,] matrix, int n, ref int m,int k)
        {
        int[,] newMatrix = new int[n, m - 1];
        for (int i = 0; i < n; i++)
            {
                int newCol = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j == k) continue;
                    newMatrix[i, newCol] = matrix[i, j];
                    newCol++;
                }
            }

            matrix = newMatrix; 
            m--;
            Console.WriteLine("Ma trận sau khi xóa cột chứ phân tử lớn nhất");
            Out(matrix, n, m);
        }
        static void Main()
        {
            Console.OutputEncoding=Encoding.UTF8;
            int n, m;
            Console.WriteLine("Nhập số hàng và cột của ma trận:");
            // Nhập số hàng
            Console.Write("Nhập số hàng: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Giá trị không hợp lệ! Vui lòng nhập lại số hàng (> 0): ");
            }
            // Nhập số cột
            Console.Write("Nhập số cột: ");
            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.Write("Giá trị không hợp lệ! Vui lòng nhập lại số cột (> 0): ");
            }
            int[,] matrix=new int[n, m];
            RandomMatrix(matrix, n, m);
            Console.WriteLine("Ma trận vừa nhập: ");
            Out(matrix, n, m);
            int k=MinMax(matrix, n, m);
            MaxSumRow(matrix, n, m);
            SumPrime(matrix, n, m);            
            DeleteRow(ref matrix,ref n, m);
            DeleteColumn(ref matrix, n, ref m,k);
        }

    }

}