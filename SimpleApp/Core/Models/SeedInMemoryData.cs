using SimpleApp.Infrastructure;
using System;
using System.Linq;

namespace SimpleApp.Core.Models
{
    public static class SeedInMemoryData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.BrainstormSessions.ToList().Any())
            {
                return;
            }
            context.BrainstormSessions.Add(GetTestSession());
            context.SaveChanges();
        }

        private static BrainstormSession GetTestSession()
        {
            var session = new BrainstormSession()
            {
                Name = "First Test Session",
                DateCreated = DateTime.Now
            };
            var idea = new Idea()
            {
                DateCreated = DateTime.Now.AddMinutes(1),
                Description = "Totally awesome idea",
                Name = "Awesome idea"
            };
            session.AddIdea(idea);
            return session;
        }
    }
}
