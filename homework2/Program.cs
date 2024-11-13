using System;
using System.ComponentModel;



namespace homework2
{
    internal class Program
    {
        static void Main()
        {
            //1 номер
            //Вывод информации о каждом типе данных
            //Ввод: ничего
            //Вывод: тип данных - максимальное значение - минимальное значение
            Console.WriteLine("1 номер");

            Console.WriteLine("byte - 255 - 0");
            Console.WriteLine("sbyte - 127 - -128");
            Console.WriteLine("short - 32 767 - -32 768");
            Console.WriteLine("ushort - 65 535 - 0");
            Console.WriteLine("int - 2 147 483 647 - -2 147 483 648");
            Console.WriteLine("uint - 4 294 967 295 - 0");
            Console.WriteLine("long - 9 223 372 036 854 775 807 - -9 223 372 036 854 775 808");
            Console.WriteLine("ulong - 18 446 744 073 709 551 615 - 0");
            Console.WriteLine("float - 3.402823e38 - -3.402823e38");
            Console.WriteLine("double - 1.797693e308 - -1.797693e308");
            Console.WriteLine("decimal - 7.922816e28 - -7.922816e28");

            //2 номер
            //Принимаются и выводятся данные пользователя в виде имени, города, возраста и PIN - кода
            //Ввод: имя, город, возраст, пин-код
            //Вывод: Вышеперечисл. информация
            Console.WriteLine("2 номер");

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите PIN-код");
            string pin = Console.ReadLine();

            string[] person = { name, city, age, pin };
            Console.WriteLine($"Имя - {person[0]}\nГород - {person[1]}\nВозраст - {person[2]}\nПИН - {person[3]}");

            //3 номер
            //Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – настрочные
            //Ввод: строка
            //Вывод: строка с измененным регистром символов
            Console.WriteLine("3 номер");

            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();

            string ans = "";
            foreach (char ch in input)
            {
                string chr = ch.ToString().ToUpper();
                if (chr == ch.ToString())
                {
                    ans += ch.ToString().ToLower();
                }
                else
                {
                    ans += ch.ToString().ToUpper();
                }
            }
            Console.WriteLine(ans);

            //4 номер
            //Определить количество вхождений подстроки в строку
            //Ввод: строка, подстрока
            //Вывод: Количество вхождений
            Console.WriteLine("4 номер");

            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            Console.WriteLine("Введите подстроку");
            string sub_s = Console.ReadLine();

            if (sub_s == "")
            {
                Console.WriteLine("!!!Пустая подстрока!!!");
            }
            else
            {
                string s_after = s.Replace(sub_s, "");
                int count = (s.Length - s_after.Length) / sub_s.Length;
                Console.WriteLine($"Количество вхождений равно {count}");
            }

            //5 номер
            //Определить, сколько бутылок виски беспошлинной торговли вам нужно будет купить,
            //чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на ваш отпуск
            //Ввод: цена без скидки, скидка, стоимость отпуска
            //Вывод: количество бутылок
            Console.WriteLine("5 номер");

            Console.WriteLine("Введите стандартную цену");
            int normPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер скидки");
            int salePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            int holidayPrice = int.Parse(Console.ReadLine());

            double delta = salePrice * normPrice / 100;
            Console.WriteLine($"Количество бутылок = {(int)(holidayPrice / delta)}");

            //6 номер
            //Создать 5 студентов с различными параметрами
            //Посчитать общий объем выпитого, общий объем алкоголя (процент спирта)
            //и кто сколько процентов алкоголя и жидкости от общего количества выпил
            //Ввод: -
            //Вывод: Информация о студентах
            Console.WriteLine("6 номер");

            //Напитки
            Drinks drink1 = new Drinks();
            drink1.title = "текила";
            drink1.alcPercent = 30;
            Drinks drink2 = new Drinks();
            drink2.title = "водка";
            drink2.alcPercent = 40;
            Drinks drink3 = new Drinks();
            drink3.title = "оно и в африке пиво";
            drink3.alcPercent = 4;
            Drinks drink4 = new Drinks();
            drink4.title = "мохито";
            drink4.alcPercent = 10;
            Drinks drink5 = new Drinks();
            drink5.title = "вино";
            drink5.alcPercent = 11;

            //Студенты пошли
            Student student1 = new Student();
            student1.firstName = "Вася";
            student1.lastName = "Васильченко";
            student1.ID = "123";
            student1.birthDate = "01.01.2001";
            student1.alcCateg = "a";
            student1.volume = (0.5, drink1.title, drink1.alcPercent);

            Student student2 = new Student();
            student2.firstName = "Петя";
            student2.lastName = "Петров";
            student2.ID = "129";
            student2.birthDate = "12.01.2002";
            student2.alcCateg = "c";
            student2.volume = (0.5, drink2.title, drink2.alcPercent);

            Student student3 = new Student();
            student3.firstName = "Ваня";
            student3.lastName = "Назаров";
            student3.ID = "121";
            student3.birthDate = "В один чудесный день";
            student3.alcCateg = "b";
            student3.volume = (2, drink3.title, drink3.alcPercent);

            Student student4 = new Student();
            student4.firstName = "Коля";
            student4.lastName = "Васильченко";
            student4.ID = "122";
            student4.birthDate = "01.01.2001";
            student4.alcCateg = "a";
            student4.volume = (0.7, drink4.title, drink4.alcPercent);

            Student student5 = new Student();
            student5.firstName = "Катя";
            student5.lastName = "Васечкина";
            student5.ID = "124";
            student5.birthDate = "Не записали";
            student5.alcCateg = "c";
            student5.volume = (20, drink5.title, drink5.alcPercent);


            //Вывод
            double genVolume = student1.volume.Item1 + student2.volume.Item1 + student3.volume.Item1 + student4.volume.Item1 + student5.volume.Item1;
            Console.WriteLine($"Общий объём выпитого - {genVolume} л");
            double alcVolume = student1.volume.Item1 * student1.volume.Item3 / 100 + student2.volume.Item1 * student2.volume.Item3 / 100 + student3.volume.Item1 * student3.volume.Item3 / 100 + student4.volume.Item1 * student4.volume.Item3 / 100 + student5.volume.Item1 * student5.volume.Item3 / 100;
            Console.WriteLine($"Объём алкоголя - {alcVolume} л ({100 * alcVolume / genVolume:F0}%)");
            Console.WriteLine($"{student1.firstName} {student1.lastName} выпил(а) {student1.volume.Item1 * 100 / genVolume:F1}% от общего объёма  (это {student1.volume.Item1 * student1.volume.Item3 / 100} л алкоголя [{student1.volume.Item1 * student1.volume.Item3 / alcVolume:F1})%]");
            Console.WriteLine($"{student2.firstName} {student2.lastName} выпил(а) {student2.volume.Item1 * 100 / genVolume:F1}% от общего объёма  (это {student2.volume.Item1 * student2.volume.Item3 / 100} л алкоголя [{student2.volume.Item1 * student2.volume.Item3 / alcVolume:F1})%]");
            Console.WriteLine($"{student3.firstName} {student3.lastName} выпил(а) {student3.volume.Item1 * 100 / genVolume:F1}% от общего объёма  (это {student3.volume.Item1 * student3.volume.Item3 / 100} л алкоголя [{student3.volume.Item1 * student3.volume.Item3 / alcVolume:F1})%]");
            Console.WriteLine($"{student4.firstName} {student4.lastName} выпил(а) {student4.volume.Item1 * 100 / genVolume:F1}% от общего объёма  (это {student4.volume.Item1 * student4.volume.Item3 / 100} л алкоголя [{student4.volume.Item1 * student4.volume.Item3 / alcVolume:F1})%]");
            Console.WriteLine($"{student5.firstName} {student5.lastName} выпил(а) {student5.volume.Item1 * 100 / genVolume:F1}% от общего объёма  (это {student5.volume.Item1 * student5.volume.Item3 / 100} л алкоголя [{student5.volume.Item1 * student5.volume.Item3 / alcVolume:F1})%]");
            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadLine();
        }
        //Структуры
        struct Drinks
        {
            public string title;
            public double alcPercent;
        }
        struct Student
        {
            public string firstName;
            public string lastName;
            public string ID;
            public string birthDate;
            public string alcCateg;
            public (double, string, double) volume;

            public void Print()
            {
                Console.WriteLine("=======================================");
                Console.WriteLine($"Имя - {firstName}");
                Console.WriteLine($"Фамилия - {lastName}");
                Console.WriteLine($"Идентификатор - {ID}");
                Console.WriteLine($"Дата рождения - {birthDate}");
                Console.WriteLine($"Категория алкоголизма - {alcCateg}");
                Console.WriteLine($"Объем выпитой жидкости - {volume.Item1}");
                Console.WriteLine($"Напиток - {volume.Item2}");
                Console.WriteLine($"Процент алкоголя - {volume.Item3}");
            }
        }
    }
}



