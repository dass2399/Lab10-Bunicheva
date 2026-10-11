string subject = "Программирование";

foreach (char letter in subject) {
    Console.WriteLine(letter);
}
Console.WriteLine($"Общее количество букв: {subject.Length}");


int[] grades = { 4, 5, 3, 5, 4 };
int sum = 0;
foreach (int grade in grades) {
    Console.WriteLine(grade);
    sum += grade;
}
Console.WriteLine($"Средний балл: {(double)sum / grades.Length}");