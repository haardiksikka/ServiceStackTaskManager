namespace TaskManager.ServiceModel.DTO
{
    using System.Collections.Generic;
    using ServiceStack.ServiceHost;
    using TaskManager.Common.DTO;

    [Route("/getcategories","GET")]
    public class GetCategoriesDto : IReturn<GetCategoryResponse>
    {
       // public int CategoryId { get; set; }
       // public string CategoryName { get; set; }
    }

    public class GetCategoryResponse
    {
        public IEnumerable<CategoryDto> Categories { get; set; }
    }
}
