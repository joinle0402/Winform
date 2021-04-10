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
    public partial class Form12 : Form
    {
        private int width = 35;
        private int height = 35;
        private int gap = 10;
        private int padding = 20;

        private int level = 5;

        private int GetMainDiagonal()
        {
            int mainDiagonalValue = 0;

            for (int i = 0; i < level; i++)
            {
                Point point = new Point();
                point.X = (width + gap) * i + padding;
                point.Y = (height + gap) * i + groupBoxMatrix.Location.Y + padding;
                mainDiagonalValue += Convert.ToInt32(groupBoxMatrix.GetChildAtPoint(point).Text);
            }


            return mainDiagonalValue;
        }

        private int GetSubDiagonal()
        {
            int subDiagonalValue = 0;

            for (int i = 0; i < level; i++)
            {
                Point point = new Point();
                point.X = (width + gap) * i + padding;
                point.Y = (height + gap) * (level - 1 - i) + groupBoxMatrix.Location.Y + padding;
                subDiagonalValue += Convert.ToInt32(groupBoxMatrix.GetChildAtPoint(point).Text);
            }

            return subDiagonalValue;
        }

        public Form12()
        {
            InitializeComponent();
        }

        private void CreateInputs()
        {
            groupBoxMatrix.Controls.Clear();

            for (int i = 0; i < level; i++)
            {
                for (int j = 0; j < level; j++)
                {
                    TextBox textBox = new TextBox();
                    textBox.Top = (height + gap) * i + groupBoxMatrix.Location.Y + padding;
                    textBox.Left = (width + gap) * j + padding;
                    textBox.Width = width;
                    textBox.Height = height;
                    textBox.Name = $"textBox[{i}, {j}]";
                    textBox.Text = "0";
                    groupBoxMatrix.Controls.Add(textBox);
                }
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            groupBoxMatrix.Width = (width + gap) * 10 + 2 * padding - gap;
            groupBoxMatrix.Height = (height + gap) * 10 + 2 * padding - gap;

            numericUpDownQuantity.Value = 4;

            labelResult1.Text = $"Tổng các phần tử trên đường chéo chính là: 0";
            labelResult2.Text = $"Tổng các phần tử trên đường chéo phụ là: 0";

            CreateInputs();
        }

        private void buttonCreateInput_Click(object sender, EventArgs e)
        {
            CreateInputs();
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            level = Convert.ToInt32(numericUpDownQuantity.Value);
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            labelResult1.Text = $"Tổng các phần tử trên đường chéo chính là: {GetMainDiagonal()}";
            labelResult2.Text = $"Tổng các phần tử trên đường chéo phụ là: {GetSubDiagonal()}";
        }
    }
}
