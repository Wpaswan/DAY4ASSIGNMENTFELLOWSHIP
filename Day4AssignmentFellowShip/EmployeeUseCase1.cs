using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4AssignmentFellowShip
{
    internal class EmployeeUseCase1
    {
        public void EmpWage1()
        {

            int isPresent = 1;
            Random random = new Random();
            int randominput = random.Next(0, 2);

            if (randominput == isPresent)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
            Console.ReadLine();
        }
    }
}
