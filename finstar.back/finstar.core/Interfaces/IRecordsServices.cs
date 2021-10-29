using finstar.db;
using System.Collections.Generic;

namespace finstar.core {
    public interface IRecordsServices {
        List<Record> GetRecords();
        Record GetRecord(int id);
        List<Record> PutRecords(List<Record> records);
    }
}
