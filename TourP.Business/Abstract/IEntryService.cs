using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Core.Utilities.Results;
using TourP.Entities.Concrete;
using TourP.Entities.DTO.EntryDTO;

namespace TourP.Business.Abstract
{
    public interface IEntryService
    {
        IDataResult<List<EntryGetDTO>> GetAll();
        IDataResult<Entry> GetById(int id);
        IResult Add(EntryAddDTO entryAddDTO);
        IResult Update(EntryUpdateDTO entryUpdateDTO);
        IResult Delete(EntryDeleteDTO entryDeleteDTO);
    }
}
