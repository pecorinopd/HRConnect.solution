using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design.Serialization;

namespace HRConnect.Server.Controllers
{
    [ApiController] //identifica che la classe è un controller
    [Route("api/benefit")] //definisce l'url che iniziera con: api/benefit, a cui le richieste HTTP saranno indirizzate.
    public class BenefitController : ControllerBase
    {
        
        private IBenefitRepository _benefitRepository; //variabile privata di tipo IBenefitRepository, e serve per accedere ai metodi
                                                       //relativi all'interfaccia. 
        public BenefitController(IBenefitRepository benefitRepository) //costruttore che implementa l'iniezione di dipendenze in modo
                                                                       //tale da rendere indipendente il controller dall'implementazione specifica di IBenefitRepository
        {
            _benefitRepository = benefitRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<Benefit>> GetAllBenefit()//ActionResult consente al framework di gestire automaticamente la formattazione
                                                                 //dei dati in base ai tipi di risposta accettati nella richiesta, ad esempio JSON
        {
            return _benefitRepository.GetAllBenefit().ToList();//il controller richiama il metodo _benefitRepository.
                                                               //GetAllBenefit() per ottenere una lista di oggetti
                                                               //Benefit e restituisce questa lista come risposta HTTP.

        }
        [HttpDelete("{id}")]
        public void DeleteBenefit(int id)
        {
            _benefitRepository.DeleteBenefit(id);
        }

        [HttpPost("Add")]
        public ActionResult AddBenefit([FromBody] Benefit nuovoBenefit) //body della request
        {
            if (nuovoBenefit == null)
            {
                return BadRequest("I dati del Benefits sono incompleti.");
            }
            _benefitRepository.AddBenefit(nuovoBenefit);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<Benefit> UpdateBenefit(int id, Benefit benefit)
        {
            return _benefitRepository.UpdateBenefit(id, benefit);
        }


    }
}
