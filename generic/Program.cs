namespace generic
{
    internal class Program
    {
        class arr<T>
        {
            private T[] _items;

           public void Add(T item)
            {
                if (_items == null)
                {
                    //new Array
                    _items= new T[] { item};

                }
                else
                {

                    int length= _items.Length;
                    //length +1 ( to add more element)
                    T[] temp = new T[length+1];
                    //to enter the new elements
                    for (int i = 0; i < length; i++)
                    {
                        temp[i] = _items[i];
                    }
                    temp[length] = item;
                    _items = temp;

                }
            }

            public void Remove(int index)
            {
                T[] TEMP=new T[_items.Length-1];
                int pos = 0;
                for(int i=0;i<_items.Length;i++)
                {
                    if(i==index)
                    {
                        continue;
                    }
                    TEMP[pos++] = _items[i];


                }
                _items = TEMP;
            }

            public void IsEmpty()
            {
                if (_items.Length==0)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    Console.WriteLine("Not Empty");

                }
            }

            public void Reverse()
            {
                T[] temp = new T[_items.Length];
                int j = 0;
                for (int i = _items.Length - 1; i >= 0; i--)
                {
                    temp[i] = _items[j];
                    j++;
                }
                _items = temp;
            }

            public void display()
            {
                foreach(T item in _items)
                {
                    Console.WriteLine(item+"");
                }
            }

        }
        static void Main(string[] args)
        {
            arr<int> numbers= new arr<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Remove(1);
            numbers.display();
            numbers.Reverse();
            numbers.IsEmpty();
        }
    }
}