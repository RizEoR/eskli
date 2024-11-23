global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру-опросник!");
        Console.WriteLine("Ответьте на несколько вопросов, и я расскажу вам о вашем характере.");

        string color = "";
        string animal = "";
        string hobby = "";
        while (true)
        {
            try
            {
                // Вопрос 1
                Console.WriteLine("\nВопрос 1: Какой ваш любимый цвет?");
                color = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(color)) throw new ArgumentException("Вы не ввели цвет!");
                // IsNullOrWhiteSpace - проверка пустой строки ArgumentException - вызов исключения при некореткном воде
                // Вопрос 2
                Console.WriteLine("\nВопрос 2: Какое ваше любимое животное?");
                animal = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(animal)) throw new ArgumentException("Вы не ввели животное!");

                // Вопрос 3
                Console.WriteLine("\nВопрос 3: Какой ваш любимый вид отдыха?");
                hobby = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(hobby)) throw new ArgumentException("Вы не ввели вид отдыха!");

                // Обработка ответов
                Console.WriteLine("\nСпасибо за ваши ответы! Вот что я о вас думаю:");

                // Анализ ответов
                if (color.ToLower() == "красный")
                {
                    Console.WriteLine("Вы энергичный и страстный человек!");
                }
                else if (color.ToLower() == "синий")
                {
                    Console.WriteLine("Вы спокойный и уравновешенный человек.");
                }
                else
                {
                    Console.WriteLine("Вы уникальны и у вас есть свой собственный стиль!");
                }

                if (animal.ToLower() == "кот")
                {
                    Console.WriteLine("Вы независимы и цените личное пространство.");
                }
                else if (animal.ToLower() == "собака")
                {
                    Console.WriteLine("Вы верный друг и любите общение.");
                }
                else
                {
                    Console.WriteLine("Вы любите приключения и открыты к новому!");
                }

                Console.WriteLine($"Ваш любимый вид отдыха: {hobby}. Это отличный способ расслабиться и зарядиться энергией!");
                break;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}. Пожалуйста, повторите ввод.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nПроизошла непредвиденная ошибка: {ex.Message}");
                break; // Выход из цикла при непредвиденной ошибке
            }
        } //конец цикла while

        Console.WriteLine("\nСпасибо за участие в опросе! Надеюсь, вам понравилось.");
    }
}
   
