using AnnexHotels.Models;
using AnnexHotels.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnexHotels.Data.DbContexts
{
    public class AnnexHotelsDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Company> Companies { get; set; }

        public AnnexHotelsDbContext()
        {

        }

        public AnnexHotelsDbContext (DbContextOptions<AnnexHotelsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .HasData(
                    new Hotel()
                    {
                        Id = 1,
                        Name = "Mavens Hotel",
                        Description = "Nestled in the heart of lush forests, this hotel offers tranquility and luxury.",
                        Status = Status.Active,
                        City = "New York",
                        Country = "USA",
                        CompanyId = 3
                    },
                    new Hotel()
                    {
                        Id = 2,
                        Name = "Oriental Hotel",
                        Description = "A stylish hotel in the midst of the city, blending modernity with comfort",
                        Status = Status.Active,
                        City = "Eti Osa",
                        Country = "Nigeria",
                        CompanyId = 1
                    },
                    new Hotel()
                    {
                        Id = 3,
                        Name = "Kruizia Hotel",
                        Description = "A beautifully restored hotel showcasing timeless charm and rich heritage",
                        Status = Status.Discontinued,
                        City = "Manchester",
                        Country = "England",
                        CompanyId = 2
                    },
                    new Hotel()
                    {
                        Id = 4,
                        Name = "Ebano Hotel",
                        Description = "Step from your room to the sandy shore at this seaside paradise",
                        Status = Status.Active,
                        City = "Jos",
                        Country = "Nigeria",
                        CompanyId = 1
                    },
                    new Hotel()
                    {
                        Id = 5,
                        Name = "Eko Hotel",
                        Description = "A cozy lodge perched amidst majestic peaks, perfect for outdoor enthusiasts",
                        Status = Status.Active,
                        City = "Birmingham",
                        Country = "England",
                        CompanyId = 2
                    }
                );

            modelBuilder.Entity<Company>()
                .HasData
                (
                    new Company()
                    {
                        Id = 1,
                        Name = "Alpine Retreats Corporation",
                        Description = "Crafting serenity and luxury in nature's embrace",
                        RegNum = "537J4",
                        Email = "aplinerc@gmailcom"
                    },
                    new Company()
                    {
                        Id = 2,
                        Name = "Metropolitan Comfort Co.",
                        Description = "Redefining urban hospitality with a blend of style and relaxation",
                        RegNum = "3B249",
                        Email = "metrocomfortco@gmailcom"
                    },
                    new Company()
                    {
                        Id = 3,
                        Name = "Gaza group",
                        Description = "Your gateway to coastal elegance and relaxation",
                        RegNum = "227A6",
                        Email = "gazagroup@gmailcom"
                    }
                );

            modelBuilder.Entity<Room>()
                .HasData
                (
                    new Room()
                    {
                        Id = 1,
                        RoomNumber = 23,
                        RoomType = "Suite",
                        PricePerDay = 40000,
                        IsBooked = true,
                        HotelId = 2,
                        BookingId = 1
                    },
                    new Room()
                    {
                        Id = 2,
                        RoomNumber = 403,
                        RoomType = "Penthouse",
                        PricePerDay = 45000,
                        IsBooked = true,
                        HotelId = 4,
                        BookingId = 4
                    },
                    new Room()
                    {
                        Id = 3,
                        RoomNumber = 37,
                        RoomType = "Suite",
                        PricePerDay = 60000,
                        IsBooked = false,
                        HotelId = 2,
                        BookingId = 3
                    },
                    new Room()
                    {
                        Id = 4,
                        RoomNumber = 54,
                        RoomType = "Loft",
                        PricePerDay = 35000,
                        IsBooked = true,
                        HotelId = 1,
                        BookingId = 4
                    },
                    new Room()
                    {
                        Id = 5,
                        RoomNumber = 13,
                        RoomType = "Suite",
                        PricePerDay = 40000,
                        IsBooked = false,
                        HotelId = 5,
                        BookingId = 2
                    },
                    new Room()
                    {
                        Id = 6,
                        RoomNumber = 64,
                        RoomType = "Loft",
                        PricePerDay = 45000,
                        IsBooked = false,
                        HotelId = 3,
                        BookingId = 3
                    },
                    new Room()
                    {
                        Id = 7,
                        RoomNumber = 47,
                        RoomType = "Cabana",
                        PricePerDay = 52000,
                        IsBooked = false,
                        HotelId = 5,
                        BookingId = 4
                    },
                    new Room()
                    {
                        Id = 8,
                        RoomNumber = 90,
                        RoomType = "Villa",
                        PricePerDay = 40000,
                        IsBooked = true,
                        HotelId = 2,
                        BookingId = 1
                    },
                    new Room()
                    {
                        Id = 9,
                        RoomNumber = 14,
                        RoomType = "Suite",
                        PricePerDay = 36000,
                        IsBooked = false,
                        HotelId = 4,
                        BookingId = 6
                    },
                    new Room()
                    {
                        Id = 10,
                        RoomNumber = 76,
                        RoomType = "Cabana",
                        PricePerDay = 35000,
                        IsBooked = false,
                        HotelId = 1,
                        BookingId = 5
                    }
                );

            modelBuilder.Entity<Customer>()
                .HasData
                (
                    new Customer()
                    {
                        Id = 1,
                        FirstName = "Sarah",
                        LastName = "Andersen",
                        Email = "sarahandersen@gmail.com",
                        Password = "sarah#$34",
                        ConfirmPassword = "sarah#$34",
                        PhoneNumber = "08139050760"
                    },
                    new Customer()
                    {
                        Id = 2,
                        FirstName = "John",
                        LastName = "Freeman",
                        Email = "johnfreeman@gmail.com",
                        Password = "john#$34",
                        ConfirmPassword = "john#$34",
                        PhoneNumber = "09033672290"
                    },
                    new Customer()
                    {
                        Id = 3,
                        FirstName = "Chibueze",
                        LastName = "Okpara",
                        Email = "chibuezeokpara@gmail.com",
                        Password = "chibueze#$34",
                        ConfirmPassword = "chibueze#$34",
                        PhoneNumber = "08140056772"
                    },
                    new Customer()
                    {
                        Id = 4,
                        FirstName = "Lisa",
                        LastName = "Hendrix",
                        Email = "lisahendrix@gmail.com",
                        Password = "lisa#$34",
                        ConfirmPassword = "lisa#$34",
                        PhoneNumber = "08087985609"
                    }
                );

            modelBuilder.Entity<Booking>()
                .HasData
                (
                    new Booking()
                    {
                        Id = 1,
                        CustomerId = 3,
                        HotelId = 1,
                        BookingStatus = BookingStatus.Completed,
                        CheckOutDate = DateTime.Now.AddDays(5),

                    },
                    new Booking()
                    {
                        Id = 2,
                        CustomerId = 1,
                        HotelId = 1,
                        BookingStatus = BookingStatus.Completed,
                        CheckOutDate = DateTime.Now.AddDays(7)
                    },
                    new Booking()
                    {
                        Id = 3,
                        CustomerId = 2,
                        HotelId = 3,
                        BookingStatus = BookingStatus.Completed,
                        CheckOutDate = DateTime.Now.AddDays(14)
                    },
                    new Booking()
                    {
                        Id = 4,
                        CustomerId = 4,
                        HotelId = 5,
                        BookingStatus = BookingStatus.Pending,
                        CheckOutDate = DateTime.Now.AddDays(6)
                    },
                    new Booking()
                    {
                        Id = 5,
                        CustomerId = 3,
                        HotelId = 4,
                        BookingStatus = BookingStatus.Completed,
                        CheckOutDate = DateTime.Now.AddDays(9)
                    },
                    new Booking()
                    {
                        Id = 6,
                        CustomerId = 2,
                        HotelId = 2,
                        BookingStatus = BookingStatus.Pending,
                        CheckOutDate = DateTime.Now.AddDays(9)
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
