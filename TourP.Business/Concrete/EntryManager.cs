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
using TourP.Entities.DTO.EntryDTO;

namespace TourP.Business.Concrete
{
    public class EntryManager : IEntryService
    {
        private readonly IEntryDal _entryDal;
        IMapper _mapper;
        public EntryManager(IEntryDal entryDal,IMapper mapper)
        {
            _entryDal = entryDal;
            _mapper = mapper; ;
        }

        public IResult Add(EntryAddDTO entryAddDTO)
        {
            var mappedAdd = _mapper.Map<Entry>(entryAddDTO);
            _entryDal.Add(mappedAdd);
            return new SuccessResult();
        }

        public IResult Delete(EntryDeleteDTO entryDeleteDTO)
        {
            var mappedDelete = _mapper.Map<Entry>(entryDeleteDTO);
            _entryDal.Delete(mappedDelete);
            return new SuccessResult();
        }

        public IDataResult<List<EntryGetDTO>> GetAll()
        {

            var entryList = _entryDal.GetAll();
            var mappedGet=_mapper.Map<List<EntryGetDTO>>(entryList);
            return new SuccessDataResult<List<EntryGetDTO>>(mappedGet);
        }

        public IDataResult<Entry> GetById(int id)
        {
            return new SuccessDataResult<Entry>(_entryDal.Get(a => a.Id == id));
        }

        public IResult Update(EntryUpdateDTO entryUpdateDTO )
        {
            var mappedUpdate = _mapper.Map<Entry>(entryUpdateDTO);
            _entryDal.Update(mappedUpdate);
            return new SuccessResult();
        }
    }
}
