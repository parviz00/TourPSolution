using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Core.Utilities.Results;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.ContentDTO;

namespace TourP.Business.Abstract
{
    public interface IContentService
    {
        IDataResult<List<ContentGetDTO>> GetAll();
        IDataResult<Content> GetById(int id);
        IResult Add(ContentAddDTO contentAddDTO);
        IResult Update(ContentUpdateDTO contentUpdateDTO);
        IResult Delete(ContentDeleteDTO contentDeleteDTO);
    }
}
