// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задание 1.1
for (int i = 10; i <= 1; i--){
    Console.WriteLine(i);
}
// Задание 1.2
for (int i = 2; i <= 50; i += 2) {
    Console.WriteLine(i)
}

// Задание 2
int sum3 = 0;
int count7 = 0;
for (int i = 1; i <= 100; i++) {
    if (i % 3 == 0) sum3 +=i;
    if (i % 7 == 0) count7++;
}
Console.Writeline($"Сумма кратных 3: {sum3}");
Console.WriteLine($"Количество кратных 7: {count7}");

// Задание 3
int number = Convert.ToInt32(Console.Readline());
int positive = 0, negative = 0;
while (number != 0) {
    if (number > 0) positive++;
    else negative++;
    number = Convert.ToInt32(Console.Readline());
}
Console.WriteLine($"Положительных: {positive}");
Console.WriteLine($"Отрицательных: {negative}");

// Задание 4
bool accessGranted = false;
for (int attempt = 1; attempt <= 3; attempt++){
    Console.Write($"Попытка{attempt}.Введите пароль:");
    string password = Console.Readline();
    if (password == "qwerty"){
        Console.WriteLine("Доступ разрешён");
        accessGranted = true;
        break;
        if (!accessGranted)
        Console.WriteLine("Доступ заблокирован");

    }
}
// Задание 5
Console.WriteLine("Введите число от 1 до 9");
int n = Convert.ToInt32(Console.Readline());
for (int i = 1; i <= 10; i++) {
    Console.WriteLine($"{n} x {i} = {n * i}");
}
// Задание 6
for (int i = 1; i <= 30; i++) {
    if (i % 3 == 0)continue;
    if (i % 10 == 0 && i> 20) break;
    Console.WriteLine(i);
}
// Итоговая задача
int secret = 42;
bool quessed = false;
for (int attempt = 1; attempt <= 5; attempt++) {
    Console.Write($"Попытка {attempt}.Введите число: ");
    int guess = Convert.ToInt32(Console.Readline);
    if (guess == secret) {
        Console.WriteLine($"Победа! Попыток: {attempt}");
        guessed = true;
        break;
    } else if (guess < secret) {
        Console.WriteLine("Больше");
    } else {
        Console.WriteLine("Меньше");
    }
}
if (!guessed) Console.WriteLine($"Вы проиграли, число было {secret}");