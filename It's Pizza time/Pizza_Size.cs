

namespace It_s_Pizza_time
{
    public class PizzaSize
    {
        public string Name { get; set; }
        public float Price { get; set; }
    }

    public class SmallPizza : PizzaSize
    {
        public SmallPizza()
        { 
           Name = "Small Pizza";
            Price = 9.99f;

        }
        public class MediumPizza : PizzaSize
        {
            public MediumPizza()
            {
               Name = "Medium Pizza";
                Price = 12.22f;
            }

        public class LargePizza : PizzaSize
            {
                public LargePizza()
                {
                    Name = "Large Pizza";
                    Price = 15.00f;
                }
            }

        }
    }
}









