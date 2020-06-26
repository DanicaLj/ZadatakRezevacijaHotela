using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] mat = new int[1000, 365];


            Console.WriteLine("Number of rooms: ");
            int numberOfRooms;
            numberOfRooms = Int32.Parse(Console.ReadLine());
            if (numberOfRooms > 1000)
            {
                return;
            }

            Console.WriteLine("Start date: ");
            int startDate = Int32.Parse(Console.ReadLine());
            Console.WriteLine("End date: ");
            int endDate = Int32.Parse(Console.ReadLine());

            if (startDate < 0 || endDate > 365)
            {
                return;
            }

            while (solve(startDate, endDate, mat, numberOfRooms))
            {
                Console.WriteLine("Start date: ");
                startDate = Int32.Parse(Console.ReadLine());
                Console.WriteLine("End date: ");
                endDate = Int32.Parse(Console.ReadLine());

            }

            //writes matix of rooms and days 1000x366
            /*int rowLength = mat.GetLength(0);
            int colLength = mat.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", mat[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }*/

            Console.ReadLine();

        }


        static bool solve(int startDate, int endDate, int[,] mat, int numberOfRooms)
        {
            bool check = true;

            int currentNumberOfRooms = 0;
            int ts = 0;

            while (ts < endDate)
            {
                for (int i = startDate; i <= endDate; i++)
                {
                    if (mat[currentNumberOfRooms, i] == 1)
                    {
                        break;
                    }
                    ts = i;
                }
                if (ts != endDate)
                {
                    currentNumberOfRooms++;
                }
            }

            if (currentNumberOfRooms > numberOfRooms - 1)
            {
                Console.WriteLine("Decline");
            }
            else
            {
                for (int i = startDate; i <= endDate; i++)
                {
                    mat[currentNumberOfRooms, i] = 1;
                }
            }


            return check;
        }
    }
}
