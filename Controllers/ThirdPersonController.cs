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
        public List<ThirdPersn> Get()
        {
            if(information.GetAllThirdPersons().Count == 0)
            {
                ThirdPersn persn = new ThirdPersn()
                {
                    firstName = "Oslo",
                    lastName = "Baud",
                    documentType = "Pasaporte",
                    documentNumber = "8281101",
                    birthdate = "1983-08-11",
                    gender = "Masculino",
                    civilStatus = "Soltero",
                    doctor = "Daniel Palomino",
                    isPatient = true,
            };
            }
            return information.GetAllThirdPersons();
        }

        // GET: ThirdPersonController/documentNumber
        public ThirdPersn Get(string documentNumber)
        {
            var thirdPersn = new ThirdPersn();
            return information.GetThirdPersnByDocumentNumber(documentNumber);
        }

        
        // POST: ThirdPersonController/Create
        public void Post([FromBody] ThirdPersn thirdPersn)
        {
            information.CreateThirdPerson(thirdPersn);
        }

        // Put: ThirdPersonController
        public void Put([FromBody] ThirdPersn thirdPersn)
        {
            information.Update(thirdPersn);
        }

        public void Delete(string documentNumber)
        {
            information.Delete(documentNumber);
        }
    }
}
