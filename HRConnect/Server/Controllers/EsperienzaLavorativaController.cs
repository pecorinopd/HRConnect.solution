using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/esperienzalavorativa")]
    public class EsperienzaLavorativaController : ControllerBase
    {
        private IEsperienzaLavorativaRepository _esperienzaLavorativaRepository;
        public EsperienzaLavorativaController(IEsperienzaLavorativaRepository esperienzaLavorativaRepository)
        {
            _esperienzaLavorativaRepository = esperienzaLavorativaRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<EsperienzaLavorativa>> GetAllEsperienzaLavorativa()
        {
            return _esperienzaLavorativaRepository.GetAllEsperienzeLavorative().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteEsperienzaLavorativa(int id)
        {
            _esperienzaLavorativaRepository.DeleteEsperienzaLavorativa(id);
        }

        [HttpPost("Add")]
        public ActionResult AddEsperienzaLavorativa([FromBody] EsperienzaLavorativa nuovoEsperienzaLavorativa)
        {
            if (nuovoEsperienzaLavorativa == null)
            {
                return BadRequest("I dati del candiato sono incompleti.");
            }
            _esperienzaLavorativaRepository.AddEsperienzaLavorativa(nuovoEsperienzaLavorativa);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<EsperienzaLavorativa> UpdateEsperienzaLavorativa(int id, EsperienzaLavorativa esperienzaLavorativa)
        {
            return _esperienzaLavorativaRepository.UpdateEsperienzaLavorativa(id, esperienzaLavorativa);
        }


    }
}
