using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Test.Helpers;
using Test.Models;

namespace Test.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Invoice> Invoice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Company> companies = new List<Company>() {
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Ecstatic Systems",Address="253 Fulton Circle Menasha, WI 54952",Telephone="431-393-0117",RegDate = new DateTime(2018,12,07)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Red Limited",Address="55 Shub Farm Court Yuma, AZ 85365",Telephone="887-738-4272",RegDate = new DateTime(2019,02,01)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Primal Electronics",Address="8863 Howard Court Traverse City, MI 49684",Telephone="909-467-1181",RegDate = new DateTime(2019,02,12)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Surprisystems",Address="813 Pheasant Street Huntley, IL 60142",Telephone="558-663-2657",RegDate = new DateTime(2019,03,13)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Gorillacoustics",Address="5 Boston St. Patchogue, NY 11772",Telephone="208-652-0972",RegDate = new DateTime(2019,03,20)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Silver Linetworks",Address="39 Jockey Hollow St. Passaic, NJ 07055",Telephone="754-934-6607",RegDate = new DateTime(2019,05,03)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Dwarfoods",Address="8 Main St. Bridgeton, NJ 08302",Telephone="428-213-6913",RegDate = new DateTime(2019,06,13)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Greenaid",Address="9801 Mammoth Drive Winston Salem, NC 27103",Telephone="453-539-9934",RegDate = new DateTime(2019,08,08)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Squidwood",Address="49 Talbot Street Stroudsburg, PA 18360",Telephone="925-925-3730",RegDate = new DateTime(2019,09,06)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Thunderwares",Address="7566 Hawthorne Drive Port Chester, NY 10573",Telephone="922-481-4794",RegDate = new DateTime(2019,10,09)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Tundra Brews",Address="9337 East Dr. Meadville, PA 16335",Telephone="771-896-0645",RegDate = new DateTime(2019,10,17)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Angel Systems",Address="14 Academy Street Arlington, MA 02474",Telephone="374-323-7205",RegDate = new DateTime(2019,12,04)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Ecstatic Enterprises",Address="8959 Pennsylvania Court Hoboken, NJ 07030",Telephone="992-452-6822",RegDate = new DateTime(2019,12,05)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Starecords",Address="8501 James St. Southampton, PA 18966",Telephone="798-594-7742",RegDate = new DateTime(2020,01,30)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Apexi",Address="9022 Branch St. Montgomery Village, MD 20886",Telephone="350-813-1923",RegDate = new DateTime(2020,03,17)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Galerprises",Address="100 Old Oxford Ave. Norwich, CT 06360",Telephone="520-872-8810",RegDate = new DateTime(2020,03,31)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Quaductions",Address="443 Gates Avenue Memphis, TN 38106",Telephone="799-500-7874",RegDate = new DateTime(2020,04,21)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Wavemedia",Address="85 Marlborough Dr. Zeeland, MI 49464",Telephone="773-728-4669",RegDate = new DateTime(2020,05,07)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Pixywater",Address="890 Wood Street Baltimore, MD 21206",Telephone="244-916-5331",RegDate = new DateTime(2020,05,11)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Hoglight",Address="39 Tarkiln Hill St. West Hempstead, NY 11552",Telephone="392-458-6631",RegDate = new DateTime(2020,06,10)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Twilight Corporation",Address="8638 Santa Clara St. Yuba City, CA 95993",Telephone="551-996-8865",RegDate = new DateTime(2020,09,14)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Silver",Address="506 South Gregory Lane Cumming, GA 30040",Telephone="467-454-5805",RegDate = new DateTime(2020,09,30)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Red Security",Address="2 Howard Ave. Germantown, MD 20874",Telephone="931-970-0832",RegDate = new DateTime(2020,10,29)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Chiefoods",Address="580 N. Liberty Dr. Orange Park, FL 32065",Telephone="975-663-2423",RegDate = new DateTime(2020,11,10)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Essensecurity",Address="9459 North Mill Ave. Roanoke Rapids, NC 27870",Telephone="966-722-2521",RegDate = new DateTime(2020,12,16)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Elitelligence",Address="543 White Drive New Bedford, MA 02740",Telephone="606-752-7843",RegDate = new DateTime(2018,09,10)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Daydreamotors",Address="96 Armstrong Lane Cary, NC 27511",Telephone="838-383-3934",RegDate = new DateTime(2018,10,12)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Heartstone",Address="8561 Glen Eagles Circle Natick, MA 01760",Telephone="509-760-3953",RegDate = new DateTime(2018,11,08)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Lagoonmaster",Address="37 East Logan Lane Eugene, OR 97402",Telephone="827-418-5289",RegDate = new DateTime(2018,12,12)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Shadecloud",Address="53 Hickory Court Klamath Falls, OR 97603",Telephone="629-202-6953",RegDate = new DateTime(2019,02,14)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Pinnacle Aviation",Address="8352 Marsh St. Indian Trail, NC 28079",Telephone="937-490-6629",RegDate = new DateTime(2019,03,18)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Neptune Solutions",Address="9825 Pilgrim Ave. Ontario, CA 91762",Telephone="713-210-5080",RegDate = new DateTime(2019,03,25)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Night Networks",Address="2 Fordham Drive Merrick, NY 11566",Telephone="865-503-5762",RegDate = new DateTime(2019,03,26)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Forestics",Address="292 Jones Lane Lanham, MD 20706",Telephone="845-892-1111",RegDate = new DateTime(2019,05,01)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Bearings",Address="91 Amerige Ave. Muscatine, IA 52761",Telephone="984-496-5436",RegDate = new DateTime(2019,05,15)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Mermedia",Address="788B Miles Ave. Fairport, NY 14450",Telephone="905-246-2186",RegDate = new DateTime(2019,07,17)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Fairiprises",Address="8403 Goldfield Ave. King Of Prussia, PA 19406",Telephone="519-259-6669",RegDate = new DateTime(2019,07,30)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Mountaintime",Address="7507 Wakehurst Avenue Murfreesboro, TN 37128",Telephone="801-871-4863",RegDate = new DateTime(2019,08,15)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Fireworth",Address="153 Old Lancaster Street Princeton, NJ 08540",Telephone="264-712-5689",RegDate = new DateTime(2019,12,30)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Cloudworld",Address="108 Canterbury Avenue Reston, VA 20191",Telephone="314-535-5117",RegDate = new DateTime(2020,01,22)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Alp Arts",Address="932 Locust Ave. Minot, ND 58701",Telephone="542-361-0307",RegDate = new DateTime(2020,02,24)},
                new Company(){Uid = SequentialGuid.GenerateComb(), Name = "Timber Security",Address="47 Glenridge Ave. Tupelo, MS 38801",Telephone="744-230-2997",RegDate = new DateTime(2020,04,09)}
            };

            List<Invoice> invoices = new List<Invoice>() {
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,01,23),Number="2020-01-23-00-01",Total=34300.04,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,01,28),Number="2020-01-28-00-02",Total=15690.59,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,01,31),Number="2020-01-31-00-03",Total=298.36,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,02,21),Number="2020-02-21-00-04",Total=1431.43,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,03,31),Number="2020-03-31-00-05",Total=18186.21,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,04,17),Number="2020-04-17-00-06",Total=4909.33,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,05,15),Number="2020-05-15-00-07",Total=39931.11,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,05,21),Number="2020-05-21-00-08",Total=28254.93,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,05,22),Number="2020-05-22-00-09",Total=44787.62,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,05,26),Number="2020-05-26-00-10",Total=22502.97,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,06,01),Number="2020-06-01-00-11",Total=4945.7,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,06,03),Number="2020-06-03-00-12",Total=36277.52,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,06,11),Number="2020-06-11-00-13",Total=23971.3,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,07,23),Number="2020-07-23-00-14",Total=46565.21,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,08,03),Number="2020-08-03-00-15",Total=38232.68,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,08,24),Number="2020-08-24-00-16",Total=27786.68,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,09,08),Number="2020-09-08-00-17",Total=22732.68,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,09,22),Number="2020-09-22-00-18",Total=43822.84,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,10,01),Number="2020-10-01-00-19",Total=15328.68,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,10,22),Number="2020-10-22-00-20",Total=48152.28,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,11,26),Number="2020-11-26-00-21",Total=14065.1,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,11,27),Number="2020-11-27-00-22",Total=37993.71,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,11,30),Number="2020-11-30-00-23",Total=38244.32,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,12,02),Number="2020-12-02-00-24",Total=27489.4,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,12,22),Number="2020-12-22-00-25",Total=14378.53,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,01,31),Number="2020-01-31-00-26",Total=45954.99,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,02,06),Number="2020-02-06-00-27",Total=47950.59,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,02,21),Number="2020-02-21-00-28",Total=15495.89,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,03,23),Number="2020-03-23-00-29",Total=25963.68,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,04,17),Number="2020-04-17-00-30",Total=27774.66,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,05,01),Number="2020-05-01-00-31",Total=36187.62,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,05,29),Number="2020-05-29-00-32",Total=29825.92,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,06,02),Number="2020-06-02-00-33",Total=4298.63,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,07,06),Number="2020-07-06-00-34",Total=43305.22,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,07,15),Number="2020-07-15-00-35",Total=46484.26,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,07,20),Number="2020-07-20-00-36",Total=47141.39,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,07,23),Number="2020-07-23-00-37",Total=2787.27,Type=2},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,07,24),Number="2020-07-24-00-38",Total=49818.98,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,08,05),Number="2020-08-05-00-39",Total=45908.63,Type=4},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,08,27),Number="2020-08-27-00-40",Total=18576.21,Type=1},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,09,02),Number="2020-09-02-00-41",Total=31128.42,Type=3},
                new Invoice(){Uid=SequentialGuid.GenerateComb(),InvDate=new DateTime(2020,09,15),Number="2020-09-15-00-42",Total=14540.69,Type=1}
            };

            for (int i = 0; i < invoices.Count; i++)
            {
                try
                {
                    invoices[i].CompanyUid = companies[i].Uid;
                }
                catch (IndexOutOfRangeException)
                {
                    invoices[i].CompanyUid = Guid.Empty;
                }
            }

            invoices.RemoveAll(i => i.CompanyUid == Guid.Empty);

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Uid)
                  .HasDefaultValueSql("(newsequentialid())");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.Uid)
                  .HasDefaultValueSql("(newsequentialid())");
            });



            modelBuilder.Entity<Company>().HasData(
                companies
            );



            modelBuilder.Entity<Invoice>().HasData(
                invoices
            );


        }
    }
}
