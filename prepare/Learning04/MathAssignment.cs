public class Mathassignment : Assignment
{

    private string _textsection = "";
    private string _problems = "";

    public string Gettextsection()
    {
        return _textsection;
    }

    public void Settextsection(string textsection)
    {

        _textsection = textsection;
    }


    public string Getproblem()
    {
        return _problems;
    }

    public void Setproblem(string problem)
    {

        _problems = problem;
    }

    public string GetHomeworkList()
    {


        return $"Section {_textsection}  Problems {_problems}";


    }




}