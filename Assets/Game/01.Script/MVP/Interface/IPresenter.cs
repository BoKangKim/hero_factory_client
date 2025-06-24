namespace Game.MVP
{
    public interface IPresenter<TModel, TView> where TModel : IModel where TView : IView
    {
        // Initialize
        public void Generate(TModel model, TView view);

        // Change Data
        public void OnChangeData(IModelData data);

        // Logic
        public void OnEvent(IEventData eventData);
    }
}