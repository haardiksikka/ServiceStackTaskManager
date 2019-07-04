namespace TmanagerFramework.ServiceInterface.Services
{
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.ServiceModel.DTO;

    public class GetCategoriesService : Service
    {
        private readonly ICategoryBll _category;
        public GetCategoriesService(ICategoryBll category)
        {
            _category = category;
        }

        public object GET(GetCategoriesDto Request)
        {
            try
            {
                return _category.GetAllCategory();
            }
            catch (System.Exception)
            {

                return "Error";
            }
        }
    }
}
