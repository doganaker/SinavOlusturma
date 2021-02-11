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
        public IActionResult Generator(QuestionVM model,string titles,string[] rightChoice)
        {
            Question q1 = new Question();
            q1.QBody = model.Q1.QBody;
            q1.ChoiceA = model.Q1.ChoiceA;
            q1.ChoiceB = model.Q1.ChoiceB;
            q1.ChoiceC = model.Q1.ChoiceC;
            q1.ChoiceD = model.Q1.ChoiceD;
            q1.RightAnswer = rightChoice[0];

            _examContext.Questions.Add(q1);

            Question q2 = new Question();
            q2.QBody = model.Q2.QBody;
            q2.ChoiceA = model.Q2.ChoiceA;
            q2.ChoiceB = model.Q2.ChoiceB;
            q2.ChoiceC = model.Q2.ChoiceC;
            q2.ChoiceD = model.Q2.ChoiceD;
            q2.RightAnswer = rightChoice[1];

            _examContext.Questions.Add(q2);

            Question q3 = new Question();
            q3.QBody = model.Q3.QBody;
            q3.ChoiceA = model.Q3.ChoiceA;
            q3.ChoiceB = model.Q3.ChoiceB;
            q3.ChoiceC = model.Q3.ChoiceC;
            q3.ChoiceD = model.Q3.ChoiceD;
            q3.RightAnswer = rightChoice[2];

            _examContext.Questions.Add(q3);

            Question q4 = new Question();
            q4.QBody = model.Q4.QBody;
            q4.ChoiceA = model.Q4.ChoiceA;
            q4.ChoiceB = model.Q4.ChoiceB;
            q4.ChoiceC = model.Q4.ChoiceC;
            q4.ChoiceD = model.Q4.ChoiceD;
            q4.RightAnswer = rightChoice[3];

            _examContext.Questions.Add(q4);
            _examContext.SaveChanges();

            Exam exam = new Exam();

            exam.ArticleTitle = titles;
            exam.QuestionOneID = q1.ID;
            exam.QuestionTwoID = q2.ID;
            exam.QuestionThreeID = q3.ID;
            exam.QuestionFourID = q4.ID;
            //exam.ArticleContent = content;

            _examContext.Exams.Add(exam);
            _examContext.SaveChanges();

            return Redirect("/Home/Index");
        }
    }
}
