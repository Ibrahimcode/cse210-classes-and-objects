class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        this._isHidden = false;
        this._text = text;
    }

    public void Hide(){

        this._isHidden = true;
        
        int wordLength = this._text.Length;

        // Hide the word by replacing each character with (_)
        string hidden = String.Concat(Enumerable.Repeat("_", wordLength));

        this._text = hidden;

    }

    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplay(){
        return this._text;
    }
}