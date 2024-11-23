using System.Threading.Tasks.Dataflow;

public class SimpleGoal : Goal {
    public override string GetStringRep()
    {
        return $"{GetName()}|{GetDesc()}|{GetPoint()}|{GetDone()}|SimpleGoal";
    }
}