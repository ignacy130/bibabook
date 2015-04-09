using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibabook.Implementation.DatabaseContext
{
    public class RepositoryConnection
    {
        private readonly DataBaseContext _context;

        public RepositoryConnection()
        {
            _context = new DataBaseContext();
        }

        public DataBaseContext DataBaseContext { get { return _context; } }
    }
}
