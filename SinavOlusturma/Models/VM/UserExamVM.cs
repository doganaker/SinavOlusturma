using SinavOlusturma.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Models.VM
{
    public class UserExamVM
    {
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public Question Q1 { get; set; }
        public Question Q2 { get; set; }
        public Question Q3 { get; set; }
        public Question Q4 { get; set; }
    }
}
