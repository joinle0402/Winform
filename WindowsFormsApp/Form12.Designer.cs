
namespace WindowsFormsApp
{
    partial class Form12
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
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateInput = new System.Windows.Forms.Button();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.labelResult1 = new System.Windows.Forms.Label();
            this.labelResult2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(535, 28);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(120, 35);
            this.numericUpDownQuantity.TabIndex = 0;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ValueChanged);
            // 
            // buttonCreateInput
            // 
            this.buttonCreateInput.Location = new System.Drawing.Point(535, 93);
            this.buttonCreateInput.Name = "buttonCreateInput";
            this.buttonCreateInput.Size = new System.Drawing.Size(120, 47);
            this.buttonCreateInput.TabIndex = 1;
            this.buttonCreateInput.Text = "Tạo mới";
            this.buttonCreateInput.UseVisualStyleBackColor = true;
            this.buttonCreateInput.Click += new System.EventHandler(this.buttonCreateInput_Click);
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(480, 480);
            this.groupBoxMatrix.TabIndex = 2;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Matrix";
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.Location = new System.Drawing.Point(535, 176);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(120, 47);
            this.buttonGetResult.TabIndex = 3;
            this.buttonGetResult.Text = "Tính";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.buttonGetResult_Click);
            // 
            // labelResult1
            // 
            this.labelResult1.AutoSize = true;
            this.labelResult1.Location = new System.Drawing.Point(7, 523);
            this.labelResult1.Name = "labelResult1";
            this.labelResult1.Size = new System.Drawing.Size(156, 29);
            this.labelResult1.TabIndex = 4;
            this.labelResult1.Text = "Hello World 1";
            // 
            // labelResult2
            // 
            this.labelResult2.AutoSize = true;
            this.labelResult2.Location = new System.Drawing.Point(7, 567);
            this.labelResult2.Name = "labelResult2";
            this.labelResult2.Size = new System.Drawing.Size(156, 29);
            this.labelResult2.TabIndex = 5;
            this.labelResult2.Text = "Hello World 1";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 635);
            this.Controls.Add(this.labelResult2);
            this.Controls.Add(this.labelResult1);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.buttonCreateInput);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form12";
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonCreateInput;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.Button buttonGetResult;
        private System.Windows.Forms.Label labelResult1;
        private System.Windows.Forms.Label labelResult2;
    }
}