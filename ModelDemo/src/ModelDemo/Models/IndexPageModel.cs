using System;

namespace ModelDemo.Models
{
    public class IndexPageModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public DateTime CurrentTime { get; set; }
    }
}
