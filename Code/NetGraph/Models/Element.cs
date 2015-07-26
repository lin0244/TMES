///////////////////////////////////////////////////////////
//  Element.cs
//  Implementation of the Class Element
//  Generated by Enterprise Architect
//  Created on:      11-���-2015 10:53:54
//  Model: Kotova Marina, Vinnichenko Dmitry 
//  Developer: Dergachev Constantine
///////////////////////////////////////////////////////////


using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.SqlClient;

public enum ElementType
{
    [Description("Z")]
    Empty,
    [Description("�")]
    Document,
    [Description("�")]
    Block,
    [Description("�")]
    Detail,
    [Description("�")]
    Normalized,
    [Description("�")]
    Purchased,
    [Description("�")][Obsolete] // ������ ������ ��������� � �������� ��������
    Connector
}


//public class Element : IStorable
//{
//    #region Properties

//    /// <summary>
//    /// �������� ����������, ������� ������������ ������ ������
//    /// </summary>
//    private static Element _root;
//    public static Element Root
//    {
//        get
//        {
//            if (_root == null)
//            {
//                _root = new Element(ElementType.Block, "0000", "00000000000");
//                _root.Parent = null;
//                _root.Depth = "-1";
//            }
//            return _root;
//        }
//    }

//    /// <summary>
//    /// ��������� ����
//    /// </summary>
//    private String _id;
//    public String Id
//    {
//        get
//        {
//            return _id;
//        }
//        set
//        {
//            _id = value;
//        }
//    }

//    /// <summary>
//    /// ��� ��������
//    /// </summary>
//    private ElementType _type;
//    public ElementType Type
//    {
//        get
//        {
//            return _type;
//        }
//        set
//        {
//            _type = value;
//        }
//    }

//    /// <summary>
//    /// ������ �������, ������������ �������� - ������ �������.
//    /// �� ����� ���� ����� ��� �������� �������, ���������� ��� ��� ������ ������.
//    /// </summary>
//    private String _index;
//    public String Index
//    {
//        get
//        {
//            if(_index == null)
//            {
//                return "";
//            }
//            if(Type == ElementType.Purchased)
//            {
//                return "";
//            }
//            return _index;
//        }
//        set
//        {
//            if(value.Length > 4)
//            {
//                throw new ArgumentException("Element's index must not exceed 4 chars. [" + value + "] value is " + value.Length + " chars.");
//            }
      
//            _index = value;
//        }
//    }

//    /// <summary>
//    /// ����������� ������� (PICH). ������������ �������� 47 ������� ��� �������� ������� � 43 ������� ��� ���� ���������.
//    /// </summary>
//    private String _denotation;
//    public String Denotation
//    {
//        get
//        {
//            if(_denotation == null)
//            {
//                return "";
//            }
//            return _denotation;
//        }
//        set
//        {
//            if(Type == ElementType.Purchased)
//            {
//                if(value.Length > 47)
//                {
//                       throw new ArgumentException("Purchased Element's denotation must not exceed 47 chars. [" + value + "] value is " + value.Length + " chars.");
//                }
//            }
//            if(value.Length > 43)
//            {
//                 throw new ArgumentException("Element's denotation must not exceed 43 chars. [" + value + "] value is " + value.Length + " chars.");
//            }
//            _denotation = value;
//        }
//    }

//    /// <summary>
//    /// ������ �� ������������ �������
//    /// </summary>
//    private Element _parent;
//    public Element Parent
//    {
//        get
//        {
//            if (_parent == null)
//            {
//                _parent = new Element();
//            }
//            return _parent;
//        }
//        set
//        {
//            _parent = value;
//        }
//    }

//    /// <summary>
//    /// [�������������� ����] �����, � �������� ��������� ������ ����
//    /// </summary>
//    private String _order;
//    public String Order
//    {
//        get
//        {
//            return _order;
//        }
//        set
//        {
//            _order = value;
//        }
//    }

//    /// <summary>
//    /// ������� ����������� ��������
//    /// </summary>
//    private String _depth;
//    public String Depth
//    {
//        get
//        {
//            return _depth;
//        }
//        set
//        {
//            _depth = value;
//        }
//    }

