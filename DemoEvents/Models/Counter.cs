namespace DemoEvents.Models;

// Création du délégué pour l'événement
public delegate void ThresholdReached(int counter, int threshold);

public class Counter
{
    protected int _counter;
    protected int _threshold;

    // Création de l'événement à déclencher lorsque la valeur aura atteint le seuil
    public event ThresholdReached ThresholdReached;

    public Counter(int threshold)
    {
        _threshold = threshold;
    }

    public void Increment(int value)
    {
        _counter += value;
        //if (_counter >= _threshold)
        OnThresholdReached();
    }
    
    protected virtual void OnThresholdReached ()
    {
        ThresholdReached?.Invoke(_counter, _threshold);
    }
}
