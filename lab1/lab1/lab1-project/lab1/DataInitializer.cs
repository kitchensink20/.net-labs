using lab1.Classes;
using System.Collections.Generic;
using System;

namespace lab1
{
    public class DataInitializer : IDataInitializer
    {
        public DataInitializer(IDataContext context) 
        {
            this.Context = context;
        }

        public IDataContext Context { get; set; }

        public void InitializeWithData()
        {
            Context.Supervisors = new List<GraduateSupervisor>()
            {
                new GraduateSupervisor()
                {
                    Id = 1,
                    FullName = "Вербицька Марiя Вiкторiвна",
                    Position = "Завiдувач кафедри"
                },
                new GraduateSupervisor()
                {
                    Id= 2,
                    FullName = "Шевченко Наталя Сергiївна",
                    Position = "Викладач"
                },
                new GraduateSupervisor()
                {
                    Id= 3,
                    FullName = "Петренко Максим Вiкторович",
                    Position = "Викладач"
                },
                new GraduateSupervisor()
                {
                    Id= 4,
                    FullName = "Коган Ярослав Станiславович",
                    Position = "Викладач"
                },
                new GraduateSupervisor()
                {
                    Id= 5,
                    FullName = "Мельник СергIй Iгорович",
                    Position = "Декан"
                },
                new GraduateSupervisor()
                {
                    Id= 6,
                    FullName = "Сидоренко Iрина Миколаївна",
                    Position = "Викладач"
                }
            };

            Context.Students = new List<GraduateStudent>()
            {
                new GraduateStudent()
                {
                    FullName = "Литовченко Алiна Олександрiвна",
                    GroupNumber = "IC-11",
                    BirthDate = new DateTime(2004, 6, 20),
                    AverageScore = 93.3,
                    SupervisorId = 1,
                },
                new GraduateStudent()
                {
                    FullName = "Iвасiшина Анна Григорiвна",
                    GroupNumber = "IC-11",
                    BirthDate = new DateTime(2004, 2, 23),
                    AverageScore = 95.1,
                    SupervisorId = 1
                },
                new GraduateStudent()
                {
                    FullName = "Толкунов Iван Сергiйович",
                    GroupNumber = "IK-03",
                    BirthDate = new DateTime(2001, 7, 7),
                    AverageScore = 97.2,
                    SupervisorId = 4,
                },
                new GraduateStudent()
                {
                    FullName = "Шелест Полiна Михайлiвна",
                    GroupNumber = "IC-11",
                    BirthDate = new DateTime(2004, 1, 18),
                    AverageScore = 88.2,
                    SupervisorId = 3
                },
                new GraduateStudent()
                {
                    FullName = "Попадiна Юлiя Юр'ївна",
                    GroupNumber = "IC-02",
                    BirthDate = new DateTime(2004, 7, 16),
                    AverageScore = 89.3,
                    SupervisorId = 1
                },
                new GraduateStudent()
                {
                    FullName = "Коломойченко Катерина Дмитрiвна",
                    GroupNumber = "IC-12",
                    BirthDate = new DateTime(2003, 12, 4),
                    AverageScore = 82.1,
                    SupervisorId = 6
                },
                new GraduateStudent()
                {
                    FullName = "Антропова Софiя Леонiдiвна",
                    GroupNumber = "IC-02",
                    BirthDate = new DateTime(2004, 3, 7),
                    AverageScore = 90.9,
                    SupervisorId = 3
                },
                new GraduateStudent()
                {
                    FullName = "Рiвний Станiслав Станiславович",
                    GroupNumber = "IC-11",
                    BirthDate = new DateTime(2003, 9, 22),
                    AverageScore = 73.1,
                    SupervisorId = 4
                },
                new GraduateStudent()
                {
                    FullName = "Чорна Таiсiя Станiславiвна",
                    GroupNumber = "IC-11",
                    BirthDate = new DateTime(2004, 4, 20),
                    AverageScore = 67.9,
                    SupervisorId= 2
                },
                new GraduateStudent()
                {
                    FullName = "Зiбро Каспер Андрiйович",
                    GroupNumber = "IC-11",
                    BirthDate = new DateTime(2003, 5, 17),
                    AverageScore = 86.9,
                    SupervisorId = 3
                },
                new GraduateStudent()
                {
                    FullName = "Базований Мiхаль Миколайович",
                    GroupNumber = "IC-12",
                    BirthDate = new DateTime(2002, 1, 10),
                    AverageScore = 97.7,
                    SupervisorId = 4
                },
                new GraduateStudent()
                {
                    FullName = "Тріпак Артем Ігорович",
                    GroupNumber = "IC-02",
                    BirthDate = new DateTime(2004, 4, 15),
                    AverageScore = 90.7,
                }
            };
        }
    }
}
