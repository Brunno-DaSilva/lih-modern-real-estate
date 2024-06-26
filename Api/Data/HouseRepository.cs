using Microsoft.EntityFrameworkCore;

public interface IHouseRepository 
{
    Task<List<HouseDto>> GetAll();
}

public class HouseRepository: IHouseRepository
{
    private readonly HouseDbContext context;
    public HouseRepository(HouseDbContext context)
    {
        this.context = context;
    }

    public async Task<List<HouseDto>> GetAll()
    {
        return await context.Houses.Select(h => new HouseDto(h.Id, h.Price, h.Address, h.City, h.ZipCode, h.Country, h.Description,h.Photo)).ToListAsync();
    }
}