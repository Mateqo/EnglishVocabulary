using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishVocabulary.Domain.Common
{
    public class AuditableModel
    {
        public DateTime CreatedDateTime { get; set; }
        public DateTime? DeletedDateTime { get; set; }
    }
}
