﻿// ======================================
// Author: Roberto Garcia
// Email:  roberto.garcia@transmaquila.com
// ======================================


namespace DAL.Models
{
    public class Department : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
    }
}
