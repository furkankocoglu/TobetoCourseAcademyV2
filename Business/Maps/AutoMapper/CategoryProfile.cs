using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Maps.AutoMapper
{
	public class CategoryProfile:Profile
	{
        public CategoryProfile()
        {
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<Category, GetListedCategoryResponse>().ReverseMap();
            CreateMap<Paginate<Category>, Paginate<GetListedCategoryResponse>>().ReverseMap();
        }
    }
}