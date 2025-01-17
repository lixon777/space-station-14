using System.Threading;

namespace Content.Server.Resist;

[RegisterComponent]
[Access(typeof(ResistLockerSystem))]
public sealed class ResistLockerComponent : Component
{
    /// <summary>
    /// How long will this locker take to kick open, defaults to 2 minutes
    /// </summary>
    [DataField("resistTime")]
    public float ResistTime = 120f;

    /// <summary>
    /// For quick exit if the player attempts to move while already resisting
    /// </summary>
    [ViewVariables]
    public bool IsResisting = false;

    /// <summary>
    /// Used to cancel the DoAfter when a locker is open
    /// </summary>
    public Shared.DoAfter.DoAfter? DoAfter;
}
