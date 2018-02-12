namespace BashSoft.IO.Commands
{
    using System;
    using Execptions;
    using BashSoft.Contracts;
    using BashSoft.Attributes;

    public abstract class Command : IExecutable
    {
        private string input;
        private string[] data;

        [Inject]
        private IContentComparer judge;

        [Inject]
        private IDatabase repository;

        [Inject]
        private IDirectoryManager inputOutputManager;

        protected Command(string input, string[] data)
        {
            this.Input = input;
            this.Data = data;
        }

        public string[] Data
        {
            get
            {
                return this.data;
            }

            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }

                this.data = value;
            }
        }  

        public string Input
        {
            get
            {
                return this.input;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.input = value;
            }
        }

        protected IContentComparer Judge
        {
            get { return this.judge; }
        }

        protected IDatabase Repository
        {
            get { return this.repository; }
        }

        protected IDirectoryManager InputOutputManager
        {
            get { return this.inputOutputManager; }
        }

        public abstract void Execute();
    }
}
