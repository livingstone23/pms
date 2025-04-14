using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;



namespace Infraestructure.Services;



public class CriteriaServices : ICriteriaService
{

    private readonly IUnitOfWork _unitOfWork;

    public CriteriaServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    

    public List<Category> GetCategories()
    {
        return _unitOfWork.Repository<Category>().ListAll();
    }

    public List<Priority> GetPriorities()
    {
        return _unitOfWork.Repository<Priority>().ListAll();
    }

    public List<Product> GetProducts()
    {
        return _unitOfWork.Repository<Product>().ListAll();
    }

    public List<string> GetStatus()
    {
        return new List<string> {
            "New",
            "OPEN",
            "CLOSED",
            "COMPLETED",
            "ON HOLD",
            "CANCELLED",
        };  
    }

}
