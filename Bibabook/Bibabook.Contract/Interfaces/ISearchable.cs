using System;
using System.Collections.Generic;

namespace Contract
{
    public interface ISearchable
    {
        ICollection<String> Tags { get; set; }
    }
}