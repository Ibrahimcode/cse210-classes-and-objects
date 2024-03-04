
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        this._name = name;
    }

    // Display resume with it job postings.
    public void Display()
    {
        Console.WriteLine($"{this._name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in this._jobs)
        {
            job.Display();
        }
    }
}