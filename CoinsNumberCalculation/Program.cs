using CoinsNumberSolution;

// сумма денег
int a = 22;

// возможные номиналы монет
int[] c = {1 ,3, 5};

var coinsNumber = CoinsNumber.GetMinCoins(a, c);

if (coinsNumber == -99)
    Console.WriteLine("Невозможно составить сумму");
else
    Console.WriteLine($"Минимальное количество монет - {coinsNumber}");
