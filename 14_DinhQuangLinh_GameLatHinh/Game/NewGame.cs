using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Game
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int anh1; // giá trị random của mảng 1 
        int vitri; // random giá trị bằng vitri từ mảng 1 vào mảng 2
        int dong = DC.dong; //Biến dùng chung để gọi 3 level Dễ-Trung Bình-Khó
        int cot = DC.cot;
        string path = Application.StartupPath + @"\PicGame\"; 
        string[] mangAnh = Directory.GetFiles(Application.StartupPath + @"\PicGame\Pic\");
        int[] mang1 = new int[DC.dong * DC.cot];
        int[] mang2 = new int[DC.dong * DC.cot];
        List<Button> dsbt = new List<Button>();
        bool lan1 = false;
        bool lan2 = false;
        bool sound1 = false;
        bool sound2 = false;
        string name1 = "";
        string name2 = "";
        string txt1 = "";
        string txt2 = "";
        int newSize = 1;
        Timer timer1, timer2;
        int lanClick = 1;
        int count = DC.countDown-1; //Biến điếm thời gian chơi
        int diem = DC.countDown / 3; //Biến tính điểm 
        WindowsMediaPlayer sound = new WindowsMediaPlayer();

        //Hoàn thành game mới được return 
        private void btReturn_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer2.Stop();
            sound.controls.stop();
            this.Close();
        }
        private void NewGame_Load(object sender, EventArgs e)
        {
            //randon âm thanh 
            int a = rand.Next(0, 5);
            sound.URL = Application.StartupPath + @"\Sound\"+ a +".mp3";
            sound.controls.play();
            //Xuất listBox1 chứa controls
            if (DC.cot == 6)
                listBox1.SetBounds(135, 60, DC.cot * 110+20 * (DC.cot+1), 512);
            else if(DC.cot == 5)
                listBox1.SetBounds(190, 60, DC.cot * 110 + 20 * (DC.cot + 1), 512);
            else
                listBox1.SetBounds(270, 60, DC.cot * 110 + 20 * (DC.cot + 1), 512);
            taoMang1();
            taoMang2();
            taoMangButton();
            lbTime.Text = DC.countDown.ToString();
            //Đọc High Scores từ files .txt
            StreamReader readHS = new StreamReader(Application.StartupPath + @"\HighScores.txt");
            lbHS.Text = readHS.ReadLine();
            readHS.Close();
        }
        // Tạo 2 mảng ảnh
        void taoMang1()
        {
            for (int i = 0; i < cot + cot; i++)
            {
                anh1 = rand.Next(0, mangAnh.Length);
                while (mang1.Contains(anh1))
                {
                    anh1 = rand.Next(0, mangAnh.Length);
                }
                mang1[i] = anh1;
            }
        }
        void taoMang2()
        {
            for (int i = 0; i < cot + cot; i++)
            {
                vitri = rand.Next(0, mang1.Length);
                while (mang2.Contains(mang1[vitri]))
                {
                    vitri = rand.Next(0, mang1.Length);
                }
                mang2[i] = mang1[vitri];
            }
        }
        //Tạo hình từ 2 mảng

        void newButton(int a, int b, int dem)
        {
            Button bt = new Button();
            //Gán ảnh mặc định cho Button
            bt.BackgroundImage = Image.FromFile(path + "99.jpg");
            bt.BackgroundImageLayout = ImageLayout.Stretch;
            bt.Name = dem.ToString();
            bt.Location = new Point(a, b);
            bt.Width = 110;
            bt.Height = 100;
            //Làm trắng đường viền của Button
            bt.TabStop = false;
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
            dsbt.Add(bt);
            bt.Click += Bt_Click;
        }
        private void kiemTraThang(List<Button> dsbt)
        {
            int dem = 0;
            //Kiểm tra số hình được lật
            for (int i = 0; i < dsbt.Count; i++)
                if (dsbt[i].Text == "100")
                    dem++;
            if (dem == dsbt.Count)
            {
                timer2.Stop();
                //Tính điểm
                lbDiem.Text = (int.Parse(lbDiem.Text) * int.Parse(lbTime.Text)).ToString();
                int diem = int.Parse(lbDiem.Text);
                int HS = int.Parse(lbHS.Text);
                //Tắt nhạc
                sound.controls.stop();
                if (diem > HS)
                {
                    lbHS.Text = lbDiem.Text;
                    //Ghi High Scores vào file .txt
                    StreamWriter writer = new StreamWriter(Application.StartupPath + @"\HighScores.txt");
                    writer.WriteLine(lbHS.Text);
                    writer.Close();
                    MessageBox.Show("Điểm cao mới!");
                }
                if (MessageBox.Show("Play Again", "You Win", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
                else
                    Application.Exit();
            }
        }
        void kiemtraThua(List<Button> dsbt,int count)
        {
            int dem = 0;
            for (int i = 0; i < dsbt.Count; i++)
                if (dsbt[i].Text == "100")
                    dem++;
            if (dem != dsbt.Count && count == 0)
            {
                if (MessageBox.Show("Play Again", "You Lose", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.Close();
                else
                    Application.Exit();
            }
        }
        //Kiểm tra button được click
        private void Bt_Click(object sender, EventArgs e)
        {
            if (lanClick == 1) 
            {
                timer2 = new Timer();
                timer2.Tick += Timer2_Tick;
                timer2.Interval = 1000;
                timer2.Start();
                lanClick--;
            }
            //Click lần 1
            if (lan1 != true)
            {
                lan1 = true;
                gan((Button)sender);
                name1 = ((Button)sender).Name;
                txt1 = ((Button)sender).Text;
                ((Button)sender).Enabled = false;
            }
            //Click lần 2
            else if (lan2 != true)
            {
                lan2 = true;
                gan((Button)sender);
                name2 = ((Button)sender).Name;
                txt2 = ((Button)sender).Text;
                ((Button)sender).Enabled = false;
                if (txt1 == txt2)
                {
                    lbDiem.Text = (int.Parse(lbDiem.Text) + diem).ToString();
                    timer1 = new Timer();
                    timer1.Enabled = true;
                    timer1.Tick += Timer1_Tick;
                    timer1.Interval = 200;
                }
                else if (txt1 != txt2)
                {
                    timer1 = new Timer();
                    timer1.Enabled = true;
                    timer1.Tick += Timer1_Tick1;
                    timer1.Interval = 300;
                }
            }
        }
        //Chạy thời gian chơi điếm ngược
        private void Timer2_Tick(object sender, EventArgs e)
        {
            lbTime.Text = count.ToString();
            if (count == 0)
            {
                timer2.Stop(); 
                kiemtraThua(dsbt, count);
            }    
            count--;
        }
        //Xóa hình khi lật đúng
        private void Timer1_Tick(object sender, EventArgs e)
        {
            dsbt[int.Parse(name1)].BackgroundImage = Image.FromFile(path + "100.jpg");
            dsbt[int.Parse(name1)].Text = "100";
            dsbt[int.Parse(name2)].BackgroundImage = Image.FromFile(path + "100.jpg");
            dsbt[int.Parse(name2)].Text = "100";
            lan1 = lan2 = false;
            timer1.Enabled = false;
            kiemTraThang(dsbt);
        }
        //Gán lại hình mặc định khi lật sai
        private void Timer1_Tick1(object sender, EventArgs e)
        {
            dsbt[int.Parse(name1)].BackgroundImage = Image.FromFile(path + "99.jpg");
            dsbt[int.Parse(name1)].Enabled = true;
            dsbt[int.Parse(name2)].BackgroundImage = Image.FromFile(path + "99.jpg");
            dsbt[int.Parse(name2)].Enabled = true;
            lan1 = lan2 = false;
            timer1.Enabled = false;
        }
        //Gán backgroundImage cho Button
        void gan(Button b)
        {
            for (int i = 0; i < dong; i++)
                for (int j = 0; j < cot; j++)
                {
                    if (b.Location.X == (20 * (j + 1) + 110 * j) && b.Location.Y == (20))
                    {
                        b.BackgroundImage = Image.FromFile(mangAnh[mang1[j]]);
                        b.BackgroundImageLayout = ImageLayout.Stretch;
                        b.Text = mangAnh[mang1[j]].Substring(mangAnh[mang1[j]].Length - 6, 2);
                        b.Font = new Font(b.Font.FontFamily, newSize);
                    }
                    if (b.Location.X == (20 * (j + 1) + 110 * j) && b.Location.Y == (140))
                    {
                        b.BackgroundImage = Image.FromFile(mangAnh[mang2[j]]);
                        b.BackgroundImageLayout = ImageLayout.Stretch;
                        b.Text = mangAnh[mang2[j]].Substring(mangAnh[mang2[j]].Length - 6, 2);
                        b.Font = new Font(b.Font.FontFamily, newSize);
                    }
                    if (b.Location.X == (20 * (j + 1) + 110 * j) && b.Location.Y == (260))
                    {
                        b.BackgroundImage = Image.FromFile(mangAnh[mang1[j+cot]]);
                        b.BackgroundImageLayout = ImageLayout.Stretch;
                        b.Text = mangAnh[mang1[j + cot]].Substring(mangAnh[mang1[j + cot]].Length - 6, 2);
                        b.Font = new Font(b.Font.FontFamily, newSize);
                    }
                    if (b.Location.X == (20 * (j + 1) + 110 * j) && b.Location.Y == (380))
                    {
                        b.BackgroundImage = Image.FromFile(mangAnh[mang2[j + cot]]);
                        b.BackgroundImageLayout = ImageLayout.Stretch;
                        b.Text = b.Text = mangAnh[mang2[j + cot]].Substring(mangAnh[mang2[j + cot]].Length - 6, 2);
                        b.Font = new Font(b.Font.FontFamily, newSize);
                    }
                }
        }

        private void NewGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer2.Start();
            timer2.Stop();
            sound.controls.stop();
        }

        // Tắt/Bật âm thanh
        private void button1_Click(object sender, EventArgs e)
        {
            if (sound1 != true)
            {
                sound1 = true;
                ((Button)sender).BackgroundImage = Image.FromFile(path + "sound2.jpg");
                sound.controls.pause();
            }
            else if (sound2 != true)
            {
                sound2 = true;
                ((Button)sender).BackgroundImage = Image.FromFile(path + "sound1.jpg");
                sound.controls.play();
                sound1 = sound2 = false;
            }   
        }
        void taoMangButton()
        {
            int dem = 0;
            for (int i = 0; i < cot; i++)
            {
                for (int j = 0; j < dong; j++)
                {
                    if (j % 2 == 0)
                    {
                        newButton(20 * (i + 1) + 110 * i, 20 * (j + 1) + j * 100, dem);
                        listBox1.Controls.Add(dsbt[dem]);
                        dem++;
                        newButton(20 * (i + 1) + 110 * i, 20 * (j + 2) + (j + 1) * 100, dem);
                        listBox1.Controls.Add(dsbt[dem]);
                        dem++;
                    }
                    else
                    {
                        newButton(20 * (i + 1) + 110 * i, 20 * (j + 1) + j * 100 + 120, dem);
                        listBox1.Controls.Add(dsbt[dem]);
                        dem++;
                        newButton(20 * (i + 1) + 110 * i, 20 * (j + 2) + (j + 1) * 100 + 120, dem);
                        listBox1.Controls.Add(dsbt[dem]);
                        dem++;
                    }
                }
            }
        }
    }
}
