using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ICodecData
    {
        Task<List<Codec>> GetCodecs();
        Task InsertCodec(Codec code);
    }
}