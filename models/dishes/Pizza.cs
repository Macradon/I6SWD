public class Pizza : Food {
    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}

    //Constructor
    public Pizza(){
        _description = "Pizza";
        _cost = 65.00 ;
    }
}