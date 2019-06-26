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
        public List<Member> Members { get; set; } = new List<Member>();
        public IActionResult OnGet()
        {
            return InitializeData();
        }

        public IActionResult OnPost()
        {
            MemberRepository memberRepository = new MemberRepository();
            if (Member.Name != null && Member.EnrollmentDate.Date <= DateTime.Today)
            {
                memberRepository.Insert(Member);
            }
            return InitializeData();
        }

        public IActionResult InitializeData()
        {
            MemberRepository memberRepository = new MemberRepository();
            RideRepository rideRepository = new RideRepository();
            try
            {
                Members = memberRepository.GetAll();
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }

            foreach (Member member in Members)
            {
                member.Add(AddRidesToMember(member));
            }
            return Page();
        }
        public List<Ride> AddRidesToMember(Member member)
        {
            RideRepository rideRepository = new RideRepository();
            return rideRepository.GetRidesFromMember(member);
        }

    }
}