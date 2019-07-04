using System.Collections.Generic;
using TaskManager.Common.DTO;

namespace TaskManager.BLL
{
    public interface ICategoryBll
    {
        bool AddCategory(CategoryDto categoryDto);
        IEnumerable<CategoryDto> GetAllCategory();
    }
}