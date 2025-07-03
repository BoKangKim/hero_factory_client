namespace Game.MVP
{
    public interface IPresenter
    {
        // Initialize
        public void Generate(IModel model, IView view);

        // Change Data
        public void OnChangeData(IModelData data);

        // Logic
        public void OnEvent(IEventData eventData);
    }
}