using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleApp.Core.Models
{
    [Table("TodoItem")]
    public class TodoItem : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool IsComplete { get; set; }
    }
}
