using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SinavOlusturma.Models.ORM.Context;
using SinavOlusturma.Models.ORM.Entities;
using SinavOlusturma.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.Controllers
{
    public class ExamController : Controller
    {
        private readonly ExamContext _examContext;

        public ExamController(ExamContext examContext)
        {
            _examContext = examContext;
        }
        public IActionResult Exam(int id)
        {
            UserExamVM userExam = new UserExamVM();
            Exam exam = _examContext.Exams.Include(q => q.QuestionOne).Include(q => q.QuestiontWO).Include(q => q.QuestionThree).Include(q => q.QuestionFour).FirstOrDefault(x => x.ID == id && x.IsDeleted == false);
            
            userExam.ArticleTitle = exam.ArticleTitle;
            //userExam.ArticleContent = content;
            userExam.Q1 = exam.QuestionOne;
            userExam.Q2 = exam.QuestiontWO;
            userExam.Q3 = exam.QuestionThree;
            userExam.Q4 = exam.QuestionFour;

            return View(userExam);
        }

        public IActionResult Answers(int id)
        {
            Question question = _examContext.Questions.Find(id);
            return Json(question);
        }

    }
}
