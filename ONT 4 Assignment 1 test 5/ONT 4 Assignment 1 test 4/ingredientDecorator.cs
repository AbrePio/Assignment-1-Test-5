using System;
using System.Collections.Generic;
using System.Text;

namespace ONT_4_Assignment_1_test_4
{
    abstract class ingredientDecorator:Ingredient
    {
        //private Ingredient ingredient;
        ////public ingredientDecorator(Ingredient ing)
        ////{
        ////    ingredient = ing;
        ////}

        //public override void GetDiscription()
        //{
        //    ingredient.GetDiscription();
        //}

        //public override void Cost()
        //{
        //    ingredient.Cost();
        //}

        // ---------------testing decorator
        Ingredient ingredient = null;
        protected string Description = "";
        protected int Price1 = 0;
        public ingredientDecorator(Ingredient ingredient)
        {
            this.ingredient = ingredient;
            //GetDiscription();
            //Cost();
        }
        public override string GetDiscription()
        {
            //return ingredient.GetDiscription();
            return Description + " " + ingredient.GetDiscription();
        }
        public override int Cost()
        {
            return ingredient.Cost() + Price1;
        }
        // ending ----------------testing decorator
    }
}
