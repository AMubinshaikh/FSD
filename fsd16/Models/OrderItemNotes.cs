using System;
using System.Collections.Generic;

namespace fsd16.Models {
    public partial class OrderItemNotes {
        public int NoteId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Note { get; set; }
    }
}