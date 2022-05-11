// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

public class Tennis
{
    private int _secondPlayerScoreTimes;
    private int _firstPlayerScoreTimes;
    private const string Deuce = "deuce";
    private const string FirstPlayer = "Joey";
    private const string SecondPlayer = "Tom";

    private readonly Dictionary<int, string> _lookup = new()
    {
        { 0, "love" },
        { 1, "fifteen" },
        { 2, "thirty" },
        { 3, "forty" }
    };

    public string Score()
    {
        if (_firstPlayerScoreTimes < 4 && _secondPlayerScoreTimes < 4)
        {
            if (!IsSameScore()) return CheckScore();
            return IsOver3() ? Deuce : SameScore();
        }

        return $"{AdvPlayer()} {IsAdv()}";
    }

    private string CheckScore()
    {
        return _lookup[_firstPlayerScoreTimes] + " " + _lookup[_secondPlayerScoreTimes];
    }

    private string SameScore()
    {
        return $"{_lookup[_firstPlayerScoreTimes]} all";
    }


    public void FirstPlayerScore()
    {
        this._firstPlayerScoreTimes++;
    }

    public void SecondPlayerScore()
    {
        this._secondPlayerScoreTimes++;
    }


    private bool IsSameScore()
    {
        return _firstPlayerScoreTimes == _secondPlayerScoreTimes;
    }

    private bool IsOver3()
    {
        return _firstPlayerScoreTimes >= 3;
    }

    private string AdvPlayer()
    {
        return _firstPlayerScoreTimes > _secondPlayerScoreTimes ? FirstPlayer : SecondPlayer;
    }

    private string IsAdv()
    {
        if (Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1)
            return "adv";
        return "win";
    }
}