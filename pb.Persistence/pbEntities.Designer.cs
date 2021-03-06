﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace pb.Persistence
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class pbDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new pbDbEntities object using the connection string found in the 'pbDbEntities' section of the application configuration file.
        /// </summary>
        public pbDbEntities() : base("name=pbDbEntities", "pbDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new pbDbEntities object.
        /// </summary>
        public pbDbEntities(string connectionString) : base(connectionString, "pbDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new pbDbEntities object.
        /// </summary>
        public pbDbEntities(EntityConnection connection) : base(connection, "pbDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Order> Orders
        {
            get
            {
                if ((_Orders == null))
                {
                    _Orders = base.CreateObjectSet<Order>("Orders");
                }
                return _Orders;
            }
        }
        private ObjectSet<Order> _Orders;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOrders(Order order)
        {
            base.AddObject("Orders", order);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="pbDbModel", Name="Order")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Order : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderId">Initial value of the OrderId property.</param>
        /// <param name="size">Initial value of the Size property.</param>
        /// <param name="crust">Initial value of the Crust property.</param>
        /// <param name="sausage">Initial value of the Sausage property.</param>
        /// <param name="pepperoni">Initial value of the Pepperoni property.</param>
        /// <param name="onions">Initial value of the Onions property.</param>
        /// <param name="greenPeppers">Initial value of the GreenPeppers property.</param>
        /// <param name="totalCost">Initial value of the TotalCost property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        /// <param name="zip">Initial value of the Zip property.</param>
        /// <param name="phone">Initial value of the Phone property.</param>
        /// <param name="paymentType">Initial value of the PaymentType property.</param>
        /// <param name="complete">Initial value of the Complete property.</param>
        public static Order CreateOrder(global::System.Guid orderId, SizeType size, global::System.Int32 crust, global::System.Boolean sausage, global::System.Boolean pepperoni, global::System.Boolean onions, global::System.Boolean greenPeppers, global::System.Decimal totalCost, global::System.String name, global::System.String address, global::System.String zip, global::System.String phone, global::System.Int32 paymentType, global::System.Boolean complete)
        {
            Order order = new Order();
            order.OrderId = orderId;
            order.Size = size;
            order.Crust = crust;
            order.Sausage = sausage;
            order.Pepperoni = pepperoni;
            order.Onions = onions;
            order.GreenPeppers = greenPeppers;
            order.TotalCost = totalCost;
            order.Name = name;
            order.Address = address;
            order.Zip = zip;
            order.Phone = phone;
            order.PaymentType = paymentType;
            order.Complete = complete;
            return order;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid OrderId
        {
            get
            {
                return _OrderId;
            }
            set
            {
                if (_OrderId != value)
                {
                    OnOrderIdChanging(value);
                    ReportPropertyChanging("OrderId");
                    _OrderId = StructuralObject.SetValidValue(value, "OrderId");
                    ReportPropertyChanged("OrderId");
                    OnOrderIdChanged();
                }
            }
        }
        private global::System.Guid _OrderId;
        partial void OnOrderIdChanging(global::System.Guid value);
        partial void OnOrderIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public SizeType Size
        {
            get
            {
                return _Size;
            }
            set
            {
                OnSizeChanging(value);
                ReportPropertyChanging("Size");
                _Size = (SizeType)StructuralObject.SetValidValue((int)value, "Size");
                ReportPropertyChanged("Size");
                OnSizeChanged();
            }
        }
        private SizeType _Size;
        partial void OnSizeChanging(SizeType value);
        partial void OnSizeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Crust
        {
            get
            {
                return _Crust;
            }
            set
            {
                OnCrustChanging(value);
                ReportPropertyChanging("Crust");
                _Crust = StructuralObject.SetValidValue(value, "Crust");
                ReportPropertyChanged("Crust");
                OnCrustChanged();
            }
        }
        private global::System.Int32 _Crust;
        partial void OnCrustChanging(global::System.Int32 value);
        partial void OnCrustChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Sausage
        {
            get
            {
                return _Sausage;
            }
            set
            {
                OnSausageChanging(value);
                ReportPropertyChanging("Sausage");
                _Sausage = StructuralObject.SetValidValue(value, "Sausage");
                ReportPropertyChanged("Sausage");
                OnSausageChanged();
            }
        }
        private global::System.Boolean _Sausage;
        partial void OnSausageChanging(global::System.Boolean value);
        partial void OnSausageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Pepperoni
        {
            get
            {
                return _Pepperoni;
            }
            set
            {
                OnPepperoniChanging(value);
                ReportPropertyChanging("Pepperoni");
                _Pepperoni = StructuralObject.SetValidValue(value, "Pepperoni");
                ReportPropertyChanged("Pepperoni");
                OnPepperoniChanged();
            }
        }
        private global::System.Boolean _Pepperoni;
        partial void OnPepperoniChanging(global::System.Boolean value);
        partial void OnPepperoniChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Onions
        {
            get
            {
                return _Onions;
            }
            set
            {
                OnOnionsChanging(value);
                ReportPropertyChanging("Onions");
                _Onions = StructuralObject.SetValidValue(value, "Onions");
                ReportPropertyChanged("Onions");
                OnOnionsChanged();
            }
        }
        private global::System.Boolean _Onions;
        partial void OnOnionsChanging(global::System.Boolean value);
        partial void OnOnionsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean GreenPeppers
        {
            get
            {
                return _GreenPeppers;
            }
            set
            {
                OnGreenPeppersChanging(value);
                ReportPropertyChanging("GreenPeppers");
                _GreenPeppers = StructuralObject.SetValidValue(value, "GreenPeppers");
                ReportPropertyChanged("GreenPeppers");
                OnGreenPeppersChanged();
            }
        }
        private global::System.Boolean _GreenPeppers;
        partial void OnGreenPeppersChanging(global::System.Boolean value);
        partial void OnGreenPeppersChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal TotalCost
        {
            get
            {
                return _TotalCost;
            }
            set
            {
                OnTotalCostChanging(value);
                ReportPropertyChanging("TotalCost");
                _TotalCost = StructuralObject.SetValidValue(value, "TotalCost");
                ReportPropertyChanged("TotalCost");
                OnTotalCostChanged();
            }
        }
        private global::System.Decimal _TotalCost;
        partial void OnTotalCostChanging(global::System.Decimal value);
        partial void OnTotalCostChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false, "Address");
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Zip
        {
            get
            {
                return _Zip;
            }
            set
            {
                OnZipChanging(value);
                ReportPropertyChanging("Zip");
                _Zip = StructuralObject.SetValidValue(value, false, "Zip");
                ReportPropertyChanged("Zip");
                OnZipChanged();
            }
        }
        private global::System.String _Zip;
        partial void OnZipChanging(global::System.String value);
        partial void OnZipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                OnPhoneChanging(value);
                ReportPropertyChanging("Phone");
                _Phone = StructuralObject.SetValidValue(value, false, "Phone");
                ReportPropertyChanged("Phone");
                OnPhoneChanged();
            }
        }
        private global::System.String _Phone;
        partial void OnPhoneChanging(global::System.String value);
        partial void OnPhoneChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PaymentType
        {
            get
            {
                return _PaymentType;
            }
            set
            {
                OnPaymentTypeChanging(value);
                ReportPropertyChanging("PaymentType");
                _PaymentType = StructuralObject.SetValidValue(value, "PaymentType");
                ReportPropertyChanged("PaymentType");
                OnPaymentTypeChanged();
            }
        }
        private global::System.Int32 _PaymentType;
        partial void OnPaymentTypeChanging(global::System.Int32 value);
        partial void OnPaymentTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Complete
        {
            get
            {
                return _Complete;
            }
            set
            {
                OnCompleteChanging(value);
                ReportPropertyChanging("Complete");
                _Complete = StructuralObject.SetValidValue(value, "Complete");
                ReportPropertyChanged("Complete");
                OnCompleteChanged();
            }
        }
        private global::System.Boolean _Complete;
        partial void OnCompleteChanging(global::System.Boolean value);
        partial void OnCompleteChanged();

        #endregion

    }

    #endregion

    #region Enums
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEnumTypeAttribute(NamespaceName="pbDbModel", Name="SizeType")]
    [DataContractAttribute()]
    public enum SizeType : int
    {
    }

    #endregion

}
