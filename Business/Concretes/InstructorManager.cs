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
	public class InstructorManager : IInstructorService
	{
		IInstructorDal _instructorDal;
		IMapper _mapper;
		public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
		{
			_instructorDal = instructorDal;
			_mapper = mapper;
		}
		public async Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest)
		{
			Instructor instructor = _mapper.Map<Instructor>(createInstructorRequest);
			var createdInstructor = await _instructorDal.AddAsync(instructor);
			CreatedInstructorResponse createdInstructorResponse = _mapper.Map<CreatedInstructorResponse>(createdInstructor);
			return createdInstructorResponse;
		}
		public async Task<Paginate<GetListedInstructorResponse>> GetListAsync()
		{
			var result = await _instructorDal.GetListAsync();
			Paginate<GetListedInstructorResponse> getListedInstructorResponse = _mapper.Map<Paginate<GetListedInstructorResponse>>(result);
			return getListedInstructorResponse;
		}
	}
}
