
class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string title){
        this._studentName = studentName;
        this._topic = title;
    }

    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}