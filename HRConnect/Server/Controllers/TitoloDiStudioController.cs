using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/titolodistudio")]
    public class TitoloDiStudioController : ControllerBase
    {
        private ITitoloDiStudioRepository _titoloDiStudioRepository;
        public TitoloDiStudioController(ITitoloDiStudioRepository titoloDiStudioRepository)
        {
            _titoloDiStudioRepository = titoloDiStudioRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<TitoloDiStudio>> GetAllTitoloDiStudio()
        {
            return _titoloDiStudioRepository.GetAllTitoliDiStudio().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteTitoloDiStudio(int id)
        {
            _titoloDiStudioRepository.DeleteTitoloDiStudio(id);
        }

        [HttpPost("Add")]
        public ActionResult AddTitoloDiStudio([FromBody] TitoloDiStudio nuovoTitoloDiStudio)
        {
            if (nuovoTitoloDiStudio == null)
            {
                return BadRequest("I dati del TitoloDiStudio sono incompleti.");
            }
            _titoloDiStudioRepository.AddTitoloDiStudio(nuovoTitoloDiStudio);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<TitoloDiStudio> UpdateTitoloDiStudio(int id, TitoloDiStudio titoloDiStudio)
        {
            return _titoloDiStudioRepository.UpdateTitoloDiStudio(id, titoloDiStudio);
        }


    }
}
