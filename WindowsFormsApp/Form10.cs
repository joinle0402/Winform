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
    public partial class Form10 : Form
    {
        List<Book> bookList = new List<Book>();

        private double GetTotalPrice()
        {
            double totalPrice = 0;

            foreach (ListViewItem RowData in listViewBooks.Items)
            {
                totalPrice += Convert.ToDouble(RowData.SubItems[2].Text);
            }

            return totalPrice;
        }

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            treeViewBookTypes.Nodes.Add("Tin học");
            treeViewBookTypes.Nodes[0].Nodes.Add("Lập trình giao diện");
            treeViewBookTypes.Nodes[0].Nodes.Add("Mạng máy tính");
            treeViewBookTypes.Nodes.Add("Thiều nhi");
            treeViewBookTypes.Nodes[1].Nodes.Add("Tấm cám");
            treeViewBookTypes.Nodes[1].Nodes.Add("Thánh giống");

            bookList.Add(new Book("Lập trình giao diện", "Phương Linh", 35000));
            bookList.Add(new Book("Mạng máy tính", "Minh Khánh", 45000));
            bookList.Add(new Book("Cơ sở dữ liệu", "Thiên Trang", 30000));
            bookList.Add(new Book("Tấm cám", "Chuyện cổ tính", 25000));
            bookList.Add(new Book("Thánh giống", "Chuyện cổ tính", 40000));
        }

        private void treeViewBookTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewBookTypes.SelectedNode.Index >= 0)
            {
                if (treeViewBookTypes.SelectedNode.Parent != null)
                {
                    int index = 0;
                    for (int i = 0; i < treeViewBookTypes.SelectedNode.Parent.Index; i++)
                        index += treeViewBookTypes.Nodes[i].Nodes.Count;
                    Book book = bookList[index + treeViewBookTypes.SelectedNode.Index];
                    string[] rowData = new string[] 
                    {
                        book.Subject,
                        book.Author,
                        book.UnitPrice.ToString()
                    };
                    ListViewItem listViewItem = new ListViewItem(rowData);
                    listViewBooks.Items.Clear();
                    listViewBooks.Items.Add(listViewItem);
                }
                else
                {
                    listViewBooks.Items.Clear();

                    int index = 0;
                    for (int i = 0; i < treeViewBookTypes.SelectedNode.Index; i++)
                    {
                        index += treeViewBookTypes.Nodes[i].Nodes.Count;
                    }

                    for (int i = 0; i < treeViewBookTypes.SelectedNode.Nodes.Count; i++)
                    {
                        Book book = bookList[index + i];
                        string[] rowData = new string[]
                        {
                            book.Subject,
                            book.Author,
                            book.UnitPrice.ToString()
                        };
                        ListViewItem listViewItem = new ListViewItem(rowData);
                        
                        listViewBooks.Items.Add(listViewItem);
                    }
                }

                labelTotalPrice.Text = $"Tổng thành tiền là : {GetTotalPrice()}";
            }
        }
    }
}
