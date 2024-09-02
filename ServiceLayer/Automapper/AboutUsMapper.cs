using AutoMapper;
using EntityLayer.Entities;
using EntityLayer.ViewModels.AboutUsVM;
namespace ServiceLayer.Automapper;
public class AboutUsMapper:Profile
{
    public AboutUsMapper()
    {
        CreateMap<AboutUs, AboutUsListVM>();
        CreateMap<AboutUs, AboutUsAddVM>();
        CreateMap<AboutUs, AboutUsUpdateVM>();
    }
}
