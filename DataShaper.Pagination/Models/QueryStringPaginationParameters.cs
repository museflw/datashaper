using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataShaper.Models;

namespace DataShaper.Pagination.Models
{
    public abstract class QueryStringPaginationParameters : QueryStringParameters
    {
        private const int MaxLimit = 50;
        
        public int Offset { get; set; } = 0;

        private int _limit = 10;

        public int Limit
        {
            get { return _limit; }
            set { _limit = (value > MaxLimit) ? MaxLimit : value; }
        }

        public string OrderBy { get; set; }
    }
}