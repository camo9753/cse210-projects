public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string subject, string title)
        : base(studentName, subject)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}