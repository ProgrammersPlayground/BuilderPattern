using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnaPizza
{
    public class PizzaBuilder
    {
        private readonly Pizza _pizza;
        public PizzaBuilder()
        {
            _pizza = new Pizza(); 
        }
        public PizzaBuilder SetSize(string size)
        {
            _pizza.Size = size;
            return this;
        }
        public PizzaBuilder AddCheese()
        {
            _pizza.HasCheese = true;
            return this;
        }
        public PizzaBuilder AddPepperoni()
        {
            _pizza.HasPepperoni = true;
            return this;
        }
        public PizzaBuilder AddTomatoes()
        {
            _pizza.HasTomatoes = true;
            return this;
        }
        public PizzaBuilder AddOlives()
        {
            _pizza.HasOlives = true;
            return this;
        }
        public Pizza Build()
        {
            return _pizza;
        }
    }
}
