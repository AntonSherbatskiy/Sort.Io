using System.ComponentModel;

namespace Sort.Io
{
    //Main form class
    public partial class MainForm : Form
    {
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Form variables
        private SortingEngine Engine { get; set; } //Component for sorting algorithm working
        private ArrayVisualizer Visualizer { get; set; } //Component for array visualization
        private readonly JsonComponent<int[]> Component = new("ArrayContainer.json"); //Component for json file interaction

        internal int[]? Arr;
        internal int SortVisualizationValueMode => visualizationModeComboBox.SelectedIndex + 1;
        #endregion

        #region Form events
        private void MainForm_Load(object sender, EventArgs e)
        {
            visualizationModeComboBox.SelectedIndex = arrayAutoSaveComboBox.SelectedIndex = 0;
        }
        #endregion

        #region Text boxes events
        private void sizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only digits allowed.", "Input data warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void sizeBox_TextChanged(object sender, EventArgs e)
        {
            if (sizeBox.Text.Length > 0)
            {
                FormComponentsControl(true, generateButton, resetButton);
            }
            else
            {
                FormComponentsControl(false, generateButton);
            }
        }
        private void delayUpDown_Leave(object sender, EventArgs e)
        {
            if (delayUpDown.Text == string.Empty)
            {
                delayUpDown.Value = 0;
                delayUpDown.Text = delayUpDown.Value.ToString();
            }
        }
        #endregion

        #region Buttons events
        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(sizeBox.Text);
                if (count > 50000)
                {
                    throw new OverflowException();
                }
                else if (count < 100)
                {
                    SizeMessageBoxControl("min");
                    return;
                }

                FormComponentsControl(true, sizeBox);

                ArrayVisualizer.ClearPanel(arrayPanel, Color.FromArgb(23, 23, 23));

                Arr = ArrayVisualizer.GenerateArray(count, arrayPanel.Height);

                Visualizer = new(this);
                Visualizer.VisualizeArray();

                if (arrayAutoSaveComboBox.SelectedIndex == 1)
                {
                    Component.Write(Arr);
                }
                FormComponentsControl(true, startButton);
                ClearBox();
            }
            catch (OverflowException)
            {
                SizeMessageBoxControl("max");
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                arrayPanel.BackgroundImage = new Bitmap(@"D:\Projects\IO.png");
                sizeBox.Text = string.Empty;
                reverseCheckBox.Checked = false;
                FormComponentsControl(false, generateButton, startButton, resetButton);
                ClearBox();
            }

            Arr = null;
            FormComponentsControl(true, sizeBox);
            visualizationModeToolStripMenuItem.Enabled = true;
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            sizeBox.Text = Arr!.Length.ToString();
            fileToolStripMenuItem.Enabled = menuToolStripMenuItem.Enabled = helpToolStripMenuItem.Enabled = false;

            Engine = new(this, backgroundWorker1, Visualizer);

            ActiveControl = null;
            FormComponentsControl(false, sizeBox, delayUpDown, reverseCheckBox, generateButton, startButton);

