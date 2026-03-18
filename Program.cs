Console.WriteLine("Statistics app - feature branch");
int result = StatisticsHelper.Sum(2, 3);
Console.WriteLine($"Sum: {result}");

double average = StatisticsHelper.Average(new[] {1, 2, 3});
Console.WriteLine($"Average: {average}");

int max = StatisticsHelper.Max(new[] {1, 2, 3});
Console.WriteLine($"Max: {max}");

int min = StatisticsHelper.Min(new[] {1, 2, 3});
Console.WriteLine($"Min: {min}");