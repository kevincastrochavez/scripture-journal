using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; } = string.Empty;
        public string Chapter { get; set; } = string.Empty;
        public string Verse { get; set; } = string.Empty;

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}