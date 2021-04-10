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
    public partial class Form11 : Form
    {
        List<Vehicle> vehicleList = new List<Vehicle>();

        public void AddVehicleToListView(Vehicle vehicle)
        {
            string[] rowData = new string[]
            {
                vehicle.Manufacturer,
                vehicle.YearOfProduction.ToString(),
                vehicle.Engine.ToString(),
                vehicle.Price.ToString()
            };
            ListViewItem listViewItem = new ListViewItem(rowData);
            listViewVehicles.Items.Add(listViewItem);
        }

        public List<Vehicle> GetVehiclesFormTreeView()
        {
            List<Vehicle> foundVehicles = new List<Vehicle>();

            if (treeViewVehicles.SelectedNode.Level == 0)
            {
                return vehicleList;
            }

            if (treeViewVehicles.SelectedNode.Level == 1)
            {
                
            }
            return foundVehicles;
        }

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBoxPaymentMethods.Items.Add("bằng chuyển khoản");
            comboBoxPaymentMethods.Items.Add("bằng tiền mặt");
            comboBoxPaymentMethods.Items.Add("bằng thẻ điện tử");

            treeViewVehicles.Nodes.Add("Xe");
            treeViewVehicles.Nodes[0].Nodes.Add("Xe máy");
            treeViewVehicles.Nodes[0].Nodes[0].Nodes.Add("SH");
            treeViewVehicles.Nodes[0].Nodes[0].Nodes.Add("Spacy");
            treeViewVehicles.Nodes[0].Nodes.Add("Ô tô");
            treeViewVehicles.Nodes[0].Nodes[1].Nodes.Add("Innova");
            treeViewVehicles.Nodes[0].Nodes[1].Nodes.Add("Camry");

            vehicleList.Add(new Vehicle("Ducati", 2012, 125, 40000000));
            vehicleList.Add(new Vehicle("Ducati", 2013, 125, 42000000));
            vehicleList.Add(new Vehicle("Spacy", 2017, 150, 52000000));
            vehicleList.Add(new Vehicle("Toyo", 2013, 100, 150000000));
            vehicleList.Add(new Vehicle("Huyndai", 2012, 300, 200000000));
            vehicleList.Add(new Vehicle("Huyndai", 2015, 400, 500000000));
        }

        private void treeViewVehicles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewVehicles.SelectedNode.Index >= 0)
            {
                List<Vehicle> vehicleFromTreeView = GetVehiclesFormTreeView();

                vehicleFromTreeView.ForEach(vehicle => AddVehicleToListView(vehicle));
            }
        }
    }
}
