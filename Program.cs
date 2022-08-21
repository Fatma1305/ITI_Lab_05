using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQl_Day_05
{
    class Program
    {
        static void Main(string[] args)
        {

                #region Variables
                Employee employee = new Employee();
                Employee[] arr = new Employee[3];
                int day;
                int month;
                int year;
                
                #endregion

                #region Input
                Console.WriteLine("\t\t\t\t Input the data of employees\n");
                for (int i = 0; i < arr.Length; i++)
                {
                arr[i] = new Employee();
                Console.WriteLine($"Employee Number {i + 1}:");
                #region ID
                while (true)
                {
                    Console.Write($"The ID of Employee {i + 1}  : ");
                    int ID = 0; ;
                    if (int.TryParse(Console.ReadLine(), out ID))
                    {
                        arr[i].setEmpId(ID);
                        break;
                    }
                    Console.WriteLine($"\n\n\t\t\t  Invalid employee ID \n");
                }
                #endregion

                #region SecurityLevel
                while (true)
                {
                    Console.Write($"The security level of Employee from (GUEST- DEVELOPER- SECRETARY- DBA){i + 1}: ");
                    string SL = Console.ReadLine();

                    if (SL.ToUpper() == "GUEST")
                    {
                        arr[i].setEmpSecurityLevel(SecurityLevel.GUEST);
                        break;
                    }
                    else if (SL.ToUpper() == "Developer")
                    {
                        arr[i].setEmpSecurityLevel(SecurityLevel.DEVELOPER);
                        break;
                    }

                    else if (SL.ToUpper() == "SECRETARY")
                    {
                        arr[i].setEmpSecurityLevel(SecurityLevel.SECRETARY);
                        break;
                    }

                    else if (SL.ToUpper() == "DBA")
                    {
                        arr[i].setEmpSecurityLevel(SecurityLevel.DBA);
                        break;
                    }

                    else Console.WriteLine($"\n\n\t\t\t  Invalid employee security level \n");
                }
                #endregion

                #region Gender
                string gen;
                while (true)
                {

                    Console.Write($"The gender of Employee {i + 1}: ");
                    gen = Console.ReadLine();
                    if (gen.ToUpper() == "F" || gen.ToUpper() == "FEMALE")
                    {
                        arr[i].setEmpGender(Gender.Female);
                        break;
                    }
                    else if (gen.ToUpper() == "M" || gen.ToUpper() == "MALE")
                    {
                        arr[i].setEmpGender(Gender.Male);
                        break;
                    }
                    else Console.WriteLine($"\n\n\t\t\t  Invalid employee Gender \n");
                }
                #endregion

                #region Salary
                    while (true)
                    {
                        Console.Write($"The salary of Employee {i + 1}: ");
                        double salary = 0;

                        if (double.TryParse(Console.ReadLine(), out salary))
                        {
                            arr[i].setEmpSalary(salary);
                            break;
                        }
                        Console.WriteLine($"\n\n\t\t\t  Invalid employee salary \n");
                    }
                    #endregion

                #region Date
                    Console.WriteLine($"The hire's date of Employee {i + 1}: ");
                    while (true)
                    {
                        Console.Write($"The day: ");
                        if (int.TryParse(Console.ReadLine(), out day) && (day >= 1 && day <= 31))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write($"\n\n\t\t\t  Invalid employee ID \n");
                            Console.Write($"The day: ");
                        }

                    }
                    while (true)
                    {
                        Console.Write($"The month: ");
                        if (int.TryParse(Console.ReadLine(), out month) && (month >= 1 && month <= 12))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write($"\n\n\t\t\t  Invalid employee ID \n");
                            Console.Write($"The month: ");
                        }

                    }
                    while (true)
                    {
                        Console.Write($"The year: ");
                        if (int.TryParse(Console.ReadLine(), out year) && (year >= 1950 && year <= 2022))
                        {
                            break;
                        }
                        else
                        {
                            Console.Write($"\n\n\t\t\t  Invalid employee ID \n");
                            Console.Write($"The year: ");
                        }

                    }

                    hireDate hdd = new hireDate(day, month, year);
                    arr[i].setEmpHD(hdd);

                    Console.WriteLine("\n");
                    #endregion
                }
                #endregion

                #region Show
                Console.WriteLine("\t\t\t\t Show the data of empioyees\n");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"The Data of Employee Number {i + 1}:");
                    Console.WriteLine($"The ID of Employee {i + 1}: { arr[i].getEmpId()}");
                    Console.WriteLine($"The security level of Employee {i + 1}: { arr[i].getEmpSecurityLevel()}");
                    Console.WriteLine($"The gender of Employee {i + 1}: { arr[i].getEmpGender()}");
                    Console.WriteLine($"The Salary of Employee {i + 1}: { arr[i].getEmpSalary()}");
                    Console.WriteLine($"The hire's date of Employee {i + 1}: {arr[i].getEmpHD()}");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("\n");
                }
                #endregion

                Console.ReadKey();
            }
        }
    }
