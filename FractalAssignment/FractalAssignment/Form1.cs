using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FractalAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();          
            init();
        }

        #region HSB
        public struct HSBColor
        {
            float h;
            float s;
            float b;
            int a;

            public HSBColor(float h, float s, float b)
            {
                this.a = 0xff;
                this.h = Math.Min(Math.Max(h, 0), 255);
                this.s = Math.Min(Math.Max(s, 0), 255);
                this.b = Math.Min(Math.Max(b, 0), 255);
            }

            public HSBColor(int a, float h, float s, float b)
            {
                this.a = a;
                this.h = Math.Min(Math.Max(h, 0), 255);
                this.s = Math.Min(Math.Max(s, 0), 255);
                this.b = Math.Min(Math.Max(b, 0), 255);
            }

            public float H
            {
                get { return h; }
            }

            public float S
            {
                get { return s; }
            }

            public float B
            {
                get { return b; }
            }

            public int A
            {
                get { return a; }
            }

            public Color Color
            {
                get
                {
                    return FromHSB(this);
                }
            }

            public static Color FromHSB(HSBColor hsbColor)
            {
                float r = hsbColor.b;
                float g = hsbColor.b;
                float b = hsbColor.b;
                if (hsbColor.s != 0)
                {
                    float max = hsbColor.b;
                    float dif = hsbColor.b * hsbColor.s / 255f;
                    float min = hsbColor.b - dif;

                    float h = hsbColor.h * 360f / 255f;

                    if (h < 60f)
                    {
                        r = max;
                        g = h * dif / 60f + min;
                        b = min;
                    }
                    else if (h < 120f)
                    {
                        r = -(h - 120f) * dif / 60f + min;
                        g = max;
                        b = min;
                    }
                    else if (h < 180f)
                    {
                        r = min;
                        g = max;
                        b = (h - 120f) * dif / 60f + min;
                    }
                    else if (h < 240f)
                    {
                        r = min;
                        g = -(h - 240f) * dif / 60f + min;
                        b = max;
                    }
                    else if (h < 300f)
                    {
                        r = (h - 240f) * dif / 60f + min;
                        g = min;
                        b = max;
                    }
                    else if (h <= 360f)
                    {
                        r = max;
                        g = min;
                        b = -(h - 360f) * dif / 60 + min;
                    }
                    else
                    {
                        r = 0;
                        g = 0;
                        b = 0;
                    }
                }

                return Color.FromArgb
                    (
                        hsbColor.a,
                        (int)Math.Round(Math.Min(Math.Max(r, 0), 255)),
                        (int)Math.Round(Math.Min(Math.Max(g, 0), 255)),
                        (int)Math.Round(Math.Min(Math.Max(b, 0), 255))
                    );
            }

        }
        #endregion

        State mandelState = new State();

        private const int MAX = 256;      // max iterations
        private const double SX = -2.025; // start value real
        private const double SY = -1.125; // start value imaginary
        private const double EX = 0.6;    // end value real
        private const double EY = 1.125;  // end value imaginary
        private static int x1, y1, xs, ys, xe, ye, framenumber;
        private static double xstart, ystart, xende, yende, xzoom, yzoom, cycleValue, warpValue;
        private static bool action, rectangle, finished, isDown, cycle, auto, warp, animate;
        private static float xy;
        private Bitmap picture, frameimage;
        private Graphics g1;
        private Cursor c1, c2;
        private HSBColor HSBcol = new HSBColor();
        private Rectangle rect;
        private static string frametxt;

        public void init() // all instances will be prepared
        {
            Text = "MandelBrot";
            HSBcol = new HSBColor();
            panel2.BackColor = Color.FromArgb(95, Color.Black);
            x1 = 640;
            y1 = 480;
            finished = false;
            c1 = Cursors.WaitCursor;
            c2 = Cursors.Cross;
            xy = (float)x1 / (float)y1;
            picture = new Bitmap(x1, y1);
            g1 = Graphics.FromImage(picture);
            finished = true;       
        }

        public void destroy() // delete all instances 
        {
            if (finished)
            {
                picture = null;
                g1 = null;
                c1 = null;
                c2 = null;
                frameimage.Dispose();
                GC.Collect(); // garbage collection
            }
        }

        public void start()
        {
            action = false;
            isDown = false;
            rectangle = false;
            cycle = false;
            auto = false;
            warp = false;
            animate = false;
            initvalues();
            if (File.Exists("state.xml"))
            {
                Loadconfig();
                xzoom = mandelState._xzoom;
                yzoom = mandelState._yzoom;
                xstart = mandelState._xstart;
                ystart = mandelState._ystart;
                xende = mandelState._xende;
                yende = mandelState._yende;
                stateMessage.Text = "State Loaded";
                stateMessage.Refresh();
            }
            else
            {
                stateMessage.Text = "You have 0 saved states";
                stateMessage.Refresh();
                xzoom = (xende - xstart) / (double)x1;
                yzoom = (yende - ystart) / (double)y1;
            }

            if (!File.Exists("framecount.txt"))
            {
                var frametxt = File.CreateText("framecount.txt");
                frametxt.Close();
                File.WriteAllText("framecount.txt", "0");
                framenumber = 1;
            }
            if (File.Exists("framecount.txt"))
            {
                string line;
                StreamReader framestream = new StreamReader("framecount.txt");               
                line = framestream.ReadLine();
                frameCount.Text = "Animation Frames " + line + "/10";
                framenumber = int.Parse(line);
                frameCount.Refresh();
                framestream.Close();
                framestream.Dispose();
            }

            mandelbrot();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            warp = true;
            cycle = true;        
            warpValue = 0;
            cycleValue = 0;
            trackBar1.Value = 0;
            trackBar1.Refresh();
            trackBar2.Value = 0;
            trackBar2.Refresh();
            mandelbrot();
            Refresh();
        }

        private void random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            warp = true;
            cycle = true;
            cycleValue = rand.NextDouble();
            warpValue = rand.NextDouble();
            mandelbrot();
            Refresh();
        }

        private void Warp_ValueChanged(object sender, EventArgs e)
        {
            warp = true;
            warpValue = trackBar2.Value / 10f;
            mandelbrot();
            Refresh();
        }


        private void AutoWarp_Click(object sender, EventArgs e)
        {
            warp = true;
            auto = true;
            for (double i = 0.1; i < 1.4; i = i + 0.05)
            {
                warpValue = i;
                mandelbrot();
                Refresh();
            }
            warp = false;
            auto = false;
            mandelbrot();
            Refresh();
        }

        private void Color_ValueChanged(object sender, EventArgs e)
        {
            if (!auto)
            {
                cycle = true;
                cycleValue = trackBar1.Value / 10f;
                mandelbrot();
                Refresh();
            }
        }

        private void CycleInput_Click(object sender, EventArgs e)
        {
            cycleInput.Visible = true;
        }

        private void AutoCycle_Click(object sender, EventArgs e)
        {
            int cyclenumber;
            int i = 0;
            double colourvalue = 0;
            cycleInput.Visible = false;
            Refresh();

            if (string.IsNullOrWhiteSpace(txtcyclenumber.Text))
            {
                cyclenumber = 1;
            }
            else
            {
                if (!int.TryParse(txtcyclenumber.Text, out cyclenumber))
                {
                    cyclenumber = 1;
                }
            }

            while (i < cyclenumber*10)
            {
                
                cycle = true;
                auto = true;

                if (colourvalue > 0.8)
                {
                    colourvalue = 0;
                }
                else
                {
                    colourvalue = colourvalue + 0.1;
                }

                i = i + 1;
                cycleValue = colourvalue;

                mandelbrot();
                Refresh();
            }

            cycle = false;
            auto = false;
            mandelbrot();
            Refresh();
        }

        public void stop()
        {
        }

        public void createRect()
        {
            if (rectangle)
            {               
                if (xs < xe)
                {
                    if (ys < ye) rect = new Rectangle(xs, ys, (xe - xs), (ye - ys));
                    else rect = new Rectangle(xs, ye, (xe - xs), (ys - ye));
                }
                else
                {
                    if (ys < ye) rect = new Rectangle(xe, ys, (xs - xe), (ye - ys));
                    else rect = new Rectangle(xe, ye, (xs - xe), (ys - ye));
                }
            }
        }

        private void mandelbrot() // calculate all points
        {
            int x, y;
            float h, b, alt = 0.0f;
            Pen pen;
            Color color;

            action = false;
            this.Cursor = c1;
            messageBox.Text = "Mandelbrot-Set will be produced - Please wait...";
            messageBox.Refresh();
            for (x = 0; x < x1; x += 2)
                for (y = 0; y < y1; y++)
                {
                    if (cycle)
                    {
                        h = pointcolour(xstart + xzoom*x, ystart + yzoom*y) + (float)cycleValue;
                            
                    }
                    else
                    {
                        h = pointcolour(xstart + xzoom *x, ystart + yzoom *y); // color value
                    }
                    
                    if (h != alt)
                    {

                        b = 1.0f - h * h; // brightnes                  
                        color = HSBColor.FromHSB(new HSBColor(h * 255, 0.8f * 255, b * 255));
                        pen = new Pen(color);
                        g1.DrawLine(pen, x, y, x + 1, y);
                        alt = h;
                    }
                    b = 1.0f - h * h; // brightnes
                    color = HSBColor.FromHSB(new HSBColor(h * 255, 0.8f * 255, b * 255));
                    pen = new Pen(color);
                    g1.DrawLine(pen, x, y, x + 1, y);
                }
            messageBox.Text = "Mandelbrot-Set ready - Please select zoom area";
            messageBox.Refresh();
            this.Cursor = c2;
            action = true;
        }

        private float pointcolour(double xwert, double ywert) // color value from 0.0 to 1.0 by iterations
        {
            double r , i = 0.0, m = 0.0;
            double j = 0;
            if (warp)
            {
                r = 0.0 + warpValue;
            }
            else
            {
                r = 0.0;
            }           

            while ((j < MAX) && (m < 4.0))
            {
                j++;
                m = r * r - i * i;
                i = 2.0 * r * i + ywert;
                r = m + xwert;
            }
            return (float)j / (float)MAX;

        }

        private void initvalues() // reset start values
        {
            xstart = SX;
            ystart = SY;
            xende = EX;
            yende = EY;
            if ((float)((xende - xstart) / (yende - ystart)) != xy)
                xstart = xende - (yende - ystart) * (double)xy;
        }

        private void Loadconfig()
        {
            XmlSerializer ser = new XmlSerializer(typeof(State));
            using (FileStream fs = File.OpenRead("state.xml"))
            {
                mandelState = (State)ser.Deserialize(fs);
            }
        }

        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //e.consume();
            if (action)
            {
                xs = e.X;
                ys = e.Y;
                isDown = true;

                if (File.Exists("state.xml"))
                {
                    stateMessage.Text = "You have 1 saved state";
                    stateMessage.Refresh();
                }
                else
                {
                    stateMessage.Text = "You have 0 saved states";
                    stateMessage.Refresh();
                }         
            }
        }

        private void Form1_MouseReleased(object sender, MouseEventArgs e)
        {
            int z, w;

            //e.consume();
            if (action)
            {
                xe = e.X;
                ye = e.Y;
                if (xs > xe)
                {
                    z = xs;
                    xs = xe;
                    xe = z;
                }
                if (ys > ye)
                {
                    z = ys;
                    ys = ye;
                    ye = z;
                }
                w = (xe - xs);
                z = (ye - ys);
                if ((w < 2) && (z < 2)) initvalues();
                else
                {
                    if (((float)w > (float)z * xy)) ye = (int)((float)ys + (float)w / xy);
                    else xe = (int)((float)xs + (float)z * xy);
                    xende = xstart + xzoom * (double)xe;
                    yende = ystart + yzoom * (double)ye;
                    xstart += xzoom * (double)xs;
                    ystart += yzoom * (double)ys;
                }
                xzoom = (xende - xstart) / (double)x1;
                yzoom = (yende - ystart) / (double)y1;
                mandelbrot();
                isDown = false;
                rectangle = false;
                Invalidate();
                if (!animate)
                {
                    framenumber++;

                    if (framenumber < 11)
                    {
                        frameCount.Text = "Animation Frames " + framenumber + "/10";
                        frameCount.Refresh();
                        picture.Save(framenumber + ".png");
                        picture.Save(framenumber + ".png");
                        File.WriteAllText("framecount.txt", framenumber.ToString());
                    }           
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //e.consume();
            if (action && isDown)
            {            
                xe = e.X;
                ye = e.Y;
                rectangle = true;
                createRect();            
                Invalidate();       
            }          
        }

        private void loadState_Click(object sender, EventArgs e)
        {
            if (File.Exists("state.xml"))
            {
                stateMessage.Text = "State Loaded               ";
                stateMessage.Refresh();
                Loadconfig();
                xzoom = mandelState._xzoom;
                yzoom = mandelState._yzoom;
                xstart = mandelState._xstart;
                ystart = mandelState._ystart;
                xende = mandelState._xende;
                yende = mandelState._yende;
                mandelbrot();
                Invalidate();
            }
            else
            {
                stateMessage.Text = "No state to load";
                stateMessage.Refresh();
            }
        }

        private void saveState_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = new StreamWriter("state.xml"))
            {
                stateMessage.Text = "State Saved";
                stateMessage.Refresh();
                mandelState._xzoom = xzoom;
                mandelState._yzoom = yzoom;
                mandelState._xstart = xstart;
                mandelState._ystart = ystart;
                mandelState._xende = xende;
                mandelState._yende = yende;
                XmlSerializer ser = new XmlSerializer(typeof (State));
                ser.Serialize(sw, mandelState);
            }
        }

        private void deleteState_Click(object sender, EventArgs e)
        {
            if (File.Exists("state.xml"))
            {
                File.Delete("State.xml");
                stateMessage.Text = "State Deleted";
                stateMessage.Refresh();
            }
            else
            {
                stateMessage.Text = "No state to delete";
                stateMessage.Refresh();
            }
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = "mandelbrot.png";
            // set filters - this can be done in properties as well
            savefile.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(savefile.FileName, FileMode.Create))
                {
                    picture.Save(s, ImageFormat.Png);
                    stateMessage.Text = "Image Saved";
                    stateMessage.Refresh();
                }    
            }
        }

        private async void start_animate(object sender, EventArgs e)
        {

            if (File.Exists("1.png"))
            {
                if (File.Exists("10.png"))
                {
                    animate = true;
                    int imageIndex = 1;
                    
                    stopToolStripMenuItem.Enabled = true;
                    saveToolStripMenuItem.Enabled = false;
                    saveStateToolStripMenuItem.Enabled = false;
                    loadStateToolStripMenuItem.Enabled = false;
                    deleteStateToolStripMenuItem.Enabled = false;
                    deleteFramesToolStripMenuItem.Enabled = false;
                    autoCycleToolStripMenuItem.Enabled = false;
                    autoWarpToolStripMenuItem.Enabled = false;
                    startToolStripMenuItem.Enabled = false;

                    while (animate)
                    {
                        frameimage = (Bitmap)Image.FromFile(imageIndex + ".png");
                        Invalidate();

                        await Task.Delay(100);

                        imageIndex++;
                        if (imageIndex > 10)
                        {
                            imageIndex = 1;
                        }
                    }
                }
                else
                {
                    stateMessage.Text = "Please record 10 zooms/frames";
                    stateMessage.Refresh();
                }

            }
            else
            {
                stateMessage.Text = "Please record 10 zooms/frames";
                stateMessage.Refresh();
            }

        }

        private void stop_animate(object sender, EventArgs e)
        {
            if (animate)
            {                
                animate = false;
                frameimage = null;
                mandelbrot();
                Invalidate();
                saveToolStripMenuItem.Enabled = true;
                saveStateToolStripMenuItem.Enabled = true;
                loadStateToolStripMenuItem.Enabled = true;
                deleteStateToolStripMenuItem.Enabled = true;
                deleteFramesToolStripMenuItem.Enabled = true;
                autoCycleToolStripMenuItem.Enabled = true;
                autoWarpToolStripMenuItem.Enabled = true;
                stopToolStripMenuItem.Enabled = false;
                startToolStripMenuItem.Enabled = true;
            }
            else
            {
                stateMessage.Text = "Animation isn't running";
                stateMessage.Refresh();
            }
        }

        private void delete_frames(object sender, EventArgs e)
        {
            if (!animate)
            {
                if (File.Exists("1.png"))
                {
                    for (int i = 0; i < 11; i++)
                    {
                        File.Delete(i + ".png");
                    }
                    stateMessage.Text = "Frames Deleted";
                    stateMessage.Refresh();
                    framenumber = 0;
                    frameCount.Text = "Animation Frames 0/10";
                    frameCount.Refresh();
                    File.WriteAllText("framecount.txt", "0");
                }
                else
                {
                    stateMessage.Text = "No frames to delete";
                    stateMessage.Refresh();
                }
            }
            else
            {
                stateMessage.Text = "Please stop the animation first";
                stateMessage.Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            //put the bitmap on the window
            Graphics windowG = e.Graphics;

            if (animate)
            {
                e.Graphics.DrawImageUnscaled(frameimage, 0, 0);
            }

            else
            {
                windowG.DrawImageUnscaled(picture, 0, 0);
            }


            //Draw rectangle
            if (rectangle)
            {
                using (Pen pen = new Pen(Color.White, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
        }

    }
}
