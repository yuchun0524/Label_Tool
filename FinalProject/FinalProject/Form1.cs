using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace FinalProject
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Color> colors = new List<Color>();
        int index=-1;
        public Form1()
        {

            InitializeComponent();
            init_label();
            for(int i =0;i< labellist.Items.Count;i++)
            {
                int a, r, g, b;
                a = random.Next(100, 150);
                r = random.Next(100, 256);
                g = random.Next(100, 256);
                b = random.Next(100, 256);
                colors.Add(Color.FromArgb(a,r,g,b));
                //MessageBox.Show(a.ToString()+ r.ToString()+ g.ToString()+ b.ToString());
            }
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        String contain;
        private void init_label() {
            int counter = 0;
            string line;
            string filename = "label.txt";
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                while ((line = file.ReadLine()) != null)
                {
                    //System.Console.WriteLine(line);
                    labellist.Items.Add(line);
                    counter++;
                }

                file.Close();
            }
            else {
                MessageBox.Show("label not exit");
                File.Create(filename);
            }
        }
        private void update_label() {
            string filename = "label.txt";
            StreamWriter file = new StreamWriter(filename);
            foreach (string item in labellist.Items) {
                //MessageBox.Show(item.ToString());
                file.WriteLine(item.ToString());
            }
            file.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void open_dir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                index = -1;
                //DialogResult result = folderBrowserDialog1.ShowDialog();
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.jpg");
                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    for (int i = 0; i < files.Length; i++)
                    {
                        listBox1.Items.Add(files[i]);
                    }
                    label3.Text = files.Length.ToString();
                    index = 0;
                    label1.Text = (index + 1).ToString();
                    try
                    {
                        listBox1.SetSelected(index, true);
                        pictureBox1.BackgroundImage = Image.FromFile(files[0]);
                    }
                    catch
                    {
                        MessageBox.Show("File not found");
                    }

                }
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    DirectoryInfo TheFolder = new DirectoryInfo(folderBrowserDialog2.SelectedPath);//檔案路徑 
                    List<string> tifNames = new List<string>();
                    for (int i = 0; i < TheFolder.GetFiles().Length; i++)//遍歷資料夾 
                    {
                        if (TheFolder.GetFiles()[i].Length > 0 && (TheFolder.GetFiles()[i].Extension == ".jpg" || TheFolder.GetFiles()[i].Extension == ".png"))//或者jpg,png 檔案大小要大於0且是圖片檔案 
                        {
                            Image image = Image.FromFile(TheFolder.GetFiles()[i].DirectoryName + "//" + TheFolder.GetFiles()[i].Name); //獲取檔案 
                            string filename = "";
                            if (TheFolder.GetFiles()[i].Name.Contains(".png"))
                                filename = TheFolder.GetFiles()[i].Name.Replace(".png", "") + ".txt";
                            if (TheFolder.GetFiles()[i].Name.Contains(".jpg"))
                                filename = TheFolder.GetFiles()[i].Name.Replace(".jpg", "") + ".txt";
                            string path = folderBrowserDialog2.SelectedPath + "/";
                            filename = path + filename;
                            FileInfo DestInfo = new FileInfo(filename);
                            string data;
                            string add_name = "";
                            add_name = TheFolder.GetFiles()[i].Name;
                            if (DestInfo.Exists)
                            {
                                StreamReader sr = new StreamReader(filename);
                                data = sr.ReadToEnd();
                                data = data.Replace("\r\n", "");
                                add_name = TheFolder.GetFiles()[i].Name + " / " + data;
                                listBox2.Items.Add(data);
                                sr.Close();
                            }
                            tifNames.Add(add_name); 
                            imageList2.Images.Add(image);//新增圖片 
                        }
                    } //初始化設定 
                    this.listView1.View = View.LargeIcon;
                    this.listView1.LargeImageList = this.imageList2; 
                    this.listView1.BeginUpdate();
                    for (int i = 0; i < tifNames.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.ImageIndex = i;
                        lvi.Text = tifNames[i];
                        this.listView1.Items.Add(lvi);
                    }
                    this.listView1.EndUpdate();
                }
            }
        }
        string previous_img=null;
        string now_img = null;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            if (previous_img == null)
            {
                previous_img = listBox1.GetItemText(listBox1.SelectedItem).ToString().Split('.')[0];
                now_img = previous_img;
            }
            else {
                previous_img = now_img;
                now_img =listBox1.GetItemText(listBox1.SelectedItem).ToString().Split('.')[0];
            }
            if (autosave.Checked)
            {
                if (voccb.Checked)
                {
                    save_xml_bbox(previous_img);
                }
                if (yolocb.Checked)
                {
                    save_yolo_bbox(previous_img);
                }
                if(!voccb.Checked&&!yolocb.Checked)
                {
                    MessageBox.Show("Please select format auto save fail");
                }
            }
            clear_box();
            label1.Text = (index + 1).ToString();
            string curItem = listBox1.SelectedItem.ToString();
            pictureBox1.BackgroundImage = Image.FromFile(listBox1.GetItemText(listBox1.SelectedItem));
            clear_box();
            if (autoload.Checked)
            {
                if (yolocb.Checked)
                {
                    load_yolo_box();
                }
                else if (voccb.Checked)
                {
                    load_xml_box();
                }
                else
                {
                    MessageBox.Show("please select format auto save fail");
                }
            }
        }
        private void next_img_Click(object sender, EventArgs e)
        {
            try
            {
                index++;
                listBox1.SetSelected(index, true);
            }
            catch {
                index--;
                MessageBox.Show("end of list");
            }
        }

        private void pre_img_Click(object sender, EventArgs e)
        {
            try
            {
                index--;
                listBox1.SetSelected(index, true);
            }
            catch
            {
                index++;
                MessageBox.Show("head of list");
            }
        }

        private void addlabel_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (string.IsNullOrEmpty(a) == true)
            {
                MessageBox.Show("Null");
            }
            else if (labellist.FindString(a)!=-1) {
                MessageBox.Show("Already exit");
                textBox1.Clear();
            }
            else {
                labellist.Items.Add(a);
                int x, r, g, b;
                x = random.Next(100, 150);
                r = random.Next(100, 256);
                g = random.Next(100, 256);
                b = random.Next(100, 256);
                colors.Add(Color.FromArgb(x, r, g, b));
                textBox1.Clear();
            }
            update_label();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.D)
            {
                try
                {
                    index++;
                    listBox1.SetSelected(index, true);
                }
                catch
                {
                    index--;
                    MessageBox.Show("end of list");
                }
            }
            else if ( e.KeyCode == Keys.A )
            {
                try
                {
                    index--;
                    listBox1.SetSelected(index, true);
                }
                catch
                {
                    index++;
                    MessageBox.Show("head of list");
                }
            }
        }

        private void labellist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = labellist.SelectedItem.ToString();
            textBox1.Text = curItem;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int n = labellist.SelectedIndex;
            labellist.Items.RemoveAt(n);
            update_label();
        }
        private void bbox_delete(object sender, MouseEventArgs e)
        {
            // Add event handler code here.
            if (e.Button == MouseButtons.Right)
            {
                Label temp= (Label)sender;
                bboxes.Remove(temp);
                temp.Dispose();
            }
        }
        private void AddMouseDownHandler(Control c)
        {
            c.MouseDown += MouseDownHandler;
        }
        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            Label temp = (Label)sender;
            if (e.Button == MouseButtons.Left)
            {
                listBox1.Select();
                first_click = !first_click;
                if (Int32.Parse(label1.Text) < 1)
                {
                    MessageBox.Show("please select image");
                    first_click = !first_click;
                    return;
                }
                else if (first_click)
                {
                    x = e.X+ temp.Location.X;
                    y = e.Y+ temp.Location.Y;
                    Label bbox = new Label();
                    bbox.MouseDown += new MouseEventHandler(bbox_delete);
                    AddMouseMoveHandler(bbox);
                    AddMouseDownHandler(bbox);
                    bboxes.Add(bbox);
                    bbox.Show();
                    bbox.BringToFront();
                    bbox.BackColor = Color.FromArgb(30, 255, 0, 100); ;
                    pictureBox1.Controls.Add(bbox);
                    bbox.SetBounds(x, y, 0, 0);
                }
                else
                {
                    try
                    {
                        bboxes.Last().Text = labellist.SelectedItem.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("please select label");
                        bboxes.Last().Dispose();
                        bboxes.Remove(bboxes.Last());
                    }

                }
            }

        }
        private void AddMouseMoveHandler(Control c)
        {
            c.MouseMove += MouseMoveHandler;
        }
        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            Label temp = (Label)sender;
            if (first_click)
            {
                int w = e.X - x + temp.Location.X;
                int h = e.Y - y + temp.Location.Y;
                bboxes.Last().SetBounds(x, y, w, h);
                textBox2.Text = x.ToString();
                textBox5.Text = y.ToString();
                textBox4.Text = w.ToString();
                textBox3.Text = h.ToString();
            }
            //MessageBox.Show("in label");
        }
        int x, y;
        bool first_click = false;
        List<Label> bboxes = new List<Label>();
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button== MouseButtons.Left)
            {
                listBox1.Select();
                first_click = !first_click;
                if (Int32.Parse(label1.Text) < 1)
                {
                    MessageBox.Show("please select image");
                    first_click = !first_click;
                    return;
                }
                else if (first_click)
                {
                    x = e.X;
                    y = e.Y;
                    Label bbox = new Label();
                    bbox.MouseDown += new MouseEventHandler(bbox_delete);
                    AddMouseMoveHandler(bbox);
                    AddMouseDownHandler(bbox);
                    bboxes.Add(bbox);
                    bbox.Show();
                    bbox.BringToFront();
                    try
                    {
                        bbox.BackColor = colors[labellist.SelectedIndex] ;
                    }
                    catch
                    {
                        MessageBox.Show("Please select label");
                    }
                    pictureBox1.Controls.Add(bbox);
                    bbox.SetBounds(x, y, 0, 0);
                }
                else
                {
                    try
                    {
                        bboxes.Last().Text = labellist.SelectedItem.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("please select label");
                        bboxes.Last().Dispose();
                        first_click = !first_click;
                        bboxes.Remove(bboxes.Last());
                    }

                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (first_click)
            {
                int w = e.X - x;
                int h = e.Y - y;
                bboxes.Last().SetBounds(x, y, w, h);
                textBox2.Text = x.ToString();
                textBox5.Text = y.ToString();
                textBox4.Text = w.ToString();
                textBox3.Text = h.ToString();

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                save_yolo_bbox(listBox1.SelectedItem.ToString().Split('.')[0]);
                save_xml_bbox(listBox1.SelectedItem.ToString().Split('.')[0]);
                MessageBox.Show("Save file");
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                string file = "";
                string middle = "";
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Text.Contains("/"))
                    {
                        int i = item.Text.IndexOf('.');
                        if (i >= 0)
                            file = item.Text.Remove(i);
                        int j = item.Text.IndexOf('/');
                        if (j >= 0)
                        {
                            middle = item.Text.Remove(0, j + 2);
                        }
                        string filename;
                        filename = folderBrowserDialog2.SelectedPath + "/" + file + ".txt";
                        FileInfo DestInfo = new FileInfo(filename);
                        if (DestInfo.Exists)
                        {
                            DestInfo.Delete();                 // 則刪除該檔案    
                            FileStream fs = DestInfo.Create();   // 建立檔案串流物件fs，開啟檔案 
                            fs.Close();
                            StreamWriter sw = DestInfo.AppendText();
                            sw.Write(middle);
                            sw.Flush();
                            sw.Close();
                        }
                        else
                        {
                            FileStream fs = DestInfo.Create();   // 建立檔案串流物件fs，開啟檔案 
                            fs.Close();
                            StreamWriter sw = DestInfo.AppendText();
                            sw.Write(middle);
                            sw.Flush();
                            sw.Close();
                        }
                    }
                }
                MessageBox.Show("Save file");
            }
        }
        private void clear_box() {
            foreach (Label bbox in bboxes)
            {
                bbox.Dispose();
            }
            bboxes.Clear();
        }
        private void load_yolo_box() {
            if (File.Exists(listBox1.SelectedItem.ToString().Split('.')[0]+".txt")) {
                //MessageBox.Show("file exits");
                int counter = 0;
                string line;
                StreamReader file =new StreamReader(listBox1.SelectedItem.ToString().Split('.')[0] + ".txt");
                while ((line = file.ReadLine()) != null)
                {
                    //MessageBox.Show(line);
                    Label bbox = new Label();
                    bbox.MouseDown += new MouseEventHandler(bbox_delete);
                    AddMouseMoveHandler(bbox);
                    AddMouseDownHandler(bbox);
                    bboxes.Add(bbox);
                    bbox.Show();
                    bbox.BringToFront();
                    pictureBox1.Controls.Add(bbox);
                    string label = labellist.Items[int.Parse(line.Split(' ')[0])].ToString();
                    bbox.Text = label;
                    bbox.BackColor = colors[labellist.FindString(label)];
                    double w = double.Parse(line.Split(' ')[3])*pictureBox1.Width;
                    double h = double.Parse(line.Split(' ')[4]) * pictureBox1.Height;
                    double x = double.Parse(line.Split(' ')[1]) * pictureBox1.Width - w / 2;
                    double y = double.Parse(line.Split(' ')[2]) * pictureBox1.Height - h / 2;
                    bbox.SetBounds((int)x, (int)y, (int)w, (int)h);
                }

                file.Close();
            }
        }
        private void load_xml_box()
        {
            if (File.Exists(listBox1.SelectedItem.ToString().Split('.')[0] + ".xml"))
            {
                //MessageBox.Show("file exits");
                string line;
                XmlDocument doc = new XmlDocument();
                doc.Load(listBox1.SelectedItem.ToString().Split('.')[0] + ".xml");
                StreamReader file = new StreamReader(listBox1.SelectedItem.ToString().Split('.')[0] + ".txt");
                Image img = System.Drawing.Image.FromFile(listBox1.SelectedItem.ToString());
                double w = img.Width;
                double h = img.Height;
                double x_factor =pictureBox1.Width/ w;
                double y_factor =pictureBox1.Height/ h;
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
         
                    string text = node.InnerText; //or loop through its children as well
                    if(node.Name=="object")
                    {
                        string label = node.SelectNodes("./name")[0].InnerText;
                        XmlNode box_node = node.SelectNodes("./bndbox")[0];
                        double xmin = int.Parse(box_node.SelectNodes("./xmin")[0].InnerText)*x_factor;
                        double ymin = int.Parse(box_node.SelectNodes("./ymin")[0].InnerText) * y_factor;
                        double xmax = int.Parse(box_node.SelectNodes("./xmax")[0].InnerText) * x_factor;
                        double ymax = int.Parse(box_node.SelectNodes("./ymax")[0].InnerText) * y_factor;
                        MessageBox.Show(xmin.ToString());
                        Label bbox = new Label();
                        bbox.MouseDown += new MouseEventHandler(bbox_delete);
                        AddMouseMoveHandler(bbox);
                        AddMouseDownHandler(bbox);
                        bboxes.Add(bbox);
                        bbox.Show();
                        bbox.BringToFront();
                        pictureBox1.Controls.Add(bbox);
                        bbox.Text = label;
                        bbox.BackColor = colors[labellist.FindString(label)];
                        bbox.SetBounds((int)xmin, (int)ymin, (int)(xmax -xmin), (int)(ymax - ymin));
                    }
         
                }
                

                file.Close();
            }
        }
        private void save_yolo_bbox(string savename) {
            //string filename = listBox1.SelectedItem.ToString().Split('.')[0]+".txt";
            StreamWriter file = new StreamWriter(savename + ".txt");
            foreach (Label bbox in bboxes)
            {
                //MessageBox.Show(item.ToString());
                double xc = ((double)bbox.Location.X + (double)bbox.Width/ (double)2) / (double)pictureBox1.Width;
                double yc = ((double)bbox.Location.Y + (double)bbox.Height / (double)2) / (double)pictureBox1.Height;
                double w = (double)bbox.Width / (double)pictureBox1.Width;
                double h = (double)bbox.Height / (double)pictureBox1.Height;
                file.Write(labellist.Items.IndexOf(bbox.Text));
                file.Write(" ");
                file.Write(xc);
                file.Write(" ");
                file.Write(yc);
                file.Write(" ");
                file.Write(w);
                file.Write(" ");
                file.WriteLine(h);
            }
            file.Close();
            //MessageBox.Show("Save YOLO file");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (yolocb.Checked)
            {
                load_yolo_box();
            }
            else if (voccb.Checked)
            {
                load_xml_box();
            }
            else
            {
                MessageBox.Show("please select format auto save fail");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = "Please enter the name of class";
            if (InputBox("請輸入類別名稱", "class name:", ref value) == DialogResult.OK)
            {
                listBox2.Items.Add(value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void listview1_doubleclick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                int i = listView1.FocusedItem.Text.IndexOf(' ');
                if (i >= 0)
                    listView1.FocusedItem.Text = listView1.FocusedItem.Text.Remove(i);
                listView1.FocusedItem.Text = listView1.FocusedItem.Text + " / " + listBox2.SelectedItem.ToString();
            }
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 0)
            {
                save.Enabled = true;
                open_dir.Enabled = true;
                next_img.Enabled = true;
                pre_img.Enabled = true;
                button1.Enabled = true;
            }
            else if(tabControl1.SelectedIndex == 1)
            {
                save.Enabled = true;
                open_dir.Enabled = true;
                next_img.Enabled = false;
                pre_img.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void save_xml_bbox(string savename) {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("annotation");
            document.AppendChild(root);
            XmlElement filename = document.CreateElement("filename");
            Image img = System.Drawing.Image.FromFile(listBox1.SelectedItem.ToString());
            filename.InnerText = listBox1.SelectedItem.ToString().Split('\\').Last();
            root.AppendChild(filename);
            XmlElement size = document.CreateElement("size");
            root.AppendChild(size);
            XmlElement width = document.CreateElement("width");
            width.InnerText = img.Width.ToString();
            size.AppendChild(width);
            XmlElement height = document.CreateElement("height");
            height.InnerText = img.Height.ToString();
            size.AppendChild(height);
            XmlElement depth = document.CreateElement("depth");
            depth.InnerText = "3";
            size.AppendChild(depth);
            double x_factor = (double)img.Width / (double)pictureBox1.Width;
            double y_factor = (double)img.Height / (double)pictureBox1.Height;
            foreach (Label bbox in bboxes) {
                XmlElement obj = document.CreateElement("object");
                root.AppendChild(obj);
                XmlElement name = document.CreateElement("name");
                name.InnerText=bbox.Text;
                obj.AppendChild(name);
                XmlElement bndbox = document.CreateElement("bndbox");
                obj.AppendChild(bndbox);
                XmlElement xmin = document.CreateElement("xmin");
                xmin.InnerText = Math.Round(bbox.Location.X*x_factor).ToString();
                bndbox.AppendChild(xmin);
                XmlElement ymin = document.CreateElement("ymin");
                ymin.InnerText = Math.Round(bbox.Location.Y*y_factor).ToString();
                bndbox.AppendChild(ymin);
                XmlElement xmax= document.CreateElement("xmax");
                xmax.InnerText = Math.Round((bbox.Location.X + bbox.Width)*x_factor).ToString();
                bndbox.AppendChild(xmax);
                XmlElement ymax =document.CreateElement("ymax");
                ymax.InnerText = Math.Round((bbox.Location.Y + bbox.Height)*y_factor).ToString();
                bndbox.AppendChild(ymax);
            }
            //MessageBox.Show("Save VOC file");
            document.Save(savename+ ".xml");

        }
    }
}
