using static System.Math;
using System.Diagnostics;
using System.ComponentModel;

namespace Sort.Io
{
    //Sort components class
    [Serializable]
    internal class SortingEngine
    {
        #region Ctors
        public SortingEngine(MainForm form, BackgroundWorker worker, ArrayVisualizer visualizer)
        {
            Arr = form.Arr!;

            FormPanelHeight = form.arrayPanel.Height;
            FormPanelWidth = form.arrayPanel.Width;

            Worker = worker;

            Delay = (int)form.delayUpDown.Value;
            Reversed = form.reverseCheckBox.Checked;
            VisualizationValueMode = form.visualizationModeComboBox.SelectedIndex + 1;
            Scope = (float)form.arrayPanel.Width / Arr.Length > 2 ? 1 : 0;

            Graphic = form.arrayPanel.CreateGraphics();
            WhiteBrush = visualizer.WhiteBrush;
            BlackBrush = visualizer.BlackBrush;
        }
        public SortingEngine() { }
        #endregion

        #region Graphic variables
        private readonly Brush WhiteBrush;
        private readonly Brush BlackBrush;
        private readonly Brush RedBrush = new SolidBrush(Color.Red);
        private Graphics Graphic { get; set; }
        #endregion

        #region Sort stuff variables
        public int[] Arr { get; private set; }
        public int Count => Arr.Length;

        private BackgroundWorker Worker { get; set; }
      
        public bool Reversed { get; set; }

        private int FormPanelHeight { get; set; }
        private int FormPanelWidth { get; set; }

        public int Comparisons { get; private set; }
        public int Swaps { get; private set; }
        public int ElapsedMilliseconds { get; private set; }

        public int Scope { get; private set; }
        public int Delay { get; private set; }
        private int VisualizationValueMode { get; set; }

        public string Complexity { get; set; }
        public string SortType { get; private set; }
        #endregion

        #region Sort and swap stuff methods
        //Starts sorting algorithm working
        public void Start(string sortType, DoWorkEventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();

            SortType = sortType;

            switch (sortType)
            {
                case "Shell":
                    ShellSequence(Delay, e);
                    break;
                case "Tokuda":
                    TokudaSequence(Delay, e);
                    break;
                case "Sedgwick":
                    SedgwickSequence(Delay, e);
                    break;
                case "Fibonacci":
                    FibonacciSequence(Delay, e);
                    break;
                default:
                    throw new ArgumentException("Invalid sort type.");
            }

            timer.Stop();
            Complexity = SpaceComplexityCalc(sortType);
            ElapsedMilliseconds = (int)timer.ElapsedMilliseconds;
        }

