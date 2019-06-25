using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BikeForLife.Dal;
using BikeForLife.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BikeForLife.Web.Pages
{
    public class MembersModel : PageModel
    {
        [BindProperty]
        public Member Member { get; set; }
        public List<Member> Members { get; set; }
        public IActionResult OnGet()
        {
            MemberRepository memberRepository = new MemberRepository();
            try
            {
                Members = memberRepository.GetAll();
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
            return Page();
        }
    }

}