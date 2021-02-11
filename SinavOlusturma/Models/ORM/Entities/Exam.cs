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
        public Nullable<int> QuestionOneID { get; set; }

        [ForeignKey("QuestionOneID")]
        public Question QuestionOne { get; set; }

        public Nullable<int> QuestionTwoID { get; set; }

        [ForeignKey("QuestionTwoID")]
        public Question QuestiontWO { get; set; }

        public Nullable<int> QuestionThreeID { get; set; }

        [ForeignKey("QuestionThreeID")]
        public Question QuestionThree { get; set; }

        public Nullable<int> QuestionFourID { get; set; }

        [ForeignKey("QuestionFourID")]
        public Question QuestionFour { get; set; }
    }
}
