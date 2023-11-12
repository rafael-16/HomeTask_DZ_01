/*
 * DZ_02
 * Задача:
Легенда:
Вы приходите в магазин и хотите купить за своё золото кристаллы. В вашем кошельке есть какое-то количество золота,
продавец спрашивает у вас, сколько кристаллов вы хотите купить? После сделки у вас остаётся какое-то количество золота и появляется какое-то количество кристаллов.

Формально:
При старте программы пользователь вводит начальное количество золота. Потом ему предлагается купить какое-то
количество кристаллов по цене N(задать в программе самому). Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран.
 */

int countGold;            //количество золота
int countCrystals = 0;    //количество кристаллов
int priceCrystals = 3;    //стоимость кристалла

int canBay;     //сколько могу купить
int wantBay;    //сколько необходимо купить

bool canIBay;

Console.Write("Введите кол-во имеющегося у вас золота: ");
countGold = Convert.ToInt32(Console.ReadLine());
canBay = countGold / priceCrystals;

Console.WriteLine($"\nВы можете купить {canBay} кристаллов\n" +
    $"по цене {priceCrystals} золота за кристалл.\n");

Console.Write($"Сколько нужно купить кристаллов: ");
wantBay = Convert.ToInt32(Console.ReadLine());

canIBay = wantBay <= canBay;

countGold -=  priceCrystals * wantBay * Convert.ToInt32(canIBay);
countCrystals +=  wantBay * Convert.ToInt32(canIBay);
Console.WriteLine($"\nТеперь у вас:\n - кристаллов {countCrystals};\n - золота {countGold}.");