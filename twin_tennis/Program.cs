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
        if (isSameScore())
        {
            if (isOver3())
                return duece;

            return SameScore();
        }

        if (isNeedCheck())
            return CheckScore();


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

    private bool isNeedCheck()
    {
        return firstPlayerScoreTimes < 4 && secondPlayerScoreTimes < 4;
    }

    private bool isSameScore()
    {
        return firstPlayerScoreTimes == secondPlayerScoreTimes;
    }

    private bool isOver3()
    {
        return firstPlayerScoreTimes >= 3;
    }

    private string SameScore()
    {
        return map[firstPlayerScoreTimes] + " " + all;
    }

    private string CheckScore()
    {
        return map[firstPlayerScoreTimes] + " " + map[secondPlayerScoreTimes];
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
