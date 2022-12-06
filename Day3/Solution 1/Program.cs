string[] rucksacks = File.ReadAllLines("../input");
int sum = 0;

rucksacks.ToList().ForEach(rucksack => {

    IEnumerable<char> compartment1 = rucksack.Take(rucksack.Length / 2);
    IEnumerable<char> compartment2 = rucksack.Skip(rucksack.Length / 2);
    compartment1.Where(item => compartment2.Contains(item))
                .Distinct()
                .ToList()
                .ForEach(item => {
                  sum += Char.IsLower(item)
			        ? (int)item - 96
			        : (int)item - 38;
                });
    
});

Console.WriteLine(sum);