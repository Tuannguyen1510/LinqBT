internal class Program
{
    class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public string BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Address { get; set; }
    }

    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student { StudentId = "SV001", StudentName = "Nguyễn Văn A", Age = 20, Sex = true, BirthDate = "2002-04-23", BirthPlace = "HN", Address = "25, Vũ Ngọc Phan" },
            new Student { StudentId = "SV002", StudentName = "Nguyễn Văn B", Age = 21, Sex = false, BirthDate = "2001-09-09", BirthPlace = "ĐN", Address = "1, Ngô Quyền" },
            new Student { StudentId = "SV003", StudentName = "Nguyễn Văn C", Age = 19, Sex = true, BirthDate = "2003-07-07", BirthPlace = "HCM", Address = "1, Lý Tự Trọng" },
            new Student { StudentId = "SV004", StudentName = "Nguyễn Văn D", Age = 29, Sex = false, BirthDate = "2005-07-07", BirthPlace = "HCM", Address = "1, Lý Tự Trọng" }
        };

        // Hiển thị thông tin của tất cả sinh viên
        Console.WriteLine("Thông tin của tất cả sinh viên:");
        foreach (var student in students)
        {
            Console.WriteLine($"Mã SV: {student.StudentId}, Tên SV: {student.StudentName}, Tuổi: {student.Age}, Giới tính: {(student.Sex ? "Nam" : "Nữ")}, Ngày sinh: {student.BirthDate}, Nơi sinh: {student.BirthPlace}, Địa chỉ: {student.Address}");
        }

        // Hiển thị thông tin của những sinh viên có tuổi lớn hơn 20
        var studentsAbove20 = students.Where(student => student.Age > 20).ToList();
        Console.WriteLine("\nThông tin của những sinh viên có tuổi lớn hơn 20:");
        foreach (var student in studentsAbove20)
        {
            Console.WriteLine($"Mã SV: {student.StudentId}, Tên SV: {student.StudentName}, Tuổi: {student.Age}, Giới tính: {(student.Sex ? "Nam" : "Nữ")}, Ngày sinh: {student.BirthDate}, Nơi sinh: {student.BirthPlace}, Địa chỉ: {student.Address}");
        }

        // Đếm số lượng sinh viên nam
        var maleStudentCount = students.Count(student => student.Sex== true);
        Console.WriteLine($"\nSố lượng sinh viên nam: {maleStudentCount}");

        // Lấy ra tên của những sinh viên có nơi sinh là HCM
        var studentsFromHCM = students.Where(student => student.BirthPlace == "HCM").Select(student => student.StudentName).ToList();
        Console.WriteLine("\nTên của những sinh viên có nơi sinh là HCM:");
        foreach (var studentName in studentsFromHCM)
        {
            Console.WriteLine(studentName);
        }
    }
}