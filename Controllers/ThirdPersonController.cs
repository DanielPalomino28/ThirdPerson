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
        public IActionResult Get(string documentNumber)
        {
            var thirdPersn = information.GetThirdPersnByDocumentNumber(documentNumber);

            if (thirdPersn == null)
            {
                return NotFound(); // Devolver un NotFoundResult (StatusCode 404)
            }

            // Devolver los datos en formato JSON
            return Ok(thirdPersn);
        }



        // POST: ThirdPersonController/Create
        public IActionResult Post([FromBody] ThirdPersn thirdPersn)
        {
            information.CreateThirdPerson(thirdPersn);
            return Ok(); // o un CreatedResult si es apropiado
        }


        // Put: ThirdPersonController
        public IActionResult Put([FromBody] ThirdPersn thirdPersn)
        {
            information.Update(thirdPersn);
            return Ok(); // o un NoContentResult si es apropiado
        }

        // Delete: ThirdPersonController
        public IActionResult Delete(string documentNumber)
        {
            information.Delete(documentNumber);
            return Ok(); // o un NoContentResult si es apropiado
        }

    }
}
