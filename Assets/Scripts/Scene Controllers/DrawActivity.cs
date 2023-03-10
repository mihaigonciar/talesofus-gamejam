using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DrawActivity
{
    public abstract void CompleteActivity();
}

public interface IDrawActivity
{
    public abstract void CompleteActivity();
}
