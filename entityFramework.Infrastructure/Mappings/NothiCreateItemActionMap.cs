using entityFrameworkArchitecture.Core.Entities;
using entityFrameworkArchitecture.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkArchitecture.Infrastructure.Mappings.Nothi
{
    public class NothiCreateItemActionMap : NothiEntityTypeConfiguration<NothiCreateItemAction>
    {
        public NothiCreateItemActionMap()
        {
            this.ToTable("NothiCreateItemAction");
            this.HasKey(a => a.Id);
        }
    }
}
