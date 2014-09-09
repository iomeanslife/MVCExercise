using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCExerciseTry1.Models
{
    public class Character
    {
        public int Id { get; set; }
        public int SkillsId { set; get; }
        public String FirstName { set; get; }
        public String SurName { set; get; }
        public DateTime Birthyear { set; get; }
        public String Interessts { set; get; }
        public String Aspirations { set; get; }
        public float Height { set; get; }
        public float Weight { set; get; }
    }

    public class Skill
    {
        public int ID { get; set; }
        public String Title { set; get; }
    }

    public class PersonDbContext : DbContext
    {
        public Character Character { set; get; }
        //public DbSet<MVCExerciseTry1.Models.Skill> Skills {get;set;}

    }
}