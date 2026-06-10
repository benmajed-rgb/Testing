using DentalBusinessCenter.Models;

namespace DentalBusinessCenter.Services
{
    public static class DataStore
    {
        private static readonly DateTime _now = DateTime.Now;

        public static List<ApplicationUser> Users { get; } = new()
        {
            new ApplicationUser { Id = 1, Username = "admin", PasswordHash = "admin123", Role = "Admin", FullName = "System Administrator", DoctorId = null },
            new ApplicationUser { Id = 2, Username = "doctor1", PasswordHash = "doc123", Role = "Doctor", FullName = "Dr. Ahmed Al-Rashidi", DoctorId = 1 },
            new ApplicationUser { Id = 3, Username = "doctor2", PasswordHash = "doc123", Role = "Doctor", FullName = "Dr. Sara Al-Mansouri", DoctorId = 2 },
            new ApplicationUser { Id = 4, Username = "doctor3", PasswordHash = "doc123", Role = "Doctor", FullName = "Dr. Khalid Al-Otaibi", DoctorId = 3 },
            new ApplicationUser { Id = 5, Username = "reception1", PasswordHash = "rec123", Role = "Receptionist", FullName = "Noura Al-Harbi", DoctorId = null },
        };

        public static List<Doctor> Doctors { get; } = new()
        {
            new Doctor { Id = 1, FullName = "Dr. Ahmed Al-Rashidi", Specialty = "General Dentistry", AssignedRoom = "VIP 1", ClinicType = "BC" },
            new Doctor { Id = 2, FullName = "Dr. Sara Al-Mansouri", Specialty = "Orthodontics", AssignedRoom = "VIP 2", ClinicType = "BC" },
            new Doctor { Id = 3, FullName = "Dr. Khalid Al-Otaibi", Specialty = "Oral Surgery", AssignedRoom = "OR", ClinicType = "OR" },
            new Doctor { Id = 4, FullName = "Dr. Fatima Al-Zahraa", Specialty = "Pediatric Dentistry", AssignedRoom = "Chair 1", ClinicType = "Pedo" },
            new Doctor { Id = 5, FullName = "Dr. Mohammed Al-Ghamdi", Specialty = "Endodontics", AssignedRoom = "Chair 2", ClinicType = "BC" },
            new Doctor { Id = 6, FullName = "Dr. Aisha Al-Shehri", Specialty = "Periodontics", AssignedRoom = "Chair 3", ClinicType = "BC" },
            new Doctor { Id = 7, FullName = "Dr. Omar Al-Qahtani", Specialty = "Prosthodontics", AssignedRoom = "Chair 4", ClinicType = "BC" },
            new Doctor { Id = 8, FullName = "Dr. Nadia Al-Dosari", Specialty = "Oral Radiology", AssignedRoom = "CBCT Room", ClinicType = "BC" },
            new Doctor { Id = 9, FullName = "Dr. Yusuf Al-Balawi", Specialty = "Implantology", AssignedRoom = "VIP 3", ClinicType = "BC" },
            new Doctor { Id = 10, FullName = "Dr. Hana Al-Mutairi", Specialty = "Cosmetic Dentistry", AssignedRoom = "VIP 4", ClinicType = "BC" },
            new Doctor { Id = 11, FullName = "Dr. Tariq Al-Anazi", Specialty = "General Dentistry", AssignedRoom = "Chair 5", ClinicType = "BC" },
            new Doctor { Id = 12, FullName = "Dr. Lina Al-Sayed", Specialty = "Orthodontics", AssignedRoom = "Chair 6", ClinicType = "BC" },
            new Doctor { Id = 13, FullName = "Dr. Faisal Al-Subhi", Specialty = "Oral Surgery", AssignedRoom = "OR", ClinicType = "OR" },
            new Doctor { Id = 14, FullName = "Dr. Reem Al-Juhani", Specialty = "Pediatric Dentistry", AssignedRoom = "Chair 7", ClinicType = "Pedo" },
            new Doctor { Id = 15, FullName = "Dr. Bader Al-Harthy", Specialty = "Endodontics", AssignedRoom = "Chair 8", ClinicType = "BC" },
            new Doctor { Id = 16, FullName = "Dr. Maryam Al-Otaibi", Specialty = "Periodontics", AssignedRoom = "Chair 9", ClinicType = "BC" },
            new Doctor { Id = 17, FullName = "Dr. Nawaf Al-Shamrani", Specialty = "Prosthodontics", AssignedRoom = "VIP 5", ClinicType = "BC" },
            new Doctor { Id = 18, FullName = "Dr. Dalal Al-Rasheed", Specialty = "Implantology", AssignedRoom = "VIP 6", ClinicType = "BC" },
            new Doctor { Id = 19, FullName = "Dr. Saad Al-Omari", Specialty = "General Dentistry", AssignedRoom = "Chair 10", ClinicType = "BC" },
            new Doctor { Id = 20, FullName = "Dr. Hessa Al-Tamimi", Specialty = "Cosmetic Dentistry", AssignedRoom = "Chair 11", ClinicType = "BC" },
            new Doctor { Id = 21, FullName = "Dr. Waleed Al-Zahrani", Specialty = "Orthodontics", AssignedRoom = "Chair 12", ClinicType = "BC" },
            new Doctor { Id = 22, FullName = "Dr. Ghada Al-Khaldi", Specialty = "Oral Surgery", AssignedRoom = "OR", ClinicType = "OR" },
            new Doctor { Id = 23, FullName = "Dr. Meshal Al-Ruwaili", Specialty = "Pediatric Dentistry", AssignedRoom = "Chair 13", ClinicType = "Pedo" },
            new Doctor { Id = 24, FullName = "Dr. Nouf Al-Qahtani", Specialty = "Periodontics", AssignedRoom = "Chair 14", ClinicType = "BC" },
            new Doctor { Id = 25, FullName = "Dr. Saud Al-Maliki", Specialty = "Implantology", AssignedRoom = "VIP 7", ClinicType = "BC" },
            new Doctor { Id = 26, FullName = "Dr. Rana Al-Enezi", Specialty = "General Dentistry", AssignedRoom = "Chair 15", ClinicType = "BC" },
            new Doctor { Id = 27, FullName = "Dr. Hamad Al-Dosari", Specialty = "Prosthodontics", AssignedRoom = "VIP 8", ClinicType = "BC" },
        };

