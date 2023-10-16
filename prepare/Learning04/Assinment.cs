public class Assignment{

    private string _studentName = "";
    private string _topic = "";

    public string GetStudent()
    {
        return _studentName;
    }

    public void SetStudent(string student)
    {
        _studentName = student;
    }

    public string GetStopic()
    {
        return _studentName;
    }

    public void Settopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

