using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface ICourseService
	{
		Task<Paginate<GetListedCourseResponse>> GetListAsync();
		Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
	}
}