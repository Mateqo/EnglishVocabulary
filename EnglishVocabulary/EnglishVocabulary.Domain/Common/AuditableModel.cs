using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EnglishVocabulary.Domain.Common
{
    public class AuditableModel
    {
        [XmlIgnore]
        public DateTime CreatedDateTime { get; set; }
        [XmlIgnore]
        public DateTime? DeletedDateTime { get; set; }
    }
}
