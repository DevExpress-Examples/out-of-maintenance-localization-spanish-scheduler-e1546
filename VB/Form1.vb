Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Localization.Internal
Imports DevExpress.XtraScheduler.Localization

Namespace FrenchScheduler
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
' Uncomment the code below to use translations provided by a custom localizer instead of localized resources.
' Note that in this instance you should provide all required translations.
			'MyLocalizer myLocalizer = new MyLocalizer();
			'DefaultActiveLocalizerProvider<SchedulerStringId> provider =
			'    new DefaultActiveLocalizerProvider<SchedulerStringId>(myLocalizer);
			'SchedulerLocalizer.SetActiveLocalizerProvider(provider);
			'SchedulerLocalizer.Active = myLocalizer;           
		End Sub

		Public Class MyLocalizer
			Inherits SchedulerLocalizer


			Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
				Dim ret As String = ""
				Select Case id
					Case SchedulerStringId.MenuCmd_LabelAs
						Return "Actions possibles"
					Case Else
						ret = MyBase.GetLocalizedString(id)
				End Select
				Return ret
			End Function
		End Class

	End Class
End Namespace