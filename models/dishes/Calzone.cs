public class Calzone : Food {
    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}

    //Constructor
    public Calzone(){
        _description = "Calzone";
        _cost = 55.00;
    }
}