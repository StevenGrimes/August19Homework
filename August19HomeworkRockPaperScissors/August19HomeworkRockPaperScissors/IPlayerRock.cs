namespace August19HomeworkRockPaperScissors
{
    interface IPlayerRock
    {
        int NumberOfWins { get; set; }

        string Act();
    }
}