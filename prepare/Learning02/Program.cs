using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        // job1.Display();
        // job2.Display();


        Resume resume = new Resume("Allison Rose");
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}