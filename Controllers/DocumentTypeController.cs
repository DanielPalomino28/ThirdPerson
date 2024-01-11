using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infraestructure;
using WebApi.Models;

namespace WebApi.Controllers
{   
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DocumentTypeController : Controller
    {
        Information information;

        //Se valida si ya continene datos el objeto información
        //En caso de que no, se crea uno nuevo
        public DocumentTypeController() 
        { 
            if(information == null)
            {
                information = new Information();
            }
        }

        // GET: DocumentTypeController
        public List<DocumentType> Get()
        {
            return information.GetAllDocumentTypes();
        }
    }
}
