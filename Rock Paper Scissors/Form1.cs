using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        bool copyLastMove = false;                                                                                  //Create boolean variable to determine whether the computer should copy the player's last move.
        int? lastPlayerMove;                                                                                        //Create an nullable integer variable to store the player's last move.
        Random random = new Random();                                                                               //Create an instance of the Random class to be used for random number generation.
        int playerChoice, computerChoice;                                                                           //Create variables to store the player and computer's choices in integer form. 
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonPressed(object sender, EventArgs e)                                                      //Function is called whenever one of the player choice buttons is pressed.
        {
            Button tempButton = sender as Button;                                                                   //Get the button that was pressed.
            playerChoice = Convert.ToInt32(tempButton.Tag);                                                         //Convert that button's tag into an integer (each button has a unique integer tag).
            if (copyLastMove && lastPlayerMove != null)
            {                
                computerChoice = (int)lastPlayerMove;                                                               //If the computer is set to copy the player's last move and the player has already made a move, the computer will copy the player's last move.
            }
            else
            {
                computerChoice = generateChoice();                                                                  //If the computer is not set to copy the player's last move or the player has not already made a move, Generate a random number from 0 to 4 to be the computer's choice.
            }
            
            playerLabel.Text = "Player chooses " + changeLabelandImage(playerChoice, playerPicture);                //Update the player choice label to display their choice and update the player's picture box to show an image of their choice.
            computerLabel.Text = "Computer chooses " + changeLabelandImage(computerChoice, computerPicture);        //Update the computer choice label to display the computer's choice and update the computer's picture box to show an image of its choice.
            checkGame();                                                                                            //Call the CheckGame function to decide who wins.
            lastPlayerMove = playerChoice;                                                                          //After the game has been decided, set the last players move to be the current player's choice.
        }

        private int generateChoice()
        {
            return random.Next(0, 5);
        }
        private string changeLabelandImage(int choice, PictureBox choiceBox)
        {
            string choiceString = null;                                                                             //Create a word variable of type string to store the string each choice, starting with a null value.
            switch (choice)                                                                                         //Start a switch statement to return the correct string and change the image of the picture box to the correct image.
            {
                case 0:                                                                                             //If the choice is 0, return "Rock" and display the rock image.    
                    choiceString = "Rock";      
                    choiceBox.Image = Properties.Resources.rock;
                    break;
                case 1:                                                                                             //If the choice is 1, return "Paper" and display the paper image.
                    choiceString = "Paper";
                    choiceBox.Image = Properties.Resources.paper;
                    break;
                case 2:                                                                                             //If the choice is 2, return "Scissors" and display the scissors image.
                    choiceString = "Scissors";
                    choiceBox.Image = Properties.Resources.scissors;
                    break;
                case 3:                                                                                             //If the choice is 3, return "Lizard" and display the lizard image.
                    choiceString = "Lizard";
                    choiceBox.Image = Properties.Resources.lizard;
                    break;
                case 4:                                                                                             //If the choice is 4, return "Spock" and display the spock image.
                    choiceString = "Spock";
                    choiceBox.Image = Properties.Resources.spock;
                    break;
            }
            return choiceString;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            copyLastMove = checkBox.Checked;
        }

        private void checkGame()
        {
            if (computerChoice == playerChoice)                                                                     //If both the player and the computer make the same choice, declare the game a draw.
            {
                resultLabel.Text = "It's a Draw!";
            }
            else if (playerChoice == 2 && computerChoice == 1 ||                                                    //If the player picks a choice that defeats the computer's choice, the player wins.
                     playerChoice == 1 && computerChoice == 0 || 
                     playerChoice == 0 && computerChoice == 3 ||
                     playerChoice == 3 && computerChoice == 4 ||
                     playerChoice == 4 && computerChoice == 2 ||
                     playerChoice == 2 && computerChoice == 3 ||
                     playerChoice == 3 && computerChoice == 1 ||
                     playerChoice == 1 && computerChoice == 4 ||
                     playerChoice == 4 && computerChoice == 0 ||
                     playerChoice == 0 && computerChoice == 2
                     )
            {
                resultLabel.Text = "Player wins!";
            }
            else                                                                                                    //Otherwise, the computer wins.
            {
                resultLabel.Text = "Computer wins!";
            }
        }
    }
}
