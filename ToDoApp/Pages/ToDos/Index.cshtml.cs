using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;


namespace ToDoApp.Pages.ToDos
{
    public class IndexModel : PageModel
    {
        private readonly ToDoApp.Models.ToDoAppContext _context;

        public IndexModel(ToDoApp.Models.ToDoAppContext context)
        {
            _context = context;
        }


        public IList<ToDo> ToDo { get;set; }
        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }
        public SelectList Description { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ToDoDescription { get; set; }


        public async Task OnGetAsync()
        {
            var todo = from m in _context.ToDo
                       select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                todo = todo.Where(s => s.Description.Contains(SearchString));
            }
            //ToDo = await _context.ToDo.ToListAsync();
            ToDo = await todo.ToListAsync();
        }
    }
}
