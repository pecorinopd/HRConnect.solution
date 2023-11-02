using HRConnect.Server.Repository;
using HRConnect.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRConnect.Server.Controllers
{

    [ApiController]
    [Route("api/softskill")]
    public class SoftSkillController : ControllerBase
    {
        private ISoftSkillRepository _softSkillRepository;
        public SoftSkillController(ISoftSkillRepository softSkillRepository)
        {
            _softSkillRepository = softSkillRepository;
        }

        [HttpGet("Lista")]
        public ActionResult<IEnumerable<SoftSkill>> GetAllSoftSkill()
        {
            return _softSkillRepository.GetAllSoftSkill().ToList();
        }
        [HttpDelete("{id}")]
        public void DeleteSoftSkill(int id)
        {
            _softSkillRepository.DeleteSoftSkill(id);
        }

        [HttpPost("Add")]
        public ActionResult AddSoftSkill([FromBody] SoftSkill nuovoSoftSkill)
        {
            if (nuovoSoftSkill == null)
            {
                return BadRequest("I dati del SoftSkill sono incompleti.");
            }
            _softSkillRepository.AddSoftSkill(nuovoSoftSkill);
            return Ok();
        }

        [HttpPut("Aggiorna")]
        public ActionResult<SoftSkill> UpdateSoftSkill(int id, SoftSkill softSkill)
        {
            return _softSkillRepository.UpdateSoftSkill(id, softSkill);
        }


    }
}
