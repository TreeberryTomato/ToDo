﻿using System;


namespace OrangeToDo_Server
{

    class Task
    {
        private string _content;
        private DateTime _startDateTime;
        private DateTime _deadLine;
        private bool _isDone;
        private int _priorityLevel;
        private string _taskID;

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        public DateTime StartDateTime
        {
            get
            {
                return _startDateTime;
            }
            set
            {
                _startDateTime = value;
            }
        }

        public DateTime DeadLine
        {
            get
            {
                return _deadLine;
            }

            set
            {
                _deadLine = value;
            }
        }

        public bool IsDone
        {
            get
            {
                return _isDone;
            }
            
            set
            {
                _isDone = value;
            }
        }

        public int PriorityLevel
        {
            get
            {
                return _priorityLevel;
            }
            set
            {
                _priorityLevel = value;
            }
        }

        public string TaskID
		{
			get
			{
                return _taskID;
			}
            set
			{
                _taskID = value;
			}
		}

        public Task()
        {
            this.Content = "";
            this.StartDateTime = DateTime.Now.ToLocalTime();
            this.DeadLine = this.StartDateTime.AddDays(1);
            this.IsDone = false;
            this.PriorityLevel = 0;
            this.TaskID = Guid.NewGuid().ToString();
        }

        public Task(string content, DateTime startDateTime, DateTime deadLine, bool isDone, int priorityLevel, string taskID)
        {
            this.Content = content;
            this.StartDateTime = startDateTime;
            this.DeadLine = deadLine;
            this.IsDone = isDone;
            this.PriorityLevel = priorityLevel;
            this.TaskID = taskID;
        }
    }
}
