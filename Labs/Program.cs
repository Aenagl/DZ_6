using Labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task7_1();
            Task7_2();
            Task7_3();
            Task7();
        }
        static void Task7_1()
        {
            Console.WriteLine("Упражнение 7.1");
            BankAccount1 myAccount1 = new BankAccount1("7888", Types.current, 34567.50m);
            myAccount1.ConsoleAccountInfo();
            BankAccount1 myAccount2 = new BankAccount1();
            Console.WriteLine();
            myAccount2.Number = "377685689";
            myAccount2.Balance =985678094.80m;
            myAccount2.Type = Types.current;
            myAccount2.ConsoleAccountInfo();
        }
        static void Task7_2()
        {
            Console.WriteLine();
            Console.WriteLine("Упражнение 7.2");
            BankAccount2 myAcc1 = new BankAccount2(Types.current,4758448.8484m);
            myAcc1.ConsoleAccountInfo();
            Console.WriteLine();
            BankAccount2 myAcc2 = new BankAccount2();
            myAcc2.Balance = 89.8m;
            myAcc2.Type = Types.saving;
            myAcc2.ConsoleAccountInfo();
        }
        static void Task7_3()
        {
            Console.WriteLine();
            Console.WriteLine("Упражнение 7.3");
            BankAccount3 myAcc = new BankAccount3(Types.current,467);
            myAcc.ConsoleAccountInfo();
            myAcc.Deposit(466);
            myAcc.ConsoleAccountInfo();
            myAcc.WithDraw(1000);
            myAcc.ConsoleAccountInfo();
        }

        static void Task7()
        {
            Console.WriteLine();
            Console.WriteLine("Домашнее задание 7.1");
            Building build1 = new Building(27.0,9,72,2);
            build1.ConsoleInfo();
            Console.WriteLine($"Высота этажа:{build1.HeightFloor()}");
            Console.WriteLine($"Количество квартир в подьезде:{build1.ApartmentHallway()}");
            Console.WriteLine($"Количество квартир на этаже:{build1.ApartmentFloor()}");
            Console.WriteLine();
            Building build2 = new Building(50, 15, 50, 3);
            build2.ConsoleInfo();
        }
    }
}