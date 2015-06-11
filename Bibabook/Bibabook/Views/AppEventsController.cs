using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;

namespace Bibabook.Views
{
    public class AppEventsController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        // GET: AppEvents
        public async Task<ActionResult> Index()
        {
            return View(await db.AppEvents.ToListAsync());
        }

        // GET: AppEvents/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppEvent appEvent = await db.AppEvents.FindAsync(id);
            if (appEvent == null)
            {
                return HttpNotFound();
            }
            return View(appEvent);
        }

        // GET: AppEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AppEventID,Name,Description,AdultsOnly,TimeStart,TimeEnd,EntryFee,IsActive,Privacy,Background,EntityID,Created,Modified,Deleted")] AppEvent appEvent)
        {
            if (ModelState.IsValid)
            {
                appEvent.AppEventID = Guid.NewGuid();
                db.AppEvents.Add(appEvent);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(appEvent);
        }

        // GET: AppEvents/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppEvent appEvent = await db.AppEvents.FindAsync(id);
            if (appEvent == null)
            {
                return HttpNotFound();
            }
            return View(appEvent);
        }

        // POST: AppEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AppEventID,Name,Description,AdultsOnly,TimeStart,TimeEnd,EntryFee,IsActive,Privacy,Background,EntityID,Created,Modified,Deleted")] AppEvent appEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appEvent).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(appEvent);
        }

        // GET: AppEvents/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppEvent appEvent = await db.AppEvents.FindAsync(id);
            if (appEvent == null)
            {
                return HttpNotFound();
            }
            return View(appEvent);
        }

        // POST: AppEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            AppEvent appEvent = await db.AppEvents.FindAsync(id);
            db.AppEvents.Remove(appEvent);
            await db.SaveChangesAsync();
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
