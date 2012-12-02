using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TheKitchen.Model.Models;
using TheKitchen.UnitOfMeasurements;

namespace TheKitchen.Converters.CoreConverters
{
    public class RecipeMLConverter : IRecipeConverter
    {
        RecipeML.NewDataSet d = new RecipeML.NewDataSet();

        public Model.Models.Recipe ToRecipe()
        {
            Recipe ret = new Recipe();
            string title = d.head.Rows[0][d.head.titleColumn.ColumnName] as string;
            ret.Title = title;

            foreach (var ing in d.ing)
            {
                var id = ing.ing_Id;
                var item = ing.item;
                TheKitchen.Converters.CoreConverters.RecipeML.NewDataSet.amtRow qty = d.amt.FirstOrDefault(p => p.ing_Id == id);
                var qtyVal = ParseQty(qty);
                if (qtyVal == null)
                    throw new ApplicationException(string.Format("Exception reading ingredient ID {0}", id));

                RecipeIngredient recipeItem = new RecipeIngredient(qtyVal, new Ingredient(item));
                ret.IngredientsRequired.Add(recipeItem);
            }

            return ret;
        }

        private IMeasurementValue ParseQty(RecipeML.NewDataSet.amtRow amt)
        {
            var qty = amt.qty;
            var unit = !amt.IsunitNull() ? amt.unit : "unit";
            return(ParseMeasure.Parse(qty, unit)); 
        }

        public void Load(string recipeML)
        {
            StringReader reader = new StringReader(recipeML);
            d.ReadXml(reader);
        }
    }
}
