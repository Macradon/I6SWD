public class Sandwich : Food
{
    //Constructor
    public Sandwich()
    {
        _description = "Sandwich";
        _cost = 60.00;
    }

    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}
}