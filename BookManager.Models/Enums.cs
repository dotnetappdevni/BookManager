using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager.Models
{
    public static class Enums
    {
        public enum BookstatusEnum
        {
            Loaned=1,    // 1
            Returned=2,   // 2
            Damaged = 3,    // 3
            
        }

        public enum BookGenreEnum
        {
            Fiction = 1,
            NonFiction=2,
            Mystery=3,
            Thriller=4,
            Romance=5,
            ScienceFiction=6,
            Fantasy=7,
            Horror=8,
            HistoricalFiction =9,
            Biography=10,
            Autobiography=11,
            Memoir=12,
            YoungAdult=13,
            Childrens=14,
            Adventure=15,
            Crime=16,
            Comedy=17,
            Drama=18,
            Poetry=19,
            SelfHelp=20,
            Other = 21
        }

    }
}
