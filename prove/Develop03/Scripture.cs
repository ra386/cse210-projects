using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();
    private List<int> _indexWordsList = new List<int>();                                    

    public Scripture(Reference Reference, string text)
    {
        List<string> textWords = text.Split(' ').ToList();
        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }       
        
        _reference = Reference;    

        for (int i = 0; i < textWords.Count; i++)                                          
        {
            _indexWordsList.Add(i);
        }   
    }
    public void HideRandomWords(int numberToHide)
    {
        Random index = new Random();
        //iterate x  = numberToHide times 
        for (int i = 0; i < numberToHide; i++)
        {   
            int randomPos = index.Next(_words.Count);                                       
            while (!_indexWordsList.Contains(randomPos) && _indexWordsList.Count > 0)       
            {
                randomPos = index.Next(_words.Count);                                       
            }
            Word wordToHide = _words[randomPos];                                            
            wordToHide.Hide();                                                              
            _indexWordsList.Remove(randomPos);                                              
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        List<string> verse = new List<string>();
        foreach (Word word in _words)
        {
            string text = word.GetDisplayText();
            verse.Add(text); 
        }
        return reference + ": " + String.Join(" ",verse) + "\n";          
    }

    public bool IsCompleteHidden()
    {
    
        if (_indexWordsList.Count == 0)
            return true; 
        else{
            return false;
        }
    }
}