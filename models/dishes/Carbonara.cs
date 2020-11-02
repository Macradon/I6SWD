public class Carbonara : Food {
    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}

    //Constructor
    public Carbonara(){
        _description = "Past description.";
        _cost = 6.9;
    }
}