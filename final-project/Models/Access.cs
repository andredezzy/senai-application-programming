using System.Collections.Generic;
using StatePrinting;

class Access
{
    public string Name { get; set; }
    public Dictionary<string, bool> Accesses;

    public Access(string name)
    {
        this.Name = name;
        this.Accesses = new Dictionary<string, bool>();
    }

    public override string ToString()
    {
        return new Stateprinter().PrintObject(this);
    }
}