        public static List<Patient> Patients { get; } = new()
        {
            new Patient { Id = 1, PrsNumber = "PRS-001", QuadraMedNumber = "QM-10001", FullNameEn = "Abdullah Al-Rashidi", FullNameAr = "عبدالله الراشدي", DateOfBirth = new DateTime(1985, 3, 15), Gender = "Male", Nationality = "Saudi", NationalId = "1234567890", Mobile = "0501234567", Email = "a.rashidi@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2022, 1, 10), AssignedDoctorIds = "1,2", HasNonPayment = false },
            new Patient { Id = 2, PrsNumber = "PRS-002", QuadraMedNumber = "QM-10002", FullNameEn = "Mariam Al-Ghamdi", FullNameAr = "مريم الغامدي", DateOfBirth = new DateTime(1990, 7, 22), Gender = "Female", Nationality = "Saudi", NationalId = "2345678901", Mobile = "0512345678", Email = "m.ghamdi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 3, 5), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 3, PrsNumber = "PRS-003", QuadraMedNumber = "QM-10003", FullNameEn = "Khalid Al-Otaibi", FullNameAr = "خالد العتيبي", DateOfBirth = new DateTime(1978, 11, 8), Gender = "Male", Nationality = "Saudi", NationalId = "3456789012", Mobile = "0523456789", Email = "k.otaibi@email.com", Category = "OR", DateOfFirstVisit = new DateTime(2021, 6, 20), AssignedDoctorIds = "3", HasNonPayment = true },
            new Patient { Id = 4, PrsNumber = "PRS-004", QuadraMedNumber = "QM-10004", FullNameEn = "Fatima Al-Zahraa", FullNameAr = "فاطمة الزهراء", DateOfBirth = new DateTime(2010, 4, 12), Gender = "Female", Nationality = "Saudi", NationalId = "4567890123", Mobile = "0534567890", Email = "f.zahraa@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 2, 14), AssignedDoctorIds = "4", HasNonPayment = false },
            new Patient { Id = 5, PrsNumber = "PRS-005", QuadraMedNumber = "QM-10005", FullNameEn = "Mohammed Al-Shehri", FullNameAr = "محمد الشهري", DateOfBirth = new DateTime(1965, 9, 30), Gender = "Male", Nationality = "Saudi", NationalId = "5678901234", Mobile = "0545678901", Email = "m.shehri@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2020, 8, 1), AssignedDoctorIds = "1,9", HasNonPayment = false },
            new Patient { Id = 6, PrsNumber = "PRS-006", QuadraMedNumber = "QM-10006", FullNameEn = "Noura Al-Qahtani", FullNameAr = "نورة القحطاني", DateOfBirth = new DateTime(1995, 1, 18), Gender = "Female", Nationality = "Saudi", NationalId = "6789012345", Mobile = "0556789012", Email = "n.qahtani@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 5, 9), AssignedDoctorIds = "6", HasNonPayment = false },
            new Patient { Id = 7, PrsNumber = "PRS-007", QuadraMedNumber = "QM-10007", FullNameEn = "Yusuf Al-Balawi", FullNameAr = "يوسف البلوي", DateOfBirth = new DateTime(1982, 6, 25), Gender = "Male", Nationality = "Saudi", NationalId = "7890123456", Mobile = "0567890123", Email = "y.balawi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 10, 3), AssignedDoctorIds = "5", HasNonPayment = true },
            new Patient { Id = 8, PrsNumber = "PRS-008", QuadraMedNumber = "QM-10008", FullNameEn = "Hana Al-Mutairi", FullNameAr = "هناء المطيري", DateOfBirth = new DateTime(1988, 12, 7), Gender = "Female", Nationality = "Saudi", NationalId = "8901234567", Mobile = "0578901234", Email = "h.mutairi@email.com", Category = "Hygienist", DateOfFirstVisit = new DateTime(2021, 11, 15), AssignedDoctorIds = "6,7", HasNonPayment = false },
            new Patient { Id = 9, PrsNumber = "PRS-009", QuadraMedNumber = "QM-10009", FullNameEn = "Tariq Al-Anazi", FullNameAr = "طارق العنزي", DateOfBirth = new DateTime(1972, 2, 20), Gender = "Male", Nationality = "Saudi", NationalId = "9012345678", Mobile = "0589012345", Email = "t.anazi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2020, 4, 8), AssignedDoctorIds = "1", HasNonPayment = false },
            new Patient { Id = 10, PrsNumber = "PRS-010", QuadraMedNumber = "QM-10010", FullNameEn = "Lina Al-Sayed", FullNameAr = "لينا السيد", DateOfBirth = new DateTime(2008, 8, 14), Gender = "Female", Nationality = "Saudi", NationalId = "0123456789", Mobile = "0590123456", Email = "l.sayed@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 7, 22), AssignedDoctorIds = "4", HasNonPayment = false },
            new Patient { Id = 11, PrsNumber = "PRS-011", QuadraMedNumber = "QM-10011", FullNameEn = "Faisal Al-Subhi", FullNameAr = "فيصل الصبحي", DateOfBirth = new DateTime(1980, 5, 3), Gender = "Male", Nationality = "Saudi", NationalId = "1122334455", Mobile = "0501122334", Email = "f.subhi@email.com", Category = "OR", DateOfFirstVisit = new DateTime(2022, 12, 1), AssignedDoctorIds = "3,13", HasNonPayment = false },
            new Patient { Id = 12, PrsNumber = "PRS-012", QuadraMedNumber = "QM-10012", FullNameEn = "Reem Al-Juhani", FullNameAr = "ريم الجهني", DateOfBirth = new DateTime(1993, 10, 28), Gender = "Female", Nationality = "Saudi", NationalId = "2233445566", Mobile = "0512233445", Email = "r.juhani@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 1, 17), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 13, PrsNumber = "PRS-013", QuadraMedNumber = "QM-10013", FullNameEn = "Bader Al-Harthy", FullNameAr = "بدر الحارثي", DateOfBirth = new DateTime(1975, 7, 11), Gender = "Male", Nationality = "Saudi", NationalId = "3344556677", Mobile = "0523344556", Email = "b.harthy@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2021, 3, 25), AssignedDoctorIds = "5", HasNonPayment = true },
            new Patient { Id = 14, PrsNumber = "PRS-014", QuadraMedNumber = "QM-10014", FullNameEn = "Maryam Al-Otaibi", FullNameAr = "مريم العتيبي", DateOfBirth = new DateTime(2005, 3, 19), Gender = "Female", Nationality = "Saudi", NationalId = "4455667788", Mobile = "0534455667", Email = "m.otaibi@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 4, 6), AssignedDoctorIds = "4,14", HasNonPayment = false },
            new Patient { Id = 15, PrsNumber = "PRS-015", QuadraMedNumber = "QM-10015", FullNameEn = "Nawaf Al-Shamrani", FullNameAr = "نواف الشمراني", DateOfBirth = new DateTime(1969, 11, 4), Gender = "Male", Nationality = "Saudi", NationalId = "5566778899", Mobile = "0545566778", Email = "n.shamrani@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2019, 9, 13), AssignedDoctorIds = "9,17", HasNonPayment = false },
            new Patient { Id = 16, PrsNumber = "PRS-016", QuadraMedNumber = "QM-10016", FullNameEn = "Dalal Al-Rasheed", FullNameAr = "دلال الرشيد", DateOfBirth = new DateTime(1997, 6, 30), Gender = "Female", Nationality = "Saudi", NationalId = "6677889900", Mobile = "0556677889", Email = "d.rasheed@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 8, 20), AssignedDoctorIds = "7", HasNonPayment = false },
            new Patient { Id = 17, PrsNumber = "PRS-017", QuadraMedNumber = "QM-10017", FullNameEn = "Saad Al-Omari", FullNameAr = "سعد العمري", DateOfBirth = new DateTime(1983, 1, 16), Gender = "Male", Nationality = "Saudi", NationalId = "7788990011", Mobile = "0567788990", Email = "s.omari@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 7, 5), AssignedDoctorIds = "1", HasNonPayment = false },
            new Patient { Id = 18, PrsNumber = "PRS-018", QuadraMedNumber = "QM-10018", FullNameEn = "Hessa Al-Tamimi", FullNameAr = "حصة التميمي", DateOfBirth = new DateTime(1991, 9, 23), Gender = "Female", Nationality = "Saudi", NationalId = "8899001122", Mobile = "0578899001", Email = "h.tamimi@email.com", Category = "Hygienist", DateOfFirstVisit = new DateTime(2022, 2, 28), AssignedDoctorIds = "6", HasNonPayment = false },
            new Patient { Id = 19, PrsNumber = "PRS-019", QuadraMedNumber = "QM-10019", FullNameEn = "Waleed Al-Zahrani", FullNameAr = "وليد الزهراني", DateOfBirth = new DateTime(1977, 4, 7), Gender = "Male", Nationality = "Saudi", NationalId = "9900112233", Mobile = "0589900112", Email = "w.zahrani@email.com", Category = "OR", DateOfFirstVisit = new DateTime(2021, 12, 10), AssignedDoctorIds = "3", HasNonPayment = true },
            new Patient { Id = 20, PrsNumber = "PRS-020", QuadraMedNumber = "QM-10020", FullNameEn = "Ghada Al-Khaldi", FullNameAr = "غادة الخالدي", DateOfBirth = new DateTime(1986, 8, 15), Gender = "Female", Nationality = "Saudi", NationalId = "0011223344", Mobile = "0590011223", Email = "g.khaldi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 6, 12), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 21, PrsNumber = "PRS-021", QuadraMedNumber = "QM-10021", FullNameEn = "Meshal Al-Ruwaili", FullNameAr = "مشعل الرويلي", DateOfBirth = new DateTime(2012, 2, 9), Gender = "Male", Nationality = "Saudi", NationalId = "1020304050", Mobile = "0501020304", Email = "m.ruwaili@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 9, 4), AssignedDoctorIds = "4", HasNonPayment = false },
            new Patient { Id = 22, PrsNumber = "PRS-022", QuadraMedNumber = "QM-10022", FullNameEn = "Nouf Al-Qahtani", FullNameAr = "نوف القحطاني", DateOfBirth = new DateTime(1994, 12, 21), Gender = "Female", Nationality = "Saudi", NationalId = "2030405060", Mobile = "0512030405", Email = "nouf.q@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 11, 7), AssignedDoctorIds = "6,24", HasNonPayment = false },
            new Patient { Id = 23, PrsNumber = "PRS-023", QuadraMedNumber = "QM-10023", FullNameEn = "Saud Al-Maliki", FullNameAr = "سعود المالكي", DateOfBirth = new DateTime(1970, 6, 18), Gender = "Male", Nationality = "Saudi", NationalId = "3040506070", Mobile = "0523040506", Email = "s.maliki@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2020, 10, 25), AssignedDoctorIds = "9,25", HasNonPayment = false },
            new Patient { Id = 24, PrsNumber = "PRS-024", QuadraMedNumber = "QM-10024", FullNameEn = "Rana Al-Enezi", FullNameAr = "رنا العنزي", DateOfBirth = new DateTime(1999, 3, 5), Gender = "Female", Nationality = "Saudi", NationalId = "4050607080", Mobile = "0534050607", Email = "r.enezi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 3, 30), AssignedDoctorIds = "1", HasNonPayment = false },
            new Patient { Id = 25, PrsNumber = "PRS-025", QuadraMedNumber = "QM-10025", FullNameEn = "Hamad Al-Dosari", FullNameAr = "حمد الدوسري", DateOfBirth = new DateTime(1963, 10, 12), Gender = "Male", Nationality = "Saudi", NationalId = "5060708090", Mobile = "0545060708", Email = "h.dosari@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2019, 5, 8), AssignedDoctorIds = "17,27", HasNonPayment = false },
            new Patient { Id = 26, PrsNumber = "PRS-026", QuadraMedNumber = "QM-10026", FullNameEn = "Sarah Mitchell", FullNameAr = "سارة ميتشيل", DateOfBirth = new DateTime(1987, 7, 28), Gender = "Female", Nationality = "American", NationalId = "A12345678", Mobile = "0506070809", Email = "s.mitchell@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 4, 14), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 27, PrsNumber = "PRS-027", QuadraMedNumber = "QM-10027", FullNameEn = "James Al-Abdullah", FullNameAr = "جيمس العبدالله", DateOfBirth = new DateTime(1979, 1, 31), Gender = "Male", Nationality = "British", NationalId = "B87654321", Mobile = "0517080910", Email = "j.abdullah@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2021, 8, 19), AssignedDoctorIds = "1", HasNonPayment = false },
            new Patient { Id = 28, PrsNumber = "PRS-028", QuadraMedNumber = "QM-10028", FullNameEn = "Ali Hassan Al-Farsi", FullNameAr = "علي حسن الفارسي", DateOfBirth = new DateTime(1992, 5, 17), Gender = "Male", Nationality = "Omani", NationalId = "C11223344", Mobile = "0528091011", Email = "a.farsi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 10, 2), AssignedDoctorIds = "5", HasNonPayment = false },
            new Patient { Id = 29, PrsNumber = "PRS-029", QuadraMedNumber = "QM-10029", FullNameEn = "Zainab Al-Hussain", FullNameAr = "زينب الحسين", DateOfBirth = new DateTime(2007, 9, 14), Gender = "Female", Nationality = "Saudi", NationalId = "6070809100", Mobile = "0539101112", Email = "z.hussain@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 11, 8), AssignedDoctorIds = "4", HasNonPayment = false },
            new Patient { Id = 30, PrsNumber = "PRS-030", QuadraMedNumber = "QM-10030", FullNameEn = "Ibrahim Al-Shammari", FullNameAr = "إبراهيم الشمري", DateOfBirth = new DateTime(1968, 12, 26), Gender = "Male", Nationality = "Saudi", NationalId = "7080910111", Mobile = "0541011121", Email = "i.shammari@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2020, 2, 17), AssignedDoctorIds = "7", HasNonPayment = true },
            new Patient { Id = 31, PrsNumber = "PRS-031", QuadraMedNumber = "QM-10031", FullNameEn = "Nada Al-Whibi", FullNameAr = "ندى الوهيبي", DateOfBirth = new DateTime(1996, 4, 2), Gender = "Female", Nationality = "Saudi", NationalId = "8091011121", Mobile = "0551112131", Email = "n.whibi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 6, 29), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 32, PrsNumber = "PRS-032", QuadraMedNumber = "QM-10032", FullNameEn = "Sultan Al-Bishi", FullNameAr = "سلطان البيشي", DateOfBirth = new DateTime(1984, 8, 8), Gender = "Male", Nationality = "Saudi", NationalId = "9101112131", Mobile = "0561213141", Email = "s.bishi@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2021, 7, 4), AssignedDoctorIds = "1,10", HasNonPayment = false },
            new Patient { Id = 33, PrsNumber = "PRS-033", QuadraMedNumber = "QM-10033", FullNameEn = "Manal Al-Qarni", FullNameAr = "منال القرني", DateOfBirth = new DateTime(1989, 11, 19), Gender = "Female", Nationality = "Saudi", NationalId = "0112131415", Mobile = "0571314151", Email = "m.qarni@email.com", Category = "Hygienist", DateOfFirstVisit = new DateTime(2022, 9, 11), AssignedDoctorIds = "6", HasNonPayment = false },
            new Patient { Id = 34, PrsNumber = "PRS-034", QuadraMedNumber = "QM-10034", FullNameEn = "Turki Al-Dossary", FullNameAr = "تركي الدوسري", DateOfBirth = new DateTime(1973, 3, 27), Gender = "Male", Nationality = "Saudi", NationalId = "1213141516", Mobile = "0581415161", Email = "t.dossary@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2020, 11, 22), AssignedDoctorIds = "5", HasNonPayment = false },
            new Patient { Id = 35, PrsNumber = "PRS-035", QuadraMedNumber = "QM-10035", FullNameEn = "Arwa Al-Malki", FullNameAr = "أروى المالكي", DateOfBirth = new DateTime(2003, 6, 11), Gender = "Female", Nationality = "Saudi", NationalId = "2314151617", Mobile = "0591516171", Email = "a.malki@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 12, 3), AssignedDoctorIds = "14", HasNonPayment = false },
            new Patient { Id = 36, PrsNumber = "PRS-036", QuadraMedNumber = "QM-10036", FullNameEn = "Nasser Al-Zahrani", FullNameAr = "ناصر الزهراني", DateOfBirth = new DateTime(1960, 1, 14), Gender = "Male", Nationality = "Saudi", NationalId = "3415161718", Mobile = "0501617181", Email = "n.zahrani@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2018, 7, 30), AssignedDoctorIds = "9,17", HasNonPayment = false },
            new Patient { Id = 37, PrsNumber = "PRS-037", QuadraMedNumber = "QM-10037", FullNameEn = "Lujain Al-Harbi", FullNameAr = "لجين الحربي", DateOfBirth = new DateTime(2001, 10, 6), Gender = "Female", Nationality = "Saudi", NationalId = "4516171819", Mobile = "0511718192", Email = "l.harbi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 2, 18), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 38, PrsNumber = "PRS-038", QuadraMedNumber = "QM-10038", FullNameEn = "Abdulrahman Al-Subhi", FullNameAr = "عبدالرحمن الصبحي", DateOfBirth = new DateTime(1976, 7, 22), Gender = "Male", Nationality = "Saudi", NationalId = "5617181920", Mobile = "0521819202", Email = "ar.subhi@email.com", Category = "OR", DateOfFirstVisit = new DateTime(2022, 5, 16), AssignedDoctorIds = "3", HasNonPayment = true },
            new Patient { Id = 39, PrsNumber = "PRS-039", QuadraMedNumber = "QM-10039", FullNameEn = "Shahad Al-Rashidi", FullNameAr = "شهد الراشدي", DateOfBirth = new DateTime(1998, 2, 4), Gender = "Female", Nationality = "Saudi", NationalId = "6718192021", Mobile = "0531920212", Email = "sh.rashidi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 7, 9), AssignedDoctorIds = "1", HasNonPayment = false },
            new Patient { Id = 40, PrsNumber = "PRS-040", QuadraMedNumber = "QM-10040", FullNameEn = "Mansour Al-Ghamdi", FullNameAr = "منصور الغامدي", DateOfBirth = new DateTime(1966, 5, 29), Gender = "Male", Nationality = "Saudi", NationalId = "7819202122", Mobile = "0542021222", Email = "man.ghamdi@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2019, 3, 14), AssignedDoctorIds = "1,9", HasNonPayment = false },
            new Patient { Id = 41, PrsNumber = "PRS-041", QuadraMedNumber = "QM-10041", FullNameEn = "Wafa Al-Mutairi", FullNameAr = "وفاء المطيري", DateOfBirth = new DateTime(1993, 8, 17), Gender = "Female", Nationality = "Saudi", NationalId = "8920212223", Mobile = "0552122232", Email = "w.mutairi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 8, 23), AssignedDoctorIds = "6", HasNonPayment = false },
            new Patient { Id = 42, PrsNumber = "PRS-042", QuadraMedNumber = "QM-10042", FullNameEn = "Fahad Al-Anazi", FullNameAr = "فهد العنزي", DateOfBirth = new DateTime(1981, 12, 1), Gender = "Male", Nationality = "Saudi", NationalId = "9021222324", Mobile = "0562223242", Email = "f.anazi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2021, 10, 8), AssignedDoctorIds = "7", HasNonPayment = false },
            new Patient { Id = 43, PrsNumber = "PRS-043", QuadraMedNumber = "QM-10043", FullNameEn = "Raneem Al-Balawi", FullNameAr = "رنيم البلوي", DateOfBirth = new DateTime(2009, 4, 25), Gender = "Female", Nationality = "Saudi", NationalId = "0122232425", Mobile = "0572324252", Email = "ran.balawi@email.com", Category = "Pedo", DateOfFirstVisit = new DateTime(2023, 10, 19), AssignedDoctorIds = "4", HasNonPayment = false },
            new Patient { Id = 44, PrsNumber = "PRS-044", QuadraMedNumber = "QM-10044", FullNameEn = "Jaber Al-Enezi", FullNameAr = "جابر العنزي", DateOfBirth = new DateTime(1974, 9, 13), Gender = "Male", Nationality = "Saudi", NationalId = "1223242526", Mobile = "0582425262", Email = "j.enezi@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2020, 6, 11), AssignedDoctorIds = "5", HasNonPayment = false },
            new Patient { Id = 45, PrsNumber = "PRS-045", QuadraMedNumber = "QM-10045", FullNameEn = "Mona Al-Tamimi", FullNameAr = "منى التميمي", DateOfBirth = new DateTime(1987, 3, 7), Gender = "Female", Nationality = "Saudi", NationalId = "2324252627", Mobile = "0592526272", Email = "mo.tamimi@email.com", Category = "Hygienist", DateOfFirstVisit = new DateTime(2022, 1, 26), AssignedDoctorIds = "6", HasNonPayment = false },
            new Patient { Id = 46, PrsNumber = "PRS-046", QuadraMedNumber = "QM-10046", FullNameEn = "Bander Al-Harthy", FullNameAr = "بندر الحارثي", DateOfBirth = new DateTime(1969, 11, 20), Gender = "Male", Nationality = "Saudi", NationalId = "3425262728", Mobile = "0502627282", Email = "b.harthy@email.com", Category = "OR", DateOfFirstVisit = new DateTime(2021, 4, 5), AssignedDoctorIds = "3", HasNonPayment = false },
            new Patient { Id = 47, PrsNumber = "PRS-047", QuadraMedNumber = "QM-10047", FullNameEn = "Rawan Al-Dosari", FullNameAr = "روان الدوسري", DateOfBirth = new DateTime(2000, 7, 3), Gender = "Female", Nationality = "Saudi", NationalId = "4526272829", Mobile = "0512728292", Email = "rawan.d@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2023, 4, 27), AssignedDoctorIds = "2", HasNonPayment = false },
            new Patient { Id = 48, PrsNumber = "PRS-048", QuadraMedNumber = "QM-10048", FullNameEn = "Majed Al-Shehri", FullNameAr = "ماجد الشهري", DateOfBirth = new DateTime(1985, 6, 16), Gender = "Male", Nationality = "Saudi", NationalId = "5627282930", Mobile = "0522829302", Email = "maj.shehri@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2022, 3, 13), AssignedDoctorIds = "1", HasNonPayment = false },
            new Patient { Id = 49, PrsNumber = "PRS-049", QuadraMedNumber = "QM-10049", FullNameEn = "Farah Al-Qahtani", FullNameAr = "فرح القحطاني", DateOfBirth = new DateTime(1991, 10, 30), Gender = "Female", Nationality = "Saudi", NationalId = "6728293031", Mobile = "0532930312", Email = "farah.q@email.com", Category = "VIP", DateOfFirstVisit = new DateTime(2021, 9, 22), AssignedDoctorIds = "10,18", HasNonPayment = false },
            new Patient { Id = 50, PrsNumber = "PRS-050", QuadraMedNumber = "QM-10050", FullNameEn = "Hassan Al-Amri", FullNameAr = "حسن العمري", DateOfBirth = new DateTime(1978, 2, 11), Gender = "Male", Nationality = "Saudi", NationalId = "7829303132", Mobile = "0543031322", Email = "has.amri@email.com", Category = "Regular", DateOfFirstVisit = new DateTime(2020, 12, 7), AssignedDoctorIds = "7", HasNonPayment = false },
        };

        private static List<Appointment> _appointments = GenerateAppointments();
        public static List<Appointment> Appointments => _appointments;

        private static List<Appointment> GenerateAppointments()
        {
            var today = DateTime.Today;
            var year = today.Year;
            var month = today.Month;
            var slots = new[] { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00" };
            var statuses = new[] { "Scheduled", "Completed", "Cancelled" };
            var rooms = new[] { "VIP 1", "VIP 2", "VIP 3", "Chair 1", "Chair 2", "Chair 3", "OR", "CBCT Room" };
            var appts = new List<Appointment>();
            var rng = new Random(42);
            int id = 1;
            for (int d = 1; d <= 28; d++)
            {
                var date = new DateTime(year, month, d);
                if (date.DayOfWeek == DayOfWeek.Friday || date.DayOfWeek == DayOfWeek.Saturday) continue;
                int count = rng.Next(2, 5);
                for (int i = 0; i < count; i++)
                {
                    var patId = rng.Next(1, 51);
                    var docId = rng.Next(1, 11);
                    var status = date < today ? (rng.Next(0, 5) == 0 ? "Cancelled" : "Completed") : "Scheduled";
                    appts.Add(new Appointment
                    {
                        Id = id++,
                        PatientId = patId,
                        DoctorId = docId,
                        AppointmentDate = date,
                        TimeSlot = slots[rng.Next(slots.Length)],
                        Room = rooms[rng.Next(rooms.Length)],
                        Status = status,
                        Notes = "",
                        NonPaymentFlag = Patients.First(p => p.Id == patId).HasNonPayment
                    });
                }
            }
            // Ensure today has appointments
            for (int i = 0; i < 5; i++)
            {
                appts.Add(new Appointment
                {
                    Id = id++,
                    PatientId = i + 1,
                    DoctorId = i + 1,
                    AppointmentDate = today,
                    TimeSlot = slots[i],
                    Room = rooms[i],
                    Status = "Scheduled",
                    Notes = "Today's appointment",
                    NonPaymentFlag = false
                });
            }
            return appts;
        }

        public static List<PatientVisit> PatientVisits { get; } = new()
        {
            new PatientVisit { Id = 1, PatientId = 1, DoctorId = 1, VisitDate = DateTime.Today.AddDays(-60), Treatment = "Full Examination", NextVisitDate = DateTime.Today.AddDays(30), NextTreatment = "Scaling" },
            new PatientVisit { Id = 2, PatientId = 2, DoctorId = 2, VisitDate = DateTime.Today.AddDays(-45), Treatment = "Orthodontic Check", NextVisitDate = DateTime.Today.AddDays(45), NextTreatment = "Wire Adjustment" },
            new PatientVisit { Id = 3, PatientId = 3, DoctorId = 3, VisitDate = DateTime.Today.AddDays(-30), Treatment = "Wisdom Tooth Extraction", NextVisitDate = DateTime.Today.AddDays(14), NextTreatment = "Post-Op Check" },
            new PatientVisit { Id = 4, PatientId = 4, DoctorId = 4, VisitDate = DateTime.Today.AddDays(-20), Treatment = "Fluoride Treatment", NextVisitDate = DateTime.Today.AddDays(180), NextTreatment = "Routine Check" },
            new PatientVisit { Id = 5, PatientId = 5, DoctorId = 1, VisitDate = DateTime.Today.AddDays(-15), Treatment = "Crown Fitting", NextVisitDate = DateTime.Today.AddDays(7), NextTreatment = "Crown Cementation" },
            new PatientVisit { Id = 6, PatientId = 6, DoctorId = 6, VisitDate = DateTime.Today.AddDays(-10), Treatment = "Deep Cleaning", NextVisitDate = DateTime.Today.AddDays(90), NextTreatment = "Periodontal Maintenance" },
            new PatientVisit { Id = 7, PatientId = 7, DoctorId = 5, VisitDate = DateTime.Today.AddDays(-5), Treatment = "Root Canal Therapy", NextVisitDate = DateTime.Today.AddDays(7), NextTreatment = "Post and Core" },
            new PatientVisit { Id = 8, PatientId = 8, DoctorId = 6, VisitDate = DateTime.Today.AddDays(-8), Treatment = "Oral Hygiene Instruction", NextVisitDate = DateTime.Today.AddDays(90), NextTreatment = "Maintenance" },
            new PatientVisit { Id = 9, PatientId = 9, DoctorId = 1, VisitDate = DateTime.Today.AddDays(-25), Treatment = "Cavity Filling", NextVisitDate = null, NextTreatment = "" },
            new PatientVisit { Id = 10, PatientId = 10, DoctorId = 4, VisitDate = DateTime.Today.AddDays(-12), Treatment = "Space Maintainer", NextVisitDate = DateTime.Today.AddDays(60), NextTreatment = "Check Space" },
            new PatientVisit { Id = 11, PatientId = 11, DoctorId = 3, VisitDate = DateTime.Today.AddDays(-40), Treatment = "Surgical Extraction", NextVisitDate = DateTime.Today.AddDays(3), NextTreatment = "Suture Removal" },
            new PatientVisit { Id = 12, PatientId = 12, DoctorId = 2, VisitDate = DateTime.Today.AddDays(-35), Treatment = "Retainer Fitting", NextVisitDate = DateTime.Today.AddDays(30), NextTreatment = "Retainer Check" },
            new PatientVisit { Id = 13, PatientId = 13, DoctorId = 5, VisitDate = DateTime.Today.AddDays(-18), Treatment = "Root Canal - Molar", NextVisitDate = DateTime.Today.AddDays(14), NextTreatment = "Crown Prep" },
            new PatientVisit { Id = 14, PatientId = 14, DoctorId = 4, VisitDate = DateTime.Today.AddDays(-7), Treatment = "Pediatric Check-Up", NextVisitDate = DateTime.Today.AddDays(180), NextTreatment = "Annual Check-Up" },
            new PatientVisit { Id = 15, PatientId = 15, DoctorId = 9, VisitDate = DateTime.Today.AddDays(-50), Treatment = "Implant Placement", NextVisitDate = DateTime.Today.AddDays(90), NextTreatment = "Osseointegration Check" },
            new PatientVisit { Id = 16, PatientId = 16, DoctorId = 7, VisitDate = DateTime.Today.AddDays(-22), Treatment = "Denture Adjustment", NextVisitDate = DateTime.Today.AddDays(30), NextTreatment = "Denture Review" },
            new PatientVisit { Id = 17, PatientId = 17, DoctorId = 1, VisitDate = DateTime.Today.AddDays(-3), Treatment = "Routine Checkup", NextVisitDate = DateTime.Today.AddDays(180), NextTreatment = "6-Month Recall" },
            new PatientVisit { Id = 18, PatientId = 18, DoctorId = 6, VisitDate = DateTime.Today.AddDays(-14), Treatment = "Scaling and Polishing", NextVisitDate = DateTime.Today.AddDays(90), NextTreatment = "Periodontal Review" },
            new PatientVisit { Id = 19, PatientId = 19, DoctorId = 3, VisitDate = DateTime.Today.AddDays(-55), Treatment = "Jaw Fracture Repair", NextVisitDate = DateTime.Today.AddDays(7), NextTreatment = "Follow-Up" },
            new PatientVisit { Id = 20, PatientId = 20, DoctorId = 2, VisitDate = DateTime.Today.AddDays(-28), Treatment = "Braces Tightening", NextVisitDate = DateTime.Today.AddDays(30), NextTreatment = "Monthly Adjustment" },
        };

        private static int _nextAppointmentId = 200;
        private static int _nextPatientId = 51;

        public static (int todayAppointments, int activePatients, int alerts, int doctorCount) GetDashboardStats()
        {
            var today = DateTime.Today;
            int todayAppts = Appointments.Count(a => a.AppointmentDate.Date == today);
            int activePatients = Patients.Count;
            int alerts = Patients.Count(p => p.HasNonPayment) + Appointments.Count(a => a.NonPaymentFlag && a.Status == "Scheduled");
            return (todayAppts, activePatients, alerts, Doctors.Count);
        }

        public static ApplicationUser? ValidateUser(string username, string password)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);
        }

        public static void AddAppointment(Appointment appt)
        {
            appt.Id = _nextAppointmentId++;
            _appointments.Add(appt);
        }

        public static void AddPatient(Patient patient)
        {
            patient.Id = _nextPatientId++;
            Patients.Add(patient);
        }

        public static void UpdatePatient(Patient updated)
        {
            var existing = Patients.FirstOrDefault(p => p.Id == updated.Id);
            if (existing != null)
            {
                existing.PrsNumber = updated.PrsNumber;
                existing.QuadraMedNumber = updated.QuadraMedNumber;
                existing.FullNameEn = updated.FullNameEn;
                existing.FullNameAr = updated.FullNameAr;
                existing.DateOfBirth = updated.DateOfBirth;
                existing.Gender = updated.Gender;
                existing.Nationality = updated.Nationality;
                existing.NationalId = updated.NationalId;
                existing.Mobile = updated.Mobile;
                existing.Email = updated.Email;
                existing.Category = updated.Category;
                existing.AssignedDoctorIds = updated.AssignedDoctorIds;
                existing.HasNonPayment = updated.HasNonPayment;
            }
        }
    }
}
