var data =  File.ReadAllLines("input.txt").ToList();
List<int> calories = data.Select(s => (s.Length > 0) ? int.Parse(s) : 0).ToList();

var caloriesPerElf = new List<int>(data.Count){0};
foreach(var calorie in calories) if (calorie == 0) caloriesPerElf.Add(0); else caloriesPerElf[caloriesPerElf.Count - 1] += calorie;

Console.WriteLine($"Maximum: {caloriesPerElf.Max()}");
Console.WriteLine($"Top 3: {caloriesPerElf.OrderByDescending(c => c).Take(3).Sum()}");