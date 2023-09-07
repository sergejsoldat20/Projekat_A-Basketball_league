using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models.Configurations;

public class ClubSeeder : IEntityTypeConfiguration<Club>
{
	public void Configure(EntityTypeBuilder<Club> builder)
	{
		throw new NotImplementedException();
	}
}
