using System.Collections;
using Domain.Repository;
using Infraestructure.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace Infraestructure.Repository;



public class UnitOfWork : IUnitOfWork
{

    private readonly AppDBContext _context;
    
    private Hashtable repositories;

    public ITicketRepository TicketRepository { get; }

    public IDiscussionRepository DiscussionRepository {get;}

    public UnitOfWork(  AppDBContext context, 
                        ITicketRepository ticketRepository, 
                        IDiscussionRepository discussionRepository)
    {
        _context = context;
        TicketRepository = ticketRepository;
        DiscussionRepository = discussionRepository;
    }



    public async Task<int> SaveChanges()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task<bool> SaveChangesReturnBool()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        
        if (repositories == null) repositories = new Hashtable();
        
        var type = typeof(TEntity).Name;

        if (!repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
            repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<TEntity>)repositories[type];
        
    }

    

    

}
