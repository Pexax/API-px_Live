using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pxLiveApi.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}