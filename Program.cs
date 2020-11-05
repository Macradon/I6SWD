using System;

namespace I6SWD
{
    class Program
    {
        static void Main(string[] args)
        {
            //We want a pizza with marinara sauce and mozzarella cheese
            Pizza pizza1 = new Pizza();
            Marinara marinara1 = new Marinara(pizza1);
            Mozzarella mozzarella1 = new Mozzarella(marinara1);
            Console.WriteLine("We want a " + mozzarella1._description);
            Console.WriteLine("Which costs: " + mozzarella1._cost + ",-\n");

            //We want a calzone with bechamel sauce, cheddar cheese, sausage, and pineapple
            Calzone calzone2 = new Calzone();
            Bechamel bechamel2 = new Bechamel(calzone2);
            Cheddar cheddar2 = new Cheddar(bechamel2);
            Sausage sausage2 = new Sausage(cheddar2);
            Pineapple pineapple2 = new Pineapple(sausage2);
            Console.WriteLine("We want a " + pineapple2._description);
            Console.WriteLine("Which costs: " + pineapple2._cost + ",-\n");

            //We want a sandwich with mayonnaise, gorgonzola cheese, bacon, and sausage
            Sandwich sandwich3 = new Sandwich();
            Mayonnaise mayonnaise3 = new Mayonnaise(sandwich3);
            Gorgonzola gorgonzola3 = new Gorgonzola(mayonnaise3);
            Bacon bacon3 = new Bacon(gorgonzola3);
            Sausage sausage3 = new Sausage(bacon3);
            Console.WriteLine("We want a " + sausage3._description);
            Console.WriteLine("Which costs: " + sausage3._cost + ",-\n");
        }
    }
}
