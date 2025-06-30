namespace losos
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_startNewGame = new Button();
            button_loadOldGame = new Button();
            SuspendLayout();
            // 
            // button_startNewGame
            // 
            button_startNewGame.Location = new Point(231, 355);
            button_startNewGame.Margin = new Padding(2, 3, 2, 3);
            button_startNewGame.Name = "button_startNewGame";
            button_startNewGame.Size = new Size(118, 31);
            button_startNewGame.TabIndex = 0;
            button_startNewGame.Text = "začít novou hru";
            button_startNewGame.UseVisualStyleBackColor = true;
            // 
            // button_loadOldGame
            // 
            button_loadOldGame.Location = new Point(231, 407);
            button_loadOldGame.Name = "button_loadOldGame";
            button_loadOldGame.Size = new Size(118, 29);
            button_loadOldGame.TabIndex = 1;
            button_loadOldGame.Text = "načíst hru";
            button_loadOldGame.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 582);
            Controls.Add(button_loadOldGame);
            Controls.Add(button_startNewGame);
            Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "losos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button_startNewGame;
        private Button button_loadOldGame;
    }
}
