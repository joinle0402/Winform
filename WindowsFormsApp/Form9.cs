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
    public partial class Form9 : Form
    {
        List<List<string>> foodMenu = new List<List<string>>();

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            comboBoxFoodTypes.Items.Add("Trung Quốc");
            comboBoxFoodTypes.Items.Add("Việt Nam");
            comboBoxFoodTypes.Items.Add("Hàn Quốc");

            buttonSelect.Enabled = false;
            buttonUnselect.Enabled = false;
            numericUpDownQuantity.Enabled = false;

            List<string> foods1 = new List<string>();
            foods1.Add("Bún xào giòn");
            foods1.Add("Bánh Canh vịt");
            foods1.Add("Hột vịt lộn");
            foodMenu.Add(foods1);

            List<string> foods2 = new List<string>();
            foods2.Add("Gỏi cuốn");
            foods2.Add("Bánh Flan");
            foods2.Add("Bún thịt nướng");
            foods2.Add("Gà Hập chao");
            foodMenu.Add(foods2);

            List<string> foods3 = new List<string>();
            foods3.Add("Su si");
            foods3.Add("Canh rong biển");
            foods3.Add("Kim chi");
            foods3.Add("Cơm trộn");
            foodMenu.Add(foods3);
        }

        private void comboBoxFoodTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFoodTypes.SelectedIndex >= 0)
            {
                checkedListBoxFoodMenu.Items.Clear();
                List<string> foods = foodMenu[comboBoxFoodTypes.SelectedIndex];
                foods.ForEach((food) => checkedListBoxFoodMenu.Items.Add(food));
            }
        }

        private void checkedListBoxFoodMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxFoodMenu.SelectedIndex >= 0)
            {
                int index = checkedListBoxFoodMenu.SelectedIndex;
                checkedListBoxFoodMenu.SetItemChecked(index, !checkedListBoxFoodMenu.GetItemChecked(index));
                
                if (checkedListBoxFoodMenu.CheckedItems.Count > 0)
                {
                    numericUpDownQuantity.Enabled = true;
                }
                else
                {
                    numericUpDownQuantity.Enabled = false;
                    numericUpDownQuantity.Value = 0;
                }
            }
        }

        private void listViewSelectedFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonUnselect.Enabled = (listViewSelectedFoods.SelectedItems.Count > 0);
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownQuantity.Value > 0 && checkedListBoxFoodMenu.CheckedItems.Count > 0)
            {
                buttonSelect.Enabled = true;
            }
            else
            {
                buttonSelect.Enabled = false;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listViewSelectedFoods.Items.Count > 0)
            {
                for (int i = 0; i < checkedListBoxFoodMenu.CheckedItems.Count; i++)
                {
                    string foodInFoodMenu = checkedListBoxFoodMenu.CheckedItems[i].ToString();
                    
                    for (int j = 0; j < listViewSelectedFoods.Items.Count; j++)
                    {
                        string foodInSelectedFoods = listViewSelectedFoods.Items[j].SubItems[0].Text;

                        if (foodInSelectedFoods.Equals(foodInFoodMenu))
                        {
                            int quantity = Convert.ToInt32(listViewSelectedFoods.Items[j].SubItems[1].Text) + Convert.ToInt32(numericUpDownQuantity.Value);
                            listViewSelectedFoods.Items[j].SubItems[1].Text = quantity.ToString();
                            break;
                        }
                        else
                        {
                            if (j == listViewSelectedFoods.Items.Count - 1)
                            {
                                string[] rowData = new string[]
                                {
                                    foodInFoodMenu,
                                    numericUpDownQuantity.Value.ToString()
                                };
                                ListViewItem listViewItem = new ListViewItem(rowData);
                                listViewSelectedFoods.Items.Add(listViewItem);
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < checkedListBoxFoodMenu.CheckedItems.Count; i++)
                {
                    string[] rowData = new string[]
                    {
                        checkedListBoxFoodMenu.CheckedItems[i].ToString(),
                        numericUpDownQuantity.Value.ToString()
                    };
                    ListViewItem listViewItem = new ListViewItem(rowData);
                    listViewSelectedFoods.Items.Add(listViewItem);
                }
            }
        }

        private void buttonUnselect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewSelectedFoods.SelectedItems.Count; i++)
            {
                if (listViewSelectedFoods.SelectedItems[i].SubItems[1].Text == "1")
                {
                    listViewSelectedFoods.SelectedItems[i].Remove();
                }
                else
                {
                    int quantity = Convert.ToInt32(listViewSelectedFoods.SelectedItems[i].SubItems[1].Text) - 1;
                    listViewSelectedFoods.SelectedItems[i].SubItems[1].Text = quantity.ToString();
                }
            }
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn tạo mới không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (listViewSelectedFoods.Items.Count > 0)
                {
                    listViewSelectedFoods.Items.Clear();
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
