using System.Collections.Generic;

namespace PE.Models.paging
{
    public class PagingCustomer
    {
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
        public List<Customer> CustomerList { get; set; }
    }
}
