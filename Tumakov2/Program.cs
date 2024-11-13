using System;

namespace Tumakov2
{
    internal class Program
    {
        static void Main()
        {
            ///3.1
            ///Создать перечисление, отображающее виды банковского счёта. Создать переменную типа перечисления, присвоить ей значение и вывести на экран
            ///Ввод: -
            Console.WriteLine("Задание 3.1");

            Account account1 = Account.Текущий;

            Console.WriteLine(account1);


            ///3.2
            ///Создать структуру, хранящую информацию о банковском счёте (номер, тип, баланс)
            ///Ввод: -
            Console.WriteLine("Задание 3.2");

            Data data = new Data();
            data.number = "123rT56";
            data.type = Account.Сберегательный;
            data.balance = -11500;
            data.printData();

            ///3.1
            ///Создать перечислимый тип ВУЗ {КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.
            ///Ввод: -
            Console.WriteLine("Домашнее задание 3.1");

            Employee employee1 = new Employee();
            employee1.name = "Вася Пупкин";
            employee1.univer = (University)0;
            employee1.Print();

            Console.WriteLine("Введите любой символ для закрытия консоли...");
            Console.ReadKey();
        }
        enum Account
        {
            Сберегательный,
            Текущий
        }
        struct Data
        {
            public string number;
            public Account type;
            public double balance;
            public void printData()
            {
                Console.WriteLine($"Номер счёта - {number}, тип - {type}, баланс - {balance}");
            }
        }
        enum University
        {
            КГУ, КАИ, КХТИ
        }
        struct Employee
        {
            public string name;
            public University univer;
            public void Print()
            {
                Console.WriteLine($"Имя - {name}, ВУЗ - {univer}");
            }
        }
    }
}
