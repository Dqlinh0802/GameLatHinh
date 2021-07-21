namespace Game
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.btReturn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.Maroon;
            this.btReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReturn.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btReturn.Location = new System.Drawing.Point(1259, 709);
            this.btReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(176, 66);
            this.btReturn.TabIndex = 0;
            this.btReturn.Text = "Return";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(157, 78);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1073, 612);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(67, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "High Scores :";
            // 
            // lbHS
            // 
            this.lbHS.BackColor = System.Drawing.Color.Black;
            this.lbHS.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbHS.ForeColor = System.Drawing.Color.Coral;
            this.lbHS.Location = new System.Drawing.Point(320, 11);
            this.lbHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHS.Name = "lbHS";
            this.lbHS.Size = new System.Drawing.Size(165, 46);
            this.lbHS.TabIndex = 2;
            this.lbHS.Text = "00";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(576, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Scores :";
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.Black;
            this.lbDiem.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbDiem.ForeColor = System.Drawing.Color.Coral;
            this.lbDiem.Location = new System.Drawing.Point(829, 11);
            this.lbDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(161, 46);
            this.lbDiem.TabIndex = 2;
            this.lbDiem.Text = "00";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(1089, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time :";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Black;
            this.lbTime.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbTime.ForeColor = System.Drawing.Color.Coral;
            this.lbTime.Location = new System.Drawing.Point(1224, 11);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(103, 46);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "0";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(47, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 48);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 778);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbHS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewGame_FormClosed);
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button button1;
    }
}