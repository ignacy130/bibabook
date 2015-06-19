using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.Models
{
    public enum AppType
    {
        AppEvent,
        AppUser
    }

    public class SearchItemViewModel
    {
        public AppType Type { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}