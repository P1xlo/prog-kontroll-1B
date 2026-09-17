class Student(string name)
{
    public String Name = name;
    public List<Course> courses = new List<Course>();

    public void JoinCourse(Course course)
    {
        if(!courses.Contains(course))
        {
            course.Enroll(this);
        }
        else
            Console.WriteLine($"{Name} är redan med i {course.Name}");
    }

    public void LeaveCourse(Course course)
    {
        if(courses.Contains(course))
        {
            course.Remove(this);
        }
        else
            Console.WriteLine($"{Name} är inte med i {course.Name}");
    }

    public void Schedule()
    {
        Console.WriteLine("Schema");
        foreach(Course c in courses)
        {
            Console.WriteLine(c.Name);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}