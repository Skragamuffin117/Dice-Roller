namespace Dice_Roller
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
            this.Roll = new System.Windows.Forms.Button();
            this.DieType = new System.Windows.Forms.ComboBox();
            this.DiceType = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this.DifficultyRating = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(101, 102);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(53, 23);
            this.Roll.TabIndex = 0;
            this.Roll.Text = "Roll";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // DieType
            // 
            this.DieType.FormattingEnabled = true;
            this.DieType.Location = new System.Drawing.Point(67, 23);
            this.DieType.Name = "DieType";
            this.DieType.Size = new System.Drawing.Size(121, 21);
            this.DieType.TabIndex = 1;
            this.DieType.SelectedIndexChanged += new System.EventHandler(this.DieType_SelectedIndexChanged);
            // 
            // DiceType
            // 
            this.DiceType.AutoSize = true;
            this.DiceType.Location = new System.Drawing.Point(99, 7);
            this.DiceType.Name = "DiceType";
            this.DiceType.Size = new System.Drawing.Size(56, 13);
            this.DiceType.TabIndex = 2;
            this.DiceType.Text = "Dice Type";
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Location = new System.Drawing.Point(103, 60);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(47, 13);
            this.Difficulty.TabIndex = 4;
            this.Difficulty.Text = "Difficulty";
            // 
            // DifficultyRating
            // 
            this.DifficultyRating.Location = new System.Drawing.Point(101, 76);
            this.DifficultyRating.Name = "DifficultyRating";
            this.DifficultyRating.Size = new System.Drawing.Size(53, 20);
            this.DifficultyRating.TabIndex = 5;
            this.DifficultyRating.TextChanged += new System.EventHandler(this.DifficultyRating_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(67, 144);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(121, 97);
            this.Result.TabIndex = 6;
            this.Result.UseCompatibleStateImageBehavior = false;
            this.Result.View = System.Windows.Forms.View.List;
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 263);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.DifficultyRating);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.DiceType);
            this.Controls.Add(this.DieType);
            this.Controls.Add(this.Roll);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.ComboBox DieType;
        private System.Windows.Forms.Label DiceType;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.TextBox DifficultyRating;
        private System.Windows.Forms.ListView Result;
    }
}

