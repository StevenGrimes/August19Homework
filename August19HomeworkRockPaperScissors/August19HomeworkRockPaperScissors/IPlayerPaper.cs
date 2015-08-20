namespace August19HomeworkRockPaperScissors
{
    interface IPlayerPaper
    {
        int NumberOfWins { get; set; }

        string Act();
    }
}