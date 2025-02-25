﻿using System;

namespace SimpleBotCore.Logic
{
    public class SimpleUser
    {
        public string Id { get; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cor { get; set; }
        public SimpleUser() { }

        public SimpleUser(string userId)
        {
            this.Id = userId ?? throw new ArgumentNullException(nameof(userId));
        }
    }
}