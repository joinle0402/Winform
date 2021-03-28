
namespace WindowsFormsApp
{
    partial class Form9
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFoodTypes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxFoodMenu = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewSelectedFoods = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUnselect = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC ĐƠN MÓN ĂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại món ăn: ";
            // 
            // comboBoxFoodTypes
            // 
            this.comboBoxFoodTypes.FormattingEnabled = true;
            this.comboBoxFoodTypes.Location = new System.Drawing.Point(214, 127);
            this.comboBoxFoodTypes.Name = "comboBoxFoodTypes";
            this.comboBoxFoodTypes.Size = new System.Drawing.Size(159, 36);
            this.comboBoxFoodTypes.TabIndex = 2;
            this.comboBoxFoodTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxFoodTypes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxFoodMenu);
            this.groupBox1.Location = new System.Drawing.Point(53, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết món ăn";
            // 
            // checkedListBoxFoodMenu
            // 
            this.checkedListBoxFoodMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxFoodMenu.FormattingEnabled = true;
            this.checkedListBoxFoodMenu.Location = new System.Drawing.Point(3, 31);
            this.checkedListBoxFoodMenu.Name = "checkedListBoxFoodMenu";
            this.checkedListBoxFoodMenu.Size = new System.Drawing.Size(314, 200);
            this.checkedListBoxFoodMenu.TabIndex = 0;
            this.checkedListBoxFoodMenu.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxFoodMenu_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewSelectedFoods);
            this.groupBox2.Location = new System.Drawing.Point(721, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các món ăn đã chọn";
            // 
            // listViewSelectedFoods
            // 
            this.listViewSelectedFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSelectedFoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSelectedFoods.FullRowSelect = true;
            this.listViewSelectedFoods.GridLines = true;
            this.listViewSelectedFoods.HideSelection = false;
            this.listViewSelectedFoods.Location = new System.Drawing.Point(3, 31);
            this.listViewSelectedFoods.Name = "listViewSelectedFoods";
            this.listViewSelectedFoods.Size = new System.Drawing.Size(356, 197);
            this.listViewSelectedFoods.TabIndex = 0;
            this.listViewSelectedFoods.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedFoods.View = System.Windows.Forms.View.Details;
            this.listViewSelectedFoods.SelectedIndexChanged += new System.EventHandler(this.listViewSelectedFoods_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(548, 228);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(121, 35);
            this.numericUpDownQuantity.TabIndex = 6;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(405, 294);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(121, 46);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "Chọn";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.Location = new System.Drawing.Point(405, 376);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(121, 46);
            this.buttonCreateNew.TabIndex = 8;
            this.buttonCreateNew.Text = "Tạo mới";
            this.buttonCreateNew.UseVisualStyleBackColor = true;
            this.buttonCreateNew.Click += new System.EventHandler(this.buttonCreateNew_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(548, 376);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 46);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonUnselect
            // 
            this.buttonUnselect.Location = new System.Drawing.Point(548, 294);
            this.buttonUnselect.Name = "buttonUnselect";
            this.buttonUnselect.Size = new System.Drawing.Size(121, 46);
            this.buttonUnselect.TabIndex = 9;
            this.buttonUnselect.Text = "Bỏ Chọn";
            this.buttonUnselect.UseVisualStyleBackColor = true;
            this.buttonUnselect.Click += new System.EventHandler(this.buttonUnselect_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món ăn";
            this.columnHeader1.Width = 243;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 105;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 474);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUnselect);
            this.Controls.Add(this.buttonCreateNew);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxFoodTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFoodTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxFoodMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewSelectedFoods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonUnselect;
    }
}