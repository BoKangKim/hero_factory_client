namespace Game.MVP
{
    public interface IEventData
    { 
    }

    public interface IView
    {
        public void UpdateView(IModelData data);
    }
}