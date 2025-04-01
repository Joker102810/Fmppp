using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}

public class Task
{
    // Public properties with getter and private setter
    public string TaskName { get; private set; }
    public string Description { get; private set; }
    public bool IsComplete { get; private set; }
    public Action OnComplete { get; private set; }

    // Constructor to initialize properties
    public Task(string taskName, string description, Action onComplete)
    {
        TaskName = taskName;
        Description = Description;
        IsComplete = false;
        OnComplete = onComplete;
    }

    // Method to mark the task as complete
    public void CompleteTask()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            // Invoke the action when the task is completed
            OnComplete?.Invoke();
        }
    }

    
}