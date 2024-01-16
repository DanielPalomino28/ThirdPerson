using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using WebApi.Infraestructure;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    
    public class ThirdPersonController : Controller
    {
        Information information;
        //Se valida si ya continene datos el objeto información
        //En caso de que no, se crea uno nuevo
        public ThirdPersonController()
        {
            if(information == null)
            {
                information = new Information();
            }
        }

        // GET: ThirdPersonController
        public List<ThirdPersn> GetAllThirdPersons()
        {
            return information.GetAllThirdPersons();
        }

        // GET: ThirdPersonController/documentNumber
        public ThirdPersn Get(string documentNumber)
        {
            var ThirdPersn = new ThirdPersn();
            return information.GetThirdPersnByDocumentNumber(documentNumber);
        }
        // POST: ThirdPersonController/Create
        public IActionResult Post([FromBody] ThirdPersn thirdPersn)
        {
            information.CreateThirdPerson(thirdPersn);
            return Ok(); 
        }


        // Put: ThirdPersonController
        public IActionResult Put([FromBody] ThirdPersn thirdpersn)
        {
            information.Update(thirdpersn);

            return Ok(); 
        }

        // Delete: ThirdPersonController
        public IActionResult Delete(string documentNumber)
        {
            information.Delete(documentNumber);
            return Ok(); 
        }

    }
}
