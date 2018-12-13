using EuGari.Domain.Contracts.Reporitories;
using EuGari.Infra.DataContext;
using EuGari.Infra.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace EuGari.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPessoaRepository, PessoaRepository>(new InjectionConstructor(
                    new ResolvedParameter(typeof(MyDataContext), "business")));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}