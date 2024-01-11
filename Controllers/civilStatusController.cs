using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infraestructure;
using WebApi.Models;

namespace WebApi.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CivilStatusController : Controller
    {
        Information information;

        //Se valida si ya continene datos el objeto información
        //En caso de que no, se crea uno nuevo
        public CivilStatusController()
        {
            if(information == null)
            {
                information = new Information();
            }
        }

        // GET: civilStatus
        public List<civilStatus> Get()
        {
            return information.GetAllCivilStatus();
        }
    }
}
