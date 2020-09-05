using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Meetup.Controller.Data.EF
{
    public partial class MeetupDBContext : DbContext
    {
        public MeetupDBContext()
        {
        }

        public MeetupDBContext(DbContextOptions<MeetupDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<LuCategories> LuCategories { get; set; }
        public virtual DbSet<LuEventStatus> LuEventStatus { get; set; }
        public virtual DbSet<LuLocations> LuLocations { get; set; }
        public virtual DbSet<LuRates> LuRates { get; set; }
        public virtual DbSet<LuRegisteredEventStatus> LuRegisteredEventStatus { get; set; }
        public virtual DbSet<LuRoles> LuRoles { get; set; }
        public virtual DbSet<UserComments> UserComments { get; set; }
        public virtual DbSet<UserRegisteredEvents> UserRegisteredEvents { get; set; }
        public virtual DbSet<UserRegisterEventNotifications> UserRegisterEventNotifications { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-8RO5U1H;Database=MeetupDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.Property(e => e.EventId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.EventEndDate)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.EventStartDate)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ModifiedDate).HasColumnType("text");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Events__Category__4F7CD00D");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Events__CreatedB__5165187F");

                entity.HasOne(d => d.EventStatus)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Events__EventSta__5070F446");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Events__Location__4E88ABD4");
            });

            modelBuilder.Entity<LuCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LuEventStatus>(entity =>
            {
                entity.HasKey(e => e.EventStatusId);

                entity.Property(e => e.EventStatusId).ValueGeneratedNever();

                entity.Property(e => e.EventStatusName)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LuLocations>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.Property(e => e.LocationId).ValueGeneratedNever();

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LuRates>(entity =>
            {
                entity.HasKey(e => e.RateId);

                entity.Property(e => e.RateId).ValueGeneratedNever();

                entity.Property(e => e.RateName)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LuRegisteredEventStatus>(entity =>
            {
                entity.HasKey(e => e.RegisteredEventStatusId);

                entity.Property(e => e.RegisteredEventStatusId).ValueGeneratedNever();

                entity.Property(e => e.RegisteredEventStatusName)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<LuRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<UserComments>(entity =>
            {
                entity.HasKey(e => e.UserCommentId);

                entity.Property(e => e.UserCommentId).ValueGeneratedNever();

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.UserComments)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserComme__Event__5CD6CB2B");

                entity.HasOne(d => d.Rate)
                    .WithMany(p => p.UserComments)
                    .HasForeignKey(d => d.RateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserComme__RateI__5DCAEF64");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserComme__UserI__5BE2A6F2");
            });

            modelBuilder.Entity<UserRegisteredEvents>(entity =>
            {
                entity.HasKey(e => e.UserRegisteredEventId);

                entity.Property(e => e.UserRegisteredEventId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.UserRegisteredEvents)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRegis__Event__5535A963");

                entity.HasOne(d => d.RegisteredEventStatus)
                    .WithMany(p => p.UserRegisteredEvents)
                    .HasForeignKey(d => d.RegisteredEventStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRegis__Regis__5629CD9C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRegisteredEvents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRegis__UserI__5441852A");
            });

            modelBuilder.Entity<UserRegisterEventNotifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.Property(e => e.NotificationId).ValueGeneratedNever();

                entity.Property(e => e.Notification)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.UserRegisteredEvent)
                    .WithMany(p => p.UserRegisterEventNotifications)
                    .HasForeignKey(d => d.UserRegisteredEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRegis__UserR__59063A47");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EMailId")
                    .HasColumnType("text");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("text");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__LocationI__440B1D61");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__RoleId__4316F928");
            });
        }
    }
}
