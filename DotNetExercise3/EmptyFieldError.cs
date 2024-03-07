namespace DotNetExercise3
{
    internal class EmptyFieldError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to submit the form with a required field empty.  This fired an error!";
        }
    }
}
