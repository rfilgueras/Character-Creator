/*
 * 
 * Rhona Filgueras
 * December 17, 2020
 * 
 * Help with layering of picture boxes by Michael Tendy
 * Transparancy Control Code
 * https://stackoverflow.com/questions/19910172/how-to-make-picturebox-transparent
 * 
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CharacterCreator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {           
            InitializeComponent();
      
            //bg1.Visible = false;
            TransparancyControl();
            //name.Font = new Font("Arial", 18, FontStyle.Bold);
            currentHat = defaultHat;
            currentHead = defaultHead;            
            currentArm = defaultArm;
            currentFood = defaultFood;
            currentWheels = defaultWheels;
            currentBG = defaultBG;
        }

        PictureBox currentHead = new PictureBox();
        PictureBox currentHat = new PictureBox();
        PictureBox currentWheels = new PictureBox();
        PictureBox currentArm = new PictureBox();
        PictureBox currentFood = new PictureBox();
        PictureBox currentBG = new PictureBox();

        public void ShowBody()
        {
            currentBG.Controls.Add(defaultBody);
            defaultBody.Location = new Point(0,0);
            defaultBody.BackColor = Color.Transparent;

            defaultBody.Controls.Add(currentWheels);
            //defaultBody.Controls.Add(currentHat);
            currentWheels.Location = new Point(0, 0);
            currentWheels.BackColor = Color.Transparent;

            //currentHat.Controls.Add(currentHead);
            currentWheels.Controls.Add(currentArm);
            currentArm.Location = new Point(0, 0);
            currentArm.BackColor = Color.Transparent;

            //currentHead.Controls.Add(currentArm);
            currentArm.Controls.Add(currentFood);
            currentFood.Location = new Point(0, 0);
            currentFood.BackColor = Color.Transparent;

            //currentArm.Controls.Add(currentFood);            
            currentFood.Controls.Add(currentHead);
            currentHead.Location = new Point(0, 0);
            currentHead.BackColor = Color.Transparent;

            //currentFood.Controls.Add(currentWheels);
            currentHead.Controls.Add(currentHat);
            currentHat.Location = new Point(0, 0);
            currentHat.BackColor = Color.Transparent;

            currentArm.Visible = true;
            currentBG.Visible = true;
            currentFood.Visible = true;
            currentHat.Visible = true;
            currentHead.Visible = true;
            currentWheels.Visible = true;
        }

        public void TransparancyControl()
        {
            defaultBG.Controls.Add(defaultBody);
            defaultBody.Location = new Point();
            defaultBody.BackColor = Color.Transparent;

            defaultBody.Controls.Add(defaultWheels);
            defaultWheels.Location = new Point();
            defaultWheels.BackColor = Color.Transparent;

            defaultWheels.Controls.Add(defaultArm);
            defaultArm.Location = new Point();
            defaultArm.BackColor = Color.Transparent;

            defaultArm.Controls.Add(defaultFood);
            defaultFood.Location = new Point();
            defaultFood.BackColor = Color.Transparent;

            defaultFood.Controls.Add(defaultHead);
            defaultHead.Location = new Point();
            defaultHead.BackColor = Color.Transparent;

            defaultHead.Controls.Add(defaultHat);
            defaultHat.Location = new Point();
            defaultHat.BackColor = Color.Transparent;
            
        }

        private void BGbutton1_Click(object sender, EventArgs e)
        {
            bg1.Visible = bg2.Visible = bg3.Visible = bg4.Visible = bg5.Visible = bg6.Visible = bg7.Visible = bg8.Visible = bg9.Visible = defaultBG.Visible = false;            

            Button tempBox = (Button)sender;
            switch (tempBox.Name)
            {
                case "BGbutton1":
                    currentBG = bg1;
                    break;
                case "BGbutton2":
                    currentBG = bg2;
                    break;
                case "BGbutton3":
                    currentBG = bg3;
                    break;
                case "BGbutton4":
                    currentBG = bg4;
                    break;
                case "BGbutton5":
                    currentBG = bg5;
                    break;
                case "BGbutton6":
                    currentBG = bg6;
                    break;
                case "BGbutton7":
                    currentBG = bg7;
                    break;
                case "BGbutton8":
                    currentBG = bg8;
                    break;
                case "BGbutton9":
                    currentBG = bg9;
                    break;
                default:
                    break;
            }

            currentBG.Visible = true;
            ShowBody();
        }

        private void HeadBtn1_Click(object sender, EventArgs e)
        {

            head1.Visible = head2.Visible = head3.Visible = head4.Visible = head5.Visible = head6.Visible = head7.Visible = head8.Visible = head9.Visible = head10.Visible = defaultHead.Visible =false;

            Button tempBox = (Button)sender;
            switch (tempBox.Name)
            {
                case "HeadBtn1":
                    currentHead = head1;
                    break;
                case "HeadBtn2":
                    currentHead = head2;
                    break;
                case "HeadBtn3":
                    currentHead = head3;
                    break;
                case "HeadBtn4":
                    currentHead = head4;
                    break;
                case "HeadBtn5":
                    currentHead = head5;
                    break;
                case "HeadBtn6":
                    currentHead = head6;
                    break;
                case "HeadBtn7":
                    currentHead = head7;
                    break;
                case "HeadBtn8":
                    currentHead = head8;
                    break;
                case "HeadBtn9":
                    currentHead = head9;
                    break;
                case "HeadBtn10":
                    currentHead = head10;
                    break;
                default:
                    break;
            }
            currentHead.Visible = true;
            ShowBody();
        }
      
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void wheels_Click(object sender, EventArgs e)
        {
            wheel1.Visible = wheel2.Visible = wheel3.Visible = wheel4.Visible = wheel5.Visible = wheel6.Visible = defaultWheels.Visible = false;
            Button tempBox = (Button)sender;
            switch (tempBox.Name)
            {
                case "WheelBtn1":                    
                    currentWheels = wheel1;
                    break;
                case "WheelBtn2":                    
                    currentWheels = wheel2;
                    break;
                case "WheelBtn3":
                    currentWheels = wheel3;
                    break;
                case "WheelBtn4":
                    currentWheels = wheel4;
                    break;
                case "WheelBtn5":
                    currentWheels = wheel5;
                    break;
                case "WheelBtn6":
                    currentWheels = wheel6;
                    break;
                default:
                    break;
            }
            currentWheels.Visible = true;
            ShowBody();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void HatBtn1_Click(object sender, EventArgs e)
        {
            hat1.Visible = hat2.Visible = hat3.Visible = hat4.Visible = hat5.Visible = hat6.Visible = hat7.Visible = hat8.Visible = defaultHat.Visible = false;
            Button tempBox = (Button)sender;
            switch (tempBox.Name)
            {
                case "HatBtn1":
                    currentHat = hat1;
                    break;
                case "HatBtn2":
                    currentHat = hat2;
                    break;
                case "HatBtn3":
                    currentHat = hat3;
                    break;
                case "HatBtn4":
                    currentHat = hat4;
                    break;
                case "HatBtn5":
                    currentHat = hat5;
                    break;
                case "HatBtn6":
                    currentHat = hat6;
                    break;
                case "HatBtn7":
                    currentHat = hat7;
                    break;
                case "HatBtn8":
                    currentHat = hat8;
                    break;               
                default:
                    break;
            }

            currentHat.Visible = true;
            ShowBody();
        }

        private void FoodBtn1_Click(object sender, EventArgs e)
        {
            food1.Visible = food2.Visible = food3.Visible = food4.Visible = food5.Visible = food6.Visible  = food7.Visible = food8.Visible = food9.Visible = defaultFood.Visible = false;

            Button tempBox = (Button)sender;
            switch (tempBox.Name)
            {
                case "FoodBtn1":
                    currentFood = food1;
                    break;
                case "FoodBtn2":
                    currentFood = food2;
                    break;
                case "FoodBtn3":
                    currentFood = food3;
                    break;
                case "FoodBtn4":
                    currentFood = food4;
                    break;
                case "FoodBtn5":
                    currentFood = food5;
                    break;
                case "FoodBtn6":
                    currentFood = food6;
                    break;
                case "FoodBtn7":
                    currentFood = food7;
                    break;
                case "FoodBtn8":
                    currentFood = food8;
                    break;
                case "FoodBtn9":
                    currentFood = food9;
                    break;
                default:
                    break;
            }
            currentFood.Visible = true;
            ShowBody();
        }

        private void ArmBtn1_Click(object sender, EventArgs e)
        {
            arm1.Visible = arm2.Visible = arm3.Visible = arm4.Visible = arm5.Visible = arm6.Visible = defaultArm.Visible = false;

            Button tempBox = (Button)sender;
            switch (tempBox.Name)
            {
                case "ArmBtn1":
                    currentArm = arm1;
                    break;
                case "ArmBtn2":
                    currentArm = arm3;
                    break;
                case "ArmBtn3":
                    currentArm = arm3;
                    break;
                case "ArmBtn4":
                    currentArm = arm4;
                    break;
                case "ArmBtn5":
                    currentArm = arm5;
                    break;
                case "ArmBtn6":
                    currentArm = arm6;
                    break;
                default:
                    break;
            }
            currentArm.Visible = true;
            ShowBody();
        }

        private void PlayerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            PlayerName.Text = PlayerNameTextBox.Text;
        }
    }
}
