using entityframeworkcore_one_to_one_relationship_example_project.Data;
using entityframeworkcore_one_to_one_relationship_example_project.Models;
using Microsoft.EntityFrameworkCore;

namespace entityframeworkcore_one_to_one_relationship_example_project.Repo
{
    public class Repository
    {
        private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task<List<CarCompany>> GetCarCompanies() => await _appDbContext.CarCompanies.Include(c => c.CarModel).ToListAsync();

        public async Task AddCarCompany(CarCompany carCompany)
        {
            _appDbContext.CarCompanies.Add(carCompany);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<CarModel>> GetCarModels() => await _appDbContext.CarModels.Include(m => m.CarCompany).ToListAsync();

        public async Task AddCarModel(CarModel carModel)
        {
            _appDbContext.CarModels.Add(carModel);
            await _appDbContext.SaveChangesAsync();
        }
    }
}