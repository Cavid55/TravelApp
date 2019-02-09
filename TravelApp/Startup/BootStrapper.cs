using Autofac;
using TravelApp.ViewModels;

namespace TravelApp.Startup
{
    public class BootStrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            ////builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            ////builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            //builder.RegisterType<MyStatDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowModel>().AsSelf();
            //builder.RegisterType<MyStatViewModel>().AsSelf();
            //builder.RegisterType<SignInViewModel>().AsSelf();
            ////builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();

            ////builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            //builder.RegisterType<UserDataService>().As<IUserDataService>();

            return builder.Build();
        }
    }
}