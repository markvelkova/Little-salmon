using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pet;
using stats;

namespace losos
{
    public partial class UCIntro : UserControl
    {
        public UCIntro()
        {
            InitializeComponent();
            UsefulForDesign.CenterControlHorizontally(myButton_LoadGame);
            UsefulForDesign.CenterControlHorizontally(myButton_StartNewGame);
            this.BackColor = MainForm.MyDefaultBackColor;
        }

        #region start new game
        public event EventHandler? StartNewGameClicked; // here are stacked requests from outside
        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            MainForm.thePet = new Pet(); // create a new pet instance
            StartNewGameClicked?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region load game
        public event EventHandler? LoadGameClicked; 
        private void button_LoadGame_Click(object sender, EventArgs e)
        {

            string fileContent; 
            try
            {
                fileContent = OpenFile();
                SerializationUnit serializationUnit = new(fileContent);
                MainForm.thePet = serializationUnit.pet;
                MessageBox.Show(MainForm.thePet.SerializePet(), "Pet Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm.theStats = serializationUnit.stats;
                LoadGameClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (FileFormatException ex)
            {
                MessageBox.Show("Error opening file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PetDeserializationException ex)
            {
                MessageBox.Show("Error loading game: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (StatsDeserializationException ex)
            {
                MessageBox.Show("Error loading game: " + ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Open Game File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the file content
                    string filePath = openFileDialog.FileName;
                    string content = File.ReadAllText(filePath);
                    return content;
                }
                else 
                    throw new FileFormatException("No file selected or file format is incorrect.");
            }
        }
        #endregion
    }
}
