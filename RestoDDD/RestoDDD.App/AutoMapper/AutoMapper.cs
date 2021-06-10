using AutoMapper;
using RestoDDD.Application.Entities;
using RestoDDD.Application.Entities;
using RestoDDD.Domaine.Entities;
using RestoDDD.Application.AutoMapper;

namespace RestoDDD.Application.AutoMapper
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new CommentaireProfile());
                cfg.AddProfile(new RestaurantProfile());
                cfg.AddProfile(new ReservationProfile());
                cfg.AddProfile(new CompteProfile());
                cfg.AddProfile(new NoteProfile());
                cfg.AddProfile(new CuisineProfile());
                cfg.AddProfile(new ImagesProfile());
            });
        }
    }

    public class ImagesProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Images, Images_DTO>();
            Mapper.CreateMap<Images_DTO, Images>();
        }
    }
    public class CommentaireProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Commentaire, Commentaire_DTO>();
            Mapper.CreateMap<Commentaire_DTO, Commentaire>();


        }
    }


    public class RestaurantProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Restaurant, Restaurant_DTO>();
            Mapper.CreateMap<Restaurant_DTO, Restaurant>();


        }
    }

    public class ReservationProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Reservation, Reservation_DTO>();
            Mapper.CreateMap<Reservation_DTO, Reservation>();
        }


    }

    public class CompteProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Compte, Compte_DTO>();
            Mapper.CreateMap<Compte_DTO, Compte>();
        }


    }

    public class NoteProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Note, Note_DTO>();
            Mapper.CreateMap<Note_DTO, Note>();
        }


    }


    public class CuisineProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Cuisine, Cuisine_DTO>();
            Mapper.CreateMap<Cuisine_DTO, Cuisine>();
        }


    }



}
