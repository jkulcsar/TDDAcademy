namespace TddAcademy
{
    using System;

    public interface IInstrument
    {
        void Execute(string task);

        event EventHandler<TaskEventArgs> Finished;
        event EventHandler<TaskEventArgs> Error;
    }
}