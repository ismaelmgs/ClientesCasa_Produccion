﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientesCasa.Objetos
{
    [Serializable]
    public class Factura : BaseObjeto
    {
        private string _sEmpresa = string.Empty;
        private int _iId = 0;
        private string _sSucursal = string.Empty;
        private DateTime _dtFecha = DateTime.Now;
        private string _sProveedor = string.Empty;
        private string _sNoFactura = string.Empty;
        private string _sTipoFactura = string.Empty;
        private string _sFormaPago = string.Empty;
        private string _sComentarios = string.Empty;
        private string _sSerie = string.Empty;
        private string _sMoneda = string.Empty;
        private int _iTimbrar = 0;
        private decimal _dDescuento = 0;
        private string _sMetodoPago = string.Empty;
        private decimal _dTipoCambio = 0;
        private string _sUID = string.Empty;

        private string _sUsoCFDI = string.Empty;
        private DateTime _dtFechaExp = DateTime.Now;
        private DateTime _dtFechaImp = DateTime.Now;
        private string _sMsg = string.Empty;

        private int _iDocSAP = 0;
        private List<ConceptosFactura> _oLstConceptos = new List<ConceptosFactura>();

        //Variables de XML para inserción en SAP
        private string _sRFC = string.Empty;
        private string _sMonto = string.Empty;

        //private int _iLinea = 0;
        //private string _sItem = string.Empty;

        public string sEmpresa { get { return _sEmpresa; } set { _sEmpresa = value; } }
        public int iId { get { return _iId; } set { _iId = value; } }
        public string sSucursal { get { return _sSucursal; } set { _sSucursal = value; } }
        public DateTime dtFecha { get { return _dtFecha; } set { _dtFecha = value; } }
        public string sProveedor { get { return _sProveedor; } set { _sProveedor = value; } }
        public string sNoFactura { get { return _sNoFactura; } set { _sNoFactura = value; } }
        public string sTipoFactura { get { return _sTipoFactura; } set { _sTipoFactura = value; } }
        public string sFormaPago { get { return _sFormaPago; } set { _sFormaPago = value; } }
        public string sComentarios { get { return _sComentarios; } set { _sComentarios = value; } }
        public string sSerie { get { return _sSerie; } set { _sSerie = value; } }
        public string sMoneda { get { return _sMoneda; } set { _sMoneda = value; } }
        public int iTimbrar { get { return _iTimbrar; } set { _iTimbrar = value; } }
        public decimal dDescuento { get { return _dDescuento; } set { _dDescuento = value; } }
        public string sMetodoPago { get { return _sMetodoPago; } set { _sMetodoPago = value; } }
        public decimal dTipoCambio { get { return _dTipoCambio; } set { _dTipoCambio = value; } }
        public string sUID { get { return _sUID; } set { _sUID = value; } }
        public string sUsoCFDI { get { return _sUsoCFDI; } set { _sUsoCFDI = value; } }
        public DateTime dtFechaExp { get { return _dtFechaExp; } set { _dtFechaExp = value; } }
        public DateTime dtFechaImp { get { return _dtFechaImp; } set { _dtFechaImp = value; } }
        public string sMsg { get { return _sMsg; } set { _sMsg = value; } }

        public int iDocSAP { get { return _iDocSAP; } set { _iDocSAP = value; } }
        public List<ConceptosFactura> oLstConceptos { get { return _oLstConceptos; } set { _oLstConceptos = value; } }

        public string sRFC { get { return _sRFC; } set { _sRFC = value; } }
        public string sMonto { get { return _sMonto; } set { _sMonto = value; } }
        
        
        //public string sItem { get { return _sItem; } set { _sItem = value; } }
        //public int iLinea { get { return _iLinea; } set { _iLinea = value; } }
    }

    [Serializable]
    public class ConceptosFactura
    {
        private string _sEmpresa = string.Empty;
        private int _iId = 0;
        private int _iLinea = 0;
        private string _sItem = string.Empty;
        private string _sDescripcionUsuario = string.Empty;
        private string _CodBarras = string.Empty;
        private decimal _dCantidad = 0;
        private decimal _dPrecio = 0;
        private int _iImpuesto = 0;
        private string _sCodigoImpuesto = string.Empty;
        private decimal _dDescuento = 0;
        private decimal _dTotalLinea = 0;
        private string _sCuenta = string.Empty;
        private string _sAlmacen = string.Empty;
        private string _sProyecto = string.Empty;
        private string _sDimension1 = string.Empty;
        private string _sDimension2 = string.Empty;
        private string _sDimension3 = string.Empty;
        private string _sDimension4 = string.Empty;
        private string _sDimension5 = string.Empty;
        private string _sXML = string.Empty;
        private string _sPDF = string.Empty;
        private string _sLugar = string.Empty;
        private string _sFechaOperacion = string.Empty;

        private string _sTipo = string.Empty;


        public string sEmpresa { get { return _sEmpresa; } set { _sEmpresa = value; } }
        public int iId { get { return _iId; } set { _iId = value; } }
        public int iLinea { get { return _iLinea; } set { _iLinea = value; } }
        public string sItem { get { return _sItem; } set { _sItem = value; } }
        public string sDescripcionUsuario { get { return _sDescripcionUsuario; } set { _sDescripcionUsuario = value; } }
        public string sCodBarras { get { return _CodBarras; } set { _CodBarras = value; } }
        public decimal dCantidad { get { return _dCantidad; } set { _dCantidad = value; } }
        public decimal dPrecio { get { return _dPrecio; } set { _dPrecio = value; } }
        public int iImpuesto { get { return _iImpuesto; } set { _iImpuesto = value; } }
        public string sCodigoImpuesto { get { return _sCodigoImpuesto; } set { _sCodigoImpuesto = value; } }
        public decimal dDescuento { get { return _dDescuento; } set { _dDescuento = value; } }
        public decimal dTotalLinea { get { return _dTotalLinea; } set { _dTotalLinea = value; } }
        public string sCuenta { get { return _sCuenta; } set { _sCuenta = value; } }
        public string sAlmacen { get { return _sAlmacen; } set { _sAlmacen = value; } }
        public string sProyecto { get { return _sProyecto; } set { _sProyecto = value; } }
        public string sDimension1 { get { return _sDimension1; } set { _sDimension1 = value; } }
        public string sDimension2 { get { return _sDimension2; } set { _sDimension2 = value; } }
        public string sDimension3 { get { return _sDimension3; } set { _sDimension3 = value; } }
        public string sDimension4 { get { return _sDimension4; } set { _sDimension4 = value; } }
        public string sDimension5 { get { return _sDimension5; } set { _sDimension5 = value; } }
        public string sXML { get { return _sXML; } set { _sXML = value; } }
        public string sPDF { get { return _sPDF; } set { _sPDF = value; } }
        public string sLugar { get { return _sLugar; } set { _sLugar = value; } }
        public string sFechaOperacion { get { return _sFechaOperacion; } set { _sFechaOperacion = value; } }
        public string sTipo { get { return _sTipo; } set { _sTipo = value; } }
        
    }
}