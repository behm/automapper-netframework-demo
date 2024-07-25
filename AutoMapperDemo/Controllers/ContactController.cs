using System;
using System.Web.Mvc;
using AutoMapper;
using AutoMapperDemo.Data.Models;
using AutoMapperDemo.Models;

namespace AutoMapperDemo.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMapper _mapper;

        public ContactController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactViewModel model)
        {
            // todo: validate model

            var contact = _mapper.Map<Contact>(model);

            contact.SubmitDateTime = DateTime.Now;

            // todo: do something with the contact data (i.e. persist it, send an email, etc.)

            return RedirectToAction("Thanks");
        }

        public ActionResult Thanks()
        {
            return View();
        }
    }
}