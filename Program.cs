Console.Write("Введите цифрой размер массива: ");
int n = int.Parse(Console.ReadLine());

string[] array = new string[n];

for(int index = 0; index < n; index++)
{
	Console.Write($"Введите {index+1} значение: ");
	array[index] = Console.ReadLine();
}

Console.Write("[");

for(int i = 0; i < array.Length; i++)
{
		Console.Write(array[i] + ", ");
}
Console.Write("] -> ");


Console.Write("[");

for(int i = 0; i < array.Length; i++)
{
	if(array[i].Length <= 3)
	{
		Console.Write(array[i] + ", ");
		
	}
}
Console.Write("]");
