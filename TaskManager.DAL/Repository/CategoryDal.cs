namespace TaskManager.DAL.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TaskManager.Common.DTO;
    using TaskManager.DAL.Context;
    using TaskManager.DAL.Mapper;

    public class CategoryDal : ICategoryDal
    {
        private readonly TaskManagerContext _context;
        private readonly IDatabaseMapper _mapper;
        public CategoryDal(IDatabaseMapper mapper)
        {
            _context = new TaskManagerContext();
            _mapper = mapper;
        }

        public bool AddCategory(CategoryDto categoryDto)
        {
            try
            {
                var taskCategory = _mapper.CategoryDtoToCategory(categoryDto);
                _context.Category.Add(taskCategory);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            try
            {
                var allCategories = _context.Category.ToList();
                var allCategoriesDto = _mapper.CategoryListToDto(allCategories);
                return allCategoriesDto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
