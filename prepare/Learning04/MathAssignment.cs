class MathAssignment: Assignment {
    private string _textBookSection;
    private string _problemSet;


    public MathAssignment(string studentName, string topic, string textBookSection, string problemSet) : base(studentName, topic){
        _studentName = studentName;
        _topic = topic;
        _textBookSection = textBookSection;
        _problemSet = problemSet;
    }

    public string GetHomeworkList(){
        return $"Section {_textBookSection} Problems {_problemSet}";
    }
}