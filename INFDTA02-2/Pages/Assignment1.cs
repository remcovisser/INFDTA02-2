using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace INFDTA02_2.Pages
{
    public class IndexModel : PageModel
    {
        public int[] data { get; set; }
        public string test { get; set; }

        public void OnGet()
        {
            data = new int[] { 12, 19, 3, 5, 2, 3 };
            test = "This is a test";
        }

    }
}
