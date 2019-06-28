using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreSites.DAL.Concrete.EntityFramework
{
    class MyStrategy:DropCreateDatabaseIfModelChanges<MusicStoreDbContext>
    {

    }
}
