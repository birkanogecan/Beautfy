using Beautfy.Models.DataModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautfy.Services
{
    public class TaskService
    {
        SQLiteConnection conn;
        public TaskService()
        {
            conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Task.db3"));
            conn.CreateTable<TaskEntity>();
        }

        public int AddTask(TaskEntity task)
        {
            return conn.Insert(task);
        }
        public int UpdateTask(TaskEntity task)
        {
            return conn.Update(task);
        }
        public TaskEntity GetTaskByID(int taskId)
        {
            var task = conn.Query<TaskEntity>($"Select * From {nameof(TaskEntity)} where Id={taskId} ");
            return task.FirstOrDefault();
        }
        public List<TaskEntity> GetTasksByRutinId(int rutinId)
        {
           return conn.Query<TaskEntity>($"Select * From {nameof(TaskEntity)} where RutinId={rutinId} ");
        }

    }
}
