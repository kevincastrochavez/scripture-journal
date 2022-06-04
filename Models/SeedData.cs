using Microsoft.EntityFrameworkCore;
using ScriptureJournal.Data;

namespace ScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                if (context == null || context.Scripture == null)
                {
                    throw new ArgumentNullException("Null ScriptureJournalContext");
                }

                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi",
                        Chapter = "3",
                        Verse = "7",
                        EntryDate = DateTime.Parse("1989-2-12"),
                        Notes = "And it came to pass that I, Nephi, said unto my father: I awill go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them."
                    },

                    new Scripture
                    {
                        Book = "Ether",
                        Chapter = "12",
                        Verse = "6",
                        EntryDate = DateTime.Parse("1984-3-13"),
                        Notes = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that afaith is things which are bhoped for and cnot seen; wherefore, dispute not because ye see not, for ye receive no dwitness until after the etrial of your faith."
                    },

                    new Scripture
                    {
                        Book = "3 Nephi",
                        Chapter = "27",
                        Verse = "27",
                        EntryDate = DateTime.Parse("1986-2-23"),
                        Notes = "And know ye that aye shall be bjudges of this people, according to the judgment which I shall give unto you, which shall be just. Therefore, what cmanner of men ought ye to be? Verily I say unto you, even das I am."
                    },

                    new Scripture
                    {
                        Book = "Moroni",
                        Chapter = "10",
                        Verse = "3-5",
                        EntryDate = DateTime.Parse("1959-4-15"),
                        Notes = "Behold, I would exhort you that when ye shall read these things, if it be wisdom in God that ye should read them, that ye would remember how amerciful the Lord hath been unto the children of men, from the creation of Adam even down until the time that ye shall receive these things, and bponder it in your chearts. And when ye shall receive these things, I would exhort you that ye would aask God, the Eternal Father, in the name of Christ, if these things are not btrue; and if ye shall ask with a csincere heart, with dreal intent, having efaith in Christ, he will fmanifest the gtruth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may aknow the btruth of all things."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}