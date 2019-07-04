namespace TaskManager.DAL.Repository
{
    using System.Collections.Generic;
    using TaskManager.Common.DTO;

    public interface ICategoryDal
    {
        bool AddCategory(CategoryDto categoryDto);
        IEnumerable<CategoryDto> GetAllCategories();
    }
}