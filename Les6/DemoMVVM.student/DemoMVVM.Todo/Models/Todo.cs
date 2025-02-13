﻿using Odisee.Common;


namespace DemoMVVM.Todo.Models
{
    internal class Todo: ObservableObject
    {
        private Guid id;
        private string? title;
        private DateTime? dueDate;
        private bool _checked;

        public Todo()
        {
            Id = Guid.NewGuid();
        }
        public Todo(Todo selectedTodo)
        {
            Id = selectedTodo.Id; 
            Title = selectedTodo.Title;
            DueDate = selectedTodo.DueDate;
            Checked = selectedTodo.Checked;
        }

        public string? Title { get => title; set => SetProperty(ref title, value); }
        public DateTime? DueDate { get => dueDate; set => SetProperty(ref dueDate, value); }
        public bool Checked { get => _checked; set => SetProperty(ref _checked, value); }
        public Guid Id { get => id; set => id = value; }
    }
}
