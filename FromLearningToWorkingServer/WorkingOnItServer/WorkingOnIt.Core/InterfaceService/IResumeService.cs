using FromLearningToWorking.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLearningToWorking.Core.InterfaceService
{
    public interface IResumeService
    {
        IEnumerable<ResumeDTO> GetAll();

        ResumeDTO? GetById(int id);

        ResumeDTO Add(ResumeDTO resumeDTO);

        ResumeDTO Update(int id,ResumeDTO resumeDTO);

        bool Delete(int id);
    }
}
