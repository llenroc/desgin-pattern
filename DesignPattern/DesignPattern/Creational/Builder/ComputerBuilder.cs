﻿namespace DesignPattern.Creational.Builder
{
    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }

        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildHardDisk();
        public abstract void BuildScreen();
    }
}
