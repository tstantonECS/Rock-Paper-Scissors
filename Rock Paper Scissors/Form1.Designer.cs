
namespace Rock_Paper_Scissors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paperButton = new System.Windows.Forms.Button();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.spockButton = new System.Windows.Forms.Button();
            this.lizardButton = new System.Windows.Forms.Button();
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.computerPicture = new System.Windows.Forms.PictureBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // paperButton
            // 
            this.paperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperButton.Location = new System.Drawing.Point(201, 355);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(98, 59);
            this.paperButton.TabIndex = 0;
            this.paperButton.Tag = "1";
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.buttonPressed);
            // 
            // scissorsButton
            // 
            this.scissorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorsButton.Location = new System.Drawing.Point(314, 355);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(98, 59);
            this.scissorsButton.TabIndex = 1;
            this.scissorsButton.Tag = "2";
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.buttonPressed);
            // 
            // rockButton
            // 
            this.rockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockButton.Location = new System.Drawing.Point(89, 355);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(98, 59);
            this.rockButton.TabIndex = 2;
            this.rockButton.Tag = "0";
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.buttonPressed);
            // 
            // spockButton
            // 
            this.spockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spockButton.Location = new System.Drawing.Point(543, 355);
            this.spockButton.Name = "spockButton";
            this.spockButton.Size = new System.Drawing.Size(98, 59);
            this.spockButton.TabIndex = 3;
            this.spockButton.Tag = "4";
            this.spockButton.Text = "Spock";
            this.spockButton.UseVisualStyleBackColor = true;
            this.spockButton.Click += new System.EventHandler(this.buttonPressed);
            // 
            // lizardButton
            // 
            this.lizardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lizardButton.Location = new System.Drawing.Point(427, 355);
            this.lizardButton.Name = "lizardButton";
            this.lizardButton.Size = new System.Drawing.Size(98, 59);
            this.lizardButton.TabIndex = 4;
            this.lizardButton.Tag = "3";
            this.lizardButton.Text = "Lizard";
            this.lizardButton.UseVisualStyleBackColor = true;
            this.lizardButton.Click += new System.EventHandler(this.buttonPressed);
            // 
            // playerPicture
            // 
            this.playerPicture.Location = new System.Drawing.Point(145, 201);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(100, 102);
            this.playerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPicture.TabIndex = 5;
            this.playerPicture.TabStop = false;
            // 
            // computerPicture
            // 
            this.computerPicture.Location = new System.Drawing.Point(480, 201);
            this.computerPicture.Name = "computerPicture";
            this.computerPicture.Size = new System.Drawing.Size(100, 102);
            this.computerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerPicture.TabIndex = 6;
            this.computerPicture.TabStop = false;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(141, 174);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(105, 16);
            this.playerLabel.TabIndex = 7;
            this.playerLabel.Text = "Player Choice";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.Location = new System.Drawing.Point(467, 174);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(126, 16);
            this.computerLabel.TabIndex = 8;
            this.computerLabel.Text = "Computer Choice";
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(228, 101);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(288, 16);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Make your choice from the buttons below";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(43, 48);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(221, 20);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Computer Copies Last Move";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerPicture);
            this.Controls.Add(this.playerPicture);
            this.Controls.Add(this.lizardButton);
            this.Controls.Add(this.spockButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.scissorsButton);
            this.Controls.Add(this.paperButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button spockButton;
        private System.Windows.Forms.Button lizardButton;
        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.PictureBox computerPicture;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

