using Autofac;
using entityFrameworkArchitecture.Core.Interfaces;
using entityFrameworkArchitecture.Desktop.Interfaces;
using entityFrameworkArchitecture.Infrastructure;
using entityFrameworkArchitecture.Services.NothiServices;

namespace entityFrameworkArchitecture.Desktop
{
    static class Program
    {
        private static IContainer container;
        static void Main()
        {
            
            Bootstrap();
            var form = FormFactory.Create<UI.WinForm>();
            form.TopMost = true;
            form.TopMost = false;
            form.ShowDialog();
            
        }

        
        private static void Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AppDbContext>().As<IDbContext>();
            
            builder.RegisterType<EfRepository<entityFrameworkArchitecture.Core.Entities.NothiCreateItemAction>>().As<IRepository<entityFrameworkArchitecture.Core.Entities.NothiCreateItemAction>>();
            
            builder.RegisterType<NothiCreateService>().As<INothiCreateService>();
            
            builder.RegisterType<AutofacFormFactory>().As<IFormFactory>();
            builder.RegisterType<AutofacUserControlFactory>().As<IUserControlFactory>();
            

            builder.RegisterType<UI.WinForm>().AsSelf();
            

           
            container = (builder.Build());
            FormFactory.Use(container.Resolve<IFormFactory>());
            UserControlFactory.Use(container.Resolve<IUserControlFactory>());
        }
    }
}
