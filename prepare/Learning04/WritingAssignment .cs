public class WritingAssignment : Assignment
{
    private string _title = "";

    public string Gettitle()
    {
        return _title;
    }

    public void Settitle(string title)
    {
        _title = title;
    }


    public string GetWritingInformation()

    {
        return $"{_title}";
    }
}