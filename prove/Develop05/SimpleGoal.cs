public class SimpleGoal : Goal
{
    private int completionPoints;

    public SimpleGoal(string name, int completionPoints)
    {
        this.name = name;
        this.completionPoints = completionPoints;
        this.isCompleted = false;
    }

    public override void RecordProgress()
    {
        if (!isCompleted)
        {
            points += completionPoints;
            isCompleted = true;
        }
    }

    public override string GetStatus()
    {
        return $"{name}: {(isCompleted ? "[X]" : "[ ]")}";
    }
}



// public class SimpleGoal : Goal
// {
//     public SimpleGoal(string name, int points) : base(name, points) { }

//     public override void RecordProgress()
//     {
//         if (!IsCompleted)
//         {
//             IsCompleted = true;
//             // Award points once
//         }
//     }

//     public override string GetStatus()
//     {
//         return IsCompleted ? $"[X] {Name}" : $"[ ] {Name}";
//     }

//     public override string Serialize()
//     {
//         return $"SimpleGoal:{Name},{Points},{IsCompleted}";
//     }
// }
