using System;
using System.Collections.Generic;

namespace MettleSystems.MultiTenant.Core.Models.Entities
{
	[Serializable]
	public partial class Client : Entity<Client>
	{
		public Client()
		{
			Applications = new Iesi.Collections.Generic.HashedSet<Application>();		
		}
		public virtual int ClientId
		{
			get;
			set;
		}
		public virtual string Name
		{
			get;
			set;
		}
		public virtual Iesi.Collections.Generic.ISet<Application> Applications
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Client);
		}
		
		public virtual bool Equals(Client obj)
		{
			if (obj == null) return false;

			if (Equals(ClientId, obj.ClientId) == false) return false;
			if (Equals(Name, obj.Name) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ ClientId.GetHashCode();
			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			return result;
		}
	}
}