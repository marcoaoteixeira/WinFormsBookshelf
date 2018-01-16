using System;
using System.Reflection;
using System.Windows.Forms;
using Nameless.Bookshelf.Views;
using Nameless.WinFormsApplication;
using Nameless.WinFormsApplication.Auth;
using Nameless.WinFormsApplication.Auth.IoC;
using Nameless.WinFormsApplication.CQRS.IoC;
using Nameless.WinFormsApplication.Infrastructure.IoC;
using Nameless.WinFormsApplication.IO.IoC;
using Nameless.WinFormsApplication.IoC;
using Nameless.WinFormsApplication.Logging.IoC;
using Nameless.WinFormsApplication.ObjectMapper.IoC;
using Nameless.WinFormsApplication.Persistence.IoC;
using Nameless.WinFormsApplication.PubSub.IoC;
using Nameless.WinFormsApplication.Search.IoC;
using Nameless.WinFormsApplication.Security.IoC;

namespace Nameless.Bookshelf {

    internal static class EntryPoint {

        #region Internal Static Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main() {
            Bootstrapper.Instance.Run();

            var supportAssemblies = new[] {
                Assembly.Load("Nameless.Bookshelf.App"),
                Assembly.Load("Nameless.Bookshelf.Core"),
                Assembly.Load("Nameless.WinFormsApplication.Core"),
                Assembly.Load("Nameless.WinFormsApplication.Auth"),
                Assembly.Load("Nameless.WinFormsApplication.Persistence.MongoDB")
            };

            using (var compositionRoot = new CompositionRoot()) {
                compositionRoot.Compose(new IServiceRegistration[] {
                    new CQRSServiceRegistration(supportAssemblies),
                    new InfrastructureServiceRegistration(supportAssemblies),
                    new IOServiceRegistration(supportAssemblies),
                    new LoggingServiceRegistration(supportAssemblies),
                    new ObjectMapperServiceRegistration(supportAssemblies),
                    new PubSubServiceRegistration(supportAssemblies),
                    new PersistenceServiceRegistration(supportAssemblies),
                    new SearchServiceRegistration(supportAssemblies),
                    new SecurityServiceRegistration(supportAssemblies),
                    new ApplicationServiceRegistration(supportAssemblies),

                    new AuthServiceRegistration(),
                    new MongoDBServiceRegistration(supportAssemblies)
                });

                compositionRoot.StartUp();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (compositionRoot.Resolver.Resolve<IAuthService>().SignIn()) {
                    Application.Run(compositionRoot.Resolver.Resolve<MainForm>());
                }
            }
        }

        #endregion Internal Static Methods
    }
}