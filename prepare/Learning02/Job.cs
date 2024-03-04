
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        this._company = company;
        this._jobTitle = jobTitle;
        this._startYear = startYear;
        this._endYear = endYear;
    }

    // Display the job postings.
    public void Display()
    {
        Console.WriteLine($"{this._company} ({this._jobTitle}) {this._startYear}-{this._endYear}");
    }
}