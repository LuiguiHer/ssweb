using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectU.App.Persistence.AppRepositories;
using ProjectU.App.Domain;

namespace ProjectU.App.Frontend.Pages
{
     public class DetailsUserModel : PageModel
    {
       private readonly UserRepository UserRepository;
              public User User {get;set;}
 
        public DetailsUserModel(UserRepository UserRepository)
       {
            this.UserRepository=UserRepository;
       }
 
        public IActionResult OnGet(int UserId)
        {
                User=UserRepository.GetUserWithId(UserId);
                return Page();
 
        }
    }

}
