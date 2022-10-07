using sep6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace sep6.Controllers
{
    public class MemberCrudController : Controller
    {

        static List<Member> MemberList = new List<Member>();
        static MemberCrudController()
        {
            MemberList.Add(new Member { MemberId = 1, MemberName = "Selva", AccOpenDate = new DateTime(2022, 11, 03) });

            MemberList.Add(new Member { MemberId = 2, MemberName = "Bharathi", AccOpenDate = new DateTime(2022, 07, 24) });
            MemberList.Add(new Member { MemberId = 3, MemberName = "Gokul", AccOpenDate = new DateTime(2022, 08, 04) });
        }
        // GET: MemberCrud
        public ActionResult Index()
        {
            return View(MemberList);
        }

       

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Member model)
        {
            MemberList.Add(model);
            return RedirectToAction("Index");
        }

       
        public ActionResult Edit(int id)
        {
            Member foundData = MemberList.Find(Member => Member.MemberId == id);


            return View(foundData);
        }

       
        [HttpPost]
        public ActionResult Edit(int id, Member m)
        {
            Member foundData = MemberList.Find(Member => Member.MemberId == id);
            MemberList.Remove(foundData);
            MemberList.Add(m);
            return RedirectToAction("Index");

        }

       
        public ActionResult Delete(int id)
        {
            Member foundData = MemberList.Find(Member => Member.MemberId == id);
            return View(foundData);
        }

        
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Member foundData = MemberList.Find(Member => Member.MemberId == id);
            MemberList.Remove(foundData);
            return View(foundData);


        }
        }
    }

