using entityFrameworkArchitecture.Services.NothiServices;
using System.Windows.Forms;

namespace entityFrameworkArchitecture.Desktop.UI
{
    public partial class WinForm : Form
    {
        INothiCreateService _nothiCreateServices { get; set; }
        public WinForm(INothiCreateService nothiCreateServices)
        {
            _nothiCreateServices = nothiCreateServices;
            loadNothiExtra();
        }
        public void loadNothiExtra()
        {
            _nothiCreateServices.SendNothiCreateListFromLocal();

        }
    }
}
