using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form8 : Form
    {
        List<List<Drink>> MainMenu = new List<List<Drink>>();

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            comboBoxMenuTypes.Items.Add("Nước uống");
            comboBoxMenuTypes.Items.Add("Nước ép");
            comboBoxMenuTypes.Items.Add("Sinh tố");

            List<Drink> drinks1 = new List<Drink>();
            drinks1.Add(new Drink("Cafe", 21000));
            drinks1.Add(new Drink("Cafe sữa", 22000));
            drinks1.Add(new Drink("Siting", 10000));
            MainMenu.Add(drinks1);

            List<Drink> drinks2 = new List<Drink>();
            drinks2.Add(new Drink("cam", 22000));
            drinks2.Add(new Drink("táo", 25000));
            drinks2.Add(new Drink("cà chua", 20000));
            MainMenu.Add(drinks2);

            List<Drink> drinks3 = new List<Drink>();
            drinks3.Add(new Drink("Xoài", 28000));
            drinks3.Add(new Drink("Bơ", 30000));
            drinks3.Add(new Drink("Dừa  ", 24000));
            MainMenu.Add(drinks3);

            buttonRight.Enabled = false;
            buttonLeft.Enabled = false;
        }

        private void comboBoxMenuTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuTypes.SelectedIndex >= 0)
            {
                listViewMainMenu.Items.Clear();
                List<Drink> drinks = MainMenu[comboBoxMenuTypes.SelectedIndex];
                
                for (int index = 0; index < drinks.Count; index++)
                {
                    string[] rowData = new string[] 
                    {
                        (index + 1).ToString(),
                        drinks[index].DrinkName,
                        drinks[index].UnitPrice.ToString()
                    };
                    ListViewItem listViewItem = new ListViewItem(rowData);
                    listViewMainMenu.Items.Add(listViewItem);
                }
                
            }
        }

        private void listViewMainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenuTypes.SelectedIndex >= 0)
            {
                if (listViewMainMenu.SelectedItems.Count > 0)
                {
                    buttonRight.Enabled = true;
                }
                else
                {
                    buttonRight.Enabled = false;
                }
            }
        }

        private void listViewSelectedDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSelectedDrinks.SelectedItems.Count > 0)
            {
                buttonLeft.Enabled = true;
            }
            else
            {
                buttonLeft.Enabled = false;
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewMainMenu.SelectedItems.Count; i++)
            {
                string drinkNameOfMainMenu = listViewMainMenu.SelectedItems[i].SubItems[1].Text;

                if (listViewSelectedDrinks.Items.Count > 0)
                {
                    for (int j = 0; j < listViewSelectedDrinks.Items.Count; j++)
                    {
                        string drinkNameOfSelectedDrinks = listViewSelectedDrinks.Items[j].SubItems[0].Text;

                        if (drinkNameOfMainMenu.Equals(drinkNameOfSelectedDrinks))
                        {
                            int quantityOfDrinks = Convert.ToInt32(listViewSelectedDrinks.Items[j].SubItems[1].Text) + 1;
                            double unitPrice = Convert.ToDouble(listViewMainMenu.SelectedItems[i].SubItems[2].Text);
                            double costPrice = quantityOfDrinks * unitPrice;

                            listViewSelectedDrinks.Items[j].SubItems[0].Text = drinkNameOfMainMenu;
                            listViewSelectedDrinks.Items[j].SubItems[1].Text = quantityOfDrinks.ToString();
                            listViewSelectedDrinks.Items[j].SubItems[2].Text = costPrice.ToString();
                            break;
                        }
                        else 
                        {
                            if (j == listViewSelectedDrinks.Items.Count - 1)
                            {
                                string[] rowData = new string[]
                                {
                                    listViewMainMenu.SelectedItems[i].SubItems[1].Text,
                                    "1",
                                    listViewMainMenu.SelectedItems[i].SubItems[2].Text
                                };
                                ListViewItem listViewItem = new ListViewItem(rowData);
                                listViewSelectedDrinks.Items.Add(listViewItem);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    string[] rowData = new string[]
                    {
                        listViewMainMenu.SelectedItems[i].SubItems[1].Text,
                        "1",
                        listViewMainMenu.SelectedItems[i].SubItems[2].Text
                    };
                    ListViewItem listViewItem = new ListViewItem(rowData);
                    listViewSelectedDrinks.Items.Add(listViewItem);
                }
            }

            labelTotalPrice.Text = $"Tổng số tiền cần trả là: {GetTotalPrice()}";
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            for (int i = listViewSelectedDrinks.SelectedItems.Count -1; i >= 0; i--)
            {
                if (listViewSelectedDrinks.SelectedItems[i].SubItems[1].Text.Equals("1"))
                {
                    listViewSelectedDrinks.SelectedItems[i].Remove();
                }
                else
                {
                    string drinkNameOfSelectedDrinks = listViewSelectedDrinks.SelectedItems[i].SubItems[0].Text;

                    for (int j = 0; j < listViewMainMenu.Items.Count; j++)
                    {
                        string drinkNameOfMainMenu = listViewMainMenu.Items[j].SubItems[1].Text;

                        if (drinkNameOfMainMenu.Equals(drinkNameOfSelectedDrinks))
                        {
                            int quantityOfDrinks = Convert.ToInt32(listViewSelectedDrinks.SelectedItems[i].SubItems[1].Text) - 1;
                            double unitPrice = Convert.ToDouble(listViewMainMenu.Items[j].SubItems[2].Text);
                            double costPrice = quantityOfDrinks * unitPrice;

                            listViewSelectedDrinks.SelectedItems[i].SubItems[0].Text = drinkNameOfMainMenu;
                            listViewSelectedDrinks.SelectedItems[i].SubItems[1].Text = quantityOfDrinks.ToString();
                            listViewSelectedDrinks.SelectedItems[i].SubItems[2].Text = costPrice.ToString();
                        }
                    }
                }
            }

            labelTotalPrice.Text = $"Tổng số tiền cần trả là: {GetTotalPrice()}";
        }

        private double GetTotalPrice()
        {
            double totalPrice = 0;

            for (int i = 0; i < listViewSelectedDrinks.Items.Count; i++)
            {
                totalPrice += Convert.ToDouble(listViewSelectedDrinks.Items[i].SubItems[2].Text);
            }

            return totalPrice;
        }
    }
}
