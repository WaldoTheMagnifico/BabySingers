using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Enitiies;
using Domain.Abstract;
using Domain.DataContext;





namespace Domain.Concrete
{
    public class QuestionRepository : IDataRepo<Question>
    {
        private readonly ApplicationDBContext _context;
        public IQueryable<Question> Items { get { return _context.Questions; } }
        public QuestionRepository(ApplicationDBContext Context)
        {
            _context = Context;
        }

        public async Task<Question> FindAsync(int? Id)
        {
            return await _context.Questions.FindAsync(Id);
        }

        public void Add(Question question)
        {
            _context.Add(question);

            _context.SaveChanges();
        }

        public void Update(Question question)
        {
            _context.Update(question);

            _context.SaveChanges();
        }

        public void Remove(Question question)
        {
            _context.Questions.Remove(question);

            _context.SaveChanges();
        }
    }
}