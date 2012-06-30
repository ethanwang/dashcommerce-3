using System;
using System.Collections.Generic;

namespace MettleSystems.MultiTenant.Core.Models.Entities
{
	[Serializable]
	public partial class DatabaseConfiguration :Entity<DatabaseConfiguration>
	{
		public DatabaseConfiguration()
		{		
		}
		public virtual int ApplicationId
		{
			get;
			set;
		}
		public virtual string CacheProvider
		{
			get;
			set;
		}
		public virtual string CacheRegionPrefix
		{
			get;
			set;
		}
		public virtual string ConnectionDriver
		{
			get;
			set;
		}
		public virtual int DatabaseConfigurationId
		{
			get;
			set;
		}
		public virtual string Dialect
		{
			get;
			set;
		}
		public virtual string InitialCatalog
		{
			get;
			set;
		}
		public virtual string Name
		{
			get;
			set;
		}
		public virtual string Password
		{
			get;
			set;
		}
		public virtual string Server
		{
			get;
			set;
		}
		public virtual string UserId
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as DatabaseConfiguration);
		}
		
		public virtual bool Equals(DatabaseConfiguration obj)
		{
			if (obj == null) return false;

			if (Equals(ApplicationId, obj.ApplicationId) == false) return false;
			if (Equals(CacheProvider, obj.CacheProvider) == false) return false;
			if (Equals(CacheRegionPrefix, obj.CacheRegionPrefix) == false) return false;
			if (Equals(ConnectionDriver, obj.ConnectionDriver) == false) return false;
			if (Equals(DatabaseConfigurationId, obj.DatabaseConfigurationId) == false) return false;
			if (Equals(Dialect, obj.Dialect) == false) return false;
			if (Equals(InitialCatalog, obj.InitialCatalog) == false) return false;
			if (Equals(Name, obj.Name) == false) return false;
			if (Equals(Password, obj.Password) == false) return false;
			if (Equals(Server, obj.Server) == false) return false;
			if (Equals(UserId, obj.UserId) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ ApplicationId.GetHashCode();
			result = (result * 397) ^ (CacheProvider != null ? CacheProvider.GetHashCode() : 0);
			result = (result * 397) ^ (CacheRegionPrefix != null ? CacheRegionPrefix.GetHashCode() : 0);
			result = (result * 397) ^ (ConnectionDriver != null ? ConnectionDriver.GetHashCode() : 0);
			result = (result * 397) ^ DatabaseConfigurationId.GetHashCode();
			result = (result * 397) ^ (Dialect != null ? Dialect.GetHashCode() : 0);
			result = (result * 397) ^ (InitialCatalog != null ? InitialCatalog.GetHashCode() : 0);
			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			result = (result * 397) ^ (Password != null ? Password.GetHashCode() : 0);
			result = (result * 397) ^ (Server != null ? Server.GetHashCode() : 0);
			result = (result * 397) ^ (UserId != null ? UserId.GetHashCode() : 0);
			return result;
		}
	}
}