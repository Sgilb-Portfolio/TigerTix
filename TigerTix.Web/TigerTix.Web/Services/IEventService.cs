// IEventService.cs
using TigerTix.Web.Models;

namespace TigerTix.Web.Services
{

    public interface IEventService
    {
        int Create(TigerTix.Web.Models.Event model);
        TigerTix.Web.Models.Event Get(int id);
        IEnumerable<Event> GetAll();
    }


}