        //Performs sorting algorithm working
        private void DoWork(ref int step, int delay, DoWorkEventArgs e)
        {
            if(Reversed == false)
            {
                for (int i = step; i < Arr.Length; i++)
                {
                    int j = i;
                    Comparisons++;

                    while (j >= step && Arr[j - step] > Arr[j])
                    {
                        if(Worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        Swap(j, j - step, delay);
                        j -= step;
                        Swaps++;
                    }
                }
            }
            else
            {
                for (int i = step; i < Arr.Length; i++)
                {
                    int j = i;
                    Comparisons++;

                    while (j >= step && Arr[j - step] < Arr[j])
                    {
                        if (Worker.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        Swap(j, j - step, delay);
                        j -= step;
                        Swaps++;
                    }
                }
            }
        }

        //Swap elements in the array
        private void Swap(int ind1, int ind2, int delay)
        {
            Graphic.FillRectangle(RedBrush, (float)FormPanelWidth / Arr.Length * ind1, (FormPanelHeight - Arr[ind1]) / VisualizationValueMode, (float)FormPanelWidth / Arr.Length - Scope, Arr[ind1]);
            Graphic.FillRectangle(RedBrush, (float)FormPanelWidth / Arr.Length * ind2, (FormPanelHeight - Arr[ind2]) / VisualizationValueMode, (float)FormPanelWidth / Arr.Length - Scope, Arr[ind2]);

            (Arr[ind2], Arr[ind1]) = (Arr[ind1], Arr[ind2]);
            Thread.Sleep(delay);
            Redraw(ind1, ind2);
        }

        //Redraw graphical elements
        private void Redraw(int ind1, int ind2)
        {
            Graphic.FillRectangle(BlackBrush, (float)FormPanelWidth / Arr.Length * ind1, 0, (float)FormPanelWidth / Arr.Length - Scope, FormPanelHeight);
            Graphic.FillRectangle(BlackBrush, (float)FormPanelWidth / Arr.Length * ind2, 0, (float)FormPanelWidth / Arr.Length - Scope, FormPanelHeight);

            Graphic.FillRectangle(WhiteBrush, (float)FormPanelWidth / Arr.Length * ind1, (FormPanelHeight - Arr[ind1]) / VisualizationValueMode, (float)FormPanelWidth / Arr.Length - Scope, Arr[ind1]);
            Graphic.FillRectangle(WhiteBrush, (float)FormPanelWidth / Arr.Length * ind2, (FormPanelHeight - Arr[ind2]) / VisualizationValueMode, (float)FormPanelWidth / Arr.Length - Scope, Arr[ind2]);
        }
        private string SpaceComplexityCalc(string sortType) => "O(1)";
        #endregion

        #region Shell sequence
        public void ShellSequence(int delay, DoWorkEventArgs e)
        {
            int step = Arr.Length / 2;

            while (step > 0)
            {
                DoWork(ref step, delay, e);
                step /= 2;
            }

            ArrayVisualizer.UpdateGraphics(new Bitmap(FormPanelWidth, FormPanelHeight), Arr, Scope, VisualizationValueMode);
        }
        #endregion

        #region Tokuda sequence
        public void TokudaSequence(int delay, DoWorkEventArgs e)
        {
            int k = 0, step = (int)Ceiling(1 / 5d * (9 * Pow(9 / 4d, k++) - 4));

            while ((int)Ceiling(1 / 5d * (9 * Pow(9 / 4d, k) - 4)) < Arr.Length)
            {
                step = (int)Ceiling(1 / 5d * (9 * Pow(9 / 4d, k++) - 4));
            }

            while (step > 0)
            {
                DoWork(ref step, delay, e);
                step = (int)Ceiling(1 / 5d * (9 * Pow(9 / 4d, --k) - 4));
            }

            ArrayVisualizer.UpdateGraphics(new Bitmap(FormPanelWidth, FormPanelHeight), Arr, Scope, VisualizationValueMode);
        }

        #endregion

        #region Fibonacci sequence
        public void FibonacciSequence(int delay, DoWorkEventArgs e)
        {
            int k = 0, step = 0;

            while (step < Arr.Length)
            {
                step = (int)Round((Pow(1.6180339d, k++) - Pow(1d - Sqrt(5) / 2d, k)) / Sqrt(5));
            }

            step = (int)Round((Pow(1.6180339d, --k - 1) - Pow(1d - Sqrt(5) / 2d, k)) / Sqrt(5));

            while (step > 0)
            {
                DoWork(ref step, delay, e);
                step = (int)Round((Pow(1.6180339d, --k - 1) - Pow(1d - Sqrt(5) / 2d, k)) / Sqrt(5));
            }

            ArrayVisualizer.UpdateGraphics(new Bitmap(FormPanelWidth, FormPanelHeight), Arr, Scope, VisualizationValueMode);
        }
        #endregion

        #region Sedgwick sequence
        public void SedgwickSequence(int delay, DoWorkEventArgs e)
        {
            int k = -1, step = 0;

            while (step < Arr.Length)
            {
                if (++k % 2 == 0) { step = (int)Ceiling(9 * (Pow(2, k) - Pow(2, k / 2d)) + 1); }
                else { step = (int)Ceiling(8 * Pow(2, k) - 6 * Pow(2, (k + 1) / 2) + 1); }
            }

            if (k % 2 != 0) { step = (int)Ceiling(9 * (Pow(2, --k) - Pow(2, k / 2d)) + 1); }
            else { step = (int)Ceiling(8 * Pow(2, --k) - 6 * Pow(2, (k + 1) / 2) + 1); }

            while (step > 0)
            {
                DoWork(ref step, delay, e);

                if (k % 2 != 0) { step = (int)Ceiling(9 * (Pow(2, --k) - Pow(2, k / 2d)) + 1); }
                else { step = (int)Ceiling(8 * Pow(2, --k) - 6 * Pow(2, (k + 1) / 2) + 1); }
            }

            ArrayVisualizer.UpdateGraphics(new Bitmap(FormPanelWidth, FormPanelHeight), Arr, Scope, VisualizationValueMode);
        }
        #endregion
    }
}