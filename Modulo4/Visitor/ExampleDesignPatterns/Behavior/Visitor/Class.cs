﻿namespace Visitor
{
    public class Class : Visitable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentName { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
