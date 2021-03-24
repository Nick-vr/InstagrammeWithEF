using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagrammeWithEF.Data.Repositories
{
    internal class PostRepo
    {
        private InstagrammeContext _context;

        public PostRepo()
        {
            _context = new InstagrammeContext();
        }
    }
}