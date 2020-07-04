using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CodecData : ICodecData
    {
        private readonly ISqlDataAccess _db;

        public CodecData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<Codec>> GetCodecs()
        {
            string sql = "select encodeString, decodeString, status from dbo.codec_log";

            return _db.LoadData<Codec, dynamic>(sql, new { });
        }

        public Task InsertCodec(Codec code)
        {
            string sql = @"insert into dbo.codec_log (time_stamp, encodeString, decodeString, status)
                            values ( GETDATE(), @EncodeString, @DecodeString, @Status);";

            return _db.SaveData(sql, code);
        }
    }
}
