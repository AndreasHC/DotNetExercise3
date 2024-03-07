namespace DotNetExercise3
{
    internal class CheckboxInputError : UserError
    {
        public override string UEMessage()
        {
            return "You somehow tried to use a text input in a checkbox field. This fired an error!";
        }
    }
}
