using Anabeesh.Data;
using Anabeesh.Data.Questions;
using Anabeesh.Data.Repositories;
using Anabeesh.DTO.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anabeesh.Services.Questions
{
    public class QuestionsService
    {
        private readonly UnitOfWork _unitOfWork;

        public QuestionsService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public CreateQuestionDto CreateQuestion(CreateQuestionDto dto)
        {
            Question question = new Question
            {
                Headline = dto.Headline,
                Description = dto.Description,
                CreationTime = DateTime.Now,
                IsDeleted = false,
                SubCategoryId = dto.SubCategoryId,
                MainCategoryId = dto.MainCategoryId,
                Upvotes = 0,
                Downvotes = 0,
                UserId = dto.UserId,
                NumberOfAnswers = 0,
                ModificationTime = DateTime.Now
            };
            var result = _unitOfWork.QuestionRepository.Insert(question);
            _unitOfWork.Save();
            dto.Id = result.Id;
            return dto;
        }


        public bool DeleteQuestion (long id)
        {
            var question = _unitOfWork.QuestionRepository.GetById(id);
            if (question == null) return false;
            question.IsDeleted = true;
            _unitOfWork.QuestionRepository.Update(question);
            return true;
        }


        public GetQuestionDto GetQuestionById (long id)
        {
            var question = _unitOfWork.QuestionRepository.GetById(id);
            if (question == null) return null;
            GetQuestionDto questionDto = new GetQuestionDto
            {
                Id = question.Id,
                Description = question.Description,
                Downvotes = question.Downvotes,
                Headline = question.Headline,
                MainCategoryId = question.MainCategoryId,
                NumberOfAnswers = question.NumberOfAnswers,
                SubCategoryId = question.SubCategoryId,
                Upvotes = question.Upvotes,
                UserId = question.UserId
            };
            return questionDto;
        }

        // Check pageSize from youssef
        public List<GetQuestionDto> ListQuestions(int page, int pageSize)
        {
            var questions = _unitOfWork.QuestionRepository.GetList(page, pageSize).ToList();
            var questionsResult = new List<GetQuestionDto>();

            foreach (var question in questions)
            {
                GetQuestionDto questionDto = new GetQuestionDto
                {
                    Id = question.Id,
                    Description = question.Description,
                    Downvotes = question.Downvotes,
                    Headline = question.Headline,
                    MainCategoryId = question.MainCategoryId,
                    NumberOfAnswers = question.NumberOfAnswers,
                    SubCategoryId = question.SubCategoryId,
                    Upvotes = question.Upvotes,
                    UserId = question.UserId
                };
                questionsResult.Add(questionDto);
            }
            return questionsResult;
        }

        public bool UpdateQuestion (UpdateQuestionDto dto)
        {
            var question = _unitOfWork.QuestionRepository.GetById(dto.Id);
            if (question == null) return false;
            question.Headline = dto.Headline;
            question.Description = dto.Description;
            question.Upvotes = dto.Upvotes;
            _unitOfWork.QuestionRepository.Update(question);
            return true;
        }

    }
}
