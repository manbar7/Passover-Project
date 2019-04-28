using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            List<int> Xs = new List<int>();
            List<int> Ys = new List<int>();
            while (x != 0 && x > 0)
            {
                Console.WriteLine("Please enter a number for the X List");
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 0 && x > 0)
                {
                    Xs.Add(x);
                    Console.WriteLine("Please enter a number for the Y List");
                    y = Convert.ToInt32(Console.ReadLine());
                    Ys.Add(y);


                }
            }

            DAO dAO = new DAO();
            dAO.Insert(Xs,"X");
            dAO.Insert(Ys, "Y");



        }
    }
}
