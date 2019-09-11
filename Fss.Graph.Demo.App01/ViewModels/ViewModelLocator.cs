using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Fss.Graph.Demo.App01.Helpers;
using Fss.Graph.Demo.App01.ViewModels.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace Fss.Graph.Demo.App01.ViewModels
{
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        static ViewModelLocator()
        {
            var builder = new ContainerBuilder();
                builder.RegisterType<GraphDataHelper>().As<IGraphDataHelper>().AsSelf();
                builder.RegisterType<UniverseGraphDataHelper>().As<IUniverseGraphDataHelper>().AsSelf();
                builder.RegisterType<MainViewModel>().As<IMainViewModel>().AsSelf();
                builder.RegisterType<GraphViewModel>().As<IGraphViewModel>().AsSelf();
                builder.RegisterType<UniverseGraphViewModel>().As<IUniverseGraphViewModel>().AsSelf();

            if (!ViewModelBase.IsInDesignModeStatic)
            {
                //builder.RegisterModule<DataServiceModule>();
            }
            else
            {
                //builder.RegisterType<Fss.HumanCapitalManager.DesignDataService.DesignDataService>().As<IDataService>().AsSelf();
            }

            //SimpleIoc.Default.Register<IGraphDataHelper, GraphDataHelper>();
            //SimpleIoc.Default.Register<IMainViewModel, MainViewModel>();

            
            
            Container = builder.Build();
            Console.WriteLine(OuputRegistrations());
        }

        public static IContainer Container { get; set; }

        public IMainViewModel MainViewModel => Container.Resolve<IMainViewModel>();

        public IUniverseGraphViewModel UniverseGraphViewModel => Container.Resolve<IUniverseGraphViewModel>();


        private static string OuputRegistrations()
        {
            var sw = new StringWriter();
            foreach (var registration in Container.ComponentRegistry.Registrations)
            {
                sw.WriteLine($"Activator: {registration.Activator}");
                sw.WriteLine($"{registration.Id}");
                foreach (var service in registration.Services)
                {
                    sw.WriteLine($"\t\t{GetPropertyValues(service)}");
                }
            }

            return sw.ToString();
        }

        private static string GetPropertyValues(Object obj)
        {
            StringWriter sw = new StringWriter();

            Type t = obj.GetType();
            sw.WriteLine("Type is: {0}", t.Name);
            PropertyInfo[] props = t.GetProperties();
            sw.WriteLine("Properties (N = {0}):",
                              props.Length);
            foreach (var prop in props)
                if (prop.GetIndexParameters().Length == 0)
                    sw.WriteLine("   {0} ({1}): {2}", prop.Name,
                                      prop.PropertyType.Name,
                                      prop.GetValue(obj));
                else
                    sw.WriteLine("   {0} ({1}): <Indexed>", prop.Name,
                                      prop.PropertyType.Name);
            return sw.ToString();
        }

    }
}
