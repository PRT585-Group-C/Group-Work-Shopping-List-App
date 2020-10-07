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

namespace GroupCWebAPI.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<NewItem> NewItem { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<ItemList> ItemLists { get; set; }
       public DbSet<ItemListItem> ItemListItems { get; set; }
       public DbSet<PaymentDetail> PaymentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
           base.OnModelCreating(modelBuilder);
          
            modelBuilder.Entity<ItemListItem>()
                .HasKey(t => new { t.ItemId, t.ItemListId });
            /*
           modelBuilder.Entity<ItemListItemsModel>()
               .HasOne(pt => pt.Item)
               .WithMany(p => p.ItemListItemsModel)
               .HasForeignKey(pt => pt.Id);

           modelBuilder.Entity<ItemListItemsModel>()
               .HasOne(pt => pt.ItemList)
               .WithMany(t => t.ItemListItemsModel)
               .HasForeignKey(pt => pt.ItemListId);
       

            modelBuilder.Entity("GroupCWebAPI.ViewModels.ItemListItemsModel", b =>
            {
                b.HasOne("GroupCWebAPI.ViewModels.ItemModel", "ItemModel")
                    .WithMany("ItemListItemsModel")
                    .HasForeignKey("Id")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
                b.HasOne("GroupCWebAPI.ViewModels.ItemListModel", "ItemListModel")
                    .WithMany("ItemListItemsModel")
                    .HasForeignKey("SkillId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });  */
        }
            
        }

       
    }
