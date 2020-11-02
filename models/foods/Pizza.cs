public class Pizza : Food {
    public override string _description {get;set;}
    public override double _cost {get;set;}

    public Pizza(){
        _description = "A pizza is a bottom crusted dish with a sauce, cheeses, and other toppings.";
        _cost = 10.3;
    }
}