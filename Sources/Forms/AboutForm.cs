/**************************************************************************************************************

    NAME
        AboutForm.cs

    DESCRIPTION
        Displays the "About" dialog box.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Drawing ;
using	System. Linq ;
using	System. Reflection ;
using	System. Windows. Forms ;

using   Thrak ;
using	Thrak. Core ;
using   Thrak. Core. Assembly ;


namespace SixtyForth. Forms
   {
	partial class AboutForm : Thrak. Forms. Form
	   {
		#region Constructor
		/*==============================================================================================================
		
			Class constructor.		
		
		  ==============================================================================================================*/
		public AboutForm ( )
		   {
			InitializeComponent ( ) ;

			this. Text			=  String. Format ( "{0} {1}...", 
										Resources. Localization. Forms. AboutForm. WindowTitle, 
										ApplicationAssembly. ApplicationName ) ;
			this. labelVersion. Text	=  String. Format ( "{0} {1}", 
										Resources. Localization. Forms. AboutForm. ProductVersion,
										ApplicationAssembly. Version + " (" +
										ApplicationAssembly. TargetArchitecture + ")" ) ;
			this. labelCopyright. Text	=  ApplicationAssembly. Copyright ;
			this. labelDescription. Text	=  Resources. Localization. Forms. AboutForm. ProductDescription ;
		     }
		# endregion
	    }
    }
