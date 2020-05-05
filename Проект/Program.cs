using System;

namespace Проект
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Я написал небольшой тест, чтобы посмотреть на то, что я уже умею в программировании");

            Console.WriteLine("Введите, пожалуйста, ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Тест будет простенький, состоять из пяти вопросов");

            FirstQuestion();
            Console.WriteLine("Не волнуйтесь, " + name + ", можно использовать гугл :)");
            SecondQuestion();
            Console.WriteLine("На этом вопросе довольно часто люди спотыкаются, но вы, " + name + ", справитесь!");
            ThirdQuestion();
            Console.WriteLine("Хорошо идете!");
            FourthQuestion();
            Console.WriteLine(name + ", напрягитесь! Осталось совсем чуть-чуть!");
            FifthQuestion();
            Console.WriteLine(name + ", вы справились!!! Мои поздравления, тест не из легких.");
            Console.WriteLine("Это не все мои познания в программировании, но я только начал, не судите строго)");
            Console.ReadLine();
        }
        static void FirstQuestion()
        {
            try
            {
                Console.WriteLine("Как выразить в двоичном коде цифру 5?");
                int firstAnswer = Convert.ToInt32(Console.ReadLine());

                if (firstAnswer == 101)
                {
                    Console.WriteLine("Молодец, переходим ко второму вопросу");
                }
                else
                {
                    Console.WriteLine("Неверный ответ");
                    FirstQuestion();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Необходимо ввести число");
                FirstQuestion();
            }
        }
        static void SecondQuestion()
        {
            try
            {
                Console.WriteLine("Столица Португалии?");
                string secondAnswer = Console.ReadLine();

                if (secondAnswer == "lissabon" || secondAnswer == "Лиссабон" || secondAnswer == "лиссабон" || secondAnswer == "Lissabon")
                {
                    Console.WriteLine("Отлично, переходим к третьему вопросу");
                }
                else
                {
                    Console.WriteLine("Неверный ответ");
                    SecondQuestion();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Необходимо ввести название города");
                SecondQuestion();
            }
        }
        static void ThirdQuestion()
        {
            try
            {
                Console.WriteLine("За бутылку с пробкой заплатили 11 рублей. Бутылка стоит на 10 рублей больше, чем пробка. Сколько стоит пробка в копейках?");
                int thirdAnswer = int.Parse(Console.ReadLine());
                if (thirdAnswer == 50)
                {
                    Console.WriteLine("Верно, переходим к четвертому вопросу");
                }
                else
                {
                    Console.WriteLine("Неверный ответ");
                    ThirdQuestion();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Необходимо ввести число");
                ThirdQuestion();
            }
        }    
        static void FourthQuestion()
        {
            try
            {
                Console.WriteLine("Как называется на английском естественный спутник земли?");
                string fourthAnswer = Console.ReadLine();
                if (fourthAnswer == "moon" || fourthAnswer == "Moon" || fourthAnswer == "MOON")
                {
                    Console.WriteLine("Верно, переходим к последнему вопросу");
                }
                else
                {
                    Console.WriteLine("Неверный ответ");
                    FourthQuestion();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибочка вышла");
                FourthQuestion();
            }
        }
        static void FifthQuestion()
        {
            try
            {
                Console.WriteLine("Каков ответ на главный вопрос жизни, вселенной и всего такого?");
                Console.WriteLine("Подсказка - это число");
                int fifthAnswer = int.Parse(Console.ReadLine());
                if (fifthAnswer == 42)
                {
                    Console.WriteLine("Верно!");
                }
                else
                {
                    Console.WriteLine("Неверный ответ");
                    FifthQuestion();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Необходимо ввести число");
                FifthQuestion();
            }
        }
    }
}
