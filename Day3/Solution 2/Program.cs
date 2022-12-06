string[] rucksacks = File.ReadAllLines("../Input");
int sum = 0;

sum = rucksacks.Chunk(3)
     .Select(threeSacks =>
		{
			var letter = threeSacks.ElementAt(0)
						.Intersect(threeSacks.ElementAt(1))
						.Intersect(threeSacks.ElementAt(2))
						.Single();
			return Char.IsLower(letter)
			? (int)letter - 96
			: (int)letter - 38;
		}).Sum();

Console.WriteLine(sum);