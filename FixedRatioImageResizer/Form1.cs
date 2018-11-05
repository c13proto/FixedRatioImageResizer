using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;

namespace FixedRatioImageResizer
{
    public partial class FixedRatioImageResizer : Form
    {
        public List<string> ImageFiles;
        public FixedRatioImageResizer()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {

            };
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            //複数のファイルを選択できるようにする
            ofd.Multiselect = true;
            // フィルタ
            ofd.Filter = "画像ファイル|*.bmp;*.gif;*.jpg;*.png|全てのファイル|*.*";
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ImageFiles != null) ImageFiles.Clear();
                ImageFiles = new List<string>();
                //OKボタンがクリックされたとき、選択されたファイル名をすべて表示する
                foreach (string fn in ofd.FileNames)
                    ImageFiles.Add(fn);
                if (ImageFiles.Count > 0) 
                    pictureBox1.ImageLocation= ImageFiles[0];                

            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (ImageFiles.Count > 0)
            {
                int dstWidth = Int16.Parse(textBox_width.Text);
                int dstHeight = Int16.Parse(textBox_height.Text);
                foreach (string file in ImageFiles)
                {
                    makeResizeImage(file,dstWidth, dstHeight);
                }
                string fileType = Path.GetExtension(ImageFiles[0]);
                pictureBox1.ImageLocation = ImageFiles[0].Replace(fileType, "_" + dstWidth + "x" + dstHeight + ".jpg");
                MessageBox.Show("complete!");
            }
            else MessageBox.Show("please open image files before start");
        }

        private void makeResizeImage(string src, int dstWidth, int dstHeight)
        {
            Bitmap orgImage = new Bitmap(src);

            Bitmap baseImage = new Bitmap(dstWidth, dstHeight);

            int resizeWidth, resizeHeight;//まずは枠ぴったりにつくる
            if (dstWidth * orgImage.Height / orgImage.Width > dstHeight)//高さで合わせるパターン
            {
                resizeHeight = dstHeight;
                resizeWidth = resizeHeight * orgImage.Width / orgImage.Height;
            }
            else
            {
                resizeWidth = dstWidth;
                resizeHeight = resizeWidth * orgImage.Height / orgImage.Width;
            }
            resizeWidth -= 2 * Int16.Parse(textBox_frame.Text);//フレーム幅だけ小さくする
            resizeHeight -= 2 * Int16.Parse(textBox_frame.Text);

            Bitmap resizeImage = getResizeBitmap(orgImage, resizeWidth, resizeHeight);


            int paddWidth = (baseImage.Width - resizeImage.Width) / 2;
            int paddHeight = (baseImage.Height - resizeImage.Height) / 2;

            Graphics g = Graphics.FromImage(baseImage);
            g.Clear(Color.FromArgb(Int16.Parse(textBox_r.Text), Int16.Parse(textBox_g.Text), Int16.Parse(textBox_b.Text)));
            g.DrawImage(resizeImage, new Point(paddWidth, paddHeight));
            string fileType = Path.GetExtension(src);
            baseImage.Save(src.Replace(fileType,"_"+dstWidth+"x"+dstHeight+".jpg"));
            
            orgImage.Dispose();
            baseImage.Dispose();
            resizeImage.Dispose();

        }

        private Bitmap getResizeBitmap(Bitmap srcBitmap,int dstWidth, int dstHeight) {
            Bitmap resizeBmp = new Bitmap(dstWidth, dstHeight);
            Graphics g = Graphics.FromImage(resizeBmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.DrawImage(srcBitmap, 0, 0, dstWidth, dstHeight);
            g.Dispose();
            return resizeBmp;
        }

    }
}
