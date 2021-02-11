using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.ORM.Entities
{
    public class Exam : BaseEntity
    {
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public Nullable<int> QuestionID { get; set; }

        [ForeignKey("QuestionID")]
        public Question Question { get; set; }
    }
}
