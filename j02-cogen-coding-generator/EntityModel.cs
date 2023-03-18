using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j02_cogen_coding_generator
{
    public class EntityModel
    {
        public string Name { get; set; }
        public string PrefixTable { get; set; }
        public List<PropertyModel> ListProperties { get; set; }
    }
    public class PropertyModel
    {
        public PropertyModel(string name) => Name = name;
        public string Name { get; set; }
    }
}
