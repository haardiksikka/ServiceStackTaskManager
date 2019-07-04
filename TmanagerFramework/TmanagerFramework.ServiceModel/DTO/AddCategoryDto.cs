namespace TaskManager.ServiceModel.DTO
{
    using ServiceStack.ServiceHost;

    [Route("/addcategory","POST")]
    public class AddCategoryDto : IReturn<CategoryResponse>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    public class CategoryResponse
    {
        public bool IsSucess { get; set; }
    }
}
