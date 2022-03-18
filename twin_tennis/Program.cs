// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Tennis
{
    private const string all = "all";
    private const string duece = "duece";
    private const string FirstPlayer = "Joey";
    private const string SecondPlayer = "Tom";
    private int secondPlayerScoreTimes;
    private int firstPlayerScoreTimes;

    private readonly Dictionary<int, string> map = new Dictionary<int, string>()
        {
            {0,"love" },
            {1, "fifteen" },
            {2, "thirty" },
            {3, "forty" },
        };

    public String score()
    {
        if (firstPlayerScoreTimes == 0 && secondPlayerScoreTimes == 0)
        {
            return map[firstPlayerScoreTimes] + " " + all;
        }
        if (firstPlayerScoreTimes == 1 && secondPlayerScoreTimes == 1)
        {
            return map[firstPlayerScoreTimes] + " " + all;
        }
        if (firstPlayerScoreTimes == 2 && secondPlayerScoreTimes == 2)
        {
            return map[firstPlayerScoreTimes] + " " + all;
        }
        if (firstPlayerScoreTimes == 3 && secondPlayerScoreTimes == 3)
        {
            return duece;
        }
        if (firstPlayerScoreTimes == 4 && secondPlayerScoreTimes == 4)
        {
            return duece;
        }


        if (firstPlayerScoreTimes < 4 && secondPlayerScoreTimes == 0)
        {
            return map[firstPlayerScoreTimes] + " " + map[secondPlayerScoreTimes];
        }

        if (firstPlayerScoreTimes == 0 && secondPlayerScoreTimes < 4)
        {
            return map[firstPlayerScoreTimes] + " " + map[secondPlayerScoreTimes];
        }


        if (firstPlayerScoreTimes == 4 && secondPlayerScoreTimes == 3)
        {
            return FirstPlayer + " adv";
        }
        if (firstPlayerScoreTimes == 3 && secondPlayerScoreTimes == 4)
        {
            return SecondPlayer + " adv";
        }
        if (firstPlayerScoreTimes == 5 && secondPlayerScoreTimes == 3)
        {
            return FirstPlayer + " win";
        }
        if (firstPlayerScoreTimes == 3 && secondPlayerScoreTimes == 5)
        {
            return SecondPlayer + " win";
        }
        return null;
    }

    public void firstPlayerScore()
    {
        this.firstPlayerScoreTimes++;
    }

    public void secondPlayerScore()
    {
        this.secondPlayerScoreTimes++;
    }
}
