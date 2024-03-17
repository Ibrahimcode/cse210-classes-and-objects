
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private Reference _reference;

    List<Word> _word;


    private int _amountofWordsHidden;

    // Store the index of each word.
    // This will help us to randomly hide a word ones
    private List<int> _wordTextIndex; 

    public Scripture(Reference reference, String text){
        this._reference = reference;
        this._word = new List<Word>();
        this._wordTextIndex = new List<int>();
        
        string[] textWords = text.Split(" ");

        int index = 0;
        foreach (string word in textWords)
        {
            this._word.Add(new Word(word));
            this._wordTextIndex.Add(index);
            index++;
        }


        _amountofWordsHidden = 0;

    }

    public void HideRandomWords(int amountOfWords){
        Random randomGenerator = new Random();

        if (IsCompletelyHidden())
        {
            return;
        }

        if (amountOfWords > 0)
        {
            int randomWordIndex = randomGenerator.Next(0, _wordTextIndex.Count-1);
            if (!this._word[_wordTextIndex[randomWordIndex]].IsHidden())
            {
                this._word[_wordTextIndex[randomWordIndex]].Hide();
                this._wordTextIndex.RemoveAt(randomWordIndex);
                this._amountofWordsHidden += 1;
                HideRandomWords(amountOfWords - 1);
            }
        }

    }

    public bool IsCompletelyHidden(){
        return this._wordTextIndex.Count == 0;
    }

    public string GetDisplay(){
        string memorizeText = this._reference.GetDisplayText() + " ";
        foreach (Word word in this._word)
        {
            string wordText = word.GetDisplay();
            memorizeText += wordText + " ";
        }
        return memorizeText;
    }
}