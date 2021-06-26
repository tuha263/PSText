using Commands;
using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.impl;
using UnityEngine;

public class MainGameContext : MVCSContext
{
    public MainGameContext() : base() { }
    public MainGameContext(MonoBehaviour view, bool autoStartUp) : base(view, autoStartUp) { }

    protected override void addCoreComponents()
    {
        base.addCoreComponents();
        this.injectionBinder.Unbind<ICommandBinder>();
        this.injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
    }

    public override void Launch()
    {
        base.Launch();
        var startGameSignal = this.injectionBinder.GetInstance<StartGameSignal>();
        startGameSignal.Dispatch();
    }

    protected override void mapBindings()
    {
        //Services binding
        
        //View binding
        
        //Commands binding
        this.commandBinder.Bind<StartGameSignal>().To<StartGameCommand>().Once();
    }
}