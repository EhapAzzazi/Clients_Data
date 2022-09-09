using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PracticalProject
{
    public partial class dataform : Form
    {
        public DateTime StartTimer = new DateTime();
        public dataform()
        {
            InitializeComponent();
        }
        private void dataform_Load(object sender, EventArgs e)
        {
            
            idtxt.Focus();
            StreamWriter hi = new StreamWriter("PersonalData.txt", true);
            hi.Close();

        }
        

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (findlbl.Text != "")
                findlbl.Text = "";
            if (resultpicbox.Image != null)
                resultpicbox.Image = new PictureBox().Image;
                    Regex reg = new Regex(@"^\d+$");
            Regex reg2 = new Regex(@"^[A-Za-z]+(\\s[A-Za-z]+)*$");
            if (reg.IsMatch(idtxt.Text))
            {
                if (reg2.IsMatch(nametxt.Text) || reg2.IsMatch(addresstxt.Text))
                {
                    if (idtxt.Text.Trim() == "" || nametxt.Text.Trim() == "" || addresstxt.Text.Trim() == "")
                    {
                        MessageBox.Show("There is something missing..!");
                        return;
                    }
                    else
                    {
                        if (System.IO.File.Exists("PersonalData.txt"))
                        {
                            StreamReader sr = new StreamReader("PersonalData.txt");
                            string idcheck = sr.ReadToEnd();
                            sr.Close();
                            if (idcheck.Contains(idtxt.Text + ";"))
                                MessageBox.Show("Try another ID, Please...");
                            else
                            {
                                //////////////////////////////////
                                StreamWriter sw = new StreamWriter("PersonalData.txt", true);
                                string personalData = this.idtxt.Text.Trim() + ";" + this.nametxt.Text.Trim()+ ";" + this.addresstxt.Text.Trim() + ";" + this.dtpicker.Value.ToString("dd/MM/yyyy").Trim();

                                sw.WriteLine(personalData);
                                sw.Close();
                                if (!Directory.Exists("imgs"))
                                    Directory.CreateDirectory("imgs");
                                if (enterpicbox.Image != null)
                                enterpicbox.Image.Save("imgs/" + idtxt.Text + Path.GetExtension(ofd.FileName));
                                MessageBox.Show("Added Successfully.");
                                foreach (Control x in Controls)
                                {
                                    if (x is TextBox)
                                        x.Text = "";
                                }
                                sltptbtn.Visible = true;
                                enterpicbox.Image = new PictureBox().Image;
                                idtxt.Clear();
                                nametxt.Clear();
                                addresstxt.Clear();
                                dtpicker.Value = DateTime.Now;
                                idtxt.Focus();
                            }
                        }
                        else
                        {
                            return;
                        }

                    }
                }
                else
                    findlbl.Text = "You can use Letters only, In Both Name and Address slot.";
                //////////////////////////////////
            }
            else
                findlbl.Text = "You can use numbers only, In ID slot.";
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {

            string search_text = idtxt.Text.ToString().Trim();
            string old;
            string n = "";
            string m = "";
            StreamReader sr = File.OpenText("PersonalData.txt");
            if ((idtxt.Text.Trim() != ""))
            {
                while ((old = sr.ReadLine()) != null)
                {
                    resultpicbox.Image = new PictureBox().Image;
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                    if (old.Contains(search_text))
                        m += old.ToString();
                }
                
                if (m.Contains(search_text))
                {
                    string mypath = "imgs/" + search_text + ".jpg";
                    string mypath1 = "imgs/" + search_text + ".png";
                    FileInfo file = new FileInfo(mypath);
                    FileInfo file1 = new FileInfo(mypath1);
                    if (resultpicbox.Image == Image.FromFile(mypath) || resultpicbox.Image == Image.FromFile(mypath))
                    {
                        resultpicbox.Image = new PictureBox().Image;
                        if (file.Exists)
                        {
                            file.Delete();
                        }
                        if (file1.Exists)
                        {
                            file1.Delete();
                        }
                    }
                    findlbl.Text = "Deleted Successfully!";
                }
                else
                {
                    findlbl.Text = "Not Existed!";
                    
                }
                sr.Close();
                //StreamWriter sw = new StreamWriter("PersonalData.txt");
                //StreamWriter sw = new StreamWriter("PersonalData.txt");
                //StreamWriter sw = new StreamWriter("PersonalData.txt");
                // sw.Write(n);
                //sw.Close();
                File.WriteAllText("PersonalData.txt", n);
            }
            else
            {
                findlbl.Text = "Raise ur ID!";
                sr.Close();
            }
            idtxt.Clear();
            idtxt.Focus();
            
        }
        private void findbtn_Click(object sender, EventArgs e)
        {
            if (findlbl.Text != "")
                findlbl.Text = "";
            bool data = false;
            if (idtxt.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("PersonalData.txt");
                string line = "";
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] arrfind = line.Split(';');
                        if (arrfind[0] == idtxt.Text.Trim())
                        {
                            if(arrfind.Length == 3)
                            findlbl.Text = "Hello " + arrfind[1] + ", Yor Address is : " + arrfind[2] + ".";
                            else
                                findlbl.Text = "Hello " + arrfind[1] + ", Address: " + arrfind[2] + ", Date: " + arrfind[3] + " .";
                            StartTimer = DateTime.Now;
                            string mypath = "imgs/" + arrfind[0] +".jpg";
                            string mypath1 = "imgs/" + arrfind[0] + ".png";
                            if (File.Exists(mypath))
                                resultpicbox.Image = Image.FromFile(mypath);
                            if (File.Exists(mypath1))
                                resultpicbox.Image = Image.FromFile(mypath);
                            idtxt.Focus();
                            idtxt.SelectAll();
                            break;

                        }
                        else
                        {
                            findlbl.Text = "This ID isn't available.";
                            idtxt.Focus();
                            idtxt.SelectAll();
                            data = true;
                        }
                    }
                    else
                    {
                        if (data != true)
                            findlbl.Text = "No Data Yet.!";
                        else
                            continue;
                    }
                } while (line != null);
                sr.Close();
            }
            else
            {
                MessageBox.Show("Raise your ID, First!");
                idtxt.Focus();
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            if (findlbl.Text != "")
                findlbl.Text = "";
            Form FM1 = new Form();
            TextBox txt = new TextBox();
            FM1.StartPosition = this.StartPosition;
            FM1.Font = this.Font;
            FM1.Icon = this.Icon;
            FM1.Size = this.Size;
            FM1.Text = "All Data!";
            txt.Multiline = true;
            txt.ReadOnly = true;
            txt.Dock = DockStyle.Fill;
            FM1.Controls.Add(txt);
            StreamReader sr = new StreamReader("PersonalData.txt");
            string ShowAll = sr.ReadToEnd();
            sr.Close();
            txt.Text =  ShowAll.Replace(";", " : ");
            FM1.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (findlbl.Text != "")
                findlbl.Text = "";
            if (resultpicbox.Image != null)
                resultpicbox.Image = new PictureBox().Image;
            ofd.Filter = "Images |*.jpg;*.png;";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                enterpicbox.Image = Image.FromFile(ofd.FileName);
                sltptbtn.Visible = false;
            }
        }

        private void shwallimgs_Click(object sender, EventArgs e)
        {
            if (findlbl.Text != "")
                findlbl.Text = "";
            if (resultpicbox.Image != null)
                resultpicbox.Image = new PictureBox().Image;
            Form FM1 = new Form();
            FM1.StartPosition = this.StartPosition;
            FM1.Font = this.Font;
            FM1.Icon = this.Icon;
            FM1.Size = this.Size;
            //FM1.Width -= 600;
            FM1.AutoScroll = true;
            FM1.BackColor = this.BackColor;
            FM1.MaximizeBox = false;
            FM1.FormBorderStyle = FormBorderStyle.FixedSingle;
            FM1.Text = "All Data!";
            //FM1.Controls.Add(txt);
            StreamReader sr = new StreamReader("PersonalData.txt");
            int top = 10;
            string ShowAll = "";
            do
            {
                ShowAll = sr.ReadLine();
               
                if (ShowAll != null)
                {
                    string[] arrfind = ShowAll.Split(';');
                    TextBox txt = new TextBox();
                    PictureBox picbx = new PictureBox();
                    /////////////////////////////////////////
                    txt.Width = 600;
                    txt.Top = top + 60;
                    //txt.Text = ShowAll.Replace(";", " : ");
                    if (arrfind.Length == 3)
                        txt.Text = "ID: " + arrfind[0] + ", Name: " + arrfind[1] + ", Address: " + arrfind[2] + " .";
                    else
                        txt.Text = "ID: " + arrfind[0] + ", Name: " + arrfind[1] + ", Address: " + arrfind[2] + ", Date: " + arrfind[3] + " .";
                    txt.ReadOnly = true;
                    /////////////////////////////////////////
                    picbx.Left = 610;
                    picbx.Top = top;
                    picbx.Size = new Size(150, 150);
                    picbx.BorderStyle = BorderStyle.FixedSingle;
                    picbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    /////////////////////////////////////////
                    string imgpath = "imgs/" + ShowAll.ToString().Split(';')[0] + ".jpg";
                    string imgpath2 = "imgs/" + ShowAll.ToString().Split(';')[0] + ".png";
                    if (File.Exists(imgpath))
                    {
                        picbx.Image = Image.FromFile(imgpath);
                    }
                    if (File.Exists(imgpath2))
                    {
                        picbx.Image = Image.FromFile(imgpath2);
                    }
                    /////////////////////////////////////////
                    FM1.Controls.Add(txt);
                    FM1.Controls.Add(picbx);
                    top += 155;
                }

            } while (ShowAll != null);
            sr.Close();
            FM1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now > StartTimer.AddSeconds(10))
            {
                resultpicbox.Image = new PictureBox().Image;
            }
        }

        private void dataform_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - pnl.Width) / 2;
            int y = (this.Height - pnl.Height) / 2;
            pnl.Location = new Point(x, y);
        }
    }
}
