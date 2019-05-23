using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_11
{
    public class KingdomAnimal
    {
        string name;
        int weight;

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }         
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public KingdomAnimal(int weight, string name)
        {
            Name = name;
            Weight = weight;
        }
        virtual public Dictionary<string, string> ReturnValue()
        {
            Dictionary<string, string> animalParameters = new Dictionary<string, string>();

            animalParameters.Add("weight", Weight.ToString());
            animalParameters.Add("name",Name);

            return animalParameters;
        }
    }
}
