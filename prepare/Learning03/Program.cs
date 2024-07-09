using System;

class JOB
{ 
    public string Company;
    public string  JobName;
    public string StartYear;
    public string EndYear;

    public void Display()

{
    Console.WriteLine($"{JobName} ({Company}) {StartYear}-{EndYear}")

}
}
// the world's worst code is the code you don't write. This is gonna be the second worst code. Apologies to any TA that might have to look at this.