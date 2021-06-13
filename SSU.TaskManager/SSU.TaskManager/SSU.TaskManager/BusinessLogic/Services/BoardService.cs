using SSU.TaskManager.BusinessLogic.ServiceInterface;
using SSU.TaskManager.Models.DaoInterface;
using SSU.TaskManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace SSU.TaskManager.BusinessLogic.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public IEnumerable<Board> GetAll()
        {
            return _boardRepository.GetAll();
        }

        public IEnumerable<Board> GetByCondition(Func<Board, bool> where)
        {
            return _boardRepository.GetAll().Where(where);
        }

        public Board GetById(int id)
        {
            return _boardRepository.GetById(id);
        }
    }
}
