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
    public List<_Jobs>;

    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"{_Jobs}");

        foreach (Job in _jobs)
        {
            job.Display();
    }
}
}