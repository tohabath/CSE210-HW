// Class ("a method or folder of functions"; "library")
class Costume
{
    // Attributes (Member Variables)
    public string headWear;
    public string gloves;
    public string shoes;
    public string upperGarment;
    public string lowerGarment;
    public string accessory;
    // Behaviors
    public void ShowWardrobe()
    {
        string result = "";
        result += $"Head: {headWear}\n";
        result += $"Shoes: {shoes}\n";
        result += $"Torso: {upperGarment}\n";
        result += $"Legs: {lowerGarment}\n";
        result += $"Gloves: {gloves}\n";
        result += $"Accessory: {accessory}\n";
        System.Console.WriteLine(result);
    }
}