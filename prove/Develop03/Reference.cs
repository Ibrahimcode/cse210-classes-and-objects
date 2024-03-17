
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse){
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse){
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText(){
        if (_endVerse == 0)
        {
            return $"{this._book} {this._chapter}:{this._verse}";
        }
        return $"{this._book} {this._chapter}:{this._verse}-{this._endVerse}";
    }

}