using System;

namespace NHibernateDemo
{
    class Customers
    {
        public virtual int CustomerId { get; set; }
        public virtual int NameStyle { get; set; }
        public virtual string Title { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Suffix { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string SalesPerson { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Phone { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string PasswordSalt { get; set; }
        public virtual Guid Rowguid { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
    }
}
