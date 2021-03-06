using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_StateOnline.Core.Models
{
    public class Product
    {
        public string Id { get; set; }
        [StringLength(30)]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        public string Description { get; set; }
        [Range(0,50000)]
        public decimal Price { get; set; }

        public string Category { get; set; }
        public string image { get; set; }
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
