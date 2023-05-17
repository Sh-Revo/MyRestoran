using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IHasProgress
{
    public event EventHandler<OnProgressEventChangedArgs> OnProgressChanged;
    public class OnProgressEventChangedArgs : EventArgs
    {
        public float progressNormalized;
    }
}
