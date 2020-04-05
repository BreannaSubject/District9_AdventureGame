using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace District9_AdventureGame
{
    public partial class District9 : Form
    {
        int scene = 0;
        Random randGen = new Random();
        int random;
        SoundPlayer hell = new SoundPlayer(Properties.Resources.hell);
        public District9()
        {
            InitializeComponent();
            random = randGen.Next(1, 11);
            
        }

  
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 2)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 7)
                {
                    scene = 0;
                }
                else if (scene == 8)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 22;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 18)
                {
                    scene = 24;
                }
                else if (scene == 19)
                {
                    scene = 13;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 34;
                }
                else if (scene == 24)
                {
                    scene = 27;
                }
                else if (scene == 27)
                {
                    scene = 28;
                }
                else if (scene == 29)
                {
                    scene = 32;
                }
                else if (scene == 30)
                {
                    scene = 54;
                }
                else if (scene == 35)
                {
                    scene = 38;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 39)
                {
                    scene = 45;
                }
                else if (scene == 41)
                {
                    scene = 43;
                }
                else if (scene == 42)
                {
                    scene = 41;
                }
                else if (scene == 43)
                {
                    scene = 44;
                }
                else if (scene == 46)
                {
                    scene = 48;
                }
                else if (scene == 48)
                {
                    scene = 50;
                }
                else if (scene == 51)
                {
                    scene = 0;
                }
            }
            else if (e.KeyCode == Keys.M)
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 3;
                }
                else if (scene == 5)
                {
                    scene = 6;
                }
                else if (scene == 7)
                {
                    this.Close();
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
                else if (scene == 13)
                {
                    scene = 19;
                }
                else if (scene == 14)
                {
                    scene = 12;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 18)
                {
                    scene = 15;
                }
                else if (scene == 19)
                {
                    if (random == 7 || random == 8 || random == 9 || random == 10)
                    {
                        scene = 21;
                    }
                    else
                    {
                        scene = 20;
                    }
                }
                else if (scene == 22)
                {
                    scene = 13;
                }
                else if (scene == 23)
                {
                    scene = 27;
                }
                else if (scene == 24)
                {
                    scene = 25;
                }
                else if (scene == 27)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 30)
                {
                    scene = 31;
                }
                else if (scene == 35)
                {
                    scene = 37;
                }
                else if (scene == 38)
                {
                    if (random <= 5)
                    {
                        scene = 40;
                    }
                    else
                    {
                        scene = 41;
                    }
                }
                else if (scene == 39)
                {
                    scene = 46;
                }
                else if (scene == 41)
                {
                    scene = 42;
                }
                else if (scene == 42)
                {
                    if (random == 1)
                    {
                        scene = 40;
                    }
                    else
                    {
                        scene = 32;
                    }
                }
                else if (scene == 43)
                {
                    scene = 41;
                }
                else if (scene == 46)
                {
                    scene = 47;
                }
                else if (scene == 48)
                {
                    scene = 49;
                }
                else if (scene == 51)
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (scene == 1)
                {
                    scene = 0;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    scene = 7;
                }
                else if (scene == 4)
                {
                    scene = 2;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 9)
                {
                    scene = 7;
                }
                else if (scene == 11)
                {
                    scene = 12;
                }
                else if (scene == 15)
                {
                    scene = 18;
                }
                else if (scene == 16)
                {
                    scene = 15;
                }
                else if (scene == 17)
                {
                    scene = 7;
                }
                else if (scene == 20)
                {
                    scene = 7;
                }
                else if (scene == 21)
                {
                    scene = 51;
                }
                else if (scene == 25)
                {
                    if (random >= 9)
                    {
                        scene = 26;
                    }
                    else
                    {
                        scene = 52;
                    }
                }
                else if (scene == 26)
                {
                    if (random >= 6)
                    {
                        scene = 27;
                    }
                    else
                    {
                        scene = 53;
                    }
                }
                else if (scene == 28)
                {
                    if (random <= 4)
                    {
                        scene = 7;
                    }
                    else
                    {
                        scene = 29;
                    }
                }
                else if (scene == 31)
                {
                    scene = 7;
                }
                else if (scene == 32)
                {
                    if (random <= 3)
                    {
                        scene = 7;
                    }
                    else
                    {
                        scene = 33;
                    }

                }
                else if (scene == 33)
                {
                    scene = 51;
                }
                else if (scene == 34)
                {
                    if (random >= 3)
                    {
                        scene = 35;
                    }
                    else
                    {
                        scene = 36;
                    }
                }
                else if (scene == 36)
                {
                    scene = 7;
                }
                else if (scene == 37)
                {
                    scene = 7;
                }
                else if (scene == 40)
                {
                    scene = 7;
                }
                else if (scene == 44)
                {
                    scene = 51;
                }
                else if (scene == 45)
                {
                    scene = 41;
                }
                else if (scene == 47)
                {
                    scene = 7;
                }
                else if (scene == 49)
                {
                    scene = 7;
                }
                else if (scene == 50)
                {
                    scene = 7;
                }
                else if (scene == 52)
                {
                    scene = 7;
                }
                else if (scene == 53)
                {
                    scene = 7;
                }
                else if (scene == 54)
                {
                    scene = 32;
                }
            }
            else 
            { 
            }

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You wake up in a cell with no memory of how you got there.";
                    outputLabel.Text += "\n" + "\nThere are two pieces of paper on the table beside your bed, one red, one yellow." + "\n" + "\nWhich do you choose?";
                    blueLabel.Text = "Yellow";
                    redLabel.Text = "Red";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.District_9;
                    hell.Play();
                    break;
                case 1:
                    outputLabel.Text = "The yellow paper says read the paper";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue";
                    break;
                case 2:
                    outputLabel.Text = "You see the word 'Miroh' in big bolded letters. It's signed CB97. You've seen this signature before.";
                    outputLabel.Text += "You want to look around your cell for more clues. There are three places you could look. Which do you choose?";
                    blueLabel.Text = "Closet";
                    redLabel.Text = "Under the bed";
                    greenLabel.Text = "Bookshelf";
                    break;
                case 3:
                    outputLabel.Text = "You look under the bed to find a spider. It bites you and you die.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 4:
                    outputLabel.Text = "You find nothing on your bookshelf, except the word 'Escape' cut into the wood. There must be a knife or a sword around here. ";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 5:
                    outputLabel.Text = "You find a tanto with the letters NM engraved in the handle. The blade is dull, but stained with blood.";
                    outputLabel.Text += "You hear footsteps outside your cell. What do you do?";
                    blueLabel.Text = "Hide";
                    redLabel.Text = "Fight";
                    greenLabel.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "You grab the tanto and wait until the footsteps stop and the door opens. You jump to attack, and get shot. ";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 7:
                    outputLabel.Text = "You lose" + "\n" + "\nPlay Again?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.death;
                    break;
                case 8:
                    outputLabel.Text = "You hide in your closet, holding your breath as you hear the door to your cell open. ";
                    blueLabel.Text = "Continue hiding";
                    redLabel.Text = "Fight";
                    greenLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You picked a fight with the wrong people.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 10:
                    outputLabel.Text = "You can hear your heartbeat in your ears, but you continue to hide, until the last footstep exits your room.";
                    outputLabel.Text += "You see a small crack in the door. You could open it and escape, or you can search more.";
                    blueLabel.Text = "Escape";
                    redLabel.Text = "Search";
                    greenLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You look by the window sill, where you find a red flower, and the word 'Escape'";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue";
                    break;
                case 12:
                    outputLabel.Text = "You exit the room, only to find an abandoned medical cart outside your room, with the word 'Run' written in blood.";
                    blueLabel.Text = "Run Right";
                    redLabel.Text = "Run Left";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.hallway;
                    break;
                case 13:
                    outputLabel.Text = "You run to the right, smashing through a door that leads to a garden. You take a look at the flowers, and they look familiar, except they are colorless";
                    outputLabel.Text += "\n" + "\nFlashback *You could see a blinding light over head, which, when the light shone on the flower, turned it red. Blood red.*";
                    outputLabel.Text += "\n" + "\nIn the gardens, there is a seemingly useless elevator, or a path that leads you to more of the jail.";
                    blueLabel.Text = "Path";
                    redLabel.Text = "Elevator";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.garden;
                    break;
                case 14:
                    outputLabel.Text = "You run to the left, smashing through on of the many doors. You find another cell just like yours.";
                    blueLabel.Text = "Search";
                    redLabel.Text = "Exit";
                    greenLabel.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "There are three things that catch your eye, the closet, the dresser drawers, and a duffel bag on the floor.";
                    blueLabel.Text = "Drawer";
                    redLabel.Text = "Duffel Bag";
                    greenLabel.Text = "Closet";
                    imageBox.BackgroundImage = Properties.Resources.District_9;
                    break;
                case 16:
                    outputLabel.Text = "You open the duffel bag and find nothing.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 17:
                    outputLabel.Text = "You open the drawer, only to find a snake inside. With one bite, you're dead.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 18:
                    outputLabel.Text = "You open the closet to find another duffel bag.";
                    blueLabel.Text = "Open it";
                    redLabel.Text = "Leave it";
                    greenLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You walk into the elevator, which looks overgrown and rusted. On the panel, there is a big red button labeled 'Hell'.";
                    blueLabel.Text = "Exit";
                    redLabel.Text = "Press It";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.elevator;
                    break;
                case 20:
                    outputLabel.Text = "The elevator explodes.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 21:
                    outputLabel.Text = "The elevator takes you to a lavender field." + "\n" + "\nYou've escaped District 9, but you still don't know who you are.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.lavendar_field;
                    break;
                case 22:
                    outputLabel.Text = "You follow the path to another part of the garden, where you find a smashed drone, with a red blinking light on it.";
                    outputLabel.Text += "The drone has a note attached to it that says, 'Find the bus'.";
                    blueLabel.Text = "Find the bus";
                    redLabel.Text = "Go back to the garden";
                    greenLabel.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "Which way do you turn?";
                    blueLabel.Text = "Right";
                    redLabel.Text = "Left";
                    greenLabel.Text = "";
                    break;
                case 24:
                    outputLabel.Text = "You find some clothes inside, along with a note that says 'Find the bus'";
                    outputLabel.Text += "\n" + "\nYou see the bus outside the window. Now all you have to do is get to it.";
                    blueLabel.Text = "Right";
                    redLabel.Text = "Left";
                    greenLabel.Text = "";
                    break;
                case 25:
                    outputLabel.Text = "You turn left, only to find a red line on the floor. You decide to follow it.";
                    outputLabel.Text += "\n" + "\nThe line takes you down a hallway, and another, and another, until you windup in a dark room.";
                    outputLabel.Text += "\n" + "\nThe only thing you see in the room is the shine off of a tanto just like yours.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.hallway;
                    break;
                case 26:
                    outputLabel.Text = "You exit the room, only to find a window to the garage right near you." + "You smash through the window.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.garage;
                    break;
                case 27:
                    outputLabel.Text = "You find yourself in the garage. All you can see are armored vehicles. You want to search the garage.";
                    blueLabel.Text = "Right";
                    redLabel.Text = "Left";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.garage;
                    break;
                case 28:
                    outputLabel.Text = "A guard catches you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 29:
                    outputLabel.Text = "You see the garage doors, just as some guards see you.";
                    blueLabel.Text = "Run";
                    redLabel.Text = "Hide";
                    greenLabel.Text = "";
                    break;
                case 30:
                    outputLabel.Text = "There are two places you could hide, the back of the armored truck, or behind the tool chest.";
                    blueLabel.Text = "Tool chest";
                    redLabel.Text = "Armored truck";
                    greenLabel.Text = "";
                    break;
                case 31:
                    outputLabel.Text = "You hop into the back of the armored truck, only to be captured by more guards.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 32:
                    outputLabel.Text = "You run towards the garage door, smashing the open button.";
                    outputLabel.Text += "\nThe door opens and you slide under, smashing the button on the other side so the guards can't get through.";
                    outputLabel.Text += "\nYou see the bus on the other side of the parking lot. You run to the bus, hoping and praying that nobody catches you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 33:
                    outputLabel.Text = "You hop onto the bus, shutting the doors quickly. You go to the drivers seat, but there's someone already there.";
                    outputLabel.Text += "\n" + "\nYou look into the bus and see your family. Memories flood back and you remember everything.";
                    outputLabel.Text += "\n" + "\nYou are CB97. The 9th escapee of District 9.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.bus;
                    break;
                case 34:
                    outputLabel.Text = "You turn right, running towards a tall tower. The light blinding you as you go by. Because of the light, you can't see the gaping hole in front of you.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.tower;
                    break;
                case 35:
                    outputLabel.Text = "You somehow avoid the hole completely as you make your way towards the tower.";
                    blueLabel.Text = "Explore the Tower";
                    redLabel.Text = "Keep Going";
                    greenLabel.Text = "";
                    break;
                case 36:
                    outputLabel.Text = "You fell in the pit of Despair! :(";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 37:
                    outputLabel.Text = "You find yourself in another part of the garden. There is only one path, so you decide to follow it.";
                    outputLabel.Text += "\n" + "\nA guard finds you in the garden.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.garden;
                    break;
                case 38:
                    outputLabel.Text = "You open the door.";
                    blueLabel.Text = "Back Door";
                    redLabel.Text = "Stairs";
                    greenLabel.Text = "";
                    break;
                case 39:
                    outputLabel.Text = "You open the back door to find an abandoned shack. Inside, there are pictures of evidence connected with bright red and blue thumbtacks and string";
                    outputLabel.Text += "\n" + "\nThe board is see through, so you can see the signature 'SpearB' on the wall behind the board.";
                    blueLabel.Text = "Examine the signature";
                    redLabel.Text = "Examine the board";
                    greenLabel.Text = "";
                    imageBox.BackgroundImage = Properties.Resources.shack;
                    break;
                case 40:
                    outputLabel.Text = "You have fallen and cannot get up.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 41:
                    outputLabel.Text = "You find a bed, along with pictures of you with people that you can't quite remember";
                    outputLabel.Text += "\n" + "\nYou also notice a small crack in the floor, big enough to fit the tanto.";
                    blueLabel.Text = "Open the floor board";
                    redLabel.Text = "Examine the pictures";
                    greenLabel.Text = "";
                    break;
                case 42:
                    outputLabel.Text = "You examine the pictures closer. You remember these people. You loved these people. You can't remember why though.";
                    outputLabel.Text += "\n" + "\nBeside the pictures, there is a window. When you look out the window, you can see the bus.";
                    blueLabel.Text = "Leave it";
                    redLabel.Text = "Run to the bus";
                    greenLabel.Text = "";
                    break;
                case 43:
                    outputLabel.Text = "You lift the floor board up, only to find a portal.";
                    blueLabel.Text = "Go in";
                    redLabel.Text = "Leave it";
                    greenLabel.Text = "";
                    break;
                case 44:
                    outputLabel.Text = "The portal takes you to lavender field.";
                    outputLabel.Text += "\n" + "\nYou've escaped District 9, but you still don't know who you are.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.lavendar_field;
                    break;
                case 45:
                    outputLabel.Text = "The signature appears to be written in red marker. You take a closer look, only to find that it is not red marker, but blood.";
                    outputLabel.Text += "\n" + "\nBeside the signature, you see a smaller signature, written in blue marker. It's signed NM, the same mark that's on the tanto.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 46:
                    outputLabel.Text = "The board has pictures of bloody and gruesome murders, all committed by one person, NM, the same person that own the tanto.";
                    outputLabel.Text = "\n" + "\nYou hear a noise.";
                    blueLabel.Text = "Hide";
                    redLabel.Text = "Run";
                    greenLabel.Text = "";
                    break;
                case 47:
                    outputLabel.Text = "You run, only to get stopped by a guard.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.garden;
                    break;
                case 48:
                    outputLabel.Text = "Where do you hide?";
                    blueLabel.Text = "Bed";
                    redLabel.Text = "Closet";
                    greenLabel.Text = "";
                    break;
                case 49:
                    outputLabel.Text = "You hide in the closet. You think that nobody can hear your heavy breathing, and just as you think your safe, the closet door opens.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 50:
                    outputLabel.Text = "You hide under the bed.The door creeks open and you see a pair of spiked black heel boots walking towards you.";
                    outputLabel.Text = "\n" + "\nYou think your safe, until someone peeks under the bed.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                case 51:
                    outputLabel.Text = "You Win!!";
                    outputLabel.Text += "\n" + "\nPlay Again?";
                    blueLabel.Text = "Yes";
                    redLabel.Text = "No";
                    greenLabel.Text = "";
                    break;
                case 52:
                    outputLabel.Text = "With one swing of the sword, you die.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.hallway;
                    break;
                case 53:
                    outputLabel.Text = "You break almost every bone in your body as you crash to the ground.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    imageBox.BackgroundImage = Properties.Resources.garage;
                    break;
                case 54:
                    outputLabel.Text = "You hide behind the tool chest, which is only a little away from the garage door. You know you can make it.";
                    blueLabel.Text = "";
                    redLabel.Text = "";
                    greenLabel.Text = "Press the green button to continue.";
                    break;
                default:
                    break;

            }
        }

    }

}
