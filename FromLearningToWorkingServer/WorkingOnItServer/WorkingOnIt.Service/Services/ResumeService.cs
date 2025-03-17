using AutoMapper;
using FromLearningToWorking.Core.DTOs;
using FromLearningToWorking.Core.Entities;
using FromLearningToWorking.Core.InterfaceRepository;
using FromLearningToWorking.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLearningToWorking.Service.Services
{
    public class ResumeService  (IRepositoryManager iManager, IMapper mapper): IResumeService
    {
        private readonly IRepositoryManager _iRepositoryManager = iManager;
        private readonly IMapper _mapper = mapper;

        public ResumeDTO Add(ResumeDTO resumeDTO)
        {
            var resume = _mapper.Map<Resume>(resumeDTO);
            resume = _iRepositoryManager._resumeRepository.Add(resume);
            if (resume != null)
                _iRepositoryManager.Save();
            return _mapper.Map<ResumeDTO>(resume);
        }

        public bool Delete(int id)
        {
            var res = _iRepositoryManager._resumeRepository.Delete(id);
            if (res)
                _iRepositoryManager.Save();
            return res;
        }

        public IEnumerable<ResumeDTO> GetAll()
        {
            var list = _iRepositoryManager._resumeRepository.GetAll();
            return _mapper.Map<List<ResumeDTO>>(list);
        }

        public ResumeDTO? GetById(int id)
        {
            var resume = _iRepositoryManager._resumeRepository.GetById(id);
            return _mapper.Map<ResumeDTO>(resume);
        }

        public ResumeDTO Update(int id, ResumeDTO resumeDTO)
        {
            var resume = _mapper.Map<Resume>(resumeDTO);
            var response = _iRepositoryManager._resumeRepository.Update(id, resume);
            if (response != null)
                _iRepositoryManager.Save();
            return _mapper.Map<ResumeDTO>(response);
        }
    }

}
