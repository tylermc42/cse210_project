using System;

//create class
public class Scripture
{
    //variables
    private Reference _reference;
    private List<Word> _words;

    //methods
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden() && hiddenCount < numberToHide)
            {
                word.Hide();
                hiddenCount ++;
            }
        }
    }
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}