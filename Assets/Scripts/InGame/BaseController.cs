

public abstract class BaseController {
    public abstract void Start();
    public abstract void Update();
    public abstract void FixedUpdate();
    public abstract void LateUpdate();
    public abstract void OnDestroy();

    // Add any common functionality or properties that all controllers should have
}