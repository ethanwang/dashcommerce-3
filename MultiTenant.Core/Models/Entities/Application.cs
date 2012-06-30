using System;
using System.Collections.Generic;

namespace MettleSystems.MultiTenant.Core.Models.Entities
{
	[Serializable]
	public partial class Application : Entity<Application>
	{
		public Application()
		{
			Clients = new Iesi.Collections.Generic.HashedSet<Client>();		
		}
		public virtual int ApplicationId
		{
			get;
			set;
		}
		public virtual string Name
		{
			get;
			set;
		}
		public virtual Iesi.Collections.Generic.ISet<Client> Clients
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Application);
		}
		
		public virtual bool Equals(Application obj)
		{
			if (obj == null) return false;

			if (Equals(ApplicationId, obj.ApplicationId) == false) return false;
			if (Equals(Name, obj.Name) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ ApplicationId.GetHashCode();
			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			return result;
		}
	}
}