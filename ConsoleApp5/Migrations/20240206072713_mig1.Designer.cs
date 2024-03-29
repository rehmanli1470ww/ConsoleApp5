﻿// <auto-generated />
using System;
using ConsoleApp5.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp5.Migrations
{
    [DbContext(typeof(Debtor_Db))]
    [Migration("20240206072713_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsoleApp5.Entity.Debtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("Debt")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Debtors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "3565 Eagles Nest Drive Woodland, CA 95695",
                            BirthDay = new DateTime(1932, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 2414,
                            Email = "ShirleyTQualls@teleworm.us",
                            FullName = "Shirley T. Qualls",
                            Phone = "530-662-7732"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1973 Stoneybrook Road Maitland, FL 32751",
                            BirthDay = new DateTime(1953, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 3599,
                            Email = "DanielleWGrier@rhyta.com",
                            FullName = "Danielle W. Grier",
                            Phone = "321-473-4178"
                        },
                        new
                        {
                            Id = 3,
                            Address = "2432 Hannah Street Andrews, NC 28901",
                            BirthDay = new DateTime(1963, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1219,
                            Email = "ConnieWLemire@rhyta.com",
                            FullName = "Connie W. Lemire",
                            Phone = "828-321-3751"
                        },
                        new
                        {
                            Id = 4,
                            Address = "2411 Blue Spruce Lane Baltimore, MD 21202",
                            BirthDay = new DateTime(1976, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 3784,
                            Email = "CoyKAdams@dayrep.com",
                            FullName = "Coy K. Adams",
                            Phone = "410-347-1307"
                        },
                        new
                        {
                            Id = 5,
                            Address = "4971 Austin Avenue Savannah, GA 31401",
                            BirthDay = new DateTime(1988, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 4060,
                            Email = "BerniceJMiles@armyspy.com",
                            FullName = "Bernice J. Miles",
                            Phone = "912-307-6797"
                        },
                        new
                        {
                            Id = 6,
                            Address = "2031 Limer Street Augusta, GA 30901",
                            BirthDay = new DateTime(1990, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 6628,
                            Email = "BobLZambrano@armyspy.com",
                            FullName = "Bob L. Zambrano",
                            Phone = "706-446-1649"
                        },
                        new
                        {
                            Id = 7,
                            Address = "2737 Rardin Drive San Jose, CA 95110",
                            BirthDay = new DateTime(1950, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5412,
                            Email = "AdamDBartlett@rhyta.com",
                            FullName = "Adam D. Bartlett",
                            Phone = "650-693-1758"
                        },
                        new
                        {
                            Id = 8,
                            Address = "16 Fraggle Drive Hickory Hills, IL 60457",
                            BirthDay = new DateTime(1936, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11097,
                            Email = "PabloMSkinner@armyspy.com",
                            FullName = "Pablo M. Skinner",
                            Phone = "630-391-2034"
                        },
                        new
                        {
                            Id = 9,
                            Address = "699 Harper Street Louisville, KY 40202",
                            BirthDay = new DateTime(1971, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7956,
                            Email = "DorothyJBrown@rhyta.com",
                            FullName = "Dorothy J. Brown",
                            Phone = "270-456-3288"
                        },
                        new
                        {
                            Id = 10,
                            Address = "2940 Adams Avenue Columbia, MD 21044",
                            BirthDay = new DateTime(1998, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7150,
                            Email = "LarryAMiracle@jourrapide.com",
                            FullName = "Larry A. Miracle",
                            Phone = "301-621-3318"
                        },
                        new
                        {
                            Id = 11,
                            Address = "4821 Elk Rd Little Tucson, AZ 85704",
                            BirthDay = new DateTime(1944, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 2910,
                            Email = "DonnaBMaynard@teleworm.us",
                            FullName = "Donna B. Maynard",
                            Phone = "520-297-0575"
                        },
                        new
                        {
                            Id = 12,
                            Address = "2527 Terra Street Custer, WA 98240",
                            BirthDay = new DateTime(1989, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11805,
                            Email = "JessicaJStoops@dayrep.com",
                            FullName = "Jessica J. Stoops",
                            Phone = "360-366-8101"
                        },
                        new
                        {
                            Id = 13,
                            Address = "151 Christie Way Marlboro, MA 01752",
                            BirthDay = new DateTime(1937, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1001,
                            Email = "AudryMStyles@jourrapide.com",
                            FullName = "Audry M. Styles",
                            Phone = "978-773-4802"
                        },
                        new
                        {
                            Id = 14,
                            Address = "1460 Walt Nuzum Farm Road Rochester, NY 14620",
                            BirthDay = new DateTime(1958, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9128,
                            Email = "VioletRAnguiano@dayrep.com",
                            FullName = "Violet R. Anguiano",
                            Phone = "585-340-7888"
                        },
                        new
                        {
                            Id = 15,
                            Address = "1824 Roosevelt Street Fremont, CA 94539",
                            BirthDay = new DateTime(1970, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5648,
                            Email = "CharlesPSegundo@dayrep.com",
                            FullName = "Charles P. Segundo",
                            Phone = "415-367-3341"
                        },
                        new
                        {
                            Id = 16,
                            Address = "759 Havanna Street Saxapahaw, NC 27340",
                            BirthDay = new DateTime(1944, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 10437,
                            Email = "PaulHSturtz@dayrep.com",
                            FullName = "Paul H. Sturtz",
                            Phone = "336-376-1732"
                        },
                        new
                        {
                            Id = 17,
                            Address = "3172 Bedford Street Birmingham, AL 35203",
                            BirthDay = new DateTime(1978, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7230,
                            Email = "DorisBKing@rhyta.com",
                            FullName = "Doris B. King",
                            Phone = "205-231-8973"
                        },
                        new
                        {
                            Id = 18,
                            Address = "1972 Orchard Street Bloomington, MN 55437",
                            BirthDay = new DateTime(1983, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 515,
                            Email = "DeannaJDonofrio@rhyta.com",
                            FullName = "Deanna J. Donofrio",
                            Phone = "952-842-7576"
                        },
                        new
                        {
                            Id = 19,
                            Address = "3749 Capitol Avenue New Castle, IN 47362",
                            BirthDay = new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1816,
                            Email = "MartinSMalinowski@dayrep.com",
                            FullName = "Martin S. Malinowski",
                            Phone = "765-599-3523"
                        },
                        new
                        {
                            Id = 20,
                            Address = "922 Hill Croft Farm Road Sacramento, CA 95814",
                            BirthDay = new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5037,
                            Email = "MelissaRArner@armyspy.com",
                            FullName = "Melissa R. Arner",
                            Phone = "530-508-7328"
                        },
                        new
                        {
                            Id = 21,
                            Address = "4738 Chapmans Lane Grants, NM 87020",
                            BirthDay = new DateTime(1969, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7755,
                            Email = "KellyGHoffman@armyspy.com",
                            FullName = "Kelly G. Hoffman",
                            Phone = "505-876-8935"
                        },
                        new
                        {
                            Id = 22,
                            Address = "124 Wood Street Saginaw, MI 48607",
                            BirthDay = new DateTime(1986, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11657,
                            Email = "DoyleBShort@teleworm.us",
                            FullName = "Doyle B. Short",
                            Phone = "989-221-4363"
                        },
                        new
                        {
                            Id = 23,
                            Address = "74 Pine Street Pittsburgh, PA 15222",
                            BirthDay = new DateTime(1960, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9693,
                            Email = "LorrieRGilmore@teleworm.us",
                            FullName = "Lorrie R. Gilmore",
                            Phone = "724-306-7138"
                        },
                        new
                        {
                            Id = 24,
                            Address = "29 Goldleaf Lane Red Bank, NJ 07701",
                            BirthDay = new DateTime(1972, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 2712,
                            Email = "LionelACook@jourrapide.com",
                            FullName = "Lionel A. Cook",
                            Phone = "201-627-5962"
                        },
                        new
                        {
                            Id = 25,
                            Address = "4686 Renwick Drive Philadelphia, PA 19108",
                            BirthDay = new DateTime(1990, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 4016,
                            Email = "CharleneCBurke@armyspy.com",
                            FullName = "Charlene C. Burke",
                            Phone = "484-334-9729"
                        },
                        new
                        {
                            Id = 26,
                            Address = "748 Rockford Road Westborough, MA 01581",
                            BirthDay = new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 349,
                            Email = "TommyMPatton@rhyta.com",
                            FullName = "Tommy M. Patton",
                            Phone = "774-571-6481"
                        },
                        new
                        {
                            Id = 27,
                            Address = "15 Hewes Avenue Towson, MD 21204",
                            BirthDay = new DateTime(1944, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9824,
                            Email = "KristinSBloomer@dayrep.com",
                            FullName = "Kristin S. Bloomer",
                            Phone = "443-652-0734"
                        },
                        new
                        {
                            Id = 28,
                            Address = "3052 Walton Street Salt Lake City, UT 84104",
                            BirthDay = new DateTime(1997, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 8215,
                            Email = "DanielKJames@rhyta.com",
                            FullName = "Daniel K. James",
                            Phone = "801-407-4693"
                        },
                        new
                        {
                            Id = 29,
                            Address = "3575 Eagle Street Norris City, IL 62869",
                            BirthDay = new DateTime(1976, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5766,
                            Email = "PaulaDHenry@rhyta.com",
                            FullName = "Paula D. Henry",
                            Phone = "618-378-5307"
                        },
                        new
                        {
                            Id = 30,
                            Address = "675 Jehovah Drive Martinsville, VA 24112",
                            BirthDay = new DateTime(1947, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 8363,
                            Email = "DonnaCSandoval@rhyta.com",
                            FullName = "Donna C. Sandoval",
                            Phone = "540-482-5463"
                        },
                        new
                        {
                            Id = 31,
                            Address = "2812 Rowes Lane Paducah, KY 42001",
                            BirthDay = new DateTime(1932, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7785,
                            Email = "RobertTTaylor@armyspy.com",
                            FullName = "Robert T. Taylor",
                            Phone = "270-596-6442"
                        },
                        new
                        {
                            Id = 32,
                            Address = "4367 Christie Way Marlboro, MA 01752",
                            BirthDay = new DateTime(1948, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 10030,
                            Email = "DonnaWAlamo@teleworm.us",
                            FullName = "Donna W. Alamo",
                            Phone = "978-778-2533"
                        },
                        new
                        {
                            Id = 33,
                            Address = "85 Elmwood Avenue Chandler, AZ 85249",
                            BirthDay = new DateTime(1995, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5347,
                            Email = "AmyRParmer@armyspy.com",
                            FullName = "Amy R. Parmer",
                            Phone = "480-883-4934"
                        },
                        new
                        {
                            Id = 34,
                            Address = "3552 Columbia Road Greenwood Village, CO 80111",
                            BirthDay = new DateTime(1986, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9838,
                            Email = "NewtonKEvans@rhyta.com",
                            FullName = "Newton K. Evans",
                            Phone = "303-207-9084"
                        },
                        new
                        {
                            Id = 35,
                            Address = "316 Elsie Drive Fort Thompson, SD 57339",
                            BirthDay = new DateTime(1949, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1672,
                            Email = "KathleenCChaney@rhyta.com",
                            FullName = "Kathleen C. Chaney",
                            Phone = "605-245-3513"
                        },
                        new
                        {
                            Id = 36,
                            Address = "4146 May Street Sharpsburg, KY 40374",
                            BirthDay = new DateTime(1957, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9195,
                            Email = "ManuelCJohnson@jourrapide.com",
                            FullName = "Manuel C. Johnson",
                            Phone = "606-247-2659"
                        },
                        new
                        {
                            Id = 37,
                            Address = "3106 Bates Brothers Road Columbus, OH 43215",
                            BirthDay = new DateTime(1988, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11271,
                            Email = "CarlaACreagh@dayrep.com",
                            FullName = "Carla A. Creagh",
                            Phone = "614-307-8974"
                        },
                        new
                        {
                            Id = 38,
                            Address = "965 Metz Lane Woburn, MA 01801",
                            BirthDay = new DateTime(1988, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9761,
                            Email = "NormaMNew@jourrapide.com",
                            FullName = "Norma M. New",
                            Phone = "857-492-8703"
                        },
                        new
                        {
                            Id = 39,
                            Address = "401 Romrog Way Grand Island, NE 68801",
                            BirthDay = new DateTime(1983, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 10771,
                            Email = "RoyDGreen@jourrapide.com",
                            FullName = "Roy D. Green",
                            Phone = "308-340-5981"
                        },
                        new
                        {
                            Id = 40,
                            Address = "2177 Harley Vincent Drive Cleveland, OH 44113",
                            BirthDay = new DateTime(1935, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5205,
                            Email = "CristyJJensen@jourrapide.com",
                            FullName = "Cristy J. Jensen",
                            Phone = "440-626-9550"
                        },
                        new
                        {
                            Id = 41,
                            Address = "3584 Jadewood Drive Demotte, IN 46310",
                            BirthDay = new DateTime(1993, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1276,
                            Email = "NancyJFergerson@dayrep.com",
                            FullName = "Nancy J. Fergerson",
                            Phone = "219-987-8498"
                        },
                        new
                        {
                            Id = 42,
                            Address = "1890 Poco Mas Drive Dallas, TX 75247",
                            BirthDay = new DateTime(1938, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9132,
                            Email = "DaveNRodriguez@rhyta.com",
                            FullName = "Dave N. Rodriguez",
                            Phone = "214-540-2499"
                        },
                        new
                        {
                            Id = 43,
                            Address = "1444 Rose Avenue Metairie, LA 70001",
                            BirthDay = new DateTime(1988, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 8176,
                            Email = "JamesEDenning@jourrapide.com",
                            FullName = "James E. Denning",
                            Phone = "504-289-8640"
                        },
                        new
                        {
                            Id = 44,
                            Address = "4454 Green Avenue Oakland, CA 94609",
                            BirthDay = new DateTime(1972, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7875,
                            Email = "RichardMThomas@jourrapide.com",
                            FullName = "Richard M. Thomas",
                            Phone = "510-735-3359"
                        },
                        new
                        {
                            Id = 45,
                            Address = "3121 Quarry Drive Montgomery, AL 36117",
                            BirthDay = new DateTime(1973, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 3088,
                            Email = "LakishaRForrest@armyspy.com",
                            FullName = "Lakisha R. Forrest",
                            Phone = "334-830-1181"
                        },
                        new
                        {
                            Id = 46,
                            Address = "3239 Tori Lane Salt Lake City, UT 84104",
                            BirthDay = new DateTime(1959, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 6588,
                            Email = "PamelaHBeauchamp@jourrapide.com",
                            FullName = "Pamela H. Beauchamp",
                            Phone = "801-559-6347"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
