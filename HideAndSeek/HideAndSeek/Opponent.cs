using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location location)
        {
            myLocation = location;
            random = new Random();
        }

        public void Move()
        {
            bool hidden = false;

            while(!hidden)
            {
                if (myLocation is IHasExteriorDoor && random.Next(2) > 0)
                {
                    IHasExteriorDoor hasDoor = myLocation as IHasExteriorDoor;
                    myLocation = hasDoor.DoorLocation;
                }
                int randNumber = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[randNumber];

                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }

        public bool Check(Location location)
        {
            return location == myLocation;
        }

    }
}
