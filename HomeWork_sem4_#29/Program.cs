var array = new int[8];

for(int i = 0; i <= array.Length - 1; i++) {
    array[i] = GenerateDigit();    
}

int GenerateDigit() 
{
    Random randomNumber = new Random();
    return randomNumber.Next(100);
}

Console.WriteLine("[{0}]", string.Join(", ", array));