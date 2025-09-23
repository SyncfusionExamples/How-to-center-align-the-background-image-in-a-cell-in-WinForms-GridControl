using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridControl_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridControl1.RowCount = 10;
            gridControl1.ColCount = 4;        
        }
        
        private void OnAddImage(object sender, EventArgs e)
        {
            var img = Image.FromFile(@"..\..\Images\img.png");
            this.gridControl1[2, 2].CellType = "Image";
            this.gridControl1[2, 2].BackgroundImage = img;
            this.gridControl1[2,2].BackgroundImageMode = GridBackgroundImageMode.CenterImage;
        }
    }
}
