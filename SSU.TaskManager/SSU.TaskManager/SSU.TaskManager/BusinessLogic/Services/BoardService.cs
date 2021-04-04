using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Models.Entities;
using SSU.TaskManager.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SSU.TaskManager.Services.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public void Add(Board entity)
        {
            _boardRepository.Add(entity);
        }

        public void Delete(Board entity)
        {
            _boardRepository.Delete(entity);
        }

        public IEnumerable<Board> GetAll()
        {
            return _boardRepository.GetAll();
        }

        public IEnumerable<Board> GetByCondition(Expression<Func<Board, bool>> where)
        {
            return _boardRepository.GetByCondition(where);
        }

        public Board GetById(int id)
        {
            return _boardRepository.GetById(id);
        }

        public void Update(Board entity)
        {
            _boardRepository.Update(entity);
        }
    }
}
