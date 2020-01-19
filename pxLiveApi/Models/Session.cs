using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pxLiveApi.Models
{
    public class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Link { get; set; }
        public virtual Users User_Id { get; set; }
    }
}