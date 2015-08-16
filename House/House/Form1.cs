using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House
{

    public partial class Form1 : Form
    {
        private Location currentLocation;

        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;


        public Form1()
        {
            InitializeComponent();
            CreateLocations();
            MoveToANewLocation(livingRoom);
        }

        private void CreateLocations()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a chrystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainles steel appliances", "a screen door");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { livingRoom };

            frontYard.Exits = new Location[] { garden };
            backYard.Exits = new Location[] { garden };
            garden.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }
    

        private void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            comboBoxLocation.Items.Clear();

            foreach(Location l in currentLocation.Exits)
            {
                comboBoxLocation.Items.Add(l.Name);
            }
            comboBoxLocation.SelectedIndex = 0;
            textBoxDescription.Text = currentLocation.Description;
            buttonGoThroughDoor.Visible = (currentLocation is IHasExteriorDoor);

        }

        private void buttonGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBoxLocation.SelectedIndex]);
        }

        private void buttonGoThroughDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
