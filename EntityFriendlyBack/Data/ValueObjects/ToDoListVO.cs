using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFriendlyBack.Data.ValueObjects
{
    public class ToDoListVO
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime Data { get; set; }
    }
}
