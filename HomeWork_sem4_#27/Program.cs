Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number){
    
    int count = Convert.ToString(number).Length;
    int s = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      s = number - number % 10;
      result = result + (number - s);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе = " + sumNumber);