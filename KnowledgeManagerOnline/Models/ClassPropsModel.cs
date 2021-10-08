using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeManagerOnline.Models
{
    public class ClassPropsModel
    {
        public string propertyName { get; set; }
        public string propertyValue { get; set; }

        public ClassPropsModel(string PropertyName, string PropertyValue)
        {
            propertyName = PropertyName;
            propertyValue = PropertyValue;
        }
    }
}
