
namespace TmanagerFramework
{
    using Funq;
    using ServiceStack;
    using ServiceStack.ServiceInterface.Cors;
    using ServiceStack.WebHost.Endpoints;
    using TaskManager.BLL;
    using TaskManager.DAL.Mapper;
    using TaskManager.DAL.Repository;
    using TmanagerFramework.ServiceInterface.Services;

    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("TmanagerFramework", typeof(GetCategoriesService).Assembly)
        {


        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            this.Plugins.Add(new CorsFeature());
            RequestFilters.Add((httpReq, httpRes, requestDto) =>
            {
                if (httpReq.HttpMethod == "OPTIONS")
                {
                    httpRes.AddHeader("Access-Control-Allow-Methods", "POST, GET, OPTIONS");
                    httpRes.AddHeader("Access-Control-Allow-Headers", "X-Requested-With, Content-Type, Accept, X-ApiKey");
                    httpRes.EndRequest();
                }

            });
            //container.Register<>();
            container.Register<IUserRepo>(new UserRepo(new DatabaseMapper()));
            container.Register<IUserBll>(new UserBll(new UserRepo(new DatabaseMapper())));
            container.Register<ICategoryDal>(new CategoryDal(new DatabaseMapper()));
            container.Register<ICategoryBll>(new CategoryBll(new CategoryDal(new DatabaseMapper())));
            container.Register<ITaskDal>(new TaskDal(new DatabaseMapper()));
            container.Register<ITaskBll>(new TaskBll(new TaskDal(new DatabaseMapper())));

           

        }
    }
}