using FromLearningToWorking.Core.DTOs;
using FromLearningToWorking.Core.InterfaceService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FromLearningToWorking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeController(IResumeService resumeService) : ControllerBase
    {
        private readonly IResumeService _resumeService = resumeService;

        [HttpGet]
        public ActionResult<IEnumerable<ResumeDTO>> GetAll()
        {
            return Ok(_resumeService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<ResumeDTO> GetById(int id)
        {
            var resume = _resumeService.GetById(id);
            if (resume == null) return NotFound();
            return Ok(resume);
        }

        [HttpPost]
        public ActionResult<ResumeDTO> Post([FromBody] ResumeDTO resumeDTO)
        {
            var createdResume = _resumeService.Add(resumeDTO);
            return CreatedAtAction(nameof(GetById), new { id = createdResume.Id }, createdResume);
        }

        [HttpPut("{id}")]
        public ActionResult<ResumeDTO> Put(int id, [FromBody] ResumeDTO resumeDTO)
        {
            var updatedResume = _resumeService.Update(id, resumeDTO);
            if (updatedResume == null) return NotFound();
            return Ok(updatedResume);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!_resumeService.Delete(id)) return NotFound();
            return NoContent();
        }
    }

}
