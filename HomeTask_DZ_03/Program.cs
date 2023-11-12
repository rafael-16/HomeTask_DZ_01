/*
 * DZ_03
 * Задача:
Легенда:

Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.

Формально:
Пользователь вводит кол-во людей в очереди.
Фиксированное время приема одного человека всегда равно 10 минутам.
Пример ввода: Введите кол-во старушек: 14
Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."
 */

int countPeople;        //количество людей в очереди
int timePeople = 10;    //количество времени на прием человека в минутах
int countMinutes;       //
int countHours;         //

Console.Write($"Введите кол-во людей в очереди: ");
countPeople = Convert.ToInt32(Console.ReadLine());

countHours = (countPeople * timePeople) / 60;
countMinutes = (countPeople * timePeople) % 60;
Console.WriteLine($"Вы будете ждать {countHours} ч {countMinutes} м");