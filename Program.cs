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

 string[] students = { "Аня", "Ярослав", "Вика" };
 int count = 0;
 foreach (string student in students) {
    Console.WriteLine(student);
     count++;
 }
 Console.WriteLine(count);

 int[] points = { 10, 20, 15 };

 for (int i = 0; i < points.Length; i++)
 {
     points[i] = points[i] + 5;
 }
 foreach (int point in points) {
     Console.WriteLine(point);
 }

 string[] students1 = { "Аня", "Борис", "Вика" };
 int number = 1;

 foreach  (string student in students1) {
     Console.WriteLine($"{number}. {student}");
     number++;
 }
 //самостоятельные задания
 //задача А
 int[] books = { 3, 5, 7, 2, 8 };
 int sum1 = 0;

 foreach (int book in books) {
     Console.WriteLine(book);
     sum1 += book;
 }
 Console.WriteLine(sum1);

 //задача В
 string name = "Анастасия";
 int count1 = 0;

 foreach (char letter in name) {
     if ("Ааеёиоуыэюя".Contains(letter))
 {
    count1++;
 }
 }
 Console.WriteLine(count1);

 //индивидуальный вариант
 Console.Write("Введите свою фамилию: ");
 string surname = Console.ReadLine()!.Trim();
 if (string.IsNullOrEmpty(surname)) {
 Console.WriteLine("Фамилия не введена. Завершение работы.");
 return;
 }
 Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
 var assigned = Enumerable.Range(1, 10)
 .OrderBy(_ => rnd.Next())
 .Take(2)
 .OrderBy(x => x)
 .ToList();
 Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

 //задача №7
 int[] grades1 = { 5, 4, 3, 5, 2, 3, 4 };
  int countt = 0;

 foreach (int grade1 in grades1) {
    if (grade1 == 5) {
         countt++;
     }
 }
 Console.WriteLine(countt);

 //вариант 9
  int[] numberss = { 1, 2, 3, 4 };

 for (int b = 0; b < numberss.Length; b++) {
         numberss[b] = numberss[b] + 1;
 }
 foreach (int numberr in numberss) {
     Console.WriteLine(numberr);
 }

 //дополнительное задание. Журнал оценок класса.

 string[] names1 = { "Варя", "Михаид", "Карина" };
 int[] grades2 = { 4, 3, 5 };

 int sum2 = 0;
 int maxGrade = 0;
 string bestStudent = "";

 for (int s = 0; s < names1.Length; s++)
 {
     Console.WriteLine($"{names1[s]} - {grades2[s]}");
     sum2 += grades2[s];

    if (grades2[s] > maxGrade) {
         maxGrade = grades2[s];
         bestStudent = names1[s];
     }
 }

Console.WriteLine($"Средний балл: {(double)sum2 / grades2.Length}");
Console.WriteLine($"Лучший ученик: {bestStudent}"); 