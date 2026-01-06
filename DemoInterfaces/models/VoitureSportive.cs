using DemoInterfaces.Interfaces;

namespace DemoInterfaces.models;

internal class VoitureSportive : Voiture, ISport
{
    private bool _turbo = false;
    public bool IsActivatedTurbo => _turbo;

    public void ToggleTurbo()
    {
        _turbo = !_turbo;
    }
}
