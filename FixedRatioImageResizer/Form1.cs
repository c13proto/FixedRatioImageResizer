using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (ImageFiles.Count > 0) {
                    Image src =  Image.FromFile(ImageFiles[0]);
                    pictureBox1.Width = src.Width;
                    pictureBox1.Height = src.Height;
                    pictureBox1.Image=src;
                    this.Width = src.Width + 200;
                    this.Height = src.Height + 50;
                    
                }

            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {

        }

        //private void makeAmazonSellerImage2(string src, int dstWidth, int dstHeight)
        //{
        //    Bitmap orgImage = new Bitmap(src);

        //    Bitmap baseImage = new Bitmap(dstWidth, dstHeight);

        //    int resizeWidth, resizeHeight;
        //    if (dstWidth * orgImage.Height / orgImage.Width > dstHeight)//高さで合わせるパターン
        //    {
        //        resizeHeight = dstHeight;
        //        resizeWidth = resizeHeight * orgImage.Width / orgImage.Height;
        //    }
        //    else
        //    {
        //        resizeWidth = dstWidth;
        //        resizeHeight = resizeWidth * orgImage.Height / orgImage.Width;
        //    }
        //    Bitmap resizeBmp = new Bitmap(resizeWidth, resizeHeight);
        //    Cv2.Resize(orgImage, orgImage, new OpenCvSharp.Size(resize_width, resize_height));

        //    int paddWidth = (baseImage.Width - orgImage.Width) / 2;
        //    int paddHeight = (baseImage.Height - orgImage.Height) / 2;
        //    Mat ROI = new Mat(baseImage, new Rect(paddWidth, paddHeight, resize_width, resize_height));

        //    orgImage.CopyTo(ROI);
        //    Cv2.ImShow(src, baseImage);


        //    orgImage.Release();
        //    baseImage.Release();
        //    ROI.Release();
        //}
    }
}
