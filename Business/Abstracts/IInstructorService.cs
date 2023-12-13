using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System.Linq.Expressions;

namespace Business.Abstracts
{
	public interface IInstructorService
	{
		Task<Paginate<GetListInstructorResponse>> GetListAsync();
		Task<CreatedInstructorResponse> Add(CreateInstructorRequest createInstructorRequest);
		Task<GetInstructorResponse> GetAsync(Expression<Func<Instructor, bool>> filter);
		Task<UpdatedInstructorResponse> Update(UpdateInstructorRequest updateInstructorRequest);
		Task<DeletedInstructorResponse> Delete(DeleteInstructorRequest deleteInstructorRequest);
	}
}
