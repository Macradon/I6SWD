
public abstract class Food {
    public abstract string _description { get; set; }
    public abstract double _cost { get; set; }

    //Default constructor
    public Food() {
        _description = "Unspecified food.";
        _cost = 0.00;
    }

    public Food(string description, float cost) {
        _description = description;
        _cost = cost;
    }
}