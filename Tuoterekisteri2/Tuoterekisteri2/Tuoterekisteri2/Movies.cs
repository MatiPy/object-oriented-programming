using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace HarjoitusTyo2
{
    class Movies
    {
        public string title { get; set; }
        public string year { get; set; }
        public List<object> cast { get; set; }
        public string genre { get; set; }
    }
}
