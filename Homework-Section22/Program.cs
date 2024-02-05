




using Homework_Section22;
using System.Collections.Generic;

List<Student> students = new List<Student>();



string opt;
do
{

    Console.WriteLine("1 Telebe alave et");
    Console.WriteLine("2 Telebeye imtahan elave et");
    Console.WriteLine("3 Telebenin 1 imtahan balina bax");
    Console.WriteLine("4 Telebenin butun imtahanlarini goster");
    Console.WriteLine("5 Telebenin imtahan ortalamasini goster");
    Console.WriteLine("6 Telebeden imtahani sil");
    Console.WriteLine("0 proqrami bitir");
    Console.WriteLine("\nEmeliyati secin");
    opt = Console.ReadLine();


    switch (opt)
    {
        case "1":
            Console.WriteLine("FullName elave et:");
            string fullNameStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(fullNameStr))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FullName bos ola bilmez");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Student student = new Student()
            {
                FullName = fullNameStr,
            };
            students.Add(student);
            break; 
        case "2":
            //2 seçilərsə tələbənin nömrəsi, imtahan adı və qiyməti daxil edilir
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Telebenin No daxil edin:");
            string noStudentStr = Console.ReadLine();
            int noStudent;
            if (!int.TryParse(noStudentStr,out noStudent))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Duzugn No daxil edin !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Console.WriteLine("Imtahan adi :");
            string examNameStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(examNameStr))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Imtahan adi bos ola bilmez !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Console.WriteLine("Point daxil edin :");
            string pointStr = Console.ReadLine();
            double point;
            if(!double.TryParse(pointStr, out point))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzugn Point daxil edin !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            foreach (var item in students)
            {
                if (noStudent == item.No)
                {
                    item.AddExam(examNameStr, point);
                }
            }
            break;
        case "3":
            Console.WriteLine("Telebenin No daxil edin :");
            string  noStuStr = Console.ReadLine();
            int noStu;
            if (!int.TryParse(noStuStr, out noStu))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzugn No daxil edin !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Console.WriteLine("Imtahan adini daxil edin :");
            string examNameStr2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(examNameStr2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Imtahan adi bos ola bilmez !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            double examResult = students[noStu - 1].GetExamResult(examNameStr2);
            Console.WriteLine("Balı: "+examResult);
            break;
        case "4":
            //seçilərsə tələbənin no dəyəri daxil edilir və o tələbənin bütün imthan adları və balları göstərilir

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("No daxil edin: ");
            string strNo = Console.ReadLine();
            int no;
            if (!int.TryParse(strNo,out no))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzugn No daxil edin !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Student student1 = students[no - 1];
            foreach (var item in student1.Exams)
            {
                Console.WriteLine("Imtahani :"+item.Key + " " +"Balı: "+ item.Value);
            }
            break; 
        case "5":
            // Tələbənin imtahan ortalamasını göstər
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("No daxil edin: ");
            string strNo2 = Console.ReadLine();
            int no2;
            if (!int.TryParse(strNo2, out no2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzugn No daxil edin !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            double examResult2 = students[no2 - 1].GetExamAvg();
            Console.WriteLine("Ortalamasi: "+examResult2);
            break;
        case "6":
            //seçilərsə tələbə no dəyəri və imtahan adı daxil edilir və həmin tələbədən həmin imtahan dəyəri silinir
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Telebenin No daxil edin :");
            string noStuStr2 = Console.ReadLine();
            int noStu2;
            if (!int.TryParse(noStuStr2, out noStu2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Duzugn No daxil edin !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Console.WriteLine("Imtahan adini daxil edin :");
            string examNameStr3 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(examNameStr3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Imtahan adi bos ola bilmez !");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
            Student student2 = students[noStu2 - 1];
            foreach (var item in student2.Exams)
            {
                if (examNameStr3 == item.Key)
                {
                    student2.Exams.Remove(item.Key);
                }
            }
            break;
        case "0":
            Console.WriteLine("Emeliyyat bitdi");
            break;
        default:
            Console.WriteLine("Duzgun operator daxil edin");
            break;
    }
} while (opt != "0");
