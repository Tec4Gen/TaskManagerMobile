﻿using Microsoft.Data.Sqlite;
using SSU.TaskManager.Entities;
using SSU.TaskManager.Models.DaoInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SSU.TaskManager.Models.DaoImplementation
{
    public class BoardDao : IBoardRepository
    {
        private readonly string _connectionString;
        private readonly ITaskRepository _taskRepository;

        public BoardDao()
        {
            _connectionString = AppSettings.ConnectionString;
            _taskRepository = new TaskDao();
        }

        public IEnumerable<Board> GetAll()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string queryString = "select * from Board";

                var command = new SqliteCommand(queryString, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new Board
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = Convert.ToString(reader["Title"]),
                            Tasks = _taskRepository.GetAll().Where(t => t.BoardId == Convert.ToInt32(reader["Id"])).ToList()
                        };
                    }
                }
            }
        }

        public Board GetById(int id)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();

                string queryString = $"select * from Board where Id='{id}'";

                var command = new SqliteCommand(queryString, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new Board
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = Convert.ToString(reader["Title"]),
                            Tasks = _taskRepository.GetAll().Where(t => t.BoardId == Convert.ToInt32(reader["Id"])).ToList()
                        };
                    }
                }
                throw new Exception($"Board with Id={id} doesn't exist");
            }
        }
    }
}
