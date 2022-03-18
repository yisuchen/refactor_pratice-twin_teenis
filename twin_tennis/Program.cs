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


    public String score()
    {
        string love = "love";
        string fifteen = "fifteen";
        string thirty = "thirty";
        string forty = "forty";
        if (firstPlayerScoreTimes == 0 && secondPlayerScoreTimes == 0)
        {
            return love + " " + all;
        }
        if (firstPlayerScoreTimes == 1 && secondPlayerScoreTimes == 0)
        {
            return fifteen + " " + love;
        }
        if (firstPlayerScoreTimes == 2 && secondPlayerScoreTimes == 0)
        {
            return thirty + " " + love;
        }
        if (firstPlayerScoreTimes == 3 && secondPlayerScoreTimes == 0)
        {
            return forty + " " + love;
        }

        if (firstPlayerScoreTimes == 0 && secondPlayerScoreTimes == 1)
        {
            return love + " " + fifteen;
        }
        if (firstPlayerScoreTimes == 0 && secondPlayerScoreTimes == 2)
        {
            return love + " " + thirty;
        }
        if (firstPlayerScoreTimes == 0 && secondPlayerScoreTimes == 3)
        {
            return love + " " + forty;
        }
        if (firstPlayerScoreTimes == 1 && secondPlayerScoreTimes == 1)
        {
            return fifteen + " " + all;
        }
        if (firstPlayerScoreTimes == 2 && secondPlayerScoreTimes == 2)
        {
            return thirty + " " + all;
        }
        if (firstPlayerScoreTimes == 3 && secondPlayerScoreTimes == 3)
        {
            return duece;
        }
        if (firstPlayerScoreTimes == 4 && secondPlayerScoreTimes == 4)
        {
            return duece;
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
