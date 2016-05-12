using Autofac;
using Autofac.Core;
using SportsMart.Repository;
using System.Configuration;
using System.Reflection;

namespace SportsMart.Web
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Register Services
            builder.RegisterAssemblyTypes(Assembly.Load("SportsMart.Services"))
                    .Where(t => t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();

            //Register Repository
            builder.RegisterAssemblyTypes(Assembly.Load("SportsMart.Repository"))
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            //Register the DBServices to default connection
            builder.Register<DbService>(c => new DbService(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)).As<IDbService>();
        }
    }
}