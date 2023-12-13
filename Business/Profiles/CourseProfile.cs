using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
	public class CourseProfile : Profile
	{
		public CourseProfile()
		{
			CreateMap<Course, CreateCourseRequest>().ReverseMap();
			CreateMap<Course, CreatedCourseResponse>().ReverseMap();
			CreateMap<Course, UpdateCourseRequest>().ReverseMap();
			CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
			CreateMap<Course, DeleteCourseRequest>().ReverseMap();
			CreateMap<Course, DeletedCourseResponse>().ReverseMap();
			CreateMap<Course, GetCourseResponse>()
				.ForMember(destinationMember: c => c.CategoryName, memberOptions: opt => opt.MapFrom(c => c.Category.Name))
				.ForMember(destinationMember: c => c.InstructorName, memberOptions: opt => opt.MapFrom(c => c.Instructor.Name))
				.ReverseMap();
			CreateMap<Course, GetListCourseResponse>()
				.ForMember(destinationMember: c => c.CategoryName, memberOptions: opt => opt.MapFrom(c => c.Category.Name))
				.ForMember(destinationMember: c => c.InstructorName, memberOptions: opt => opt.MapFrom(c => c.Instructor.Name))
				.ReverseMap();
			CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();
		}
	}
}