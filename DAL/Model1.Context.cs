﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dBConnexion : DbContext
    {
        public dBConnexion()
            : base("name=dBConnexion")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AWBuildVersion> AWBuildVersion { get; set; }
        public DbSet<DatabaseLog> DatabaseLog { get; set; }
        public DbSet<ErrorLog> ErrorLog { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public DbSet<JobCandidate> JobCandidate { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressType> AddressType { get; set; }
        public DbSet<BusinessEntity> BusinessEntity { get; set; }
        public DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public DbSet<ContactType> ContactType { get; set; }
        public DbSet<CountryRegion> CountryRegion { get; set; }
        public DbSet<EmailAddress> EmailAddress { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonPhone> PersonPhone { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public DbSet<StateProvince> StateProvince { get; set; }
    }
}
