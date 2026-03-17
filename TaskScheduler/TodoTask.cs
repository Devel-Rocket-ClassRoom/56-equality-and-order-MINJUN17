using System;
using System.Collections.Generic;
using System.Text;

class TodoTask: IComparable<TodoTask>
{
    public string Title;
    public int Priority;
    public string DueDate;
    public bool IsCompleted;
    public TodoTask(string title, int priority, string dueDate, bool isCompleted)
    {
        Title = title;
        Priority = priority;
        DueDate = dueDate;
        IsCompleted = isCompleted;
    }
    public override string ToString()
    {
        return $"[우선순위 {Priority}] {Title} (마감: {DueDate})";
    }
    public int CompareTo(TodoTask other)
    {
        if(other == null)
        {
            return 1;
        }
        if(Priority.CompareTo(other.Priority) != 0)
        {
            return Priority.CompareTo(other.Priority);
        }
        
    }
}
