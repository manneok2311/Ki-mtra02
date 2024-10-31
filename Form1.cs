using System.Data;

namespace Kiểm_tra_02
{
    public partial class Form1 : Form
    {
        private ShoppingCart cart;
        private List<Product> products;

        public Form1()
        {
            InitializeComponent();
            cart = new ShoppingCart();
            LoadProducts();
            DisplayProducts();
        }

        private void LoadProducts()
        {
            products = new List<Product>
            {
                new Product("path/to/image1.jpg", "Sản phẩm 1", 10000, 1),
                new Product("path/to/image2.jpg", "Sản phẩm 2", 15000, 10),
                new Product("path/to/image3.jpg", "Sản phẩm 3", 25000, 12),
                new Product("path/to/image4.jpg", "Sản phẩm 4", 35000, 13),
                new Product("path/to/image5.jpg", "Sản phẩm 5", 55000, 20),
                new Product("path/to/image6.jpg", "Sản phẩm 6", 20000, 5)
            };
        }

        private void DisplayProducts()
        {
            var dt = new DataTable();
            dt.Columns.Add("Hình ảnh", typeof(Image));
            dt.Columns.Add("Tên sản phẩm", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));

            foreach (var product in products)
            {
                var row = dt.NewRow();
                row["Hình ảnh"] = File.Exists(product.Image) ? Image.FromFile(product.Image) : null;
                row["Tên sản phẩm"] = product.Name;
                row["Giá"] = product.Price.ToString("C");
                row["Số lượng"] = product.Quantity; // Hiển thị số lượng hiện tại
                dt.Rows.Add(row);
            }

            dataGridViewProducts.DataSource = dt;

            dataGridViewProducts.Columns[0].Width = 100;
            dataGridViewProducts.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProducts.Columns[0].HeaderText = "Hình ảnh";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
            {
                if (dataGridViewProducts.SelectedRows.Count > 0)
                {
                    // Lấy tên sản phẩm từ DataGridView
                    string productName = dataGridViewProducts.SelectedRows[0].Cells["Tên sản phẩm"].Value.ToString();
                    var selectedProduct = products.FirstOrDefault(p => p.Name == productName);

                    if (selectedProduct != null && selectedProduct.Quantity > 0) // Kiểm tra số lượng
                    {
                        // Thêm sản phẩm vào giỏ hàng
                        cart.AddProduct(selectedProduct);

                        // Giảm số lượng sản phẩm trong danh sách
                        selectedProduct.Quantity--;

                        // Cập nhật hiển thị giỏ hàng
                        UpdateCartDisplay();
                        DisplayProducts(); // Cập nhật lại hiển thị sản phẩm
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm đã hết hàng!");
                    }
                }
            }

        


        private void UpdateCartDisplay()
        {
            var cartItems = cart.GetItems().Select(item => new
            {
                item.Image,
                item.Name,
                Price = item.Price.ToString(),
                item.Quantity,
                Product = item 
            }).ToList();

            dataGridViewCart.DataSource = cartItems;
            lblTotalPrice.Text = $"Tổng tiền: {cart.CalculateTotal():N0} VNĐ";
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedRows.Count > 0)
            {
                
                var selectedProduct = (Product)dataGridViewCart.SelectedRows[0].Cells["Product"].Value;
                cart.RemoveProduct(selectedProduct);
                UpdateCartDisplay();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var total = cart.CalculateTotal();
            MessageBox.Show("Thanh toán thành công");

            cart.Clear();
            UpdateCartDisplay();
        }
    }

    public class Product
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string image, string name, decimal price, int quantity)
        {
            Image = image;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    public class ShoppingCart
    {
        private List<Product> items = new List<Product>();

        public void AddProduct(Product product)
        {
            items.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            items.Remove(product);
        }

        public decimal CalculateTotal()
        {
            return items.Sum(item => item.Price * item.Quantity);
        }

        public List<Product> GetItems()
        {
            return items;
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
