﻿using Microsoft.Azure.Mobile.Server;

namespace a9todolist2Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public string Text2 { get; set; }

        public bool Complete { get; set; }
    }
}