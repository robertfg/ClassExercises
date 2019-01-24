using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndStatics
{
    class PlantRevised : IPlant
    {
        public int Test { get; private set; }

        public void GrowthRate()
        {
            int test = this.Test;
            string anotherTest = GetString();

            throw new NotImplementedException();
        }

        private string GetString()
        {
            throw new NotImplementedException();
        }
    }
}
