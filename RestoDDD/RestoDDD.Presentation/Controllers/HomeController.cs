using RestoDDD.Application.Interfaces;
using RestoDDD.Presentation.ViewModels;
using System.Collections;
using System.Web.Mvc;

namespace RestoDDD.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public readonly IRestaurantAppService _RestaurantAppService;
        public readonly IReservationAppService _ReservationAppService;
        public readonly INoteAppService _NoteAppService;
        public readonly ICuisineAppService _CuisineAppService;
        public readonly ICompteAppService _CompteAppService;
        public readonly ICommentaireAppService _CommentaireAppService;
        public HomeController(IRestaurantAppService RestaurantAppService,
            ICuisineAppService CuisineAppService,
            IReservationAppService ReservationAppService,
            INoteAppService NoteAppService,
            ICompteAppService CompteAppService,
            ICommentaireAppService CommentaireAppService
            )
        {
            _RestaurantAppService = RestaurantAppService;
            _CuisineAppService = CuisineAppService;
            _ReservationAppService = ReservationAppService;
            _NoteAppService = NoteAppService;
            _CompteAppService = CompteAppService;
            _CommentaireAppService = CommentaireAppService;
        }
        [AllowAnonymous]
        public ActionResult Index()
        {//
            return View(_RestaurantAppService.GetAll());
        }
        [AllowAnonymous]
        public ActionResult Recherche(int id)
        {
            return View(_RestaurantAppService.GetById(id));
        }

        [AllowAnonymous]
        public ActionResult Restaurant(int id)
        {
            ViewBag.Id = id;

            RestaurantViewModels rvm = new RestaurantViewModels
            {
                Restaurant = _RestaurantAppService.GetById(id),
                ListesDesCuisine = _CuisineAppService.GetAll()
            };
            return View(_RestaurantAppService.GetById(id));
        }
        [AllowAnonymous]
        public ActionResult Cuisine(int id)
        {
            ViewBag.Id = id;
            return View(_CuisineAppService.GetAll());
        }
        [AllowAnonymous]
        public ActionResult Menu(int id)
        {
            ViewBag.Id = id;
            return View(_RestaurantAppService.GetAll());
        }
        public ActionResult Reserver(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [AllowAnonymous]
        public ActionResult Galerie(int id)
        {
            ViewBag.Id = id;
            return View(_RestaurantAppService.GetAll());
        }
        [AllowAnonymous]
        public ActionResult Contact(int id)
        {
            ViewBag.Id = id;
            return View(_RestaurantAppService.GetById(id));
        }
    }
}