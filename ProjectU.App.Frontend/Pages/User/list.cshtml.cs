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
    public class ListUserModel : PageModel
    {
       
        private readonly UserRepository UserRepository;
        public IEnumerable<User> User {get;set;}
 
    public ListUserModel(UserRepository UserRepository)
    {
        this.UserRepository=UserRepository;
     }
 
    public void OnGet()
    {
        User=UserRepository.GetAll();
    }
    }
}


