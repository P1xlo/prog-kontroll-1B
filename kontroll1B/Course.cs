
class Course(String name, int maxSeats)
{
    public String Name = name;
    int MaxSeats = maxSeats;
    public List<Student> Students = new List<Student>();


    public void Enroll(Student student)
    {
        if(Students.Count <= MaxSeats)
        {
            if(!Students.Contains(student))
            {
                Students.Add(student);
                student.courses.Add(this);
            }
            else
                Console.WriteLine($"{student.Name} finns redan i krusen");
        }
        else
            Console.WriteLine("Kursen är full");
    }
    
    public void Remove(Student student)
    {
        if(Students.Contains(student))
        {
            Students.Remove(student);
            student.courses.Remove(this);
            Console.WriteLine($"Studenten {student.Name} har blivit bortagen från kursen");
        }
        else
            Console.WriteLine($"Studenten {student.Name} är inte med i denna kurs");
    }

    public void RollCall()
    {
        for(int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Students.ElementAt(i)}");
        }
    }

    public override string ToString()
    {
        return $"{Name}: {Students.Count}/{MaxSeats} Platser";
    }
}
