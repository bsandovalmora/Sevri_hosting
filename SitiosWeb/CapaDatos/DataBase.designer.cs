﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="APSWSEVRI")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataBaseDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.APSWSEVRIConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PrAdmi")]
		public int PrAdmi([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TipoRiesgo", DbType="VarChar(50)")] string tipoRiesgo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Prioridad", DbType="VarChar(50)")] string prioridad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NivelRiesgoInherente", DbType="VarChar(50)")] string nivelRiesgoInherente, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NivelRiesgoResidual", DbType="VarChar(50)")] string nivelRiesgoResidual, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GradoAfectacion", DbType="VarChar(50)")] string gradoAfectacion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Importancia", DbType="VarChar(150)")] string importancia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Variacion", DbType="VarChar(150)")] string variacion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Costo", DbType="Int")] System.Nullable<int> costo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Aceptabilidad", DbType="VarChar(250)")] string aceptabilidad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Resultado", DbType="VarChar(50)")] string resultado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tipoRiesgo, prioridad, nivelRiesgoInherente, nivelRiesgoResidual, gradoAfectacion, importancia, variacion, costo, aceptabilidad, resultado);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.PrEvalu")]
		public int PrEvalu([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="VarChar(50)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ControlActual", DbType="VarChar(50)")] string controlActual, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(250)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Probabilidad", DbType="VarChar(50)")] string probabilidad, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Impacto", DbType="VarChar(50)")] string impacto, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NivelRiesgoInherente", DbType="VarChar(50)")] string nivelRiesgoInherente, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NivelRiesgoResidual", DbType="VarChar(50)")] string nivelRiesgoResidual, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaApli", DbType="Date")] System.Nullable<System.DateTime> fechaApli)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo, controlActual, descripcion, probabilidad, impacto, nivelRiesgoInherente, nivelRiesgoResidual, fechaApli);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ProDiccionario")]
		public int ProDiccionario([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="VarChar(50)")] string codigo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Descripcion", DbType="VarChar(50)")] string descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Categoria", DbType="VarChar(50)")] string categoria, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Subcategoria", DbType="VarChar(50)")] string subcategoria)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo, nombre, descripcion, categoria, subcategoria);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ProEspecif")]
		public int ProEspecif([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodigoEspe", DbType="VarChar(50)")] string codigoEspe, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AreaRiesgo", DbType="VarChar(50)")] string areaRiesgo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DependenciaRiesgo", DbType="VarChar(50)")] string dependenciaRiesgo, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Causa", DbType="VarChar(50)")] string causa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Evento", DbType="VarChar(50)")] string evento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaIdenti", DbType="Date")] System.Nullable<System.DateTime> fechaIdenti, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Consecuencia", DbType="VarChar(50)")] string consecuencia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="VarChar(50)")] string codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigoEspe, areaRiesgo, dependenciaRiesgo, causa, evento, fechaIdenti, consecuencia, codigo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ProGenerales")]
		public int ProGenerales([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CodigoGeneral", DbType="VarChar(50)")] string codigoGeneral, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Causa", DbType="VarChar(50)")] string causa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Consecuencia", DbType="VarChar(50)")] string consecuencia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Evento", DbType="VarChar(50)")] string evento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FechaIdenti", DbType="Date")] System.Nullable<System.DateTime> fechaIdenti, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Codigo", DbType="VarChar(50)")] string codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigoGeneral, nombre, causa, consecuencia, evento, fechaIdenti, codigo);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.inser")]
		public int inser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Usuario", DbType="VarChar(100)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contra", DbType="VarChar(50)")] string contra)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, contra);
			return ((int)(result.ReturnValue));
		}
	}
}
#pragma warning restore 1591
