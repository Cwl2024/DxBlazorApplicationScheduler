using DxBlazorApplicationScheduler.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;

namespace DxBlazorApplicationScheduler.Login
{
    public class UserAccountService
    {
        private List<UserAccount>? _users;
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public UserAccountService(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;

        }

        private bool EnsureUsersLoaded()
        {
            if (_users != null) return true;
            using var context = _contextFactory.CreateDbContext();
            if (!context.Database.CanConnect() || !context.Model.GetEntityTypes().Any(e => e.GetTableName() == "usgrlink"))
            {
                return false;
            }
            _users = (from ep in context.Usgrlinks
                      join e in context.Users on ep.Iuserid equals e.Iid
                      join t in context.Groups on ep.Igroupid equals t.Iid
                      select new UserAccount
                      {
                          UserName = e.Cuserid,
                          Password = e.Cpassword,
                          Role = t.Cgrpdesc
                      })
                     .ToList();
            return true;
        }
        public UserAccount? GetByUserName(string userName)
        {
            if (EnsureUsersLoaded())
            {
                return _users!.FirstOrDefault(x => x.UserName.ToUpper() == userName.ToUpper());
            }
            throw new InvalidOperationException("Database connection failed.");
        }

    }
}
