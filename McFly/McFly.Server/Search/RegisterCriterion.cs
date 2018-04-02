﻿using McFly.Core;

namespace McFly.Server.Search
{
    public abstract class RegisterCriterion : ICriterion
    {
        public Register Register { get; set; }

        protected RegisterCriterion(Register register)
        {
            Register = register;
        }

        public abstract object Accept(ICriterionVisitor visitor);
    }
}