namespace TmanagerFramework.ServiceInterface.Services
{
    using System;
    using ServiceStack.ServiceInterface;
    using TaskManager.BLL;
    using TaskManager.Common.DTO;
    using TaskManager.ServiceModel.DTO;

    public class AddCategoryService : Service
    {
        readonly private ICategoryBll _categoryBll;
        // readonly private ILogger _logger;
        public AddCategoryService(ICategoryBll categoryBll)
        {
            _categoryBll = categoryBll;
        }

        public bool POST(AddCategoryDto Request)
        {
            try
            {
                var category = new CategoryDto();
                category.CategoryId = Request.Id;
                category.CategoryName = Request.CategoryName;
                return _categoryBll.AddCategory(category);
            }
            catch (Exception e)
            {

                return "Error";
            }
        }

    }
}
