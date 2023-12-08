using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
	public interface IInstructorService
	{
		Task<Paginate<GetListedInstructorResponse>> GetListAsync();
		Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
	}
}
