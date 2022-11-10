namespace Sort.Io
{
    //Array visualization class
    public class ArrayVisualizer
    {
        #region Ctor
        public ArrayVisualizer(MainForm form)
        {
            Form = form;
            ArraySize = form.Arr!.Length;

            ArrayPanelWidth = form.arrayPanel.Width;
            ArrayPanelHeight = form.arrayPanel.Height;

            Arr = form.Arr;

            Scope = (float)form.arrayPanel.Width / ArraySize > 2 ? 1 : 0;
        }
        #endregion

        #region Graphic variables
        public Graphics Graphic { get; private set; } //Determines the graphical components on the panel
        public SolidBrush WhiteBrush { get; private set; } = new SolidBrush(Color.White);
        public SolidBrush BlackBrush { get; private set; } = new SolidBrush(Color.FromArgb(23, 23, 23));
        #endregion

        #region Form variables
        public static MainForm Form { get; private set; }
        public int ArraySize { get; private set; }

        private int[] Arr;

        public int ArrayPanelWidth { get; private set; }
        public int ArrayPanelHeight { get; private set; }
        public int Scope { get; private set; } //Determines the size of the elements on the panel
        #endregion

        #region Methods
        //Clear panel with black color
        public static void ClearPanel(PictureBox panel, Color color)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(color);
        }

        //Generates array with its size and maximum value
        public static int[] GenerateArray(int count, int maxValue)
        {
            var random = new Random();
            var arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = random.Next(maxValue);
            }

            return arr;
        }

        //Visualizes the array on the panel
        public void VisualizeArray()
        {
            Bitmap bitmap = new Bitmap(Form.arrayPanel.Width, Form.arrayPanel.Height);
            Form.arrayPanel.BackgroundImage = bitmap;
            Form.arrayPanel.BackColor = Color.FromArgb(23, 23, 23);
            Graphic = Graphics.FromImage(bitmap);

            for (int i = 0; i < ArraySize; i++)
            {
                Graphic.FillRectangle(WhiteBrush,
                    (float)ArrayPanelWidth / ArraySize * i,
                    (ArrayPanelHeight - Arr[i]) / Form.SortVisualizationValueMode,
                    (float)ArrayPanelWidth / ArraySize - Scope,
                    Arr[i]);
            }
        }

        //Update graphics on the panel
        public static void UpdateGraphics(Bitmap bitmap, int[] arr, int scope, int sortVisualizationValueMode)
        {
            Graphics g = Graphics.FromImage(bitmap);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            for (int i = 0; i < arr.Length; i++)
            {
                g.FillRectangle(whiteBrush, (float)bitmap.Width / arr.Length * i, (bitmap.Height - arr[i]) / sortVisualizationValueMode, (float)bitmap.Width / arr.Length - scope, arr[i]);
            }

            Form.arrayPanel.BackgroundImage = bitmap;
        }
        #endregion
    }
}