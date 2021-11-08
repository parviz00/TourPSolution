using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Business.Abstract;
using TourP.Core.Utilities.Results;
using TourP.DataAccess.Abstract;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.StepsDTO;

namespace TourP.Business.Concrete
{
    public class StepManager : IStepService
    {
        private readonly IStepDal _stepDal;
        IMapper _mapper;
        public StepManager(IStepDal stepDal,IMapper mapper)
        {
            _stepDal = stepDal;
            _mapper = mapper;
        }

        public IResult Add(StepsAddDTO stepsAddDTO)
        {
            var mappedAdd = _mapper.Map<Steps>(stepsAddDTO);
            _stepDal.Add(mappedAdd);
            return new SuccessResult();
        }

        public IResult Delete(StepsDeleteDTO stepsDeleteDTO)
        {
            var mappedDelete = _mapper.Map<Steps>(stepsDeleteDTO);
            _stepDal.Delete(mappedDelete);
            return new SuccessResult();
        }

        public IDataResult<List<StepsGetDTO>> GetAll()
        {
            var stepList = _stepDal.GetAll();
            var mappedGet = _mapper.Map<List<StepsGetDTO>>(stepList);
            return new SuccessDataResult<List<StepsGetDTO>>(mappedGet);
        }

        public IDataResult<Steps> GetById(int id)
        {
            return new SuccessDataResult<Steps>(_stepDal.Get(s => s.Id == id));
        }

        public IResult Update(StepsUpdateDTO stepsUpdateDTO)
        {
            var mappedUpdate = _mapper.Map<Steps>(stepsUpdateDTO);
            _stepDal.Update(mappedUpdate);
            return new SuccessResult();
        }
    }
}
