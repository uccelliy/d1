

public abstract class BaseStateMchine {

    protected BaseController owner;

    public BaseStateMchine(BaseController owner)
    {
        this.owner = owner;
    }   
    // Start is called before the first frame update
    public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
    
 
}
