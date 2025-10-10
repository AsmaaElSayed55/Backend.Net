using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Overloading
{
    // ViewModel : Is a Class That Represent Data That Will Be Render In View [ HTML ]
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static explicit operator UserViewModel(User user)
        {
            string[]? names=user?.FullName?.Split(" ") ;
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                Email = user?.Email,
                FirstName = names?[0],
                LastName = names?.Length > 1 ? names[1] : null,
            };
        }

        public override string ToString()
        {
            return $"Id = {Id}\nFirstName = {FirstName}\nLastName = {LastName}\nEmail = {Email}";
        }
    }
}
