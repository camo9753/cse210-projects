class Doctor : Person
{
    private string _tools;
    
    public Doctor(string firstName, string lastName, int age, string tools) : base(firstName, lastName, age)
    {
        _tools = tools;
    }

    public string GetDoctorInfo()
    {
        return $"Tools: {_tools}, {base.GetPersonInfo()} {_firstName}";
    }
    public override string GetPersonInfo()
    {
        return $"Doctors are kooler than police, my tools: {_tools}, My info is: {base.GetPersonInfo()}";
    }
}