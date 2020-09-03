namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.open_dir = new System.Windows.Forms.Button();
            this.next_img = new System.Windows.Forms.Button();
            this.pre_img = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.single = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labellist = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.yolocb = new System.Windows.Forms.CheckBox();
            this.addlabel = new System.Windows.Forms.Button();
            this.voccb = new System.Windows.Forms.CheckBox();
            this.delete = new System.Windows.Forms.Button();
            this.autosave = new System.Windows.Forms.CheckBox();
            this.autoload = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.single.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // open_dir
            // 
            this.open_dir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.open_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_dir.BackgroundImage")));
            this.open_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_dir.FlatAppearance.BorderSize = 0;
            this.open_dir.Location = new System.Drawing.Point(1, 6);
            this.open_dir.Margin = new System.Windows.Forms.Padding(4);
            this.open_dir.Name = "open_dir";
            this.open_dir.Size = new System.Drawing.Size(76, 75);
            this.open_dir.TabIndex = 1;
            this.open_dir.Text = "open dir";
            this.open_dir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.open_dir.UseVisualStyleBackColor = false;
            this.open_dir.Click += new System.EventHandler(this.open_dir_Click);
            // 
            // next_img
            // 
            this.next_img.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.next_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_img.BackgroundImage")));
            this.next_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next_img.FlatAppearance.BorderSize = 0;
            this.next_img.Location = new System.Drawing.Point(1, 80);
            this.next_img.Margin = new System.Windows.Forms.Padding(4);
            this.next_img.Name = "next_img";
            this.next_img.Size = new System.Drawing.Size(76, 75);
            this.next_img.TabIndex = 2;
            this.next_img.Text = "next img";
            this.next_img.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.next_img.UseVisualStyleBackColor = false;
            this.next_img.Click += new System.EventHandler(this.next_img_Click);
            // 
            // pre_img
            // 
            this.pre_img.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pre_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pre_img.BackgroundImage")));
            this.pre_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pre_img.FlatAppearance.BorderSize = 0;
            this.pre_img.Location = new System.Drawing.Point(1, 154);
            this.pre_img.Margin = new System.Windows.Forms.Padding(4);
            this.pre_img.Name = "pre_img";
            this.pre_img.Size = new System.Drawing.Size(76, 75);
            this.pre_img.TabIndex = 3;
            this.pre_img.Text = "pre img";
            this.pre_img.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pre_img.UseVisualStyleBackColor = false;
            this.pre_img.Click += new System.EventHandler(this.pre_img_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.Location = new System.Drawing.Point(1, 228);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(76, 75);
            this.save.TabIndex = 4;
            this.save.Text = "save";
            this.save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 75);
            this.button1.TabIndex = 15;
            this.button1.Text = "load ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.single);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(112, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1383, 886);
            this.tabControl1.TabIndex = 16;
            // 
            // single
            // 
            this.single.Controls.Add(this.label8);
            this.single.Controls.Add(this.pictureBox1);
            this.single.Controls.Add(this.textBox5);
            this.single.Controls.Add(this.listBox1);
            this.single.Controls.Add(this.label7);
            this.single.Controls.Add(this.labellist);
            this.single.Controls.Add(this.textBox4);
            this.single.Controls.Add(this.label1);
            this.single.Controls.Add(this.label6);
            this.single.Controls.Add(this.label2);
            this.single.Controls.Add(this.textBox3);
            this.single.Controls.Add(this.label3);
            this.single.Controls.Add(this.label5);
            this.single.Controls.Add(this.label4);
            this.single.Controls.Add(this.textBox2);
            this.single.Controls.Add(this.textBox1);
            this.single.Controls.Add(this.yolocb);
            this.single.Controls.Add(this.addlabel);
            this.single.Controls.Add(this.voccb);
            this.single.Controls.Add(this.delete);
            this.single.Controls.Add(this.autosave);
            this.single.Controls.Add(this.autoload);
            this.single.Location = new System.Drawing.Point(4, 25);
            this.single.Name = "single";
            this.single.Padding = new System.Windows.Forms.Padding(3);
            this.single.Size = new System.Drawing.Size(1375, 857);
            this.single.TabIndex = 0;
            this.single.Text = "object detection";
            this.single.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1189, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 49;
            this.label8.Text = "Y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(888, 832);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1214, 174);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 25);
            this.textBox5.TabIndex = 48;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(907, 334);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 514);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1187, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "W";
            // 
            // labellist
            // 
            this.labellist.FormattingEnabled = true;
            this.labellist.ItemHeight = 15;
            this.labellist.Location = new System.Drawing.Point(930, 70);
            this.labellist.Margin = new System.Windows.Forms.Padding(4);
            this.labellist.Name = "labellist";
            this.labellist.Size = new System.Drawing.Size(224, 214);
            this.labellist.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1214, 210);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(79, 25);
            this.textBox4.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1070, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1189, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1101, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "/";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1214, 246);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 25);
            this.textBox3.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1119, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1189, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(927, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Label list";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1214, 138);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 25);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(930, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 25);
            this.textBox1.TabIndex = 35;
            // 
            // yolocb
            // 
            this.yolocb.AutoSize = true;
            this.yolocb.Location = new System.Drawing.Point(1302, 21);
            this.yolocb.Margin = new System.Windows.Forms.Padding(4);
            this.yolocb.Name = "yolocb";
            this.yolocb.Size = new System.Drawing.Size(57, 19);
            this.yolocb.TabIndex = 41;
            this.yolocb.Text = "Yolo";
            this.yolocb.UseVisualStyleBackColor = true;
            // 
            // addlabel
            // 
            this.addlabel.Location = new System.Drawing.Point(1093, 40);
            this.addlabel.Margin = new System.Windows.Forms.Padding(4);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(63, 29);
            this.addlabel.TabIndex = 36;
            this.addlabel.Text = "add";
            this.addlabel.UseVisualStyleBackColor = true;
            this.addlabel.Click += new System.EventHandler(this.addlabel_Click);
            // 
            // voccb
            // 
            this.voccb.AutoSize = true;
            this.voccb.Location = new System.Drawing.Point(1302, 48);
            this.voccb.Margin = new System.Windows.Forms.Padding(4);
            this.voccb.Name = "voccb";
            this.voccb.Size = new System.Drawing.Size(52, 19);
            this.voccb.TabIndex = 40;
            this.voccb.Text = "Voc";
            this.voccb.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1093, 7);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(63, 29);
            this.delete.TabIndex = 37;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // autosave
            // 
            this.autosave.AutoSize = true;
            this.autosave.Location = new System.Drawing.Point(1201, 21);
            this.autosave.Margin = new System.Windows.Forms.Padding(4);
            this.autosave.Name = "autosave";
            this.autosave.Size = new System.Drawing.Size(85, 19);
            this.autosave.TabIndex = 39;
            this.autosave.Text = "Auto save";
            this.autosave.UseVisualStyleBackColor = true;
            // 
            // autoload
            // 
            this.autoload.AutoSize = true;
            this.autoload.Location = new System.Drawing.Point(1201, 48);
            this.autoload.Margin = new System.Windows.Forms.Padding(4);
            this.autoload.Name = "autoload";
            this.autoload.Size = new System.Drawing.Size(85, 19);
            this.autoload.TabIndex = 38;
            this.autoload.Text = "Auto load";
            this.autoload.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1375, 857);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "classfiication";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.Location = new System.Drawing.Point(1072, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "label list";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1012, 828);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listview1_doubleclick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1204, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(1075, 109);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(204, 244);
            this.listBox2.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1075, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(200, 200);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1507, 953);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pre_img);
            this.Controls.Add(this.next_img);
            this.Controls.Add(this.open_dir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Label Tool";
            this.tabControl1.ResumeLayout(false);
            this.single.ResumeLayout(false);
            this.single.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button open_dir;
        private System.Windows.Forms.Button next_img;
        private System.Windows.Forms.Button pre_img;
        private System.Windows.Forms.Button save;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage single;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox labellist;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox yolocb;
        private System.Windows.Forms.Button addlabel;
        private System.Windows.Forms.CheckBox voccb;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox autosave;
        private System.Windows.Forms.CheckBox autoload;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Timer timer1;
    }
}

