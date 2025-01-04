using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using FilmApplikation.Models;
using Microsoft.AspNetCore.Authorization;

namespace FilmApplikation.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager) { _userManager = userManager; }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();

            return View(users);
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = _userManager.Users.FirstOrDefault(user => user.Id == id);

            if (user == null)
            {

                return NotFound();
            }

            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            { // Handle the error as needed ModelState.AddModelError("", "Error deleting user."); } return RedirectToAction(nameof(Index));
                ModelState.AddModelError("", "Error deleting user.");
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            var userToBeEdited = _userManager.Users.FirstOrDefault(u => u.Id == id);

            if (userToBeEdited == null)
            {
                return NotFound();
            }

            return View(userToBeEdited);    
        }

        [HttpPost] 
        public async Task<IActionResult> Edit(IdentityUser user)         
        { 
            if (!ModelState.IsValid) 
            { 
                return View(user); 
            } 
            
            var userToUpdate = await _userManager.FindByIdAsync(user.Id); 
            
            if (userToUpdate == null) 
            { 
                return NotFound(); 
            } 
            
            userToUpdate.UserName = user.UserName; 
            userToUpdate.Email = user.Email; 
            
            var result = await _userManager.UpdateAsync(userToUpdate); 
            
            if (!result.Succeeded) 
            { 
                foreach (var error in result.Errors) 
                
                { 
                    ModelState.AddModelError(string.Empty, error.Description); 
                } 
                
                return View(user); 
            } 
            
            return RedirectToAction(nameof(Index)); 
        }



    }
}
