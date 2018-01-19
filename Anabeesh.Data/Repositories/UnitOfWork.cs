using Anabeesh.Data.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Data.Repositories
{
    public class UnitOfWork
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private Repository<Question> questionRepository;
        public UnitOfWork()
        {
            questionRepository = new Repository<Question>(context);
        }

        public Repository<Question> QuestionRepository
        {
            get
            {
                return questionRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
