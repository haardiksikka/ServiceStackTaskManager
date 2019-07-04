namespace TaskManager.BLL
{
    using System;
    using System.Collections.Generic;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Repository;

    public class CategoryBll : ICategoryBll
    {
        private readonly ICategoryDal _category;
        public CategoryBll(ICategoryDal category)
        {
            _category = category;
        }

        public bool AddCategory(CategoryDto categoryDto)
        {
            try
            {
                return _category.AddCategory(categoryDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<CategoryDto> GetAllCategory()
        {
            try
            {
                return _category.GetAllCategories();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
