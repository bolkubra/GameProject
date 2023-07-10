using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Gamer : IEntitys
    {

        public Gamer(int Id, string gamername, string gamerlastname, DateTime dateOfbirth, long nationalityId) 
        {
            GamerId = Id;
            GamerName = gamername;
            GamerLastName= gamerlastname;
            DateOfBrith = dateOfbirth;
            NationalityId = nationalityId;
        }
        public int GamerId { get; set; }
        public string GamerName { get; set; }
        public string GamerLastName { get; set; }
        public DateTime DateOfBrith { get; set; }
        public long NationalityId { get; set; }
    }
}
