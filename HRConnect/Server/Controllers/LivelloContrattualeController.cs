using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/livellocontrattuale")]
    public class LivelloContrattualeController : ControllerBase
    {
        private ILivelloContrattualeRepository _livelloContrattualeRepository;
        public LivelloContrattualeController(ILivelloContrattualeRepository livelloContrattuale)
        {
            _livelloContrattualeRepository = livelloContrattuale;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<LivelloContrattuale>> GetAllLivelloContrattuale()
        {
            return _livelloContrattualeRepository.GetAllLivelliContrattuali().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteLivelloContrattuale(int id)
        {
            _livelloContrattualeRepository.DeleteLivelloContrattuale(id);
        }

        [HttpPost("Add")]
        public ActionResult AddLivelloContrattuale([FromBody] LivelloContrattuale nuovoLivelloContrattuale)
        {
            if (nuovoLivelloContrattuale == null)
            {
                return BadRequest("I dati del Livello Contrattuale sono incompleti.");
            }
            _livelloContrattualeRepository.AddLivelloContrattuale(nuovoLivelloContrattuale);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<LivelloContrattuale> UpdateCandidato(int id, LivelloContrattuale livelloContrattuale)
        {
            return _livelloContrattualeRepository.UpdateLivelloContrattuale(id, livelloContrattuale);
        }


    }
}
