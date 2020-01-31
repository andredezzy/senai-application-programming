using System.Collections.Generic;
using StatePrinting;

class Access
{
    public string Name { get; set; }
    private Dictionary<string, bool> Accesses;

    public Access(string name)
    {
        this.Name = name;
        this.Accesses = new Dictionary<string, bool>();
    }

    public void Add(string name, bool active)
    {
        this.Accesses.Add(name, active);
    }

    public bool Has(string name)
    {
        return this.Accesses.ContainsKey(name) && this.Accesses[name];
    }

    public override string ToString()
    {
        return new Stateprinter().PrintObject(this);
    }
}