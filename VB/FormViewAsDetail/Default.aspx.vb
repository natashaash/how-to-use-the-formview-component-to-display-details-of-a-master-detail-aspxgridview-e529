Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGridView

Namespace FormViewAsDetail
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
		Protected Sub FormView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
			Dim fv As FormView = CType(sender, FormView)
			Dim row As GridViewDetailRowTemplateContainer = CType(fv.Parent, GridViewDetailRowTemplateContainer)
			fv.DataSource = SqlDataSource2
			SqlDataSource2.SelectParameters("CategoryID").DefaultValue = row.KeyValue.ToString()
		End Sub
	End Class
End Namespace
