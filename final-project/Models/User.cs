using StatePrinting;

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public bool Status { get; set;  }
    public Access Access { get; set;  }

    public User(string name, string email, string username, bool status)
    {
        this.Name = name;
        this.Email = email;
        this.Username = username;
        this.Status = status;
    }

    public override string ToString()
    {
        return new Stateprinter().PrintObject(this);
    }
}
