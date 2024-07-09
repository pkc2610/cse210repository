using System;

class JOB
{ 
    public string _Company;
    public string  _JobName;
    public int _StartYear;
    public int _EndYear;

    public void Display() 
    {
        Console.WriteLine($"{_JobName} ({_Company}) {_StartYear}-{_EndYear}");
    }
}
// the world's worst code is the code you don't write. This is gonna be the second worst code. Apologies to any TA that might have to look at this.



class RESUMEbb

{
    public string Name;
    public List<JOB> Jobs = new List<JOB>();
        public void Display()

    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"{Jobs}");

        foreach (Job in JOB)
            {
                Jobs.Display();
            }
    }
}