using ISpan.Infra.Extensions;
using ISpan.Model.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan
{
    public partial class ProductsForm : Form
    {
        private ProductIndexVM[] products = null;
        public ProductsForm()
        {
            InitializeComponent();

            InitForm();

            // 顯示商品記錄
            DisplayProducts();


        }

        private void InitForm()
        {
            // 設定 categoryIdComboBox property
            categoryIdComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sql = "SELECT * FROM ProductCategories ORDER BY DisplayOrder";
            var dbHelper = new SqlDbHelper("default");

            List<ProductCategoryVM> categories = dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => ToCategoryVM(row))
                .Prepend(new ProductCategoryVM { Id = 0, CategoryName = String.Empty })
                .ToList();

            this.categoryIdComboBox.DataSource = categories;


            ///////////////////////////////////////////////
            priceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var sqlprice = "SELECT * FROM Products ORDER BY Price";
            var dbHelperprice = new SqlDbHelper("default");

            List<ProductVM> priceies = dbHelperprice.Select(sqlprice, null)
                .AsEnumerable()
                .Select(row => ToProductVM(row))
                .Prepend(new ProductVM { Id = 0, Price = 0})
                .ToList();

            this.priceComboBox.DataSource = priceies;
        }


        private ProductVM ToProductVM(DataRow row)
        {
            return new ProductVM
            {
                Id = row.Field<int>("Id"),
                CategoryId = row.Field<int>("CategoryId"),
                StoreName = row.Field<string>("StoreName"),
                ProductsName = row.Field<string>("ProductsName"),
                Price = row.Field<int>("Price")


            };
        }
        //////////////////////////////////////////////


        private ProductCategoryVM ToCategoryVM(DataRow row)
        {
            return new ProductCategoryVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                DisplayOrder = row.Field<int>("DisplayOrder")
            };
        }


        private void DisplayProducts()
        {
            string sql = @"SELECT P.Id, P.StoreName , P.ProductsName, P.Price, C.CategoryName
FROM Products P
INNER JOIN ProductCategories C ON P.CategoryId = C.Id";

            #region 加入 where 
            SqlParameter[] parameters = new SqlParameter[] { };

            //取得篩選值
            int categoryId = ((ProductCategoryVM)categoryIdComboBox.SelectedItem).Id;


            int priceid = ((ProductVM)priceComboBox.SelectedItem).Id;
            int price = priceComboBox.Text.ToInt(-1);

            if (categoryId > 0 && priceid > 0)


            {
                sql += " WHERE CategoryId=@CategoryId and Price=@Price";
                parameters = new SqlParameterBuilder()
                .AddNInt("CategoryId", categoryId)
                    .AddNInt("Price", price)
                    .Build();
            }
            ////////////////////////////////////
            else if (priceid > 0)
            {
                sql += " WHERE Price=@Price";
                parameters = new SqlParameterBuilder()
                    .AddNInt("Price", price)
                    .Build();
            }

            else if (categoryId > 0)
            {
                sql += " WHERE CategoryId=@CategoryId";
                parameters = new SqlParameterBuilder()
                    .AddNInt("CategoryId", categoryId)
                    .Build();
            }


            //if (categoryId == 0 && priceid == 0)


            //    {
            //        sql += " ";
            //        parameters = new SqlParameterBuilder()
            //        .AddNInt("CategoryId", categoryId)
            //            .AddNInt("Price", price)
            //            .Build();
            //    }

            /////////////////////////////////////////////

            #endregion

            // 加入排序子句
            sql += " ORDER BY C.DisplayOrder, P.ProductsName";
            var dbHelper = new SqlDbHelper("default");
            // 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
            products = dbHelper.Select(sql, parameters)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToArray();
           
            BindData(products);


        }
        private void BindData(ProductIndexVM[] data)
        {
            dataGridView1.DataSource = data;
        }

        private ProductIndexVM ParseToIndexVM(DataRow row)
        {
            return new ProductIndexVM
            {
                Id = row.Field<int>("Id"),
                CategoryName = row.Field<string>("CategoryName"),
                StoreName = row.Field<string>("StoreName"),
                ProductsName = row.Field<string>("ProductsName"),
                Price = row.Field<int>("Price"),
            };
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void addnewButton_Click(object sender, EventArgs e)
        {
            var frm = new AddProductForm();
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                DisplayProducts();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndx = e.RowIndex;

            if (rowIndx < 0) return;

            ProductIndexVM row = this.products[rowIndx]; // 使用者點到的那一筆記錄

            int id = row.Id; // 使用者點到的那一筆記錄的id值

            // 把 id 傳給編輯表單的建構函數
            var frm = new EditProductForm(id);
            
            if (frm.ShowDialog() == DialogResult.OK)
            {
                DisplayProducts();
            }

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
