namespace DemoEvents.Models;

// Création du délégué pour l'événement
public delegate void ThresholdReached(int counter, int threshold);
public delegate string ThresholdReachedWithReturn(int count, float threshold);

public class Counter
{
    protected int _counter;
    protected int _threshold;

    // Création de l'événement à déclencher lorsque la valeur aura atteint le seuil
    public event ThresholdReached ThresholdReached;
    public event Action<int, int> ThresholdReachedAction;
    public event Func<int, float, string> ThresholdReachedFunc;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    public virtual void Increment(int value)
    {
        _counter += value;
        OnThresholdReached();
    }
    
    protected void OnThresholdReached ()
    {
        ThresholdReached?.Invoke(_counter, _threshold);
    }
}
