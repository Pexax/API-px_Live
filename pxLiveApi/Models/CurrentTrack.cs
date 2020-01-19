using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pxLiveApi.Models
{
    public class CurrentTrack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Length { get; set; }
        public string Stop { get; set; }
        public int IsPlay { get; set; }
        public virtual Session Session_Id { get; set; }
    }
}