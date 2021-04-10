
namespace WindowsFormsApp
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewVehicles = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewVehicles = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethods = new System.Windows.Forms.ComboBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách xe:";
            // 
            // treeViewVehicles
            // 
            this.treeViewVehicles.Location = new System.Drawing.Point(17, 72);
            this.treeViewVehicles.Name = "treeViewVehicles";
            this.treeViewVehicles.Size = new System.Drawing.Size(233, 308);
            this.treeViewVehicles.TabIndex = 1;
            this.treeViewVehicles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewVehicles_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin chi tiết về xe:";
            // 
            // listViewVehicles
            // 
            this.listViewVehicles.HideSelection = false;
            this.listViewVehicles.Location = new System.Drawing.Point(313, 72);
            this.listViewVehicles.Name = "listViewVehicles";
            this.listViewVehicles.Size = new System.Drawing.Size(498, 308);
            this.listViewVehicles.TabIndex = 3;
            this.listViewVehicles.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(121, 403);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(54, 33);
            this.numericUpDownQuantity.TabIndex = 5;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(12, 464);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(0, 25);
            this.labelTotalPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phương thức thanh toán: ";
            // 
            // comboBoxPaymentMethods
            // 
            this.comboBoxPaymentMethods.FormattingEnabled = true;
            this.comboBoxPaymentMethods.Location = new System.Drawing.Point(559, 403);
            this.comboBoxPaymentMethods.Name = "comboBoxPaymentMethods";
            this.comboBoxPaymentMethods.Size = new System.Drawing.Size(252, 33);
            this.comboBoxPaymentMethods.TabIndex = 8;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(313, 464);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(125, 50);
            this.buttonOrder.TabIndex = 9;
            this.buttonOrder.Text = "Đặt hàng";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(559, 464);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 50);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 538);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.comboBoxPaymentMethods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewVehicles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeViewVehicles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewVehicles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewVehicles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethods;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonExit;
    }
}