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

namespace DA_WebBanQuanAo.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_SHOP1")]
	public partial class QLShopDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPHANQUYEN(PHANQUYEN instance);
    partial void UpdatePHANQUYEN(PHANQUYEN instance);
    partial void DeletePHANQUYEN(PHANQUYEN instance);
    partial void InsertTAIKHOAN(TAIKHOAN instance);
    partial void UpdateTAIKHOAN(TAIKHOAN instance);
    partial void DeleteTAIKHOAN(TAIKHOAN instance);
    partial void InsertLOAI(LOAI instance);
    partial void UpdateLOAI(LOAI instance);
    partial void DeleteLOAI(LOAI instance);
    partial void InsertPHANQUYEN1(PHANQUYEN1 instance);
    partial void UpdatePHANQUYEN1(PHANQUYEN1 instance);
    partial void DeletePHANQUYEN1(PHANQUYEN1 instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertHOADON(HOADON instance);
    partial void UpdateHOADON(HOADON instance);
    partial void DeleteHOADON(HOADON instance);
    partial void InsertCT_HOADON(CT_HOADON instance);
    partial void UpdateCT_HOADON(CT_HOADON instance);
    partial void DeleteCT_HOADON(CT_HOADON instance);
    #endregion
		
		public QLShopDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QL_SHOP1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLShopDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLShopDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PHANQUYEN> PHANQUYENs
		{
			get
			{
				return this.GetTable<PHANQUYEN>();
			}
		}
		
		public System.Data.Linq.Table<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this.GetTable<TAIKHOAN>();
			}
		}
		
		public System.Data.Linq.Table<LOAI> LOAIs
		{
			get
			{
				return this.GetTable<LOAI>();
			}
		}
		
		public System.Data.Linq.Table<PHANQUYEN1> PHANQUYEN1s
		{
			get
			{
				return this.GetTable<PHANQUYEN1>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<HOADON> HOADONs
		{
			get
			{
				return this.GetTable<HOADON>();
			}
		}
		
		public System.Data.Linq.Table<CT_HOADON> CT_HOADONs
		{
			get
			{
				return this.GetTable<CT_HOADON>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHANQUYEN")]
	public partial class PHANQUYEN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaQuyen;
		
		private string _TenQuyen;
		
		private EntitySet<TAIKHOAN> _TAIKHOANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaQuyenChanging(int value);
    partial void OnMaQuyenChanged();
    partial void OnTenQuyenChanging(string value);
    partial void OnTenQuyenChanged();
    #endregion
		
		public PHANQUYEN()
		{
			this._TAIKHOANs = new EntitySet<TAIKHOAN>(new Action<TAIKHOAN>(this.attach_TAIKHOANs), new Action<TAIKHOAN>(this.detach_TAIKHOANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQuyen", DbType="NVarChar(50)")]
		public string TenQuyen
		{
			get
			{
				return this._TenQuyen;
			}
			set
			{
				if ((this._TenQuyen != value))
				{
					this.OnTenQuyenChanging(value);
					this.SendPropertyChanging();
					this._TenQuyen = value;
					this.SendPropertyChanged("TenQuyen");
					this.OnTenQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANQUYEN_TAIKHOAN", Storage="_TAIKHOANs", ThisKey="MaQuyen", OtherKey="MaQuyen")]
		public EntitySet<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this._TAIKHOANs;
			}
			set
			{
				this._TAIKHOANs.Assign(value);
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
		
		private void attach_TAIKHOANs(TAIKHOAN entity)
		{
			this.SendPropertyChanging();
			entity.PHANQUYEN = this;
		}
		
		private void detach_TAIKHOANs(TAIKHOAN entity)
		{
			this.SendPropertyChanging();
			entity.PHANQUYEN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TAIKHOAN")]
	public partial class TAIKHOAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TenTK;
		
		private string _HoTen;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _Gmail;
		
		private string _DienThoai;
		
		private System.Nullable<int> _MaQuyen;
		
		private string _Pass;
		
		private EntitySet<HOADON> _HOADONs;
		
		private EntityRef<PHANQUYEN> _PHANQUYEN;
		
		private EntityRef<PHANQUYEN1> _PHANQUYEN1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnGmailChanging(string value);
    partial void OnGmailChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnMaQuyenChanging(System.Nullable<int> value);
    partial void OnMaQuyenChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    #endregion
		
		public TAIKHOAN()
		{
			this._HOADONs = new EntitySet<HOADON>(new Action<HOADON>(this.attach_HOADONs), new Action<HOADON>(this.detach_HOADONs));
			this._PHANQUYEN = default(EntityRef<PHANQUYEN>);
			this._PHANQUYEN1 = default(EntityRef<PHANQUYEN1>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="NVarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(5)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gmail", DbType="VarChar(50)")]
		public string Gmail
		{
			get
			{
				return this._Gmail;
			}
			set
			{
				if ((this._Gmail != value))
				{
					this.OnGmailChanging(value);
					this.SendPropertyChanging();
					this._Gmail = value;
					this.SendPropertyChanged("Gmail");
					this.OnGmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="Char(10)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", DbType="Int")]
		public System.Nullable<int> MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					if ((this._PHANQUYEN.HasLoadedOrAssignedValue || this._PHANQUYEN1.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(50)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAIKHOAN_HOADON", Storage="_HOADONs", ThisKey="TenTK", OtherKey="TenTK")]
		public EntitySet<HOADON> HOADONs
		{
			get
			{
				return this._HOADONs;
			}
			set
			{
				this._HOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANQUYEN_TAIKHOAN", Storage="_PHANQUYEN", ThisKey="MaQuyen", OtherKey="MaQuyen", IsForeignKey=true)]
		public PHANQUYEN PHANQUYEN
		{
			get
			{
				return this._PHANQUYEN.Entity;
			}
			set
			{
				PHANQUYEN previousValue = this._PHANQUYEN.Entity;
				if (((previousValue != value) 
							|| (this._PHANQUYEN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHANQUYEN.Entity = null;
						previousValue.TAIKHOANs.Remove(this);
					}
					this._PHANQUYEN.Entity = value;
					if ((value != null))
					{
						value.TAIKHOANs.Add(this);
						this._MaQuyen = value.MaQuyen;
					}
					else
					{
						this._MaQuyen = default(Nullable<int>);
					}
					this.SendPropertyChanged("PHANQUYEN");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANQUYEN1_TAIKHOAN", Storage="_PHANQUYEN1", ThisKey="MaQuyen", OtherKey="MaQuyen", IsForeignKey=true)]
		public PHANQUYEN1 PHANQUYEN1
		{
			get
			{
				return this._PHANQUYEN1.Entity;
			}
			set
			{
				PHANQUYEN1 previousValue = this._PHANQUYEN1.Entity;
				if (((previousValue != value) 
							|| (this._PHANQUYEN1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PHANQUYEN1.Entity = null;
						previousValue.TAIKHOANs.Remove(this);
					}
					this._PHANQUYEN1.Entity = value;
					if ((value != null))
					{
						value.TAIKHOANs.Add(this);
						this._MaQuyen = value.MaQuyen;
					}
					else
					{
						this._MaQuyen = default(Nullable<int>);
					}
					this.SendPropertyChanged("PHANQUYEN1");
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
		
		private void attach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.TAIKHOAN = this;
		}
		
		private void detach_HOADONs(HOADON entity)
		{
			this.SendPropertyChanging();
			entity.TAIKHOAN = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAI")]
	public partial class LOAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoai;
		
		private string _TenLoai;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    #endregion
		
		public LOAI()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(50)")]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_SANPHAM", Storage="_SANPHAMs", ThisKey="MaLoai", OtherKey="MaLoai")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAI = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PHANQUYEN")]
	public partial class PHANQUYEN1 : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaQuyen;
		
		private string _TenQuyen;
		
		private EntitySet<TAIKHOAN> _TAIKHOANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaQuyenChanging(int value);
    partial void OnMaQuyenChanged();
    partial void OnTenQuyenChanging(string value);
    partial void OnTenQuyenChanged();
    #endregion
		
		public PHANQUYEN1()
		{
			this._TAIKHOANs = new EntitySet<TAIKHOAN>(new Action<TAIKHOAN>(this.attach_TAIKHOANs), new Action<TAIKHOAN>(this.detach_TAIKHOANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQuyen", DbType="NVarChar(50)")]
		public string TenQuyen
		{
			get
			{
				return this._TenQuyen;
			}
			set
			{
				if ((this._TenQuyen != value))
				{
					this.OnTenQuyenChanging(value);
					this.SendPropertyChanging();
					this._TenQuyen = value;
					this.SendPropertyChanged("TenQuyen");
					this.OnTenQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PHANQUYEN1_TAIKHOAN", Storage="_TAIKHOANs", ThisKey="MaQuyen", OtherKey="MaQuyen")]
		public EntitySet<TAIKHOAN> TAIKHOANs
		{
			get
			{
				return this._TAIKHOANs;
			}
			set
			{
				this._TAIKHOANs.Assign(value);
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
		
		private void attach_TAIKHOANs(TAIKHOAN entity)
		{
			this.SendPropertyChanging();
			entity.PHANQUYEN1 = this;
		}
		
		private void detach_TAIKHOANs(TAIKHOAN entity)
		{
			this.SendPropertyChanging();
			entity.PHANQUYEN1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private string _DoiTuong;
		
		private System.Nullable<decimal> _Gia;
		
		private string _MaLoai;
		
		private System.Nullable<int> _SoLuong;
		
		private string _Images;
		
		private string _MoTa;
		
		private EntitySet<CT_HOADON> _CT_HOADONs;
		
		private EntityRef<LOAI> _LOAI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnDoiTuongChanging(string value);
    partial void OnDoiTuongChanged();
    partial void OnGiaChanging(System.Nullable<decimal> value);
    partial void OnGiaChanged();
    partial void OnMaLoaiChanging(string value);
    partial void OnMaLoaiChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnImagesChanging(string value);
    partial void OnImagesChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public SANPHAM()
		{
			this._CT_HOADONs = new EntitySet<CT_HOADON>(new Action<CT_HOADON>(this.attach_CT_HOADONs), new Action<CT_HOADON>(this.detach_CT_HOADONs));
			this._LOAI = default(EntityRef<LOAI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(50)")]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoiTuong", DbType="NVarChar(50)")]
		public string DoiTuong
		{
			get
			{
				return this._DoiTuong;
			}
			set
			{
				if ((this._DoiTuong != value))
				{
					this.OnDoiTuongChanging(value);
					this.SendPropertyChanging();
					this._DoiTuong = value;
					this.SendPropertyChanged("DoiTuong");
					this.OnDoiTuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Money")]
		public System.Nullable<decimal> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoai", DbType="NVarChar(50)")]
		public string MaLoai
		{
			get
			{
				return this._MaLoai;
			}
			set
			{
				if ((this._MaLoai != value))
				{
					if (this._LOAI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiChanging(value);
					this.SendPropertyChanging();
					this._MaLoai = value;
					this.SendPropertyChanged("MaLoai");
					this.OnMaLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Images", DbType="NVarChar(50)")]
		public string Images
		{
			get
			{
				return this._Images;
			}
			set
			{
				if ((this._Images != value))
				{
					this.OnImagesChanging(value);
					this.SendPropertyChanging();
					this._Images = value;
					this.SendPropertyChanged("Images");
					this.OnImagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(500)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CT_HOADON", Storage="_CT_HOADONs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<CT_HOADON> CT_HOADONs
		{
			get
			{
				return this._CT_HOADONs;
			}
			set
			{
				this._CT_HOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_SANPHAM", Storage="_LOAI", ThisKey="MaLoai", OtherKey="MaLoai", IsForeignKey=true)]
		public LOAI LOAI
		{
			get
			{
				return this._LOAI.Entity;
			}
			set
			{
				LOAI previousValue = this._LOAI.Entity;
				if (((previousValue != value) 
							|| (this._LOAI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAI.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAI.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaLoai = value.MaLoai;
					}
					else
					{
						this._MaLoai = default(string);
					}
					this.SendPropertyChanged("LOAI");
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
		
		private void attach_CT_HOADONs(CT_HOADON entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = this;
		}
		
		private void detach_CT_HOADONs(CT_HOADON entity)
		{
			this.SendPropertyChanging();
			entity.SANPHAM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOADON")]
	public partial class HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private string _TenTK;
		
		private System.Nullable<System.DateTime> _NgayDat;
		
		private System.Nullable<decimal> _TongTien;
		
		private System.Nullable<System.DateTime> _ngaygiao;
		
		private EntitySet<CT_HOADON> _CT_HOADONs;
		
		private EntityRef<TAIKHOAN> _TAIKHOAN;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnTenTKChanging(string value);
    partial void OnTenTKChanged();
    partial void OnNgayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDatChanged();
    partial void OnTongTienChanging(System.Nullable<decimal> value);
    partial void OnTongTienChanged();
    partial void OnngaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnngaygiaoChanged();
    #endregion
		
		public HOADON()
		{
			this._CT_HOADONs = new EntitySet<CT_HOADON>(new Action<CT_HOADON>(this.attach_CT_HOADONs), new Action<CT_HOADON>(this.detach_CT_HOADONs));
			this._TAIKHOAN = default(EntityRef<TAIKHOAN>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTK", DbType="NVarChar(20)")]
		public string TenTK
		{
			get
			{
				return this._TenTK;
			}
			set
			{
				if ((this._TenTK != value))
				{
					if (this._TAIKHOAN.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTenTKChanging(value);
					this.SendPropertyChanging();
					this._TenTK = value;
					this.SendPropertyChanged("TenTK");
					this.OnTenTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="Date")]
		public System.Nullable<System.DateTime> NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Money")]
		public System.Nullable<decimal> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaygiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> ngaygiao
		{
			get
			{
				return this._ngaygiao;
			}
			set
			{
				if ((this._ngaygiao != value))
				{
					this.OnngaygiaoChanging(value);
					this.SendPropertyChanging();
					this._ngaygiao = value;
					this.SendPropertyChanged("ngaygiao");
					this.OnngaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CT_HOADON", Storage="_CT_HOADONs", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<CT_HOADON> CT_HOADONs
		{
			get
			{
				return this._CT_HOADONs;
			}
			set
			{
				this._CT_HOADONs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TAIKHOAN_HOADON", Storage="_TAIKHOAN", ThisKey="TenTK", OtherKey="TenTK", IsForeignKey=true)]
		public TAIKHOAN TAIKHOAN
		{
			get
			{
				return this._TAIKHOAN.Entity;
			}
			set
			{
				TAIKHOAN previousValue = this._TAIKHOAN.Entity;
				if (((previousValue != value) 
							|| (this._TAIKHOAN.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TAIKHOAN.Entity = null;
						previousValue.HOADONs.Remove(this);
					}
					this._TAIKHOAN.Entity = value;
					if ((value != null))
					{
						value.HOADONs.Add(this);
						this._TenTK = value.TenTK;
					}
					else
					{
						this._TenTK = default(string);
					}
					this.SendPropertyChanged("TAIKHOAN");
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
		
		private void attach_CT_HOADONs(CT_HOADON entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = this;
		}
		
		private void detach_CT_HOADONs(CT_HOADON entity)
		{
			this.SendPropertyChanging();
			entity.HOADON = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CT_HOADON")]
	public partial class CT_HOADON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private int _MaSP;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<decimal> _ThanhTien;
		
		private EntityRef<HOADON> _HOADON;
		
		private EntityRef<SANPHAM> _SANPHAM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnThanhTienChanging(System.Nullable<decimal> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public CT_HOADON()
		{
			this._HOADON = default(EntityRef<HOADON>);
			this._SANPHAM = default(EntityRef<SANPHAM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._HOADON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SANPHAM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Money")]
		public System.Nullable<decimal> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HOADON_CT_HOADON", Storage="_HOADON", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public HOADON HOADON
		{
			get
			{
				return this._HOADON.Entity;
			}
			set
			{
				HOADON previousValue = this._HOADON.Entity;
				if (((previousValue != value) 
							|| (this._HOADON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HOADON.Entity = null;
						previousValue.CT_HOADONs.Remove(this);
					}
					this._HOADON.Entity = value;
					if ((value != null))
					{
						value.CT_HOADONs.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(int);
					}
					this.SendPropertyChanged("HOADON");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SANPHAM_CT_HOADON", Storage="_SANPHAM", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SANPHAM SANPHAM
		{
			get
			{
				return this._SANPHAM.Entity;
			}
			set
			{
				SANPHAM previousValue = this._SANPHAM.Entity;
				if (((previousValue != value) 
							|| (this._SANPHAM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SANPHAM.Entity = null;
						previousValue.CT_HOADONs.Remove(this);
					}
					this._SANPHAM.Entity = value;
					if ((value != null))
					{
						value.CT_HOADONs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(int);
					}
					this.SendPropertyChanged("SANPHAM");
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
