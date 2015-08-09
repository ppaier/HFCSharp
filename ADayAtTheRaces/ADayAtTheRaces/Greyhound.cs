using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            Location += 10*Randomizer.Next(4);
            MyPictureBox.Left = StartingPosition + Location;

            return MyPictureBox.Right > RacetrackLength;
        }

        public void TakingStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }

    }



}
