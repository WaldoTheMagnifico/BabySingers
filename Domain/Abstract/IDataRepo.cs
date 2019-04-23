using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Enitiies;
using System.Text;



namespace Domain.Abstract
{
    public interface IDataRepo<T>
    {
        IQueryable<T> Items { get; }

        Task<T> FindAsync(int? Id);
    }
}