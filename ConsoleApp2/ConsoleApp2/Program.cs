class Student
{
    public string name;
    public int weight;

    public Student(string modelName,int modelWeight)
    {
        name = modelName;
        weight = modelWeight;
    }
    static void main(string[])
    {
        Student student1 = new Student("Pe", 62);
        Student student2= new Student("Top", 79);
        Student student3= new Student("Ter", 70);
        Student student4 = new Student("Ley", 90);
        Student student5 = new Student("Haroon", 82);
        int[] weightList = { student1.weight, student2.weight, student3.weight, student4.weight, student5.weight };
        int max = weightList.Max();
        int min = weightList.Max();
        Console.WriteLine("แสดงค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด" + (student1.weight, student2.weight, student3.weight, student4.weight, student5.weight) / 5);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักมากที่สุด" + max);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักน้อยที่สุด" + min);
        Console.WriteLine("นาย พิชัย ทองอาสา 653450096ข4");
    }
}
