﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.ToTable("Courses").HasKey(b => b.Id);

			builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
			builder.Property(b => b.CategoryId).HasColumnName("CategoryId").IsRequired();
			builder.Property(b => b.InstructorId).HasColumnName("InstructorId").IsRequired();
			builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
			builder.Property(b => b.Description).HasColumnName("Description").IsRequired();
			builder.Property(b => b.Price).HasColumnName("Price").IsRequired();
			builder.Property(b => b.ImageUrl).HasColumnName("ImageUrl").IsRequired();

			builder.HasIndex(indexExpression: b => b.Name, name: "UK_Courses_Name").IsUnique();

			builder.HasOne(b => b.Category);
			builder.HasOne(b => b.Instructor);
			builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
		}
	}
}
