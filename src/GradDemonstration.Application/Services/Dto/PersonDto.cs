﻿using Abp.Application.Services.Dto;
using GradDemonstration.Domain.Enum;
using GradDemonstration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;

namespace GradDemonstration.Services.Dto
{
    [AutoMap(typeof(Person))]
    public class PersonDto : EntityDto<Guid>
    {
        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string IDNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public RefListGender? Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string GenderName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual long userId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] RoleNames { get; set; }
    }
}
