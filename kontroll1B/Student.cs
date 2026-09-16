class Student(string name)
{
    public String Name = name;
    List<Course> courses;

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
            Console.WriteLine(c);
        }
    }

    public override string ToString()
    {
        return Name;
    }
}