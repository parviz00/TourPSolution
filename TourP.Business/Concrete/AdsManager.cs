using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Business.Abstract;
using TourP.Business.Constants;
using TourP.Core.Utilities.Results;
using TourP.DataAccess.Abstract;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.AdsDTO;

namespace TourP.Business.Concrete
{
    public class AdsManager : IAdsService
    {
        private readonly IAdsDal _adsDal;
        IMapper _mapper;

        public AdsManager(IAdsDal adsDal,IMapper mapper)
        {
            _adsDal = adsDal;
            _mapper = mapper;
        }

        public IResult Add(AdsAddDTO adsAddDTO)
        {
            var mappedAdd = _mapper.Map<Ads>(adsAddDTO);
            _adsDal.Add(mappedAdd);
            return new SuccessResult(Messages.AdsAdded);
        }

        public IResult Delete(AdsDeleteDTO adsDeleteDTO)
        {
            var mappedDelete = _mapper.Map<Ads>(adsDeleteDTO);
            _adsDal.Delete(mappedDelete);
            return new SuccessResult(Messages.AdsDeleted);
        }

        public IDataResult<List<AdsGetDTO>> GetAll()
        {
            var adsList=_adsDal.GetAll();
            var result = _mapper.Map<List<AdsGetDTO>>(adsList);
            return new SuccessDataResult<List<AdsGetDTO>>(result);
        }

        public IDataResult<Ads> GetById(int id)
        {
            return new SuccessDataResult<Ads>(_adsDal.Get(a => a.Id == id));
        }

        public IResult Update(AdsUpdateDTO adsUpdateDTO)
        {
            var mappedUpdate = _mapper.Map<Ads>(adsUpdateDTO);
            _adsDal.Update(mappedUpdate);
            return new SuccessResult();
        }
    }
}
