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
    public class ShowMemberModel : PageModel
    {

        private MemberRepository memberRepository = new MemberRepository();

        [BindProperty(SupportsGet = true)]
        public int MemberId { get; set; }
        [BindProperty(SupportsGet = true)]
        public Member Member { get; set; }

#warning Page do not handle invalid MemberId Yet

        public void OnGet()
        { 
            InitializeMember();
        }

        private void InitializeMember()
        {
            RideRepository rideRepository = new RideRepository();
            Member = memberRepository.GetMember(MemberId);
            if (Member is null)
            {
                throw new ArgumentException("Person findes ikke!");
            }
            Member.Add(AddRidesToMember(Member));
        }

        public List<Ride> AddRidesToMember(Member member)
        {
            RideRepository rideRepository = new RideRepository();
            return rideRepository.GetRidesFromMember(member);
        }
    }
}