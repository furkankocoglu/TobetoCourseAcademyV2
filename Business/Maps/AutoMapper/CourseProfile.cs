using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Maps.AutoMapper
{
	public class CourseProfile:Profile
	{
        public CourseProfile()
        {
			CreateMap<Course, CreateCourseRequest>().ReverseMap();
			CreateMap<Course, CreatedCourseResponse>().ReverseMap();
			CreateMap<Course, GetListedCourseResponse>().ReverseMap();
			CreateMap<Paginate<Course>, Paginate<GetListedCourseResponse>>().ReverseMap();
		}
    }
}