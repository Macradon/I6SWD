public class Pizza : Food {
    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}

    //Constructor
    public Pizza(){
        _description = "A pizza is a bottom crusted dish with a sauce, cheeses, and other toppings.";
        _cost = 10.3;
    }
}