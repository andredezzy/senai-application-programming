using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public int Status { get; set;  }
    public AccessControl AccessControl { get; set;  }

    public User(string name, string email, string username, int status)
    {
        this.Name = name;
        this.Email = email;
        this.Username = username;
        this.Status = status;
    }
}
