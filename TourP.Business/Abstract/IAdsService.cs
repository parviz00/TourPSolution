using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Core.Utilities.Results;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.AdsDTO;

namespace TourP.Business.Abstract
{
    public interface IAdsService
    {
        IDataResult<List<AdsGetDTO>> GetAll();
        IDataResult<Ads> GetById(int id);
        IResult Add(AdsAddDTO adsAddDTO);
        IResult Update(AdsUpdateDTO adsUpdateDTO);
        IResult Delete(AdsDeleteDTO adsDeleteDTO);
    }
}
