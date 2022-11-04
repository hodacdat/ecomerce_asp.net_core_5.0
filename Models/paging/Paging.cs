using System.Collections.Generic;

namespace PE.Models.paging
{
    public class Paging
    {
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
        public List<Product> ProductList { get; set; }
    }


}
