using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using GoogleAuth;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPageMovie.Pages.Admin
{
    public class Form : PageModel
    {
        public SelectList? Rooms { get; set;}
        public async Task OnGetAsync()
        {
            var service = GoogleCredential.CreateCredential();
            CalendarList calendarList = service.CalendarList.List().Execute();
            IEnumerable<CalendarListEntry> roomList = calendarList.Items.Where(c => c.Description != null);
            roomList = roomList.Where(c => c.Description.Contains("Ruang"));
            IEnumerable<string> room = roomList.Select(c => c.Summary).Order();

            Rooms = new SelectList(room);

        }
    }
}