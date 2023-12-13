using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System.Linq.Expressions;

namespace Business.Abstracts
{
	public interface ICourseService
	{
		Task<Paginate<GetListCourseResponse>> GetListAsync();
		Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
		Task<GetCourseResponse> GetAsync(Expression<Func<Course, bool>> filter);
		Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
		Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest);
	}
}