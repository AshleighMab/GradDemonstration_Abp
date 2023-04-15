using Abp.Domain.Entities.Auditing;
using GradDemonstration.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradDemonstration.Domain.Enum;

namespace GradDemonstration.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime DateOfBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public virtual string Password { get; set; }

        [StringLength(13)]
        public virtual string IDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual RefListGender? Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 
        /// </summary>

        [NotMapped]
        public virtual string[] RoleNames { get; set; }
    }
}
