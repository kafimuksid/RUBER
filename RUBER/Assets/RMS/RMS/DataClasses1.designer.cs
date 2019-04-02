﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMS
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RMSDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertmenu(menu instance);
    partial void Updatemenu(menu instance);
    partial void Deletemenu(menu instance);
    partial void Insertorder(order instance);
    partial void Updateorder(order instance);
    partial void Deleteorder(order instance);
    partial void Insertselectedmenu(selectedmenu instance);
    partial void Updateselectedmenu(selectedmenu instance);
    partial void Deleteselectedmenu(selectedmenu instance);
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::RMS.Properties.Settings.Default.RMSDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<menu> menus
		{
			get
			{
				return this.GetTable<menu>();
			}
		}
		
		public System.Data.Linq.Table<order> orders
		{
			get
			{
				return this.GetTable<order>();
			}
		}
		
		public System.Data.Linq.Table<selectedmenu> selectedmenus
		{
			get
			{
				return this.GetTable<selectedmenu>();
			}
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.menu")]
	public partial class menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Desc;
		
		private int _Price;
		
		private System.Data.Linq.Binary _img;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescChanging(string value);
    partial void OnDescChanged();
    partial void OnPriceChanging(int value);
    partial void OnPriceChanged();
    partial void OnimgChanging(System.Data.Linq.Binary value);
    partial void OnimgChanged();
    #endregion
		
		public menu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Desc]", Storage="_Desc", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				if ((this._Desc != value))
				{
					this.OnDescChanging(value);
					this.SendPropertyChanging();
					this._Desc = value;
					this.SendPropertyChanged("Desc");
					this.OnDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Int NOT NULL")]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.orders")]
	public partial class order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _orderId;
		
		private string _foodName;
		
		private int _foodQuantity;
		
		private int _itemTotal;
		
		private string _orderStatus;
		
		private string _orderuser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnorderIdChanging(int value);
    partial void OnorderIdChanged();
    partial void OnfoodNameChanging(string value);
    partial void OnfoodNameChanged();
    partial void OnfoodQuantityChanging(int value);
    partial void OnfoodQuantityChanged();
    partial void OnitemTotalChanging(int value);
    partial void OnitemTotalChanged();
    partial void OnorderStatusChanging(string value);
    partial void OnorderStatusChanged();
    partial void OnorderuserChanging(string value);
    partial void OnorderuserChanged();
    #endregion
		
		public order()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderId", DbType="Int NOT NULL")]
		public int orderId
		{
			get
			{
				return this._orderId;
			}
			set
			{
				if ((this._orderId != value))
				{
					this.OnorderIdChanging(value);
					this.SendPropertyChanging();
					this._orderId = value;
					this.SendPropertyChanged("orderId");
					this.OnorderIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodName", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string foodName
		{
			get
			{
				return this._foodName;
			}
			set
			{
				if ((this._foodName != value))
				{
					this.OnfoodNameChanging(value);
					this.SendPropertyChanging();
					this._foodName = value;
					this.SendPropertyChanged("foodName");
					this.OnfoodNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodQuantity", DbType="Int NOT NULL")]
		public int foodQuantity
		{
			get
			{
				return this._foodQuantity;
			}
			set
			{
				if ((this._foodQuantity != value))
				{
					this.OnfoodQuantityChanging(value);
					this.SendPropertyChanging();
					this._foodQuantity = value;
					this.SendPropertyChanged("foodQuantity");
					this.OnfoodQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemTotal", DbType="Int NOT NULL")]
		public int itemTotal
		{
			get
			{
				return this._itemTotal;
			}
			set
			{
				if ((this._itemTotal != value))
				{
					this.OnitemTotalChanging(value);
					this.SendPropertyChanging();
					this._itemTotal = value;
					this.SendPropertyChanged("itemTotal");
					this.OnitemTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderStatus", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string orderStatus
		{
			get
			{
				return this._orderStatus;
			}
			set
			{
				if ((this._orderStatus != value))
				{
					this.OnorderStatusChanging(value);
					this.SendPropertyChanging();
					this._orderStatus = value;
					this.SendPropertyChanged("orderStatus");
					this.OnorderStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orderuser", DbType="NVarChar(MAX)")]
		public string orderuser
		{
			get
			{
				return this._orderuser;
			}
			set
			{
				if ((this._orderuser != value))
				{
					this.OnorderuserChanging(value);
					this.SendPropertyChanging();
					this._orderuser = value;
					this.SendPropertyChanged("orderuser");
					this.OnorderuserChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.selectedmenu")]
	public partial class selectedmenu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Desc;
		
		private string _Price;
		
		private System.Data.Linq.Binary _img;
		
		private string _slot;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescChanging(string value);
    partial void OnDescChanged();
    partial void OnPriceChanging(string value);
    partial void OnPriceChanged();
    partial void OnimgChanging(System.Data.Linq.Binary value);
    partial void OnimgChanged();
    partial void OnslotChanging(string value);
    partial void OnslotChanged();
    #endregion
		
		public selectedmenu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Desc]", Storage="_Desc", DbType="NVarChar(MAX)")]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				if ((this._Desc != value))
				{
					this.OnDescChanging(value);
					this.SendPropertyChanging();
					this._Desc = value;
					this.SendPropertyChanged("Desc");
					this.OnDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="NVarChar(MAX)")]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_slot", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string slot
		{
			get
			{
				return this._slot;
			}
			set
			{
				if ((this._slot != value))
				{
					this.OnslotChanging(value);
					this.SendPropertyChanging();
					this._slot = value;
					this.SendPropertyChanged("slot");
					this.OnslotChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _email;
		
		private string _password;
		
		private int _usertype;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnusertypeChanging(int value);
    partial void OnusertypeChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usertype", DbType="Int NOT NULL")]
		public int usertype
		{
			get
			{
				return this._usertype;
			}
			set
			{
				if ((this._usertype != value))
				{
					this.OnusertypeChanging(value);
					this.SendPropertyChanging();
					this._usertype = value;
					this.SendPropertyChanged("usertype");
					this.OnusertypeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
