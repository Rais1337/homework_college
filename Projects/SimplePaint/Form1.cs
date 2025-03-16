using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        private Bitmap canvasBitmap;
        private Graphics graphics;
        private bool isDrawing = false;
        private Point lastPoint;
        private CanvasHistory history;

        public Form1()
        {
            InitializeComponent();
            InitializeCanvas();

            history = new CanvasHistory();
            btnUndo.Enabled = false;
        }

        private void InitializeCanvas()
        {
            canvasBitmap = new Bitmap(panelCanvas.Width, panelCanvas.Height);
            graphics = Graphics.FromImage(canvasBitmap);
            graphics.Clear(Color.White);
            panelCanvas.BackgroundImage = canvasBitmap;
        }

        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            lastPoint = e.Location;

            history.SaveState(new Memento(canvasBitmap));
            btnUndo.Enabled = true;
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    g.DrawLine(pen, lastPoint, e.Location);
                }

                lastPoint = e.Location;
                panelCanvas.Invalidate();
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Memento previousState = history.Undo();

            if (previousState != null)
            {
                canvasBitmap = previousState.State;
                panelCanvas.BackgroundImage = canvasBitmap;
            }

            btnUndo.Enabled = history.Undo() != null;
        }
    }
}
