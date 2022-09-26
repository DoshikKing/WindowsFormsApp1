using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<double> F12(int x, int y)
        {
            var nums = new List<double>();
            if (x > 0){
                nums.Add(x * 2);
                if (y > 0)
                {
                    nums.Add(y * 2);
                    return nums;
                }
                else
                {
                    nums.Add(Math.Pow(y, 2));
                    return nums;
                }
            }
            else
            {
                nums.Add(Math.Pow(x, 2));
                if (y > 0)
                {
                    nums.Add(y * 2);
                    return nums;
                }
                else
                {
                    nums.Add(Math.Pow(y, 2));
                    return nums;
                }
            }
        }

        public static List<double> F15(int x, int y)
        {
            var nums = new List<double>();
            if (x > 0)
            {
                nums.Add(Math.Pow(x, 3));
                if (y > 0)
                {
                    nums.Add(Math.Pow(y, 3));
                    return nums;
                }
                else
                {
                    nums.Add(Math.Abs(y));
                    return nums;
                }
            }
            else
            {
                nums.Add(Math.Abs(x));
                if (y > 0)
                {
                    nums.Add(Math.Pow(y, 3));
                    return nums;
                }
                else
                {
                    nums.Add(Math.Abs(y));
                    return nums;
                }
            }
        }

        public static List<double> F18(double x1, double y1, double c1, double x2, double y2, double c2)
        {
            double D = (x1 * y2) - (x2 * y1);
            var nums = new List<double>();
            if (D != 0)
            {
                double x = ((c1 * y2) - (c2 * y1)) / D;
                double y = ((x1 * c2) - (x2 * c1)) / D;
                nums.Add(x);
                nums.Add(y);
                return nums;
            }
            else
            {
                return null;
            }
        }

        public static int F21(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return x;
            } 
            else if (y > z && y > x)
            {
                return y;
            } 
            else
            {
                return z;
            }
        }

        public static string f24(int x, int y)
        {
            if ((x > 0 && y < 0) || (x < 0 && y > 0))
            {
                return "" + x * y;
            }
            else
            {
                return "X= " + Math.Pow(x, 2) + " Y=" + Math.Pow(y, 2);
            }
        }
    }
}
