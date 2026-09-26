namespace backend;

public class StackUsingArray<T>
{
  private T[] _stack;
  private int _top;

    //constructor
    // tamaño de la pila
  public StackUsingArray(int capacity)
  {
    _stack = new T[capacity];
    _top = -1;
  }

  public void Push(T item)
  {
    _top++;
    _stack[_top] = item;
  }

  public T Pop()
  {
    T item = _stack[_top];
    _top--;
    return item;
  }

  public T Peek()
  {
    return _stack[_top];
  }

  public bool IsEmpty()
  {
    return _top == -1;
  }
}
