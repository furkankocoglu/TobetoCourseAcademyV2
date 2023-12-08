using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
namespace Business.Maps.AutoMapper
{
	public class InstructorProfile:Profile
	{
        public InstructorProfile()
        {
			CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
			CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
			CreateMap<Instructor, GetListedInstructorResponse>().ReverseMap();
			CreateMap<Paginate<Instructor>, Paginate<GetListedInstructorResponse>>().ReverseMap();
		}
    }
}