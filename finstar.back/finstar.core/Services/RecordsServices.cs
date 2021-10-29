using finstar.db;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace finstar.core {
    public class RecordsServices : IRecordsServices {
        private RecordsContext _context;

        public RecordsServices(RecordsContext context) {
            _context = context;
        }

        public List<Record> GetRecords() {
            return _context.Records.ToList();
        }

        public Record GetRecord(int id) {
            return _context.Records.FirstOrDefault(e => e.id == id);
        }

        public List<Record> PutRecords(List<Record> records) {
            var sortedRecords = records.OrderBy(e => e.code).ToList();

            //_context.Records.RemoveRange(_context.Records);
            _context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Records]");

            _context.Records.AddRange(sortedRecords);

            _context.SaveChanges();

            return _context.Records.ToList();
        }
    }
}
