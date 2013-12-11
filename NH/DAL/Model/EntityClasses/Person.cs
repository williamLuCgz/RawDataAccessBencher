﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Person'</summary>
	public partial class Person
	{
		#region Class Member Declarations
		private BusinessEntity _businessEntity;
		private Iesi.Collections.Generic.ISet<BusinessEntityContact> _businessEntityContacts;
		private Iesi.Collections.Generic.ISet<ContactCreditCard> _contactCreditCards;
		private Iesi.Collections.Generic.ISet<Customer> _customers;
		private Iesi.Collections.Generic.ISet<EmailAddress> _emailAddresses;
		private Employee _employee;
		private Password _password;
		private Iesi.Collections.Generic.ISet<PersonPhone> _personPhones;
		private System.String _additionalContactInfo;
		private System.Int32 _businessEntityId;
		private System.String _demographics;
		private System.Int32 _emailPromotion;
		private System.String _firstName;
		private System.String _lastName;
		private System.String _middleName;
		private System.DateTime _modifiedDate;
		private System.Boolean _nameStyle;
		private System.String _personType;
		private System.Guid _rowguid;
		private System.String _suffix;
		private System.String _title;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="Person"/> class.</summary>
		public Person() : base()
		{
			_businessEntityContacts = new Iesi.Collections.Generic.HashedSet<BusinessEntityContact>();
			_contactCreditCards = new Iesi.Collections.Generic.HashedSet<ContactCreditCard>();
			_customers = new Iesi.Collections.Generic.HashedSet<Customer>();
			_emailAddresses = new Iesi.Collections.Generic.HashedSet<EmailAddress>();
			_personPhones = new Iesi.Collections.Generic.HashedSet<PersonPhone>();
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.BusinessEntityId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AdditionalContactInfo field. </summary>	
		public virtual System.String AdditionalContactInfo
		{ 
			get { return _additionalContactInfo; }
			set { _additionalContactInfo = value; }
		}

		/// <summary>Gets or sets the BusinessEntityId field. </summary>	
		public virtual System.Int32 BusinessEntityId
		{ 
			get { return _businessEntityId; }
			set { _businessEntityId = value; }
		}

		/// <summary>Gets or sets the Demographics field. </summary>	
		public virtual System.String Demographics
		{ 
			get { return _demographics; }
			set { _demographics = value; }
		}

		/// <summary>Gets or sets the EmailPromotion field. </summary>	
		public virtual System.Int32 EmailPromotion
		{ 
			get { return _emailPromotion; }
			set { _emailPromotion = value; }
		}

		/// <summary>Gets or sets the FirstName field. </summary>	
		public virtual System.String FirstName
		{ 
			get { return _firstName; }
			set { _firstName = value; }
		}

		/// <summary>Gets or sets the LastName field. </summary>	
		public virtual System.String LastName
		{ 
			get { return _lastName; }
			set { _lastName = value; }
		}

		/// <summary>Gets or sets the MiddleName field. </summary>	
		public virtual System.String MiddleName
		{ 
			get { return _middleName; }
			set { _middleName = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the NameStyle field. </summary>	
		public virtual System.Boolean NameStyle
		{ 
			get { return _nameStyle; }
			set { _nameStyle = value; }
		}

		/// <summary>Gets or sets the PersonType field. </summary>	
		public virtual System.String PersonType
		{ 
			get { return _personType; }
			set { _personType = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets or sets the Suffix field. </summary>	
		public virtual System.String Suffix
		{ 
			get { return _suffix; }
			set { _suffix = value; }
		}

		/// <summary>Gets or sets the Title field. </summary>	
		public virtual System.String Title
		{ 
			get { return _title; }
			set { _title = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Person.BusinessEntity - BusinessEntity.Person (1:1)'</summary>
		public virtual BusinessEntity BusinessEntity
		{
			get { return _businessEntity; }
			set { _businessEntity = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'BusinessEntityContact.Person - Person.BusinessEntityContacts (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<BusinessEntityContact> BusinessEntityContacts
		{
			get { return _businessEntityContacts; }
			set { _businessEntityContacts = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.Person - Person.ContactCreditCards (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<ContactCreditCard> ContactCreditCards
		{
			get { return _contactCreditCards; }
			set { _contactCreditCards = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Person - Person.Customers (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<Customer> Customers
		{
			get { return _customers; }
			set { _customers = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'EmailAddress.Person - Person.EmailAddresses (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<EmailAddress> EmailAddresses
		{
			get { return _emailAddresses; }
			set { _emailAddresses = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Employee.Person - Person.Employee (1:1)'</summary>
		public virtual Employee Employee
		{
			get { return _employee; }
			set { _employee = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'Password.Person - Person.Password (1:1)'</summary>
		public virtual Password Password
		{
			get { return _password; }
			set { _password = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'PersonPhone.Person - Person.PersonPhones (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<PersonPhone> PersonPhones
		{
			get { return _personPhones; }
			set { _personPhones = value; }
		}
		
		#endregion
	}
}