using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DammioMVC.Models;

namespace DammioMVC.Controllers
{
    public class LinksController : Controller
    {
        private DammioMVCEntities db = new DammioMVCEntities();

        //// GET: Links
        //public ActionResult Index()
        //{
        //    var links = db.Links.Include(l => l.Category);
        //    return View(links.ToList());
        //}

        // GET: Link
        [HttpPost]
        public ActionResult Index(string searchString, int categoryID = 0)
        {
            //1. Tạo danh sách danh mục để hiển thị ở giao diện View thông qua DropDownList
            var categories = from c in db.Categories select c;
            ViewBag.categoryID = new SelectList(categories, "CategoryID", "CategoryName"); // danh sách Category

            //2. Tạo câu truy vấn kết 2 bảng Link, Category bằng mệnh đề join
            var links = from l in db.Links
                        join c in db.Categories on l.CategoryID equals c.CategoryID
                        select new { l.LinkID, l.LinkName, l.LinkURL, l.LinkDescription, l.CategoryID, c.CategoryName };

            //3. Tìm kiếm chuỗi truy vấn
            if (!String.IsNullOrEmpty(searchString))
            {
                links = links.Where(s => s.LinkName.Contains(searchString));
            }

            //4. Tìm kiếm theo CategoryID
            if (categoryID != 0)
            {
                links = links.Where(x => x.CategoryID == categoryID);
            }

            //5. Chuyển đổi kết quả từ var sang danh sách List<Link>
            List<Link> listLinks = new List<Link>();
            foreach (var item in links)
            {
                Link temp = new Link();
                temp.CategoryID = item.CategoryID;
                temp.CategoryName = item.CategoryName;
                temp.LinkDescription = item.LinkDescription;
                temp.LinkID = item.LinkID;
                temp.LinkName = item.LinkName;
                temp.LinkURL = item.LinkURL;
                listLinks.Add(temp);
            }

            return View(listLinks);
        }



        // GET: Links/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Link link = db.Links.Find(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            return View(link);
        }

        // GET: Links/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // POST: Links/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LinkID,LinkName,LinkURL,LinkDescription,CategoryID")] Link link)
        {
            if (ModelState.IsValid)
            {
                db.Links.Add(link);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", link.CategoryID);
            return View(link);
        }

        // GET: Links/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Link link = db.Links.Find(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", link.CategoryID);
            return View(link);
        }

        // POST: Links/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LinkID,LinkName,LinkURL,LinkDescription,CategoryID")] Link link)
        {
            if (ModelState.IsValid)
            {
                db.Entry(link).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", link.CategoryID);
            return View(link);
        }

        // GET: Links/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Link link = db.Links.Find(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            return View(link);
        }

        // POST: Links/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Link link = db.Links.Find(id);
            db.Links.Remove(link);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