//   ///<summary>
//   /// ���������� 
//   ///</summary>
//    private String _quantity;
//    public String Quantity
//    {
//        get
//        {
//            return _quantity;
//        }
//        set
//        {
//            _quantity = null;
//        }
//    }


//    //public double Code;
//    //private double Duration;
//    //public int ElementID;
//    //public Element List<elements>;

//    private List<Work> _works;
//    public List<Work> Works
//    {
//        get
//        {
//            if (_works == null)
//            {
//                _works = GetListWork();
//            }
//            return _works;
//        }
//        set
//        {
//            _works = value;
//        }
//    }

//    //public string Name;
//    //public Order Order;

//    //public Order m_Order;

//    #endregion Properties

//    #region Constructor


//    /// <summary>
//    /// ������ �����������, ���������� ����� ������
//    /// </summary>
//    public Element()
//    {

//    }

//    /// <summary>
//    /// ����������� ��� ��������
//    /// </summary>
//    /// <param name="Type_"></param>
//    /// <param name="Index_"></param>
//    /// <param name="Denotation_"></param>
//    public Element(ElementType Type_, String Index_, String Denotation_, Element Parent_ = null, String Order_ = null, String Quantity = null)
//    {
//        this.Type = Type_;
//        this.Index = Index_;
//        this.Denotation = Denotation_;

//        if (Parent_ != null)
//        {
//            this.Parent = Parent_;
//        }
//        if (Order_ != null)
//        {
//            this.Index = Index_;
//        }
//        if (Quantity != null)
//        {
//            this.Quantity = Denotation_;
//        }
//    }

//    /// 
//    /// <param name="Name"></param>
//    /// <param name="ElementID"></param>
//    public Element(string Name, int ElementID){

//    }

//    /// 
//    /// <param name="List<element>"></param>
//    /// <param name="Code"></param>
//    /// <param name="Order"></param>
//    /// <param name="Type"></param>
//    /// <param name="Name"></param>
//    /// <param name="ElementID"></param>
//    //public Element(Element List<element>, char Code, Order Order, string Type, string Name, int ElementID)
//    //{

//    //}

	

    
//    ~Element()
//    {

//    }

//    public virtual void Dispose()
//    {

//    }



//    #endregion Constructor


//#region Methods 

//    public bool Delete(){

//        return false;
//    }

//    /// 
//    /// <param name="Code"></param>
//    public static Element GetByCode(double Code){

//        return null;
//    }

//    /// 
//    /// <param name="ElementID"></param>
//    public static Element GetByID(int ElementID){

//        return null;
//    }

//    /// 
//    /// <param name="Order"></param>
//    //public static List<Element> GetByOrder(Order Order){

//    //    return null;
//    //}

//    public List<Work> GetListWork()
//    {
//        var Result = new List<Work>();
//        SqlCommand Cmd = new SqlCommand("", DBManager.MainConn);
//        Cmd.CommandText = @"SELECT * FROM [NetGraph].[dbo].[TEXNORM]
//                            WHERE IND = @IND AND PICH = @PICH";
//        Cmd.Parameters.AddWithValue("IND", Index);
//        Cmd.Parameters.AddWithValue("PICH", Denotation);
//        using (SqlDataReader dr = Cmd.ExecuteReader())
//        {
//            var TargetElement = new Element();
//            TargetElement.Type = Type;
//            TargetElement.Index = Index;
//            TargetElement.Denotation = Denotation;
//            while (dr.Read())
//            {
         
//                var Work = new Work();
               
//              //  Work.Department = Department.GetByShortName(dr["C"].ToString());
//                Work.Duration = Convert.ToDouble(dr["NV"]);
//                Work.Target.Add(TargetElement);
//                Work.ExecutionChain = Convert.ToInt32(dr["F"]);

//                Result.Add(Work);
//            }
//        }
//        return Result;
//    }

//    public bool Insert(){

//        return false;
//    }

//    public List<Element> Razuzlovat(){

//        return null;
//    }

//    public IStorable Select(){

//        return null;
//    }

//    public List<IStorable> SelectAll(){

//        return null;
//    }

//    public bool Update(){

//        return false;
//    }

//#endregion Methods


//#region Logic

//#endregion Logic 

//}