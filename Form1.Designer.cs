namespace Kiểm_tra_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddToCart = new Button();
            btnRemoveFromCart = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            lblTotalPrice = new Label();
            dataGridViewProducts = new DataGridView();
            dataGridViewCart = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.Location = new Point(40, 456);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(160, 29);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "Thêm vào giỏ hàng";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveFromCart.Location = new Point(307, 456);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(157, 29);
            btnRemoveFromCart.TabIndex = 2;
            btnRemoveFromCart.Text = "Xóa khỏi giỏ hàng";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 15);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 5;
            label1.Text = "Danh sách sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(765, 15);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 6;
            label2.Text = "Giỏ hàng";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(599, 456);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 7;
            button3.Text = "Thanh toán";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(599, 411);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(90, 20);
            lblTotalPrice.TabIndex = 8;
            lblTotalPrice.Text = "Tổng giá trị";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(26, 54);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(522, 330);
            dataGridViewProducts.TabIndex = 9;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(569, 54);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(460, 330);
            dataGridViewCart.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 535);
            Controls.Add(dataGridViewCart);
            Controls.Add(dataGridViewProducts);
            Controls.Add(lblTotalPrice);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(btnAddToCart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnAddToCart;
        private Button btnRemoveFromCart;
        private Label label1;
        private Label label2;
        private Button button3;
        private Label lblTotalPrice;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCart;
    }
}
