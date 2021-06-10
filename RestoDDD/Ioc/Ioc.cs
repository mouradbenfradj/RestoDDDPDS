using Microsoft.Practices.Unity;
using RestoDDD.Application.Interfaces;
using RestoDDD.Application.Services;
using RestoDDD.Domaine.Interfaces.Repositories;
using RestoDDD.Domaine.Interfaces.Services;
using RestoDDD.Domaine.Services;
using RestoDDD.infra.Repositories;

namespace Ioc
{
    public class IoC
    {
        private static IUnityContainer _Container;

        public IoC(IUnityContainer Container)
        {
            _Container = Container;
        }
        public void ResgitreType()
        {
            _Container.RegisterType(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));

            _Container.RegisterType<IRestaurant, RestaurantRepository>();
            _Container.RegisterType<IReservation, ReservationRepository>();
            _Container.RegisterType<ICommentaire, CommentaireRepository>();
            _Container.RegisterType<INote, NoteRepository>();
            _Container.RegisterType<ICompte, CompteRepository>();
            _Container.RegisterType<ICuisine, CuisineRepository>();


            //_Container.RegisterType(typeof(IServiceBase<>), typeof(ServiceBase<>));
            _Container.RegisterType<IRestaurantService, RestaurantService>();
            _Container.RegisterType<IReservationService, ReservationService>();
            _Container.RegisterType<ICommentaireService, CommentaireService>();
            _Container.RegisterType<INoteService, NoteService>();
            _Container.RegisterType<ICompteService, CompteService>();
            _Container.RegisterType<ICuisineService, CuisineService>();

            
            //_Container.RegisterType(typeof(IAppServiceBase<>), typeof(AppServiceBase<>));
            _Container.RegisterType<IRestaurantAppService, RestaurantAppService>();
            _Container.RegisterType<IReservationAppService, ReservationAppService>();
            _Container.RegisterType<ICommentaireAppService, CommentaireAppService>();
            _Container.RegisterType<INoteAppService, NoteAppService>();
            _Container.RegisterType<ICompteAppService, CompteAppService>();
            _Container.RegisterType<ICuisineAppService, CuisineAppService>();
            



        }





    }
}
