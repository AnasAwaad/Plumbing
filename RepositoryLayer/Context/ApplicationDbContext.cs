using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace RepositoryLayer.Context;
public class ApplicationDbContext : DbContext
{

	// Constructor
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
	{
	}

	// Sql Tables
	public DbSet<AboutUs> AboutUs { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<ContactUs> ContactUs { get; set; }
	public DbSet<HomePage> HomePages { get; set; }
	public DbSet<Portfolio> Portfolios { get; set; }
	public DbSet<Service> Services { get; set; }
	public DbSet<SocialMedia> SocialMedias { get; set; }
	public DbSet<Team> Teams { get; set; }
	public DbSet<Testimonial> Testimonials { get; set; }


	// Override for seeking assemblies
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}
}
