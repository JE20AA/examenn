using System;
namespace examen;

public abstract class Abstract
{
    protected Abstract k = null;

    public AbstractCoffee(Abstract k)
    {
        this.k = k;
    }

    public abstract string ShowCoffee();
}