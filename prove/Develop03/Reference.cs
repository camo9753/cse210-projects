using System;
using System.Collections.Generic;

class Reference
{
    private string _reference;
    private string _referenceText;
    private Dictionary<string,string> _scriptureReferences = new Dictionary<string, string>
    {
        {"Alma 31:15", "Holy, holy God; we believe that thou art God, and we believe that thou art holy, and that thou wast a spirit, and that thou art a spirit, and that thou wilt be a spirit forever."},
        {"1 Nephi 1:1", "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."},
        {"1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."},
        {"Ether 12:27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."},
        {"Mosiah 4:9-10","Believe in God; believe that he is, and that he created all things, both in heaven and in earth; believe that he has all wisdom, and all power, both in heaven and in earth; believe that man doth not comprehend all the things which the Lord can comprehend. And again, believe that ye must repent of your sins and forsake them, and humble yourselves before God; and ask in sincerity of heart that he would forgive you; and now, if you believe all these things see that ye do them."},
        {"Alma 32:21", "And now as I said concerning faith-faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."},
        {"Alma 37:6-7","6 Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls."}
    };

    public Reference()
    {
        _reference = "";
        _referenceText = "";
        
    }
    public Reference(string reference, string referenceText)
    {
        _reference = reference;
        _referenceText = referenceText;
    }
    public string SetReferenceText()
    {
        return _referenceText;
    }
    public string SetReference()
    {
        return _reference;
    }
    public List<string> GetReference()
    {
        Console.WriteLine("Scripture Options:");
        var scriptureList = _scriptureReferences.ToList();

        for (int i = 0; i < scriptureList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {scriptureList[i].Key}");
        }
        Console.Write("What scripture would you like to try to memorize (ex:'3'): ");
        string userSelect = Console.ReadLine();
        int indexSelect= int.Parse(userSelect); 
        indexSelect = indexSelect - 1;

        List<string> oneScripture = new List<string>{scriptureList[indexSelect].Key, scriptureList[indexSelect].Value};
        return oneScripture;


    }
    
}