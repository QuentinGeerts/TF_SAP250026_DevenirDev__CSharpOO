namespace DemoEvents.Models;

internal class SubCounter : Counter
{
    public SubCounter(int threshold) : base(threshold)
    {
    }

    protected override void OnThresholdReached()
    {
        // Déclenchement par l'enfant de l'événément prévu dans le parent
        base.OnThresholdReached();
    }
}
