using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSL.ConfigLib;


namespace Converter
{
    public partial class Form1 : Form
    {
        string temp = Path.GetTempPath();
        string file = Path.GetTempPath() + "/settings.txt";

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            mode1.Items.Add("Comics"); // добавление элементов в комбобокс
            mode1.Items.Add("Collectibles");
            mode1.Items.Add("BlindBox");
            retry1.Items.Add("True");
            retry1.Items.Add("None");
            if (File.Exists("config.txt")) // создаем файл с кфг
            {

            }
            else
            {
                FileStream fs = File.Create("config.txt");
                fs.Close();
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw3 = new StreamWriter("config.txt"); //запись в файл с кфг
            sw3.WriteLine(product.Text, "\n");
            sw3.WriteLine(timer.Text, "\n");
            sw3.WriteLine(delay.Text, "\n");
            sw3.WriteLine(mode1.SelectedItem.ToString(), "\n");
            sw3.WriteLine(retry1.SelectedItem.ToString(), "\n");
            sw3.Close();
                    List<billings> people = new List<billings>();
                    FileStream fs4 = File.Create("tokens.txt");
                    fs4.Close();
                    FileStream fs5 = File.Create("names.txt");
                    fs5.Close();
                    StreamWriter sw9 = new StreamWriter("tokens.txt");
                    sw9.WriteLine(Token.Text);
                    sw9.Close();
                    StreamWriter sw12 = new StreamWriter("names.txt");
                    sw12.WriteLine(namee.Text);
                    sw12.Close();
                    string[] row = File.ReadAllLines("tokens.txt");
                    string[] row2 = File.ReadAllLines("names.txt");

                    for (int i = 0; i < row.Length; i++)
                    {
                        if (guna2RadioButton1.Checked)
                        {
                            people.Add(new billings() { title = $"{namee.Text} {i}", cookie = row[i] });
                        }
                        if (guna2RadioButton2.Checked)
                        {
                            people.Add(new billings() { title = $"{row2[i]} {i}", cookie = row[i] });
                        }
                    }
                    string json = JsonConvert.SerializeObject(people);

                    FolderBrowserDialog fb = new FolderBrowserDialog();
                    fb.Description = "Select a folder";
                    if (fb.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = File.Create(fb.SelectedPath + "/billings.json");
                        fs.Close();
                        StreamWriter sw = new StreamWriter(fb.SelectedPath + "/billings.json");
                        sw.Write(json);
                        sw.Close();
                        List<tasks> people1 = new List<tasks>();
                        string[] row1 = File.ReadAllLines("names.txt");
                        for (int i = 0; i < row.Length; i++)
                        {
                            if (retry1.SelectedItem.ToString().Contains("True"))
                            {
                                if (mode1.SelectedItem.ToString().Contains("Comics"))
                                {
                                    if (guna2RadioButton1.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{namee.Text} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "comics",
                                            modeTitle = "Comics",
                                            retry = true
                                        });
                                    }
                                    if (guna2RadioButton2.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{row1[i]} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "comics",
                                            modeTitle = "Comics",
                                            retry = true
                                        });
                                    }
                                }
                                if (mode1.SelectedItem.ToString().Contains("Collectibles"))
                                {
                                    if (guna2RadioButton1.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{namee.Text} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "colls",
                                            modeTitle = "Collectibles",
                                            retry = true
                                        });
                                    }
                                    if (guna2RadioButton2.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{row1[i]} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "colls",
                                            modeTitle = "Collectibles",
                                            retry = true
                                        });
                                    }
                                }
                                if (mode1.SelectedItem.ToString().Contains("BlindBox"))
                                {
                                    if (guna2RadioButton1.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{namee.Text} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "blindbox",
                                            modeTitle = "BlindBox",
                                            retry = true
                                        });
                                    }
                                    if (guna2RadioButton2.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{row1[i]} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "blindbox",
                                            modeTitle = "BlindBox",
                                            retry = true
                                        });
                                    }
                                }
                            }
                            else
                            {
                                if (mode1.SelectedItem.ToString().Contains("Comics"))
                                {
                                    if (guna2RadioButton1.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{namee.Text} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "comics",
                                            modeTitle = "Comics"
                                        });
                                    }
                                    if (guna2RadioButton2.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{row1[i]} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "comics",
                                            modeTitle = "Comics"
                                        });
                                    }
                                }
                                if (mode1.SelectedItem.ToString().Contains("Collectibles"))
                                {
                                    if (guna2RadioButton1.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{namee.Text} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "colls",
                                            modeTitle = "Collectibles"
                                        });
                                    }
                                    if (guna2RadioButton2.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{row1[i]} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "colls",
                                            modeTitle = "Collectibles"
                                        });
                                    }
                                }
                                if (mode1.SelectedItem.ToString().Contains("BlindBox"))
                                {
                                    if (guna2RadioButton1.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{namee.Text} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "blindbox",
                                            modeTitle = "BlindBox",
                                            retry = true
                                        });
                                    }
                                    if (guna2RadioButton2.Checked)
                                    {
                                        people1.Add(new tasks()
                                        {
                                            billingTitle =
                                            $"{row1[i]} {i}",
                                            billing = $"{i}",
                                            product = product.Text,
                                            timer = timer.Text,
                                            delay = delay.Text,
                                            mode = "blindbox",
                                            modeTitle = "BlindBox"
                                        });
                                    }
                                }
                            }
                        }
                        string json1 = JsonConvert.SerializeObject(people1);
                        FileStream fs1 = File.Create(fb.SelectedPath + "/tasks.json");
                        fs1.Close();
                        StreamWriter sw1 = new StreamWriter(fb.SelectedPath + "/tasks.json");
                        sw1.Write(json1);
                        sw1.Close();
                        log.Text = "Succeful converted!";
                        File.Delete("tokens.txt");
                        File.Delete("names.txt");
                    }
        }

        // классы
        class billings
        {
            public string title { get; set; }
            public string email = "";
            public string password = "";
            public string fullname = "";
            public string phone = "";
            public string zipcode = "";
            public string adress = "";
            public string cookie { get; set; }
            public string edited = "0000-00-00T00:00:00.000Z";
            public string isCookie = "Yes";
            public string cardType = "Soon";

        }
        class tasks
        {

            public string site = "veve";
            public string mode { get; set; }
            public string proxy = "localhost";
            public string billing { get; set; }
            public string account = "empty";
            public string product { get; set; }
            public string timer { get; set; }
            public string delay { get; set; }
            public Boolean retry { get; set; }
            public string siteTitle = "Veve";
            public string modeTitle = "Collectibles";
            public string billingTitle { get; set; }
            public string proxyTitle = "Localhost";

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Token.Text = fd.FileName;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                namee.Text = fd.FileName;
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string product3 = File.ReadLines("config.txt").Skip(0).First();
                string timer3 = File.ReadLines("config.txt").Skip(1).First();
                string delay2 = File.ReadLines("config.txt").Skip(2).First();
                string mode11 = File.ReadLines("config.txt").Skip(3).First();
                string retryyy = File.ReadLines("config.txt").Skip(4).First();
                delay.Text = delay2;
                product.Text = product3;
                timer.Text = timer3;
                mode1.Text = mode11;
                retry1.Text = retryyy;
            }
            catch
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = ((string[])Token.Lines).Length.ToString();
            label10.Text = ((string[])namee.Lines).Length.ToString();
            if (guna2RadioButton1.Checked)
            {
                namee.Width = 273;
                namee.Height = 36;
                namee.Multiline = false;
                namee.ScrollBars = ScrollBars.None;
            }
            if (guna2RadioButton2.Checked)
            {
                namee.Width = 273;
                namee.Height = 222;
                namee.Multiline = true;
                namee.ScrollBars = ScrollBars.Vertical;
            }
        }
    }
}

