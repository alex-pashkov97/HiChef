using System;

namespace HiChef.Model.Models
{
    public class Author
    {
        public Guid UserGuid { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
