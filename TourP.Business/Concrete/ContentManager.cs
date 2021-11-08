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
using TourP.Entities.DTO.ContentDTO;

namespace TourP.Business.Concrete
{
    public class ContentManager:IContentService
    {
        private readonly IContentDal _contentDal;
        IMapper _mapper;
        public ContentManager(IContentDal contentDal, IMapper mapper)
        {
            _contentDal = contentDal;
            _mapper = mapper;
        }

        public IResult Add(ContentAddDTO contentAddDTO)
        {
            var mappedContent = _mapper.Map<Content>(contentAddDTO);
            _contentDal.Add(mappedContent);
            return new SuccessResult(Messages.ContentAdded);
        }

        public IResult Delete(ContentDeleteDTO contentDeleteDTO)
        {
            var mappedDelete = _mapper.Map<Content>(contentDeleteDTO);
            _contentDal.Delete(mappedDelete);
            return new SuccessResult();
        }

        public IDataResult<List<ContentGetDTO>> GetAll()
        {
            var adsList = _contentDal.GetAll();
            var mappedGet = _mapper.Map<List<ContentGetDTO>>(adsList);
            return new SuccessDataResult<List<ContentGetDTO>>(mappedGet);
        }

        public IDataResult<Content> GetById(int id)
        {
            return new SuccessDataResult<Content>(_contentDal.Get(a => a.Id == id));
        }

        public IResult Update(ContentUpdateDTO contentUpdateDTO)
        {
            var mappedUpdate = _mapper.Map<Content>(contentUpdateDTO);
            _contentDal.Update(mappedUpdate);
            return new SuccessResult();
        }
    }
}
