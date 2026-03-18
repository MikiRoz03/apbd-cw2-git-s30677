Console.WriteLine("Statistics app");
int result = StatisticsHelper.Sum(2, 3);
Console.WriteLine($"Sum: {result}");

double average = StatisticsHelper.Average(new[] {1, 2, 3});
Console.WriteLine($"Average: {average}");