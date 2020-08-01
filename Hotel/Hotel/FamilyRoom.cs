using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber) : base(roomNumber)
        {
            _price = 100;
            
        }

        protected override void SetFeatrues()
        {
            _features = "TV, minibar, king size bed";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
