public abstract class Food
{
    //Default constructor
    public Food()
    {
        _description = "Unspecified food.";
        _cost = 0.00;
    }

    public abstract string _description { get; set; }
    public abstract double _cost { get; set; }
}