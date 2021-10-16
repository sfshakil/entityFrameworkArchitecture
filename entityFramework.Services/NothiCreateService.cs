
using entityFrameworkArchitecture.Core.Entities;
using entityFrameworkArchitecture.Core.Interfaces;

namespace entityFrameworkArchitecture.Services.NothiServices
{
    public class NothiCreateService : INothiCreateService
    {
        IRepository<NothiCreateItemAction> _nothiCreateItemAction;
        public NothiCreateService(IRepository<NothiCreateItemAction> nothiCreateItemAction)
        {
            _nothiCreateItemAction = nothiCreateItemAction;
        }
        public void SendNothiCreateListFromLocal()
        {
            NothiCreateItemAction nothiCreateItemAction; 
            nothiCreateItemAction = new NothiCreateItemAction();
            nothiCreateItemAction.designation_id = 1;
            nothiCreateItemAction.office_id = 2;
            nothiCreateItemAction.office_unit_id = 3;
            nothiCreateItemAction.designation = "";

            _nothiCreateItemAction.Insert(nothiCreateItemAction);
        }
    }
}
