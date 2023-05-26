﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trading_Company
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Trading_CompanyEntities : DbContext
    {
        public Trading_CompanyEntities()
            : base("name=Trading_CompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Exchange_Notice> Exchange_Notice { get; set; }
        public virtual DbSet<Exchange_Notice_Item> Exchange_Notice_Item { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Item_Unit> Item_Unit { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supply_Notice> Supply_Notice { get; set; }
        public virtual DbSet<Supply_Notice_Item> Supply_Notice_Item { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Transfer_Item> Transfer_Item { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    
        public virtual ObjectResult<InsertNewWH_Result> InsertNewWH(string wh_Name, string wh_Address, string wh_Manager)
        {
            var wh_NameParameter = wh_Name != null ?
                new ObjectParameter("Wh_Name", wh_Name) :
                new ObjectParameter("Wh_Name", typeof(string));
    
            var wh_AddressParameter = wh_Address != null ?
                new ObjectParameter("Wh_Address", wh_Address) :
                new ObjectParameter("Wh_Address", typeof(string));
    
            var wh_ManagerParameter = wh_Manager != null ?
                new ObjectParameter("Wh_Manager", wh_Manager) :
                new ObjectParameter("Wh_Manager", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InsertNewWH_Result>("InsertNewWH", wh_NameParameter, wh_AddressParameter, wh_ManagerParameter);
        }
    
        public virtual ObjectResult<SelectAllWarehouses_Result> SelectAllWarehouses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllWarehouses_Result>("SelectAllWarehouses");
        }
    
        public virtual ObjectResult<SelectWarehouseByName_Result> SelectWarehouseByName(string wh_Name)
        {
            var wh_NameParameter = wh_Name != null ?
                new ObjectParameter("Wh_Name", wh_Name) :
                new ObjectParameter("Wh_Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectWarehouseByName_Result>("SelectWarehouseByName", wh_NameParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<string> UpdateWH(string wh_Name, string new_Name, string wh_Address, string wh_Manager)
        {
            var wh_NameParameter = wh_Name != null ?
                new ObjectParameter("Wh_Name", wh_Name) :
                new ObjectParameter("Wh_Name", typeof(string));
    
            var new_NameParameter = new_Name != null ?
                new ObjectParameter("New_Name", new_Name) :
                new ObjectParameter("New_Name", typeof(string));
    
            var wh_AddressParameter = wh_Address != null ?
                new ObjectParameter("Wh_Address", wh_Address) :
                new ObjectParameter("Wh_Address", typeof(string));
    
            var wh_ManagerParameter = wh_Manager != null ?
                new ObjectParameter("Wh_Manager", wh_Manager) :
                new ObjectParameter("Wh_Manager", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("UpdateWH", wh_NameParameter, new_NameParameter, wh_AddressParameter, wh_ManagerParameter);
        }
    }
}