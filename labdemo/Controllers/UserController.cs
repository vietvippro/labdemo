using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace labdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserManager<User> userManager { get; set; }
        RoleManager<IdentityRole> roleManager { get; set; }
        IConfiguration configuration { get; set; }
        public UserController(UserManager<User>
        userManager, RoleManager<IdentityRole> roleManager, IConfiguration
        configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }
        [HttpPost]
        public async Task<ActionResult> Register(User userModel)
        {
            if (!await roleManager.RoleExistsAsync("Teacher"))
            {
                await roleManager.CreateAsync(new IdentityRole("Teacher"));
            }
            if (!await roleManager.RoleExistsAsync("Student"))
            {
                await roleManager.CreateAsync(new IdentityRole("Student"));
            }
            User user = new User();
            user.UserName = userModel.UserName;
            user.HoTen = userModel.HoTen;
            user.GioiTinh = userModel.GioiTinh;
            user.Email = userModel.Email;
            user.Id = Guid.NewGuid().ToString();
            var result = await userManager.CreateAsync(user,
            userModel.MatKhau);
            await userManager.AddToRoleAsync(user, "Student");
            return Ok(new { status = true, message = "Register successful" });
        }
    }
}
