using RestoDDD.Domaine.Entities;
using RestoDDD.Domaine.Interfaces.Repositories;
using RestoDDD.Domaine.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoDDD.Domaine.Services
{
    public class CommentaireService : ServiceBase<Commentaire>, ICommentaireService
    {
        private readonly ICommentaire _commentaireRepository;
        public CommentaireService(ICommentaire commentaireRepository)
            : base(commentaireRepository)
        {
            _commentaireRepository = commentaireRepository;
        }
    }
}
