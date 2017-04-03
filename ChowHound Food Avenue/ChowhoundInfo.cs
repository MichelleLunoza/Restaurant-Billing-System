using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowhound_Food_Avenue
{
    public class ChowhoundInfo
    {
        public ChowhoundInfo()
        {
        }

        public string Order_No { get; set; }
        public DateTime Date { get; set; }
        public string BuffetMeal { get; set; }
        public string PlateOfTheDay { get; set; }
        public string Sisig { get; set; }
        public string Dynamite { get; set; }
        public string BuffaloWings { get; set; }
        public string LechonKawali { get; set; }
        public string PotatoFries { get; set; }
        public string PotatoWedge { get; set; }
        public string CrispyPataWhole { get; set; }
        public string CrispyPataHalf { get; set; }
        public string Samyupsal { get; set; }
        public string SanMigLightsBucket { get; set; }
        public string SanMigLightsPerBottle { get; set; }
        public string SMBPalePilsenBucket { get; set; }
        public string SMBPalePilsenPerBottle { get; set; }
        public string TotalMealOrder { get; set; }
        public string TotalDrinks { get; set; }
        public string GrandTotal { get; set; }
        public string Cash { get; set; }
        public string Change { get; set; }
        public static CultureInfo CurrentCulture { get; set; }

        //Login
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SecurityCode { get; set; }
    }
}
