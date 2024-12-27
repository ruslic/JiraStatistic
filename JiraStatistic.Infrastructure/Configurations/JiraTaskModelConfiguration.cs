using JiraStatistic.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JiraStatistic.Infrastructure.Configurations
{
    public class JiraTaskModelConfiguration : IEntityTypeConfiguration<JiraTaskEntity>
    {
        public void Configure(EntityTypeBuilder<JiraTaskEntity> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.ToTable("");
            //builder.Property(x => x.Id);
            //builder.Property(x => x.Tag).HasMaxLength(64).IsRequired();
            //builder.HasIndex(x =>x.Tag);
        }
    }
}
