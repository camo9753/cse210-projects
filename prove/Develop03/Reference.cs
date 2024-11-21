using System;

class Reference
{
    private string _reference;
    private string _referenceText;

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
    public string GetReference()
    {
        // Dictionary to be added later
        string reference = "Alma 31:15";
        string referenceText = @"Holy, holy God; we believe that thou art God, and we believe that thou art 
holy, and that thou wast a spirit, and that thou art a spirit, and that thou wilt be a spirit forever.";

        return referenceText;
    }
    public void SetReference(string referenceText)
    {
        _referenceText = referenceText;
    }
}