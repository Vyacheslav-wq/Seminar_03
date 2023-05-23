//РАЗВОРОТ МАССИВА В ОБРАТНОМ ПОРЯДКЕ.
Console.Clear();
Console.Write("Наш массив: ");
int[] myArrey = { 8, 2, 5, 9, 3, 5, 7 };
for (int i = 0; i < 7; i++)
{
    Console.Write($"{myArrey[i]}, ");
}
Console.WriteLine();
Console.Write("А это массив в обратном порядке: ");
for (int i = 7 - 1; i >= 0; i--)
{
    Console.Write($"{myArrey[i]}, ");
}