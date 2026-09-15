
class Course(String name)
{
    String Name = name;
    int MaxSeats;
    List<Student> Students;


    public void Entroll(Student student)
    {
        if(!Students.Contains(student))
        {
            Students.Add(student);
        }
        else
            Console.WriteLine($"{student.Name} finns redan i krusen");
    }
    
    public void Remove(Student student)
    {
        if(Students.Contains(student))
        {
            Students.Remove(student);
            Console.WriteLine($"Studenten {student.Name} har blivit bortagen från kursen");
        }
        else
            Console.WriteLine($"Studenten {student.Name} är inte med i denna kurs");
    }

    public void RollCall()
    {
        
    }

    public override string ToString()
    {
        return $"{Name}: {Students.Count}/{MaxSeats} Platser";
    }
}
