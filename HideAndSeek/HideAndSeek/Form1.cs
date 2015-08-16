using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek
{

    public partial class Form1 : Form
    {
        Location currentLocation;
        int Moves = 0;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;



        public Form1()
        {
            InitializeComponent();
            CreateLocations();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void ResetGame(bool displayMessage)
        {
            if(displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                textBoxDescription.Text = "You found your opponent in " + Moves
                    + " moves! He was hiding " + foundLocation.HidingPlace + " of the " + currentLocation.Name +  ".";
            }
            Moves = 0;
            buttonHide.Visible = true;
            buttonGoHere.Visible = false;
            buttonCheck.Visible = false;
            comboBoxLocation.Visible = false;
            buttonGoThroughDoor.Visible = false;
        }

        private void CreateLocations()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "inside the closet", "an oak door with a brass knob");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a chrystal chandelier", "in the tall armoire");
            kitchen = new RoomWithDoor("Kitchen", "stainles steel appliances", "in the cabinet", "a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");

            frontYard = new OutsideWithDoor("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", false, "in the garage");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };


            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }
    

        private void MoveToANewLocation(Location location)
        {
            ++Moves;
            currentLocation = location;
            RedrawForm();
        }

        private void RedrawForm()
        {

            comboBoxLocation.Items.Clear();

            foreach (Location l in currentLocation.Exits)
            {
                comboBoxLocation.Items.Add(l.Name);
            }
            comboBoxLocation.SelectedIndex = 0;
            textBoxDescription.Text = currentLocation.Description + "\r\n(move  #" + Moves + ")";

            if(currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                buttonCheck.Text = "Check " + hidingPlace.HidingPlace;
                buttonCheck.Visible = true;
            }
            else
            {
                buttonCheck.Visible = false;
            }
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

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            ++Moves;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();

        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            buttonHide.Visible = false;

            for(int i=0; i < 10;++i)
            {
                opponent.Move();
                textBoxDescription.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            textBoxDescription.Text = "Ready or not, here I come!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            buttonGoHere.Visible = true;
            comboBoxLocation.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
