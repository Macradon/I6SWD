public class Calzone : Food {
    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}

    //Constructor
    public Calzone(){
        _description = "A Calzon is a baked dough wrapped dish with sauce, cheese, and toppings.";
        _cost = 8.7;
    }
}