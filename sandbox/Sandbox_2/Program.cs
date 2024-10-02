namespace Sandbox_2;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile";
        nurse.shoes = "orthepedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        nurse.ShowWardrobe();
    }
}
