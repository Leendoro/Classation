public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isCompleted;

    public string Name => name;
    public int Points => points;
    public bool IsCompleted => isCompleted;

    public abstract void RecordProgress();
    public abstract string GetStatus();
}




// public abstract class Goal
// {
//     public string Name { get; set; }
//     public int Points { get; protected set; }
//     public bool IsCompleted { get; protected set; }

//     public Goal(string name, int points)
//     {
//         Name = name;
//         Points = points;
//         IsCompleted = false;
//     }

//     public abstract void RecordProgress();
//     public abstract string GetStatus();
//     public abstract string Serialize();
// }
