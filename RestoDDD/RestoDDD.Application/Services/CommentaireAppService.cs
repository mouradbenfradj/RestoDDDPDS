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
    public class CommentaireAppService : AppServiceBase<Commentaire>, ICommentaireAppService
    {
        private readonly ICommentaireService _commentaireService;
        public CommentaireAppService(ICommentaireService commentaireService)
            : base(commentaireService)
        {
            _commentaireService = commentaireService;
        }
    }
}
