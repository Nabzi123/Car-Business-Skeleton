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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<CPU> cpus = new List<CPU>();
        List<Motherboard> motherboards = new List<Motherboard>();
        List<HardDrive> harddrive = new List<HardDrive>();
        List<RAM> ram = new List<RAM>();

        public Form1()
        {
            InitializeComponent();

            // Readin all the stock items
            List<Item> stockItems = ReadIn();

            //For each stock item, split it into cpu, HD, Ram and motherboard
            //At the same time, add them to the list box
            for(int i = 0; i < stockItems.Count; i++)
            {
                if(stockItems[i].ToString().Split(',')[0] == "CPU")
                {
                    listBoxCPU.Items.Add(stockItems[i]);
                    cpus.Add((CPU)stockItems[i]);
                }

                if (stockItems[i].ToString().Split(',')[0] == "Motherboard")
                {
                    listBoxMotherBoard.Items.Add(stockItems[i]);
                    motherboards.Add((Motherboard)stockItems[i]);
                }

                if (stockItems[i].ToString().Split(',')[0] == "Hard Drive")
                {
                    listBoxHardDrive.Items.Add(stockItems[i]);
                    harddrive.Add((HardDrive)stockItems[i]);
                }

                if (stockItems[i].ToString().Split(',')[0] == "RAM")
                {
                    listBoxRam.Items.Add(stockItems[i]);
                    ram.Add((RAM)stockItems[i]);
                }
            }


        
        }

        //This is the readin function form the lab 
        static List<Item> ReadIn()
        {
            string[] data = File.ReadAllLines("Data.txt");
            
            List<Item> Items = new List<Item>();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == "CPU")
                {
                    int index = i + 1;
                    string[] bits;

                    do
                    {
                        bits = data[index].Split(',');
                        CPU c = new CPU(bits[0], double.Parse(bits[2]), int.Parse(bits[1]));
                        Items.Add(c);
                        index++;

                        if (index == data.Length)
                        {
                            break;
                        }
                    }
                    while (data[index].Split(',').Length > 1);
                }

                if (data[i].ToUpper() == "MotherBoard".ToUpper())
                {
                    int index = i + 1;
                    string[] bits;

                    do
                    {
                        bits = data[index].Split(',');
                        Motherboard m = new Motherboard(bits[0], double.Parse(bits[4]),
                            bits[1], int.Parse(bits[2]), bool.Parse(bits[3]));
                        Items.Add(m);
                        index++;

                        if (index == data.Length)
                        {
                            break;
                        }
                    }
                    while (data[index].Split(',').Length > 1);
                }

                if (data[i].ToUpper() == "Hard Drive".ToUpper())
                {
                    int index = i + 1;
                    string[] bits;

                    do
                    {
                        bits = data[index].Split(',');
                        HardDrive h = new HardDrive(bits[0], double.Parse(bits[3]),
                            bits[1], double.Parse(bits[2]));
                        Items.Add(h);
                        index++;

                        if (index == data.Length)
                        {
                            break;
                        }
                    }
                    while (data[index].Split(',').Length > 1);
                }

                if (data[i].ToUpper() == "RAM".ToUpper())
                {
                    int index = i + 1;
                    string[] bits;

                    do
                    {
                        bits = data[index].Split(',');
                        RAM r = new RAM(bits[0], double.Parse(bits[3]),
                            bits[1], int.Parse(bits[2]));
                        Items.Add(r);
                        index++;

                        if (index == data.Length)
                        {
                            break;
                        }
                    }
                    while (data[index].Split(',').Length > 1);
                }
            }

            return Items;
        }

        //These are button clicks that happen when you press the sort button

        //They clear the listbox, then sort the list of (cpu,motherboard,ramHD ect..).

        //Ther then add the sorted items back tothe listbox
        private void sortCpu_Click(object sender, EventArgs e)
        {
            listBoxCPU.Items.Clear();

            cpus.Sort();

            for(int i = 0; i < cpus.Count; i++)
            {
                listBoxCPU.Items.Add(cpus[i]);
            }
        }

        private void sortMotherboard_Click(object sender, EventArgs e)
        {
            listBoxMotherBoard.Items.Clear();
            motherboards.Sort();

            for (int i = 0; i < motherboards.Count; i++)
            {
                listBoxMotherBoard.Items.Add(motherboards[i]);
            }
        }

        private void sortHD_Click(object sender, EventArgs e)
        {
            listBoxHardDrive.Items.Clear();
            harddrive.Sort();

            for (int i = 0; i < harddrive.Count; i++)
            {
                listBoxHardDrive.Items.Add(harddrive[i]);
            }
        }

        private void sortRam_Click(object sender, EventArgs e)
        {
            listBoxRam.Items.Clear();
            ram.Sort();

            for(int i = 0; i < ram.Count; i++)
            {
                listBoxRam.Items.Add(ram[i]);
            }
        }

        //Takes all the selected items and calculate the price of them all, + a build cost of 10%

        //No error checking here, there should be
        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;

            CPU c = (CPU)listBoxCPU.SelectedItem;
            Motherboard m = (Motherboard)listBoxMotherBoard.SelectedItem;
            HardDrive h = (HardDrive)listBoxHardDrive.SelectedItem;
            RAM r = (RAM)listBoxRam.SelectedItem;

            price = (c.getPrice() + m.getPrice() + h.getPrice() + r.getPrice()) * 1.1;

            MessageBox.Show("Computer costs : " + price.ToString());
        }
    }


    class Item
    {
        protected string name;
        protected double price;

        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double getPrice()
        {
            return price;
        }
    }

    class CPU : Item, IComparable<CPU>
    {
        int speed;

        public CPU(string name, double price, int speed) : base(name, price)
        {
            this.speed = speed;
        }

        public int CompareTo(CPU other)
        {
            return speed.CompareTo(other.speed);
        }

        public override string ToString()
        {
            return "CPU" + "," + name + "," + speed + "," + price;
        }
    }

    class Motherboard : Item, IComparable<Motherboard>
    {
        string model;
        int memoryChannels;
        bool ATX;

        public override string ToString()
        {
            return "Motherboard" + "," + name + "," + model + "," + "," + memoryChannels + "," + price;
        }
        public Motherboard(string name, double price,
            string model, int memoryChannels, bool ATX) : base(name, price)
        {
            this.model = model;
            this.memoryChannels = memoryChannels;
            this.ATX = ATX;
        }

        public int CompareTo(Motherboard other)
        {
            return memoryChannels.CompareTo(other.memoryChannels);
        }
    }

    class HardDrive : Item, IComparable<HardDrive>
    {
        string model;
        double sizeInTB;

        public override string ToString()
        {
            return "Hard Drive" + "," + name + "," + model + "," + sizeInTB + "," + price;
        }

        public HardDrive(string name, double price, string model,
            double sizeInTB) : base(name, price)
        {
            this.model = model;
            this.sizeInTB = sizeInTB;
        }

        public int CompareTo(HardDrive other)
        {
            return sizeInTB.CompareTo(other.sizeInTB);
        }
    }

    class RAM : Item, IComparable<RAM>
    {
        string model;
        int sizeInGB;

        public override string ToString()
        {
            return "RAM" + "," + name + "," + model + "," + sizeInGB + "," + price;
        }

        public RAM(string name, double price, string model,
            int sizeInGB) : base(name, price)
        {
            this.model = model;
            this.sizeInGB = sizeInGB;
        }

        public int CompareTo(RAM other)
        {
            return sizeInGB.CompareTo(other.sizeInGB);
        }
    }
}
