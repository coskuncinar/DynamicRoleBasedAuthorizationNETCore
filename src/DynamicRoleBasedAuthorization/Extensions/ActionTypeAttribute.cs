using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicRoleBasedAuthorization.Extensions
{
    public class ActionTypeAttribute : Attribute
    {
        public bool ActionHide { get; set; }
        public ActionTypeAttribute()
        {
            this.ActionHide = true;
        }
    }    
}
