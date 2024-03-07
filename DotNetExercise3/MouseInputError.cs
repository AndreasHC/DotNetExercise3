namespace DotNetExercise3
{
    internal class MouseInputError : UserError
    {
        public override string UEMessage()
        {
            return "You by God-knows-what means tried to use a text input in a mouse gesture field. This fired an error!";
        }
    }
}
