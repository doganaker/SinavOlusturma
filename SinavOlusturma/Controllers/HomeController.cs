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
    public class HomeController : Controller
    {
        private readonly ExamContext _examContext;

        public HomeController(ExamContext examContext)
        {
            _examContext = examContext;
        }
        public IActionResult Index()
        {
            List<ExamVM> examList = _examContext.Exams.Where(q => q.IsDeleted == false).Select(q => new ExamVM()
            {
                ID = q.ID,
                ArticleTitle = q.ArticleTitle,
                AddDate = q.Date
            }).OrderByDescending(q => q.AddDate).ToList();

            return View(examList);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Exam exam = _examContext.Exams.FirstOrDefault(x => x.ID == id);

            exam.IsDeleted = true;

            _examContext.SaveChanges();

            return Json("Sınav Başarılı Bir Şekilde Silindi!");
        }
    }
}
