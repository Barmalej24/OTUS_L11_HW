namespace OTUS_L11_HW
{
    public class Stack
    {
        private List<string> _stack;
        public int Size => _stack.Count;
        public string? Top => _stack.Count != 0 ? _stack.Last().ToString() : null;

        public Stack(params string[] _strings)
        {
            _stack = new List<string>(_strings);
        }

        public void Add(params string[] _strings)
        {
            _stack.AddRange(_strings);
        }

        public string? Pop()
        {
            if (_stack.Count == 0)
                return null;

            var _item = _stack.Last();
            _stack.RemoveAt(_stack.Count - 1);
            return _item;
        }

        public static Stack Concat(params Stack[] _stacks)
        {
            var _result = new Stack();

            foreach (var item in _stacks)
            {
                var _temp = new List<string> { };
                item._stack.ForEach(i => _temp.Add(i));
                _temp.Reverse();
                _temp.ForEach(i => _result.Add(i));
            }

            return _result;
        }

    }
}
