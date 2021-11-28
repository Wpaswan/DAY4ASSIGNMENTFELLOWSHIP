
using Day4AssignmentFellowShip;
Console.WriteLine("\tEnter any key to continiue and n to stop");
char cho=Convert.ToChar(Console.ReadLine());
while (cho != 'n')
{
    Console.WriteLine("\t((((((((Please Select   )))))))");
    Console.WriteLine("\\t(((((((1.Employ Wage Uc1)))))))");
    
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            EmployeeUseCase1 e1 = new EmployeeUseCase1();
            e1.EmpWage1();
            break;
    }
    break;
    Console.WriteLine("\tEnter any key to continiue and n to stop");
    cho = Convert.ToChar(Console.ReadLine());
}