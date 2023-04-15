using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradDemonstration.Domain
{
    public class Product:FullAuditedEntity<Guid>
    {
        public virtual string ProductName { get; set; }
        public virtual string ProductDescription { get; set; }
    }
}
