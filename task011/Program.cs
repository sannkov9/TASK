// Напишите программу которая выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {num}");
int DeleteCenter(int num)
{
    int first = num / 100;
    int third = num % 10;
    int answer = first * 10 + third;
    return answer;
}
// int deleteCenter = DeleteCenter(num);
Console.WriteLine($"Двузнаное число {DeleteCenter(num)}");