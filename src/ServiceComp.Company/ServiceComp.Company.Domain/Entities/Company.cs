using System;
using System.Collections.Generic;
using System.Linq;
using Resources;
using ServiceComp.Company.Exceptions;

namespace ServiceComp.Company.Domain
{
    public class Company
    {

        public Company(string name, string corporateName, string documentNumber, Address address)
        {
            
        }
        
        private CompanyUser GetUserOrThrow(Guid userId)
        {
            var user = Users.FirstOrDefault(u => u.UserId == userId) ?? throw new EntityNotFoundException(Messages.User);
            return user;
        }
        
        public string Name { get; set; }
        public string CorporateName { get; set; }
        public string DocumentNumber { get; set; }
        public Address Address { get; set; }

        public IList<CompanyUser> Users { get; set; }

        public void AddUser(Guid userId)
        {
            Users ??= new List<CompanyUser>();

            Users.Add(new CompanyUser()
            {
                UserId = userId,
                Company = this,
                IsEnabled = true,
                AddedAt = DateTimeOffset.Now
            });
        }

        public void GiveAdminRightsToUser(Guid userId)
        {
            Users ??= new List<CompanyUser>();
            var user = GetUserOrThrow(userId);
            user.IsAdmin = true;
        }

        

        public void DisableUser(Guid userId)
        {
            Users ??= new List<CompanyUser>();
            var user = GetUserOrThrow(userId);
            user.IsEnabled = false;
        }

        public void EnableUser(Guid userId)
        {
            Users ??= new List<CompanyUser>();
            var user = GetUserOrThrow(userId);
            user.IsEnabled = true;
        }

        public void RemoveUser(Guid userId)
        {
            Users ??= new List<CompanyUser>();
            var user = GetUserOrThrow(userId);
            user.IsDeleted = true;
        }
        
        
    }
}