﻿using System;

namespace MovieReview.Core.Domain.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}