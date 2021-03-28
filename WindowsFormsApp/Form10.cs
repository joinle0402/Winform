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
        List<List<Book>> BookMenu = new List<List<Book>>();

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
            TreeNode root1 = new TreeNode("Tin học");
            root1.Nodes.AddRange(new TreeNode[] 
            { 
                new TreeNode("Lập trình giao diện"),
                new TreeNode("Mạng máy tính"),
                new TreeNode("Cơ sở dữ liệu")
            });

            TreeNode root2 = new TreeNode("Thiều nhi");
            root2.Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Tấm cám"),
                new TreeNode("Thánh giống")
            });

            treeViewBookTypes.Nodes.AddRange(new TreeNode[] { root1, root2 });

            List<Book> books1 = new List<Book>();
            books1.Add(new Book("Lập trình giao diện", "Phương Linh", 35000));
            books1.Add(new Book("Mạng máy tính", "Minh Khánh", 45000));
            books1.Add(new Book("Cơ sở dữ liệu", "Thiên Trang", 30000));
            BookMenu.Add(books1);

            List<Book> books2 = new List<Book>();
            books2.Add(new Book("Tấm cám", "Chuyện cổ tính", 25000));
            books2.Add(new Book("Thánh giống", "Chuyện cổ tính", 40000));
            BookMenu.Add(books2);
        }

        private void treeViewBookTypes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewBookTypes.SelectedNode.Index >= 0)
            {
                listViewBooks.Items.Clear();
                List<Book> books = BookMenu[treeViewBookTypes.SelectedNode.Index];

                foreach (Book book in books)
                {
                    string[] rowData = new string[]
                    {
                        book.Subject,
                        book.Author,
                        book.UnitPrice.ToString()
                    };
                    ListViewItem listViewItem = new ListViewItem(rowData);
                    listViewBooks.Items.Add(listViewItem);
                }

                labelTotalPrice.Text = $"Tổng thành tiền là: {GetTotalPrice()}";
            }
        }
    }
}
