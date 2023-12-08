using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
	public class CourseManager : ICourseService
	{
		ICourseDal _courseDal;
		IMapper _mapper;

		public CourseManager(ICourseDal courseDal, IMapper mapper)
		{
			_courseDal = courseDal;
			_mapper = mapper;
		}

		public async Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest)
		{
			Course course = _mapper.Map<Course>(createCourseRequest);
			var result = await _courseDal.AddAsync(course);
			CreatedCourseResponse createdCourseResponse = _mapper.Map<CreatedCourseResponse>(result);
			return createdCourseResponse;
		}

		public async Task<Paginate<GetListedCourseResponse>> GetListAsync()
		{
			var result = await _courseDal.GetListAsync();
			Paginate<GetListedCourseResponse> getListedCourseResponse = _mapper.Map<Paginate<GetListedCourseResponse>>(result);
			return getListedCourseResponse;
		}
	}
}
