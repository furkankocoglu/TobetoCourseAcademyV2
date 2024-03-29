﻿namespace Business.Dtos.Requests
{
	public class UpdateCourseRequest
	{
		public Guid Id { get; set; }
		public Guid CategoryId { get; set; }
		public Guid InstructorId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
	}	
}
