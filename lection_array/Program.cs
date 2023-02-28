double bankDeposit = Convert.ToDouble(Console.ReadLine());
double sum = 0.0;

if (bankDeposit < 100)
    sum = bankDeposit + (bankDeposit * 0.05);
else if (bankDeposit > 100 && bankDeposit <= 200)
    sum = bankDeposit + (bankDeposit * 0.07);
else if (bankDeposit > 200)
    sum = bankDeposit + (bankDeposit * 0.1);


Console.WriteLine($"Сумма вклада после начисления процентов: {sum}");