using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choresmanagement.Services
{
    public class ChoresService
    {
        private readonly ChoresRepository _repo;

        public ChoresService(ChoresRepository repo)
        {
            _repo = repo;
        }

        internal List<Chore> Get()
        {
            List<Chore> chores = _repo.Get();
            return chores;
        }
    }
}