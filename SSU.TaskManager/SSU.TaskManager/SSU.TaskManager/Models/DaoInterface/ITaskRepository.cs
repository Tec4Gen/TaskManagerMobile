using SSU.TaskManager.Entities;

namespace SSU.TaskManager.Models.DaoInterface
{
    public interface ITaskRepository: IRepository<Task>
    {
        void SwitchBoard(Task task, Board newBoard);
    }
}
