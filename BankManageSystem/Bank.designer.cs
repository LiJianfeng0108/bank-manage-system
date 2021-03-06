﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1008
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankManageSystem
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bank")]
	public partial class BankDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void InsertAccountInfo(AccountInfo instance);
    partial void UpdateAccountInfo(AccountInfo instance);
    partial void DeleteAccountInfo(AccountInfo instance);
    partial void InsertEmployeeInfo(EmployeeInfo instance);
    partial void UpdateEmployeeInfo(EmployeeInfo instance);
    partial void DeleteEmployeeInfo(EmployeeInfo instance);
    partial void InsertLoginInfo(LoginInfo instance);
    partial void UpdateLoginInfo(LoginInfo instance);
    partial void DeleteLoginInfo(LoginInfo instance);
    partial void InsertMoneyInfo(MoneyInfo instance);
    partial void UpdateMoneyInfo(MoneyInfo instance);
    partial void DeleteMoneyInfo(MoneyInfo instance);
    partial void InsertRateInfo(RateInfo instance);
    partial void UpdateRateInfo(RateInfo instance);
    partial void DeleteRateInfo(RateInfo instance);
    #endregion
		
		public BankDataContext() : 
				base(global::BankManageSystem.Properties.Settings.Default.BankConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BankDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AccountInfo> AccountInfo
		{
			get
			{
				return this.GetTable<AccountInfo>();
			}
		}
		
		public System.Data.Linq.Table<EmployeeInfo> EmployeeInfo
		{
			get
			{
				return this.GetTable<EmployeeInfo>();
			}
		}
		
		public System.Data.Linq.Table<LoginInfo> LoginInfo
		{
			get
			{
				return this.GetTable<LoginInfo>();
			}
		}
		
		public System.Data.Linq.Table<MoneyInfo> MoneyInfo
		{
			get
			{
				return this.GetTable<MoneyInfo>();
			}
		}
		
		public System.Data.Linq.Table<RateInfo> RateInfo
		{
			get
			{
				return this.GetTable<RateInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AccountInfo")]
	public partial class AccountInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _帐号;
		
		private string _身份证号;
		
		private string _姓名;
		
		private string _密码;
		
		private string _存款类型;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void On帐号Changing(string value);
    partial void On帐号Changed();
    partial void On身份证号Changing(string value);
    partial void On身份证号Changed();
    partial void On姓名Changing(string value);
    partial void On姓名Changed();
    partial void On密码Changing(string value);
    partial void On密码Changed();
    partial void On存款类型Changing(string value);
    partial void On存款类型Changed();
    #endregion
		
		public AccountInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_帐号", DbType="NChar(6) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string 帐号
		{
			get
			{
				return this._帐号;
			}
			set
			{
				if ((this._帐号 != value))
				{
					this.On帐号Changing(value);
					this.SendPropertyChanging();
					this._帐号 = value;
					this.SendPropertyChanged("帐号");
					this.On帐号Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_身份证号", DbType="NChar(18) NOT NULL", CanBeNull=false)]
		public string 身份证号
		{
			get
			{
				return this._身份证号;
			}
			set
			{
				if ((this._身份证号 != value))
				{
					this.On身份证号Changing(value);
					this.SendPropertyChanging();
					this._身份证号 = value;
					this.SendPropertyChanged("身份证号");
					this.On身份证号Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_姓名", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string 姓名
		{
			get
			{
				return this._姓名;
			}
			set
			{
				if ((this._姓名 != value))
				{
					this.On姓名Changing(value);
					this.SendPropertyChanging();
					this._姓名 = value;
					this.SendPropertyChanged("姓名");
					this.On姓名Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_密码", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string 密码
		{
			get
			{
				return this._密码;
			}
			set
			{
				if ((this._密码 != value))
				{
					this.On密码Changing(value);
					this.SendPropertyChanging();
					this._密码 = value;
					this.SendPropertyChanged("密码");
					this.On密码Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_存款类型", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string 存款类型
		{
			get
			{
				return this._存款类型;
			}
			set
			{
				if ((this._存款类型 != value))
				{
					this.On存款类型Changing(value);
					this.SendPropertyChanging();
					this._存款类型 = value;
					this.SendPropertyChanged("存款类型");
					this.On存款类型Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EmployeeInfo")]
	public partial class EmployeeInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _编号;
		
		private string _姓名;
		
		private char _性别;
		
		private System.Nullable<System.DateTime> _参加工作日期;
		
		private string _联系电话;
		
		private string _身份证号;
		
		private System.Data.Linq.Binary _照片;
		
		private System.Nullable<decimal> _工资;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void On编号Changing(string value);
    partial void On编号Changed();
    partial void On姓名Changing(string value);
    partial void On姓名Changed();
    partial void On性别Changing(char value);
    partial void On性别Changed();
    partial void On参加工作日期Changing(System.Nullable<System.DateTime> value);
    partial void On参加工作日期Changed();
    partial void On联系电话Changing(string value);
    partial void On联系电话Changed();
    partial void On身份证号Changing(string value);
    partial void On身份证号Changed();
    partial void On照片Changing(System.Data.Linq.Binary value);
    partial void On照片Changed();
    partial void On工资Changing(System.Nullable<decimal> value);
    partial void On工资Changed();
    #endregion
		
		public EmployeeInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_编号", DbType="NChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string 编号
		{
			get
			{
				return this._编号;
			}
			set
			{
				if ((this._编号 != value))
				{
					this.On编号Changing(value);
					this.SendPropertyChanging();
					this._编号 = value;
					this.SendPropertyChanged("编号");
					this.On编号Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_姓名", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string 姓名
		{
			get
			{
				return this._姓名;
			}
			set
			{
				if ((this._姓名 != value))
				{
					this.On姓名Changing(value);
					this.SendPropertyChanging();
					this._姓名 = value;
					this.SendPropertyChanged("姓名");
					this.On姓名Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_性别", DbType="NChar(1) NOT NULL")]
		public char 性别
		{
			get
			{
				return this._性别;
			}
			set
			{
				if ((this._性别 != value))
				{
					this.On性别Changing(value);
					this.SendPropertyChanging();
					this._性别 = value;
					this.SendPropertyChanged("性别");
					this.On性别Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_参加工作日期", DbType="DateTime")]
		public System.Nullable<System.DateTime> 参加工作日期
		{
			get
			{
				return this._参加工作日期;
			}
			set
			{
				if ((this._参加工作日期 != value))
				{
					this.On参加工作日期Changing(value);
					this.SendPropertyChanging();
					this._参加工作日期 = value;
					this.SendPropertyChanged("参加工作日期");
					this.On参加工作日期Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_联系电话", DbType="NVarChar(11)")]
		public string 联系电话
		{
			get
			{
				return this._联系电话;
			}
			set
			{
				if ((this._联系电话 != value))
				{
					this.On联系电话Changing(value);
					this.SendPropertyChanging();
					this._联系电话 = value;
					this.SendPropertyChanged("联系电话");
					this.On联系电话Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_身份证号", DbType="NChar(18) NOT NULL", CanBeNull=false)]
		public string 身份证号
		{
			get
			{
				return this._身份证号;
			}
			set
			{
				if ((this._身份证号 != value))
				{
					this.On身份证号Changing(value);
					this.SendPropertyChanging();
					this._身份证号 = value;
					this.SendPropertyChanged("身份证号");
					this.On身份证号Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_照片", DbType="VarBinary(MAX) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary 照片
		{
			get
			{
				return this._照片;
			}
			set
			{
				if ((this._照片 != value))
				{
					this.On照片Changing(value);
					this.SendPropertyChanging();
					this._照片 = value;
					this.SendPropertyChanged("照片");
					this.On照片Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_工资", DbType="Money")]
		public System.Nullable<decimal> 工资
		{
			get
			{
				return this._工资;
			}
			set
			{
				if ((this._工资 != value))
				{
					this.On工资Changing(value);
					this.SendPropertyChanging();
					this._工资 = value;
					this.SendPropertyChanged("工资");
					this.On工资Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginInfo")]
	public partial class LoginInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _编号;
		
		private string _密码;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void On编号Changing(string value);
    partial void On编号Changed();
    partial void On密码Changing(string value);
    partial void On密码Changed();
    #endregion
		
		public LoginInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_编号", DbType="NChar(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string 编号
		{
			get
			{
				return this._编号;
			}
			set
			{
				if ((this._编号 != value))
				{
					this.On编号Changing(value);
					this.SendPropertyChanging();
					this._编号 = value;
					this.SendPropertyChanged("编号");
					this.On编号Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_密码", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string 密码
		{
			get
			{
				return this._密码;
			}
			set
			{
				if ((this._密码 != value))
				{
					this.On密码Changing(value);
					this.SendPropertyChanging();
					this._密码 = value;
					this.SendPropertyChanged("密码");
					this.On密码Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoneyInfo")]
	public partial class MoneyInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _帐号;
		
		private System.DateTime _发生时间;
		
		private string _发生类别;
		
		private double _发生金额;
		
		private double _余额;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void On帐号Changing(string value);
    partial void On帐号Changed();
    partial void On发生时间Changing(System.DateTime value);
    partial void On发生时间Changed();
    partial void On发生类别Changing(string value);
    partial void On发生类别Changed();
    partial void On发生金额Changing(double value);
    partial void On发生金额Changed();
    partial void On余额Changing(double value);
    partial void On余额Changed();
    #endregion
		
		public MoneyInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_帐号", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string 帐号
		{
			get
			{
				return this._帐号;
			}
			set
			{
				if ((this._帐号 != value))
				{
					this.On帐号Changing(value);
					this.SendPropertyChanging();
					this._帐号 = value;
					this.SendPropertyChanged("帐号");
					this.On帐号Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_发生时间", DbType="DateTime NOT NULL")]
		public System.DateTime 发生时间
		{
			get
			{
				return this._发生时间;
			}
			set
			{
				if ((this._发生时间 != value))
				{
					this.On发生时间Changing(value);
					this.SendPropertyChanging();
					this._发生时间 = value;
					this.SendPropertyChanged("发生时间");
					this.On发生时间Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_发生类别", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string 发生类别
		{
			get
			{
				return this._发生类别;
			}
			set
			{
				if ((this._发生类别 != value))
				{
					this.On发生类别Changing(value);
					this.SendPropertyChanging();
					this._发生类别 = value;
					this.SendPropertyChanged("发生类别");
					this.On发生类别Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_发生金额", DbType="Float NOT NULL")]
		public double 发生金额
		{
			get
			{
				return this._发生金额;
			}
			set
			{
				if ((this._发生金额 != value))
				{
					this.On发生金额Changing(value);
					this.SendPropertyChanging();
					this._发生金额 = value;
					this.SendPropertyChanged("发生金额");
					this.On发生金额Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_余额", DbType="Float NOT NULL")]
		public double 余额
		{
			get
			{
				return this._余额;
			}
			set
			{
				if ((this._余额 != value))
				{
					this.On余额Changing(value);
					this.SendPropertyChanging();
					this._余额 = value;
					this.SendPropertyChanged("余额");
					this.On余额Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RateInfo")]
	public partial class RateInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _类别;
		
		private double _利率;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void On类别Changing(string value);
    partial void On类别Changed();
    partial void On利率Changing(double value);
    partial void On利率Changed();
    #endregion
		
		public RateInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_类别", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string 类别
		{
			get
			{
				return this._类别;
			}
			set
			{
				if ((this._类别 != value))
				{
					this.On类别Changing(value);
					this.SendPropertyChanging();
					this._类别 = value;
					this.SendPropertyChanged("类别");
					this.On类别Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_利率", DbType="Float NOT NULL")]
		public double 利率
		{
			get
			{
				return this._利率;
			}
			set
			{
				if ((this._利率 != value))
				{
					this.On利率Changing(value);
					this.SendPropertyChanging();
					this._利率 = value;
					this.SendPropertyChanged("利率");
					this.On利率Changed();
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
