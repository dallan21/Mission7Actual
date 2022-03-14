using System;
namespace Mission7.Models.ViewModels
{
    public class LoginModel
    {
        [Requried]
        public string Username { get; set; }
        [Requried]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