            backgroundWorker1.RunWorkerAsync();
            FormComponentsControl(true, resetButton);
        }
        #endregion

        #region ToolStrip events
        //Program exit event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) =>
            Application.Exit();

        //Save array to the json file event
        private void writeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Arr == null)
            {
                MessageBox.Show("Create array first.", "Empty array warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Component.Write(Arr);
                MessageBox.Show("Succesfully written!", "ArrayContainer.json", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Read array from json file event
        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Component.Empty)
            {
                MessageBox.Show("File is empty.", "ArrayContainer.json", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int[] temp = Component.Read()!;

                    if (temp.Length < 100 || temp.Length > 50000)
                    {
                        throw new System.Runtime.Serialization.SerializationException();
                    }

                    Arr = temp;
                    Visualizer = new(this);

                    sizeBox.Text = Arr.Length.ToString();
                    FormComponentsControl(false, sizeBox);

                    visualizationModeToolStripMenuItem.Enabled = true;

                    ArrayVisualizer.ClearPanel(arrayPanel, Color.FromArgb(23, 23, 23));
                    Visualizer.VisualizeArray();

                    FormComponentsControl(true, startButton);
                }
                catch (System.Runtime.Serialization.SerializationException)
                {
                    DialogResult = MessageBox.Show("File is corrupted or array size is not valid! Do you want to clear the file?", "ArrayContainer.json", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (DialogResult == DialogResult.Yes)
                    {
                        Component.Clear();
                    }
                }
            }
        }

        //About program element click event
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) =>
            new HelpForm().ShowDialog();

        //Delete contents of json file event
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Component.Clear();
            MessageBox.Show("Succesfully cleared!", "ArrayContainer.json", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Visualization mode index changed event
        private void visualizationModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Arr != null)
            {
                ArrayVisualizer.ClearPanel(arrayPanel, Color.FromArgb(23, 23, 23));
                Visualizer.VisualizeArray();
            }
        }

        //Open json file event
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Component.Open();
        }

        //Open txt file event
        private void openToolStripMenuItem1_Click(object sender, EventArgs e) => Logger.Open("Log.txt");

        //Delete contents of txt file event
        private void clearToolStripMenuItem1_Click(object sender, EventArgs e) => Logger.Clear("Log.txt");
        #endregion

        #region Form components control methods
        private void ClearBox() =>
            complexityBox.Text = timeBox.Text = comparisonsBox.Text = swapsBox.Text = string.Empty;
        private static void FormComponentsControl(bool status, params Control[] controls)
        {
            foreach (var item in controls)
            {
                item.Enabled = status;
            }
        }
        private void SizeMessageBoxControl(string messageStatus)
        {
            switch (messageStatus)
            {
                case "max":
                    MessageBox.Show("Maximum size is 50000.", "Array Size warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case "min":
                    MessageBox.Show("Minimum size is 100.", "Array size warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    throw new ArgumentException("Invalid message status.");
            }

            sizeBox.Focus();
        }
        #endregion

        #region BackgroundWorker events
        //Separate thread start working event
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string sortType = string.Empty;

            if (shellButton.Checked)
            {
                sortType = "Shell";
            }
            else if (tokudaButton.Checked)
            {
                sortType = "Tokuda";
            }
            else if (sedgwickButton.Checked)
            {
                sortType = "Sedgwick";
            }
            else if (fibonacciButton.Checked)
            {
                sortType = "Fibonacci";
            }

            Engine.Start(sortType, e);
        }

        //Separate thread working completed vent
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FormComponentsControl(true, delayUpDown, sizeBox, reverseCheckBox);
            fileToolStripMenuItem.Enabled = menuToolStripMenuItem.Enabled = helpToolStripMenuItem.Enabled = true;

            if (e.Cancelled)
            {
                FormComponentsControl(false, startButton);
                FormComponentsControl(true, generateButton);

                arrayPanel.BackgroundImage = new Bitmap(@"D:\Projects\IO.png");
                ClearBox();
            }
            else
            {
                FormComponentsControl(true, generateButton, startButton);

                timeBox.Text = $"{Engine.ElapsedMilliseconds}(ms), " +
                    $"{Math.Round((float)Engine.ElapsedMilliseconds / 1000, 1)}(sec)";

                comparisonsBox.Text = Engine.Comparisons.ToString();
                swapsBox.Text = Engine.Swaps.ToString();
                complexityBox.Text = Engine.Complexity;

                Logger.Write(Engine, "Log.txt");
                if (arrayAutoSaveComboBox.SelectedIndex == 1)
                {
                    Component.Write(Arr!);
                }
            }

            sizeBox.Select();
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((DialogResult = MessageBox.Show("Do you want to close the application?", "Sort.Io", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}