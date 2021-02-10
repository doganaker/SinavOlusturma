using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.ORM.Entities
{
    public class Question : BaseEntity
    {
        public string QBody { get; set; }
        public string RightAnswer { get; set; }
        public string ChoiceA { get; set; }
        public string ChoiceB { get; set; }
        public string ChoiceC { get; set; }
        public string ChoiceD { get; set; }
    }
}
