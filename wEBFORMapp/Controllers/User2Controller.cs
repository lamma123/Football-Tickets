using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using wEBFORMapp.Models;

namespace wEBFORMapp.Controllers
{
    public class User2Controller : Controller

    { Prn211ProjectContext projectContext=new Prn211ProjectContext();
        public IActionResult Index()
        {
            ViewBag.listTicket=projectContext.Tickets.Include(x=>x.Category).ToList();
            return View();
        }


        public ActionResult Details(int id)
        {
            Ticket ticket =projectContext.Tickets.Include(x=>x.Category).SingleOrDefault(x=>x.TicketId==id);
            return View(ticket);
        }
        public ActionResult BuyTicket(int id)
        {
            Ticket ticket = projectContext.Tickets.Include(x => x.Category).SingleOrDefault(x => x.TicketId == id);
            ViewBag.username = HttpContext.Session.GetString("username");
            return View(ticket);
        }

        public string GetConfirmCode()
        {
            string c = "qwertyuiopasdfghjklzxcvbnm1234567890";
            string code = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                code += c[random.Next(36)];
            }
            return code;
        }     
        [HttpPost]
        public ActionResult BuyTicket(int id, Ticket ticket)
        {
            try
            {
                id = ticket.TicketId;
                Prn211ProjectContext prn211ProjectContext = new Prn211ProjectContext();
                int orderid = 0;
                Ticket t = prn211ProjectContext.Tickets.SingleOrDefault(x => x.TicketId == id);
                foreach (Order o in prn211ProjectContext.Orders)
                {
                    if (orderid < o.OrderId)
                    {
                        orderid = o.OrderId;
                    }
                }
                Order order = new Order
                {
                    OrderId = ++orderid,
                    Code = GetConfirmCode(),
                    Username = HttpContext.Session.GetString("username"),
                    Orderdate = DateTime.Now
                };
                prn211ProjectContext.Orders.Add(order);
                prn211ProjectContext.OrderDetails.Add(new OrderDetail
                {
                    OrderId = orderid,
                    Price = (ticket.Price),
                    Quantity = (ticket.Quantity),
                    TicketId = ticket.TicketId,
                });

                t.Quantity = t.Quantity - ticket.Quantity;
                prn211ProjectContext.Tickets.Update(t);
                prn211ProjectContext.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }
        [HttpGet("/User2/History")]
        public ActionResult History()
        {
            string username = HttpContext.Session.GetString("username");
            ViewBag.Username = username;
            return View();
        }
        [HttpGet("user2/searchTicket")]
        public string searchticket(string search)
        {
            List<Ticket> ticketList = projectContext.Tickets.Include(x=>x.Category).
                Where(x => x.TenTranDau.Contains(String.IsNullOrEmpty(search)?"":search)).ToList();
            string data = "";
            foreach(Ticket ticket in ticketList)
            {
                //data += "<tr>"+"<td>" + ticket.TicketId + "</td>" ; 
                data += "<td>" + ticket.TenTranDau + "</td>";
                data += "<td>" + ticket.Time + "</td>";
                data += "<td>" + ticket.Price + "</td>";
                data += "<td>" + ticket.Category + "</td>";
                data += "<td>" + ticket.Quantity + "</td>"+"</tr>";
                 

            }
            return data;
        }

    }

}
