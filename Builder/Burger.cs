using System;

namespace Builder
{


    public class Burger
    {
        public int NumPatties { get; set; } = 1;
        public bool Cheese { get; set; }
        public bool Bacon { get; set; }
        public bool Pickles { get; set; }
        public bool Lettuce { get; set; }
        public bool Tomato { get; set; }

        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("Burger: ------- \n");
            builder.Append($" With {NumPatties} Patties\n");
            builder.Append(Cheese ? " With Cheese\n" : "");
            builder.Append(Bacon ? " With Bacon\n" : "");
            builder.Append(Pickles? " With Pickles\n" : "");
            builder.Append(Lettuce ? " With Lettuce\n" : "");
            builder.Append(Tomato ? " With Tomato\n" : "");

            return builder.ToString();
        }

        public class BurgerBuilder
        {
            private readonly Burger _burger = new Burger();
            public Burger Build() {
                return _burger;
            }

            public BurgerBuilder WithPatties(int num)
            {
                _burger.NumPatties = num;
                return this;
            }

            public BurgerBuilder WithCheese()
            {
                _burger.Cheese = true;
                return this;
            }

            public BurgerBuilder WithBacon()
            {
                _burger.Bacon = true;
                return this;
            }

            public BurgerBuilder WithPickles()
            {
                _burger.Pickles = true;
                return this;
            }

            public BurgerBuilder WithLettuce()
            {
                _burger.Lettuce = true;
                return this;
            }
            
            public BurgerBuilder WithTomato()
            {
                _burger.Tomato = true;
                return this;
            }
        }
    }
}
