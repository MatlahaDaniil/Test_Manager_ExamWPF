using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{

    [Table(Name = "Teacher")]
    class TeacherTable
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Login")]
        public string Login { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }

        [Column(Name = "Fullname")]
        public string Fullname { get; set; }

        [Column(Name = "Email")]
        public string Email { get; set; }

        [Column(Name = "PhoneNum")]
        public string PhoneNum { get; set; }

        [Column(Name = "SchoolNum")]
        public string SchoolNum { get; set; }

        [Column(Name = "ProfileIcon")]
        public byte[] ProfileIcon { get; set; }
    }

    [Table(Name = "Student")]
    class StudentTable
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Login")]
        public string Login { get; set; }

        [Column(Name = "Password")]
        public string Password { get; set; }

        [Column(Name = "Fullname")]
        public string Fullname { get; set; }

        [Column(Name = "Email")]
        public string Email { get; set; }

        [Column(Name = "PhoneNum")]
        public string PhoneNum { get; set; }

        [Column(Name = "ClassNum")]
        public string ClassNum { get; set; }

        [Column(Name = "SchoolNum")]
        public string SchoolNum { get; set; }

        [Column(Name = "ProfileIcon")]
        public byte[] ProfileIcon { get; set; }
    }

}
