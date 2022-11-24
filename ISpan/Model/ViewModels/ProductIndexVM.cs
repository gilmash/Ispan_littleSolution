using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Model.ViewModels
{
    internal class ProductIndexVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string StoreName { get; set; }
        public string ProductsName { get; set; }
        public int Price { get; set; }
    }

    /// <summary>
    /// 供CreateProductForm, EditProductForm使用
    /// </summary>
    public class ProductVM
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string StoreName { get; set; }
        public string ProductsName { get; set; }
        public int Price { get; set; }
    }
}

