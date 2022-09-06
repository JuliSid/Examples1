// Конвертировать инт в строчку с помощью чар

int num = 8975;
string result = Convert.ToString(num);

int sum = (int) char.GetNumericValue(result[0]);
Console.WriteLine(sum);