public class Carbonara : Food {
    public override string _description {get;set;}
    public override double _cost {get;set;}

    public Carbonara(){
        _description = "Past description.";
        _cost = 6.9;
    }
}