using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using wEBFORMapp.Models;

namespace wEBFORMapp.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminControl
         Prn211ProjectContext projectContext = new Prn211ProjectContext();

        public ActionResult Index(string? tentrandau)
        {
            List<Ticket> ticketslist = projectContext.Tickets.Include(x=>x.Category).ToList();
            if(tentrandau != null)
            {
                ticketslist = projectContext.Tickets.Include(x => x.Category)
                    .Where(x => x.TenTranDau.Contains(tentrandau)).ToList();
            }    

            return View(ticketslist);
        }

        // GET: AdminControl/Details/5
        public ActionResult Details(int id)
        {
            Ticket ticket=projectContext.Tickets.Include(x=>x.Category).SingleOrDefault(x=>x.TicketId==id);

            return View(ticket);
        }

        // GET: AdminControl/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: AdminControl/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ticket ticket)
        {
            try
            {
                Ticket ticket1= projectContext.Tickets.SingleOrDefault(x=>x.TicketId== ticket.TicketId);
                if(ticket1!=null) {
                    ModelState.AddModelError("", "ID exist");
                    return View(ticket);
                    
                }
                else
                {
                    projectContext.Tickets.Add(ticket);
                    projectContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }

               
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminControl/Edit/5
        public ActionResult Edit(int id)
        {
            Ticket ticket= projectContext.Tickets.SingleOrDefault(x=>x.TicketId==id);
            if (ticket != null)
            {  
return View(ticket);
            }
            else
            {
                return RedirectToAction(nameof(Index));

            }

        }

        // POST: AdminControl/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Ticket ticket)
        {
            try
            {
               
                    projectContext.Tickets.Update(ticket);
                    projectContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminControl/Delete/5
        [HttpGet("/admin/delete/{id?}")]
        public ActionResult Delete(int id)
        {
            Ticket ticket = projectContext.Tickets.SingleOrDefault(x => x.TicketId == id);
            if (ticket != null)
            {
                projectContext.Tickets.Remove(ticket);
                projectContext.SaveChanges();       
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return RedirectToAction(nameof(Index));

            }
        }

        

        [HttpGet("/searchTicket")]
        public string searchticket(string search)
        {
            List<Ticket> ticketList = projectContext.Tickets.Include(x => x.Category).
                Where(x => x.TenTranDau.Contains(String.IsNullOrEmpty(search) ? "" : search)).ToList();
            string data = "";
            foreach (Ticket ticket in ticketList)
            {
                data += "<tr>" + "<td>" + ticket.TicketId + "</td>";
                data += "<td>" + ticket.TenTranDau + "</td>";
                data += "<td>" + ticket.Time + "</td>";
                data += "<td>" + ticket.Price + "</td>";

                data += "<td>" + ticket.Category + "</td>";
                data += "<td>" + ticket.Quantity + "</td>" + "</tr>";


            }
            return data;
        }
    }
}
