/*
 *DZ_04
 * Задача:
Вы задаете вопросы пользователю, по типу "Как вас зовут", "какой ваш знак зодиака" и тд, после чего по данным, которые он ввел формируете небольшой текст о пользователе.

"Вас зовут Алексей, вам 21 год, вы водолей и работает на заводе."
 */
Console.Write("Введите ваше имя: ");
string firstName = Console.ReadLine()!;

Console.Write("Введите вашу фамилию: ");
string lastName = Console.ReadLine()!;

Console.Write("Введите ваш знак зодиака: ");
string signZodiac = Console.ReadLine()!;

Console.Write("Введите ваш возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите место работы: ");
string placeWork = Console.ReadLine()!;

Console.WriteLine($"Вас зовут {firstName} {lastName},");
Console.WriteLine($"ваш возраст {age}, ваш зодиак: {signZodiac},");
Console.WriteLine($"вы работаете на {placeWork}.");