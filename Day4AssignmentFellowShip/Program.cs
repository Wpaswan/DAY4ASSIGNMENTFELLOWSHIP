﻿
using Day4AssignmentFellowShip;
Console.WriteLine("\tEnter any key to continiue and n to stop");
char cho=Convert.ToChar(Console.ReadLine());
while (cho != 'n')
{
    Console.WriteLine("\t((((((((Please Select                         )))))))");
    Console.WriteLine("\\t(((((((1.Employ attendance                   )))))))");
    Console.WriteLine("\\t(((((((2.Employee Wage per day               )))))))");
    Console.WriteLine("\\t(((((((3.Employee Wage Part time or full time)))))))");

    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            EmployeeUseCase1 e1 = new EmployeeUseCase1();
            e1.EmpWage1();
            break;

            break;
        case 2:
            EmployeeUseCase2 e2 = new EmployeeUseCase2();
            e2.WagePer_Day();
            break;
        case 3:
            EmployeeUseCase3 e3 = new EmployeeUseCase3();
            e3.input();
            break;
           
    }
    Console.WriteLine("\tEnter any key to continiue and n to stop");
    cho = Convert.ToChar(Console.ReadLine());
}