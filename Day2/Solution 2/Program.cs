var plays = File.ReadAllLines("../Input.txt");
int totalScore = 0;

Dictionary<string, (string lose, string win, int score )> actions = 
    new () {
        {"A",("C","B",(1))},
        {"B",("A","C",(2))},
        {"C",("B","A",(3))}
    };

int calculateScore(string opponent, string player)
{
    int result = 0;

    if (player == "Z"){
       //Win
        return result = actions[actions[opponent].win].score + 6;
    }   
    else if(player == "Y"){
        //draw
        return result = actions[opponent].score + 3;
    }
        
    return result = actions[actions[opponent].lose].score;   
}

    
plays.ToList().ForEach(play => {
     totalScore += calculateScore(play.Split(" ")[0], play.Split(" ")[1]);
});

Console.WriteLine($"Total Score: {totalScore}");


     








