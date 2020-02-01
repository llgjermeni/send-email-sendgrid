using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SendEmail.Services
{
    public class EmailAuthOptions
    {
        public string SendGridUser { get; set; }
        public string SendGridKey { get; set; }
    }
}
