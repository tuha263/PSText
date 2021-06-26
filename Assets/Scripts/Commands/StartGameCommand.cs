namespace Commands
{
    using strange.extensions.command.impl;
    using strange.extensions.signal.impl;
    using UnityEngine;

    public class StartGameSignal : Signal
    {
    }

    public class StartGameCommand : Command
    {
        public override void Execute() { Debug.Log("Start Game"); }
    }
}