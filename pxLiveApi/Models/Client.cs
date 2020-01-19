using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pxLiveApi.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string IpAddres { get; set; }
        public int IsActive { get; set; }
        public virtual Session Session_Id { get; set; }
    }
}