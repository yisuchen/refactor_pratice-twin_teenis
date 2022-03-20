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
            return isOver3() ? duece : SameScore();

        if (isNeedCheck())
            return CheckScore();

        return string.Format("{0} {1}", advPlayer(), isAdv() ? "adv" : "win");
    }

    private bool isAdv()
    {
        return Math.Abs(firstPlayerScoreTimes - secondPlayerScoreTimes) == 1;
    }

    private string advPlayer()
    {
        string advPlayer;
        if (firstPlayerScoreTimes > secondPlayerScoreTimes)
            advPlayer = FirstPlayer;
        else
            advPlayer = SecondPlayer;
        return advPlayer;
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
        return string.Format("{0} {1}", map[firstPlayerScoreTimes], all);
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
