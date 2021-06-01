using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//TODO: 28
using ActorsRazorPages.Models;

namespace ActorsRazorPages.Pages.Actors
{
    public class IndexModel : PageModel
    {
        //TODO: 27 borramos el código
        /*public void OnGet()
        {
        }*/
        //TODO: 29
        private IData _data;
        public IndexModel(IData data)
        {
            _data = data;
        }
        public IList<Actor> Actors { get; set; }
        public void OnGet()
        {
            Actors = _data.ActorsInitializeData();
        }
    }
}
