
using Linedata.DataMaintenance.Repository.Models;
using Linedata.DataMaintenance.Shared.DTOs;

namespace Linedata.DataMaintenance.Shared.DataAccess
{
    public interface IMapping
    {
        public Security MappingInput(InputDto dto);
        public Security MappingEquity(EquityDtoInput dto);
        public Security MappingFund(FundDtoInput dto);
        public Security MappingFutures(FuturesDtoInput dto);
    }
}
