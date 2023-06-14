﻿namespace PostgreSqlAsp.Models
{
    public class User 
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Image { get; set; } = "";
    }
}
