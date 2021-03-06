using System;
using System.Collections.Generic;
using System.Text;

namespace AdmBoots.Data.EntityFrameworkCore.Uow {

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Interface)]
    public class UnitOfWorkAttribute : Attribute {
        public bool IsDisabled { get; set; }
    }
}
