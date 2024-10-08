using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TigerTix.Web.Models;
using TigerTix.Web.Services;



namespace TigerTix.Web.Controllers
{
    public class EventController : Controller
    {

        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        // GET: /Event/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: /Event/Create
        [HttpPost]
        public IActionResult Create(Event model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var state in ModelState)
                {
                    if (state.Value.Errors.Any())
                    {
                        Debug.WriteLine($"Key: {state.Key}, Errors: {string.Join(",", state.Value.Errors.Select(e => e.ErrorMessage))}");
                    }
                }
            }

            if (ModelState.IsValid)
            { 
                // Save the event to the database and get the ID of the created event
                var eventId = _eventService.Create(model);

                // Redirect to the Details action, passing the ID of the created event
                return RedirectToAction("Details", new { id = eventId });
            }

            // If the model is not valid, redisplay the form
            return View(model);

        }

        public IActionResult Details(int id)
        {
            // Retrieve the event from the database
            var eventItem = _eventService.Get(id);

            // Return the Details view, passing the event
            return View(eventItem);
        }

        public IActionResult UpcomingEvents(string sport)
        {
            IEnumerable<Event> events;

            if (string.IsNullOrEmpty(sport))
            {
                // Retrieve all events from the service
                events = _eventService.GetAll();
            }
            else
            {
                // Retrieve only events for the selected sport
                events = _eventService.GetAll().Where(e => e.Sport == sport);
            }

            // Return the UpcomingEvents view, passing the list of events
            return View(events);
        }


    }
}