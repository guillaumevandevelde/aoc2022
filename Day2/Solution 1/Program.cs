var plays = File.ReadAllLines("../Input.txt");
int totalScore = 0;

Dictionary<string, (string draw, string win, int score )> actions = 
    new () {
        {"X",("A","C",1)},
        {"Y",("B","A",2)},
        {"Z",("C","B",3)}
    };

int calculateScore(string opponent, string player)
{
    int result = 0;

    if(opponent == actions[player].draw)
    {
        return result = actions[player].score + 3;
    }
    else if(opponent == actions[player].win)    {
        return result = actions[player].score + 6;
    }
   
    return result = actions[player].score;  
}

    
plays.ToList().ForEach(play => {
     totalScore += calculateScore(play.Split(" ")[0], play.Split(" ")[1]);
});

Console.WriteLine($"Total Score: {totalScore}");


     








