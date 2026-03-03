namespace CWS_App
{
    partial class Manage_Products
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
            addNewProduct = new GroupBox();
            ProductName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            addNewProduct.SuspendLayout();
            SuspendLayout();
            // 
            // addNewProduct
            // 
            addNewProduct.Controls.Add(textBox2);
            addNewProduct.Controls.Add(label1);
            addNewProduct.Controls.Add(textBox1);
            addNewProduct.Controls.Add(ProductName);
            addNewProduct.Location = new Point(12, 12);
            addNewProduct.Name = "addNewProduct";
            addNewProduct.Size = new Size(776, 354);
            addNewProduct.TabIndex = 0;
            addNewProduct.TabStop = false;
            addNewProduct.Text = "Add New Product";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(6, 37);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(84, 15);
            ProductName.TabIndex = 0;
            ProductName.Text = "Product Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(632, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // Manage_Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 624);
            Controls.Add(addNewProduct);
            Name = "Manage_Products";
            Text = "Manage Products";
            addNewProduct.ResumeLayout(false);
            addNewProduct.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox addNewProduct;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label ProductName;
    }
}