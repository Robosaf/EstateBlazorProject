using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {              
        }

        public DbSet<Premise> Premises { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<PremiseFeature> PremiseFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Premise>()
                .HasOne(p => p.Location)
                .WithMany()
                .HasForeignKey(p => p.LocationId);

            modelBuilder.Entity<PremiseFeature>()
                .HasKey(pf => new { pf.PremiseId, pf.FeatureId });

            modelBuilder.Entity<PremiseFeature>()
                .HasOne(pf => pf.Premise)
                .WithMany(p => p.PremiseFeatures)
                .HasForeignKey(pf => pf.PremiseId);

            modelBuilder.Entity<PremiseFeature>()
                .HasOne(pf => pf.Feature)
                .WithMany(f => f.PremiseFeatures)
                .HasForeignKey(pf => pf.FeatureId);

            modelBuilder.Entity<Feature>(entity => {
                entity.Property(f => f.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Premise>(entity => {
                entity.Property(f => f.Id).ValueGeneratedOnAdd();
            });


            modelBuilder.Entity<Location>().HasData(
                    new Location
                    {
                        Id = 1,
                        City = "Warsaw",
                        Country = "Poland"
                    },
                    new Location
                    {
                        Id = 2,
                        City = "Gdansk",
                        Country = "Poland"
                    }
                );

            modelBuilder.Entity<Feature>()
                .HasData(
                    new Feature
                    {
                        Id = 1,
                        Name = "Security System",
                    },
                    new Feature
                    {
                        Id = 2,
                        Name = "High-Speed Internet Connectivity",
                    },
                    new Feature
                    {
                        Id = 3,
                        Name = "Energy-Efficient Lighting",
                    },
                    new Feature
                    {
                        Id = 4,
                        Name = "Flexible Workspace",
                    },
                    new Feature
                    {
                        Id = 5,
                        Name = "Smart HVAC Systems",
                    },
                    new Feature
                    {
                        Id = 6,
                        Name = "Customizable Interior Layouts",
                    },
                    new Feature
                    {
                        Id = 7,
                        Name = "Green Spaces",
                    },
                    new Feature
                    {
                        Id = 8,
                        Name = "Meeting Rooms with Tech Infrastructure",
                    },
                    new Feature
                    {
                        Id = 9,
                        Name = "Accessibility Features",
                    }, 
                    new Feature
                    {
                        Id = 10,
                        Name = "Waste Management Systems",
                    }
                );

            // modelBuilder.Entity<Premise>().HasData(
            //        new Premise
            //        {
            //            Id = 1,
            //            Title = "Warsaw House",
            //            ImageUrl = "https://hotelverte.com/wp-content/uploads/2023/12/top-things-to-do-in-warsaw-old-town.jpg",
            //            Description = "Single room in unit (2+1) - from 430 EUR / month - 10-12 sqm - Fully furnished with a bed with storage space, comfortable mattress, desk and chair, wardrobe. Shared fridge in the hall with max. two persons - Shared bathroom with max. two persons. Nearby services: - Bus stop (160 meters) - Tram stop (350 meters) - Bars, restaurants and clubs - One of the greenest area in Warsaw. Feature check-list: - 24/7 reception support & security - High speed WiFi - Rooftop terrace, cinema room, shared kitchens, laundry room, study room, chill out zone - One card for everything - Front door, room door",
            //            LocationId = 1,
            //            Street = "Pulawska",
            //            Price = 3000000,
            //            Size = 129,
            //            RoomsCount = 5
            //        },
            //        new Premise
            //        {
            //            Id = 2,
            //            Title = "Warsaw Flat White",
            //            ImageUrl = "https://thumbor.forbes.com/thumbor/fit-in/900x510/https://www.forbes.com/home-improvement/wp-content/uploads/2022/07/download-23.jpg",
            //            Description = "Tucked away at the edge of an ancient forest, this whimsical cottage seems plucked from the pages of a fairy tale. Its charming exterior, adorned with climbing ivy and surrounded by a vibrant garden, invites you into a world of enchantment. Inside, the warm glow of a fireplace dances on rustic wooden beams, creating a cozy atmosphere. Unique stained glass windows add a touch of magic to each room, casting colorful patterns that change with the shifting sunlight. The Enchanted Cottage is a haven for those seeking a retreat into a storybook setting.",
            //            LocationId = 1,
            //            Street = "Zlota",
            //            Price = 4000000,
            //            Size = 180,
            //            RoomsCount = 7
            //        },
            //        new Premise
            //        {
            //            Id = 3,
            //            Title = "Gdansk Home",
            //            ImageUrl = "https://mygate.com/wp-content/uploads/2023/07/110.jpg",
            //            Description = "Rising amidst the bustling cityscape, this sleek and stylish modern residence stands as a testament to contemporary design. The exterior's clean lines and large windows offer panoramic views of the surrounding urban jungle. Inside, an open-concept living space is adorned with minimalist furnishings, creating a sense of spaciousness. Smart home technology seamlessly integrates into every corner, allowing residents to control the ambiance with a touch. A rooftop terrace provides a private escape, offering a breathtaking skyline as a backdrop to the rhythmic pulse of the city below.",
            //            LocationId = 2,
            //            Street = "Kazimierza Porebicza",
            //            Price = 250000,
            //            Size = 210,
            //            RoomsCount = 10
            //        },
            //        new Premise
            //        {
            //            Id = 4,
            //            Title = "Flat in Warsaw center",
            //            ImageUrl = "https://i.pinimg.com/736x/d0/c0/4b/d0c04be7f982a0753cb6dc0c565ea661.jpg",
            //            Description = "Nestled on the shores of a tranquil lake, this rustic yet elegant house exudes a timeless charm. Weathered stone and cedar shingles blend seamlessly with the natural surroundings, while a sprawling porch offers a front-row seat to breathtaking sunsets. Inside, exposed wooden beams and a grand stone fireplace create a warm and inviting atmosphere. Large windows frame picturesque views of the lake, blurring the lines between indoor and outdoor living. A private dock extends into the water, inviting residents to embrace a serene lakeside lifestyle in this idyllic retreat.",
            //            LocationId = 1,
            //            Street = "Bulana Zlotego",
            //            Price = 3450000,
            //            Size = 99,
            //            RoomsCount = 3
            //        }
            //    );

            //modelBuilder.Entity<PremiseFeature>().HasData(
            //        new PremiseFeature
            //        {
            //            PremiseId = 1,
            //            FeatureId = 6,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 1,
            //            FeatureId = 3,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 1,
            //            FeatureId = 4,
            //        },

            //        new PremiseFeature
            //        {
            //            PremiseId = 2,
            //            FeatureId = 1,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 2,
            //            FeatureId = 7,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 2,
            //            FeatureId = 2,
            //        },

            //        new PremiseFeature
            //        {
            //            PremiseId = 3,
            //            FeatureId = 10,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 3,
            //            FeatureId = 4,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 3,
            //            FeatureId = 9,
            //        },

            //        new PremiseFeature
            //        {
            //            PremiseId = 4,
            //            FeatureId = 3,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 4,
            //            FeatureId = 6,
            //        },
            //        new PremiseFeature
            //        {
            //            PremiseId = 4,
            //            FeatureId = 8,
            //        }
            //    );
        }
    }
}
