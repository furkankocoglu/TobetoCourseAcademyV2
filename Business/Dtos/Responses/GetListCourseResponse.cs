﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses
{
	public class GetListCourseResponse
	{
		public Guid Id { get; set; }
		public Guid CategoryId { get; set; }
		public Guid InstructorId { get; set; }
		public string Name { get; set; }
		public string CategoryName { get; set; }
		public string InstructorName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
	}
}
