using RestoDDD.Application.Entities;
using RestoDDD.Application.Interfaces;
using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Application.Services
{
    public class CommentaireAppService : AppServiceBase<Commentaire,Commentaire_DTO>, ICommentaireAppService
    {
        private readonly ICommentaireService _commentaireService;
        public CommentaireAppService(ICommentaireService commentaireService)
            : base(commentaireService)
        {
            _commentaireService = commentaireService;
        }


        public bool Add(Commentaire obj)
        {
            return _commentaireService.Add(obj);
        }

        public new Commentaire GetById(int id)
        {
            return _commentaireService.GetById(id);
        }

        public new IEnumerable<Commentaire> GetAll()
        {
            return _commentaireService.GetAll();
        }

        public bool Update(Commentaire obj)
        {
            return _commentaireService.Update(obj);
        }

        public bool Remove(Commentaire obj)
        {
            return _commentaireService.Remove(obj);
        }
    }
}
