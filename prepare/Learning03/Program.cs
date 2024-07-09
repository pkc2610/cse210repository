using System;

class JOB
{ 
    public string _Company;
    public string  _JobName;
    public string _StartYear;
    public string _EndYear;

    public void Display()

{
    Console.WriteLine($"{_JobName} ({_Company}) {_StartYear}-{_EndYear}");

}
}
// the world's worst code is the code you don't write. This is gonna be the second worst code. Apologies to any TA that might have to look at this.