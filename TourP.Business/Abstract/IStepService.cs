using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Core.Utilities.Results;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.StepsDTO;

namespace TourP.Business.Abstract
{
    public interface IStepService
    {
        IDataResult<List<StepsGetDTO>> GetAll();
        IDataResult<Steps> GetById(int id);
        IResult Add(StepsAddDTO stepsAddDTO);
        IResult Update(StepsUpdateDTO stepsUpdateDTO);
        IResult Delete(StepsDeleteDTO stepsDeleteDTO);
    }
}
