using lab2.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace lab2
{
    public class XmlSerializerModel
    {
        [XmlRoot("GraduateStudents")]
        public class GraduateStudents
        {
            [XmlElement("GraduateStudent")]
            public List<GraduateStudent> Students { get; set; }
        }

        public List<GraduateStudent> GetGraduateStudents(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GraduateStudents));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                GraduateStudents students = (GraduateStudents)xmlSerializer.Deserialize(fileStream);
                return students.Students;
            }
        }

        [XmlRoot("GraduateSupervisors")]
        public class GraduateSupervisors
        {
            [XmlElement("GraduateSupervisor")]
            public List<GraduateSupervisor> Supervisors { get; set; }
        }

        public List<GraduateSupervisor> GetGraduateSupervisors(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GraduateSupervisors));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                GraduateSupervisors supervisors = (GraduateSupervisors)xmlSerializer.Deserialize(fileStream);
                return supervisors.Supervisors;
            }
        }
    }
}

/*  
    Атрибути:
    XmlRoot(string value) атрибут визначає, що корневий елемент XML документу має бути десереалізований
    як вказане значення. 
    XmlElement(string value) атрибут визначає, що кожен елемент корневого елементу має бути
    десереалізованим як вказане значення.

    XmlSerializer це клас, що використовується для того, щоб конвертувати об'єкти в XML і навпаки.
    Надає 2 основні методи: Serialize i Deserialize. 
    Використовує атрибути для того, щоб вказувати як об'єкти будуть серіалізовані та десереалізовані.
    Щоб створити XmlSerializer єкземляр необхідно в конструкторі вказати тип об'єкту, з яким ви 
    будете працювати.

    FileStream це клас, що використовується для того щоб виконувати операції вводу та виводу відносно
    файлів. Надає спосіб створити потік, який може бути використано для читання або запису файлів.
    Одна з перегрузок його конструктору приймає 2 параметри: шлях до файлу і FileMode enum, що вказує
    як файл має бути відкрито або створено(Open - відкриває існуючий файл, Create - створює новий
    файл або перезаписує вже існуючий, Append - створює новий файл або додає нові дані з кінця вже існуючого).
    Cтворення FileStream об'єкту необхідно помістити в using блок, щоб переконатися, що поток належно
    зупинено і утилізовано, коли виконання коду залишає блок, навіть якщо під час виконання виникає виняткова
    ситуація. Це важливо, бо FileStream імлементує IDisposable.
 */