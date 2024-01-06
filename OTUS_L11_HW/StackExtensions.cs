namespace OTUS_L11_HW
{
    public static class StackExtensions
    {
        public static void Merge(this Stack stack, Stack addStack)
        {
            for (var i = 0; addStack.Size != 0; i++)
            {
                stack.Add(addStack.Pop());
            }

        }
    }
}
