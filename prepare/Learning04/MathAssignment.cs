
class MathAssignment : Assignment
{
    private string _textbookSection;

    private string _problem;

    public MathAssignment(
        string studentName, 
        string topic, 
        string textbookSection, 
        string problem) : base(studentName, topic){

        this._textbookSection = textbookSection;
        this._problem = problem;
    }

    public string GetHomeWorkList(){
        return $"Section {_textbookSection} Problems {_problem}";
    }
}