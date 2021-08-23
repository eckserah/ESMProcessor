using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESMProcessor
{
    public class EnumDescription : Attribute
    {
        /// <summary>
        /// Description of what the attribute is applied to.
        /// </summary>
        /// <value>description string</value>
        public string Description { get; set; }
        public FormID ID { get; set; }
        public string Name { get; set; }
        public int Index { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumDescription"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public EnumDescription(string description, uint formID, string editorID, int index = 0)
        {
            Description = description;
            ID = formID;
            Name = editorID;
            Index = index;
        }
    }
}
