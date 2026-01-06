namespace DemoEvents.Models;

internal class SubCounter : Counter
{
    public SubCounter(int threshold) : base(threshold)
    {
    }

    public override void Increment(int value)
    {
        _counter += value;
        if (_counter >= _threshold)
        {
            OnThresholdReached();
        }
    }

    
}
