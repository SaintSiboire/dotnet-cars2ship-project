using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars2Ship.Shared.Models;
using System.Data.Entity;

namespace Cars2Ship.Shared.Data
{
    public class DealersRepository : BaseRepository<Dealer>
    {
        public DealersRepository(Context context)
            : base(context) { }

        public override Dealer Get(int id, string userId, bool includeRelatedEntities = true)
        {
            var dealer = Context.Dealers.AsQueryable();

            return dealer
                        .Where(i => i.Id == id && i.UserId == userId)
                        .SingleOrDefault();
        }

        public Dealer GetLast(bool includeRelatedEntities = true)
        {
            var dealer = Context.Dealers.AsQueryable();


            return dealer
                .OrderByDescending(i => i.Id)
                .FirstOrDefault();
        }

        public Dealer GetById(int id)
        {
            var dealer = Context.Dealers.AsQueryable();


            return dealer
                .Where(i => i.Id == id)
                .SingleOrDefault();
        }


        public override IList<Dealer> GetList(string userId)
        {
            return Context.Dealers
                        .Where(i => i.UserId == userId)
                        .OrderBy(i => i.Id)
                        .ToList();
        }

        public IList<Dealer> GetAll()
        {
            return Context.Dealers

                        .OrderBy(i => i.Id)
                        .ToList();
        }
    }
}
