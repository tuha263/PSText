using strange.extensions.context.impl;

public class MainGameRoot : ContextView
{
    private void Awake()
    {
        this.context = new MainGameContext(this, true);
        this.context.Start();
    }
}
