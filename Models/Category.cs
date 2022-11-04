using System;
using System.Collections.Generic;

#nullable disable

namespace PE.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            TbTinTucs = new HashSet<TbTinTuc>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? Levels { get; set; }
        public int? Ordering { get; set; }
        public bool Published { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetalDesc { get; set; }
        public string MetalKey { get; set; }
        public string Cover { get; set; }
        public string SchemalMarkup { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<TbTinTuc> TbTinTucs { get; set; }
    }
}
