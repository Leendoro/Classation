public class EternalGoal : Goal
{
    private int incrementPoints;

    public EternalGoal(string name, int incrementPoints)
    {
        this.name = name;
        this.incrementPoints = incrementPoints;
        this.isCompleted = false; // Always false as it never completes.
    }

    public override void RecordProgress()
    {
        points += incrementPoints;
    }

    public override string GetStatus()
    {
        return $"{name}: [∞] ({points} points)";
    }
}





// public class EternalGoal : Goal
// {
//     public EternalGoal(string name, int points) : base(name, points) { }

//     public override void RecordProgress()
//     {
//         // Always add points
//     }

//     public override string GetStatus()
//     {
//         return $"[∞] {Name}";
//     }

//     public override string Serialize()
//     {
//         return $"EternalGoal:{Name},{Points}";
//     }
// }
