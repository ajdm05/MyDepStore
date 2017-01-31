using MyDepStore.Database.Model;
using MyDepStore.Database.Repository;
using System;
using System.Web.Mvc;
using System.Linq;
using MyAppStore.Site.Models.Client;

namespace MyAppStore.Site.Controllers
{
    public class ClientController : BaseController
    {
        public Lazy<BaseRepository<Client>> ClientRepository { get; set; }

        public ClientController(Lazy<BaseRepository<Client>> clientRepository)
        {
            this.ClientRepository = clientRepository;
        }

        public ActionResult Index()
        {
            var allClients = this.ClientRepository.Value.All().Select(cl => new DisplayClientModel
            {
                Id = cl.Id,
                FirstName = cl.FirstName,
                LastName = cl.LastName,
                IdNumber = cl.IdNumber,
                IsActive = cl.IsActive
            }).ToList();
            return View(allClients);
        }
    }
}