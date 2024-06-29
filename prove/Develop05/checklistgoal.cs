public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int targetCount, int pointsPerCompletion, int bonusPoints)
    {
        this.name = name;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.points = pointsPerCompletion;
        this.currentCount = 0;
    }

    public override void RecordProgress()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            points += points;
            if (currentCount == targetCount)
            {
                points += bonusPoints;
                isCompleted = true;
            }
        }
    }

    public override string GetStatus()
    {
        return $"{name}: [{currentCount}/{targetCount}]";
    }
}






// public class ChecklistGoal : Goal
// {
//     public int TargetCount { get; private set; }
//     public int CurrentCount { get; private set; }
//     public int BonusPoints { get; private set; }

//     public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
//         : base(name, points)
//     {
//         TargetCount = targetCount;
//         BonusPoints = bonusPoints;
//         CurrentCount = 0;
//     }

//     public override void RecordProgress()
//     {
//         if (CurrentCount < TargetCount)
//         {
//             CurrentCount++;
//             if (CurrentCount == TargetCount)
//             {
//                 IsCompleted = true;
//                 // Add bonus points
//             }
//         }
//     }

//     public override string GetStatus()
//     {
//         return IsCompleted ? $"[X] {Name} (Completed {CurrentCount}/{TargetCount} times)" :
//                              $"[ ] {Name} (Completed {CurrentCount}/{TargetCount} times)";
//     }

//     public override string Serialize()
//     {
//         return $"ChecklistGoal:{Name},{Points},{CurrentCount},{TargetCount},{BonusPoints},{IsCompleted}";
//     }
// }
