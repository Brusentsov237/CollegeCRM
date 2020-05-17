using System;
using Autofac;
using DevEduCRM.DAL;
using DevEduCRM.Data;
using DevEduCRM.Data.DataManagement;
using DevEduCRM.Data.Models;
using DevEduCRM.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace DevEduCRM
{
    public partial class App : Application
    {
         static IContainer container;
         public App()
        {
            
            InitializeComponent();

            ContainerBuilder builder = new ContainerBuilder();
            RegisterTypes(builder);
            container = builder.Build();

            //DependencyResolver.ResolveUsing(type => container.IsRegistered(type) ? container.Resolve(type) : null);
            MainPage = new MainPage();
        }

        private void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<TokenManager>().As<ITokenManager>()
            .SingleInstance();
        }
       

        protected override async void OnStart()
        {
            var service = new UserService();
            var model = new AuthModel
            {
                Id = 0,
                Login = "TestYourLuck",
                Password = "123"
            };
            var tokenManager = container.Resolve<ITokenManager>();
            var token = await service.Auth(model);
            tokenManager.SetToken(token);
            var groupService = new GroupService(token);

            var group = await groupService.GetGroupById();
            var groups = await groupService.GetAllGroups();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
