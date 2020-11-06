public class Pizza : Food
{
    //Constructor
    public Pizza()
    {
        _description = "Pizza";
        _cost = 65.00;
    }

    //Property implementations
    public override string _description {get;set;}
    public override double _cost {get;set;}
}