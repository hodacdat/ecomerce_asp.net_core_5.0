using System;
using System.Collections.Generic;

#nullable disable

namespace PE.Models
{
    public partial class AttributesPrice
    {
        public int AttributePriceId { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public bool Active { get; set; }

        public virtual Attribute Attribute { get; set; }
    }
}
