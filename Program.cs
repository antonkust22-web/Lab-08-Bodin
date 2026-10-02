// See https://aka.ms/new-console-template for more information
// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons) {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"подсчёт количества введённых оценок {count}");

using System.ComponentModel.DataAnnotations;

// int sum = 0;
// int count = 0;
// int max = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
//     if (grade > max) max = grade;
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

// Console.WriteLine($"наибольшая из введённых оценок {max}");

string correctPassword = "qwerty123";
int count = 0;

while (true)
{
    Console.Write("Введите пароль от личного кабинета: ");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }
    else if (password != correctPassword)
    {
        count++;
    }
    Console.WriteLine("Неверный пароль, попробуйте снова");
}

Console.WriteLine($"Неудачных попыток {count}");