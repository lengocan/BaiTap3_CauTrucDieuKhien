using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_CauTrucDieuKhien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai 1:
            /*Console.WriteLine("Nhap vao so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 3== 0)
            {
                Console.WriteLine("So nhap vao chia het cho 3");
            }
            else {
                Console.WriteLine("So nhap vao khong chia het cho 3");
            }*/

            //Bai 2:
            /*for (int i = 1; i <= a; i++) { 
                for (int j = 1; j <= 10; j++)
                {
                    int y = i * j;
                    Console.WriteLine("{0} x {1} = {2}",i,j,y);
                }
                
            }*/

            //Bai 3:
            /*int a = int.Parse(Console.ReadLine());

            int tong = 0;
            int giaithua = 1;
            for (int i = 1; i <= a; i++)
            {
                giaithua *= i;
                tong += giaithua;
            }
            Console.WriteLine(tong);*/


            //Bai 4:

            /*double b = Math.Sqrt(a);

            double c = Math.Round(b);

            if (b-c!=0)
            {
                Console.WriteLine("Khong phai so chinh phuong");

            }
            else {
                Console.WriteLine("La so chinh phuong");
            }
            */


            //Bai 5:
            /*Console.WriteLine("Nhap vao thang bat ki: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao nam bat ki: ");
            int b = int.Parse(Console.ReadLine());*/
            /*switch (a)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    Console.WriteLine("Co 31 ngay");
                    break;
                case 2:
                    if (DateTime.IsLeapYear(b))
                    {
                        Console.WriteLine("Co 29 ngay");
                    }
                    else
                    {
                        Console.WriteLine("Co 28 ngay");

                    }
                    break;
                case 4: case 6: case 9: case 11:
                    Console.WriteLine("Co 30 ngay");
                    break;
            }*/
            //Bai 6:


            /*double tong = 0;
            for (int i = 1; i <= a; i++)
            {
                double b = Math.Pow(i,i);
                tong += b;
            }
            Console.WriteLine(tong);*/


            //Bai 7:
            /*int tong = 0;

            for (int i = 1; i <= a; i++)
            {
                if (i%2 != 0)
                {
                    tong += i;
                }
            }
            Console.WriteLine(tong);*/

            //Bai 8:
            /*for (int i = 2; i <= a; i++)
            {
                bool check = false;

                for (int j = 2; j <= i / 2; j++)
                {

                    if (i % j == 0)
                    {
                        check = true;
                    }

                }

                if (check == false)
                {
                    Console.WriteLine("{0} la so nguyen to", i);
                }
            }*/
            //Bai 9
            

            //Tam giac xuoi
            /*for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <=a; j++)
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat("*", j)));
                   
                }
                break;
            }*/

            //Tam giac nguoc
            /*for (int i = 1; i <= a; i++)
            {
                for (int j = a; j >= 1; j--)
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat("*", j)));

                }
                break;
            }

            */
            //Bai 10
            /*Console.WriteLine("Nhap vao so nguyen bat ki: ");
            int a = int.Parse(Console.ReadLine());

            int f0 = 0;
            int f1 = 1;
            int fn = f0 +f1;

            Console.Write("{0} {1} {2}", f0, f1, fn);
            for (int i = 3; i <a; i++)
            {
                f0 = f1;

                f1 = fn;
                fn = f0 + f1;

                Console.Write(" " + fn);
            }*/
            Console.ReadKey();
        }
    }

}
