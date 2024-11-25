using System;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;   
    }

    public void Hide()
    {
        foreach (char letter in "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz;,.") 
        {
            _text = _text.Replace(letter, '_'); 
        }
        _isHidden = true; 
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else{
            return false;
        }
    }
   
    

    public string GetDisplayText()
    {
        return _text;
    }
}