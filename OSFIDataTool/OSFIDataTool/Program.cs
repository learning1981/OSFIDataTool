using Autofac;
using System;
using System.Windows.Forms;

namespace OSFIDataTool
{
    static class Program
    {
        private static IContainer _container { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();

            builder.RegisterType<Repository>().As<IRepository>();
            builder.RegisterType<ViewModel>().As<IViewModel>();

            _container = builder.Build();

            using (var scope = _container.BeginLifetimeScope())
            {
                var viewModel = scope.Resolve<IViewModel>();
                Application.Run(new OSFIDataTool(viewModel));
            }
        }
    }
}
