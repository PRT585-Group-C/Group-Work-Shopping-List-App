using AngularShopListApp.Models;
using GroupCWebAPI._DAL.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupCWebAPI.ViewModels;
using GroupCWebAPI.Models;

namespace AngularShopListApp.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<NewItem> NewItem { get; set; }
        public DbSet<ItemModel> Items { get; set; }

        public DbSet<PaymentDetail> PaymentDetails { get; set;  }
    }
}
