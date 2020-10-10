using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    public class tblPhoto
    {
        public int Id {get;set;}

        public string Url{get;set;}

        public string Description{get;set;}

        public DateTime DateAdded{get;set;}

        public bool IsMain{get;set;}

        public tblUser Users{get;set;}

        [ForeignKey("tblUser")]
        public int UserId {get;set;}
    }
}