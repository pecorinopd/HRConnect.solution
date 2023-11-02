using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/hardskill")]
    public class HardSkillController : ControllerBase
    {
        private IHardSkillRepository _hardSkillRepository;
        public HardSkillController(IHardSkillRepository hardSkillRepository)
        {
            _hardSkillRepository = hardSkillRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<HardSkill>> GetAllHardSkill()
        {
            return _hardSkillRepository.GetAllHardSkill().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteHardSkill(int id)
        {
            _hardSkillRepository.DeleteHardSkill(id);
        }

        [HttpPost("Add")]
        public ActionResult AddHardSkill([FromBody] HardSkill nuovoHardSkill)
        {
            if (nuovoHardSkill == null)
            {
                return BadRequest("I dati del candidato sono incompleti.");
            }
            _hardSkillRepository.AddHardSkill(nuovoHardSkill);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<HardSkill> UpdateHardSkill(int id, HardSkill hardSkill)
        {
            return _hardSkillRepository.UpdateHardSkill(id, hardSkill);
        }


    }
}
