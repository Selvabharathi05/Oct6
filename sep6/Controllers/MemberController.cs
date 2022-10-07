using sep6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sep6.Controllers
{
    public class MemberController : Controller
    {

        static List<Member> MemberList = new List<Member>();
        static MemberController()
        {
            MemberList.Add(new Member { MemberId = 1, MemberName = "Selva", AccOpenDate = new DateTime(2022, 05, 03) });

            MemberList.Add(new Member { MemberId = 2, MemberName = "Bharathi", AccOpenDate = new DateTime(2022, 05, 03) });
            MemberList.Add(new Member { MemberId = 3, MemberName = "Gokul", AccOpenDate = new DateTime(2022, 05, 03) });
        }
            // GET: Member
            public ActionResult Index()
        {
            ViewBag.msg = "List Of Members";
            return View(MemberList);
        }
    }
}