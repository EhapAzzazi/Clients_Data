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
        private bool Check = false;
        public dataform()
        {
            InitializeComponent();
        }
        private void dataform_Load(object sender, EventArgs e)
        {

            idtxt.Focus();
            if (!File.Exists("PersonalData.txt"))
            {
                StreamWriter hi = new StreamWriter("PersonalData.txt", true);
                hi.Close();
            }


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
            ///////////////////////////////////////////////////
            if (idtxt.Text.Trim() == "")
            {
                MessageBox.Show("You should provide us with an ID.");
            }
            else if (nametxt.Text.Trim() == "")
            {
                MessageBox.Show("Name slot cannot be empty.");
            }
            else if (addresstxt.Text.Trim() == "")
            {
                MessageBox.Show("There is a problem with the provided Address.");
            }
            else
            {
                if (File.Exists("PersonalData.txt"))
                {
                    using (StreamReader sr = new StreamReader("PersonalData.txt"))
                    {
                        string test = "";
                        do
                        {
                            test = sr.ReadLine();
                            if (test != null)
                            {
                                string[] arr = test.Split(';');
                                if (arr[0] == idtxt.Text)
                                {
                                    MessageBox.Show("Try another ID, please...");
                                    return;
                                }
                            }
                        }
                        while (test != null);
                        sr.Close();
                    }
                    //////////////////////////////////
                    StreamWriter sw = new StreamWriter("PersonalData.txt", true);
                    string personalData = this.idtxt.Text.Trim() + ";" + this.nametxt.Text.Trim() + ";" + this.addresstxt.Text.Trim() + ";" + this.dtpicker.Value.ToString("dd/MM/yyyy").Trim();
                    sw.WriteLine(personalData);
                    sw.Close();
                    if (!Directory.Exists("imgs"))
                        Directory.CreateDirectory("imgs");
                    if (enterpicbox.Image != null)
                        enterpicbox.Image.Save("imgs/" + idtxt.Text + Path.GetExtension(ofd.FileName));
                    MessageBox.Show("Added Successfully.");
                    ////////////////////
                    sltptbtn.Visible = true;
                    enterpicbox.Image = new PictureBox().Image;
                    idtxt.Clear();
                    nametxt.Clear();
                    addresstxt.Clear();
                    dtpicker.Value = DateTime.Now;
                    idtxt.Focus();
                    ///////////////////
                }
                else
                {
                    StreamWriter Create = new StreamWriter("PersonalData.txt");
                    Create.Close();
                }
            }
        
    
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            string search_text = idtxt.Text.Trim();
            string old;
            string n = "";
            string m = "";
            if ((idtxt.Text.Trim() != ""))
            {
                StreamReader sr = File.OpenText("PersonalData.txt");
                while ((old = sr.ReadLine()) != null)
                {
                    resultpicbox.Image = new PictureBox().Image;
                    string[] arr = old.Split(';');
                    if (arr[0] != search_text)
                        n += old + Environment.NewLine;
                    else
                    {
                        m += old.ToString();
                    }
                }

                if (m != "")
                {
                    
                    string path = "imgs/" + search_text + ".jpg";
                    string path1 = "imgs/" + search_text + ".png";
                    FileInfo file = new FileInfo(path);
                    FileInfo file1 = new FileInfo(path1);
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                    else if (file1.Exists)
                    {
                        file1.Delete();
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
            }
            idtxt.Clear();
            idtxt.Focus();

        }
        private void findbtn_Click(object sender, EventArgs e)
        {
            if (resultpicbox.Image != null)
                resultpicbox.Image = new PictureBox().Image;
            if (findlbl.Text != "")
                findlbl.Text = "";
            if (idtxt.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("PersonalData.txt");
                string line = "";
                do
                {
                    StartTimer = DateTime.Now;
                    Check = true;
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] arrfind = line.Split(';');
                        if (arrfind[0] == idtxt.Text)
                        {
                            if(arrfind.Length == 3)
                            findlbl.Text = "Hello " + arrfind[1] + ", Yor Address is : " + arrfind[2] + ".";
                            else
                                findlbl.Text = "Hello " + arrfind[1] + ", Address: " + arrfind[2] + ", Date: " + arrfind[3] + " .";
                            string mypath = "imgs/" + arrfind[0] +".jpg";
                            string mypath1 = "imgs/" + arrfind[0] + ".png";
                            if (File.Exists(mypath))
                            {
                                using (FileStream stream = new FileStream(mypath, FileMode.Open))
                                resultpicbox.Image = Image.FromStream(stream);
                            }
                            else if (File.Exists(mypath1))
                            {
                                using (FileStream stream = new FileStream(mypath1, FileMode.Open))
                                resultpicbox.Image = Image.FromStream(stream);
                            }
                            idtxt.Focus();
                            idtxt.SelectAll();
                            break;
                        }
                        else
                        {
                            findlbl.Text = "This ID isn't available.";
                            idtxt.Focus();
                            idtxt.SelectAll();
                        }
                    }
                    else
                    {
                            findlbl.Text = "No Data Yet.!";
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

        //private void showbtn_Click(object sender, EventArgs e)
        //{
        //    if (findlbl.Text != "")
        //        findlbl.Text = "";
        //    Form FM1 = new Form();
        //    TextBox txt = new TextBox();
        //    FM1.StartPosition = this.StartPosition;
        //    FM1.Font = this.Font;
        //    FM1.Icon = this.Icon;
        //    FM1.Size = this.Size;
        //    FM1.Text = "All Data!";
        //    txt.Multiline = true;
        //    txt.ReadOnly = true;
        //    txt.Dock = DockStyle.Fill;
        //    FM1.Controls.Add(txt);
        //    StreamReader sr = new StreamReader("PersonalData.txt");
        //    string ShowAll = sr.ReadToEnd();
        //    sr.Close();
        //    txt.Text =  ShowAll.Replace(";", " : ");
        //    FM1.ShowDialog();

        //}

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
                    if (arrfind.Length == 3)
                        txt.Text = $"ID: {arrfind[0]}, Name: {arrfind[1]}, Address: {arrfind[2]}.";
                    else
                        txt.Text = $"ID: {arrfind[0]}, Name: {arrfind[1]}, Address: {arrfind[2]}, Date: {arrfind[3]}.";
                    txt.ReadOnly = true;
                    /////////////////////////////////////////
                    picbx.Left = 610;
                    picbx.Top = top;
                    picbx.Size = new Size(150, 150);
                    picbx.BorderStyle = BorderStyle.FixedSingle;
                    picbx.SizeMode = PictureBoxSizeMode.StretchImage;
                    /////////////////////////////////////////
                    string imgpath = $"imgs/{arrfind[0]}.jpg";
                    string imgpath2 = $"imgs/{arrfind[0]}.png";
                    if (File.Exists(imgpath))
                    {
                        using (FileStream SM = new FileStream(imgpath, FileMode.Open))
                        picbx.Image = Image.FromStream(SM);
                    }
                    else if (File.Exists(imgpath2))
                    {
                        using (FileStream SM = new FileStream(imgpath2, FileMode.Open))
                        picbx.Image = Image.FromStream(SM);
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
            if(DateTime.Now >= StartTimer.AddSeconds(5) && Check == true)
            {
                resultpicbox.Image = new PictureBox().Image;
                findlbl.Text = "";
                Check = false;
            }
        }

        private void dataform_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - pnl.Width) / 2;
            int y = (this.Height - pnl.Height) / 2;
            pnl.Location = new Point(x, y);
        }

        private void idtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsWhiteSpace(e.KeyChar)) && (!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void addresstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsPunctuation(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsLetterOrDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
    }
}
