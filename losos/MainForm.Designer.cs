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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SuspendLayout();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(5F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 601);
            Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(640, 640);
            Name = "MainForm";
            Text = "losos";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
