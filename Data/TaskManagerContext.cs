using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext (DbContextOptions<TaskManagerContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManager.Models.TaskItem> TaskItem { get; set; } = default!;
    }
