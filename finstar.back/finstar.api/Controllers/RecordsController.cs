using finstar.core;
using finstar.db;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace finstar.api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class RecordsController : ControllerBase {
        private IRecordsServices _recordsServices;

        public RecordsController(IRecordsServices recordsServices) {
            _recordsServices = recordsServices;
        }

        [HttpGet(Name = "GetRecords")]
        public IActionResult GetRecords() {
            return Ok(_recordsServices.GetRecords());
        }

        [HttpGet("{id}", Name = "GetRecord")]
        public IActionResult GetRecord(int id) {
            return Ok(_recordsServices.GetRecord(id));
        }

        [HttpPost]
        public IActionResult PutRecords(List<Record> records) {
            var newRecords = _recordsServices.PutRecords(records);
            return CreatedAtRoute("GetRecords", newRecords);
        }
    }
}
