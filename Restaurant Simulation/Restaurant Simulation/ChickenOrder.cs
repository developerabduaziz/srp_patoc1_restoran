using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Simulation
{
    internal class ChickenOrder
    {
        private int _quantity;

        public ChickenOrder(int quantity)
        {
            _quantity = quantity;
        }

        int GetQuantity()
        {
            return this._quantity;
        }


        void CutUp() 
        { 

        }
        void Cook()
        {

        }


    }
}
