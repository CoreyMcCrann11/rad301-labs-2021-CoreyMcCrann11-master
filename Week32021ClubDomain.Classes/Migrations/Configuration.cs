namespace Week32021ClubDomain.Classes.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week32021ClubDomain.Classes.ClubsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week32021ClubDomain.Classes.ClubsContext context)
        {
            context.Clubs.AddOrUpdate(new ClubDomain.Classes.ClubModels.Club[]
           {
                new ClubDomain.Classes.ClubModels.Club { ClubId = 1, ClubName = "Snooker Club", CreationDate = DateTime.Now, adminID = 1 },
                new ClubDomain.Classes.ClubModels.Club { ClubId = 2, ClubName = "BaseBall Club", CreationDate = DateTime.Now, adminID = 2 },
                new ClubDomain.Classes.ClubModels.Club { ClubId = 3, ClubName = "Gaming Club", CreationDate = DateTime.Now, adminID = 3 }
           });

            context.Members.AddOrUpdate(new ClubDomain.Classes.ClubModels.Member[]
            {
                new ClubDomain.Classes.ClubModels.Member{MemberID = 1, AssociatedClub = 1, approved = true, StudentID = "S00123456"},
                new ClubDomain.Classes.ClubModels.Member{MemberID = 1, AssociatedClub = 2, approved = true, StudentID = "S00123456"},
                new ClubDomain.Classes.ClubModels.Member{MemberID = 2, AssociatedClub = 1, approved = true, StudentID = "S00987654"},
                new ClubDomain.Classes.ClubModels.Member{MemberID = 2, AssociatedClub = 2, approved = true, StudentID = "S00987654"},
                new ClubDomain.Classes.ClubModels.Member{MemberID = 3, AssociatedClub = 3, approved = true, StudentID = "S00167890"},
                new ClubDomain.Classes.ClubModels.Member{MemberID = 4, AssociatedClub = 3, approved = true, StudentID = "S09874632"}
            });

            context.ClubEvents.AddOrUpdate(new ClubDomain.Classes.ClubModels.ClubEvent[]
            {
                new ClubDomain.Classes.ClubModels.ClubEvent{EventID = 1, ClubId = 1, StartDateTime = DateTime.Parse("01/11/2020"), EndDateTime = DateTime.Parse("04/11/2020"), Location = "Sligo", Venue = "The Embassy", associatedClub = context.Clubs.FirstOrDefault(p => p.ClubId == 1)},
                new ClubDomain.Classes.ClubModels.ClubEvent{EventID = 2, ClubId = 1, StartDateTime = DateTime.Parse("02/11/2020"), EndDateTime = DateTime.Parse("05/11/2020"), Location = "London", Venue = "The Crucible", associatedClub = context.Clubs.FirstOrDefault(p => p.ClubId == 1)},
                new ClubDomain.Classes.ClubModels.ClubEvent{EventID = 3, ClubId = 2, StartDateTime = DateTime.Parse("03/11/2020"), EndDateTime = DateTime.Parse("06/11/2020"), Location = "New york", Venue = "NY Stadiom", associatedClub = context.Clubs.FirstOrDefault(p => p.ClubId == 2)},
                new ClubDomain.Classes.ClubModels.ClubEvent{EventID = 4, ClubId = 2, StartDateTime = DateTime.Parse("04/11/2020"), EndDateTime = DateTime.Parse("07/11/2020"), Location = "Chicago", Venue = "Chicago Stadium", associatedClub = context.Clubs.FirstOrDefault(p => p.ClubId == 2)},
                new ClubDomain.Classes.ClubModels.ClubEvent{EventID = 5, ClubId = 3, StartDateTime = DateTime.Parse("05/11/2020"), EndDateTime = DateTime.Parse("08/11/2020"), Location = "Paris", Venue = "GamesCom", associatedClub = context.Clubs.FirstOrDefault(p => p.ClubId == 3)},
                new ClubDomain.Classes.ClubModels.ClubEvent{EventID = 6, ClubId = 3, StartDateTime = DateTime.Parse("06/11/2020"), EndDateTime = DateTime.Parse("09/11/2020"), Location = "Berlin", Venue = "Berlin Arcade", associatedClub = context.Clubs.FirstOrDefault(p => p.ClubId == 3)}
            });

            context.EventAttendances.AddOrUpdate(new ClubDomain.Classes.ClubModels.EventAttendnace[]
            {
                new ClubDomain.Classes.ClubModels.EventAttendnace{ID = 1, EventID = 1, AttendeeMember = 1},
                new ClubDomain.Classes.ClubModels.EventAttendnace{ID = 2, EventID = 2, AttendeeMember = 1},
                new ClubDomain.Classes.ClubModels.EventAttendnace{ID = 3, EventID = 3, AttendeeMember = 2},
                new ClubDomain.Classes.ClubModels.EventAttendnace{ID = 4, EventID = 4, AttendeeMember = 2},
                new ClubDomain.Classes.ClubModels.EventAttendnace{ID = 5, EventID = 5, AttendeeMember = 3},
                new ClubDomain.Classes.ClubModels.EventAttendnace{ID = 6, EventID = 6, AttendeeMember = 3}
            });

        
    }
    }
}
