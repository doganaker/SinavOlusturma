using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SinavOlusturma.Models.ORM.Context;
using SinavOlusturma.Models.ORM.Entities;
using SinavOlusturma.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Controllers
{
    [Authorize]
    public class ExamGeneratorController : Controller
    {
        private readonly ExamContext _examContext;

        public ExamGeneratorController(ExamContext examContext)
        {
            _examContext = examContext;
        }
        public IActionResult Generator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Generator(List<QuestionVM> model,string titles,string[] rightChoice)
        {

            Exam exam = new Exam();

            exam.ArticleTitle = titles;
            //exam.ArticleContent = content;
            //exam.QuestionID = 3;
            
            return View();
        }
    }
}
