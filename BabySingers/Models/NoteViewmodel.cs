using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enitiies;

namespace BabySingers.Models
{
    public class NoteViewmodel
    {
        public IEnumerable<Question> questions { get; set; }

        public List<string> answers { get; set; }
<<<<<<< HEAD

        public List<string> questionpic { get; set; }
=======
>>>>>>> b830e11543be9bdeeeafccb12826682fae25cde1
    }
}
