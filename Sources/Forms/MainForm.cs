/**************************************************************************************************************

    NAME
        MainForm.cs

    DESCRIPTION
        Main form class.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using	System. Linq ;
using	System. Text ;
using	System. Windows. Forms ;

using   Thrak ;
using   Thrak. Forms ;
using   Thrak. Core ;
using   Thrak. Core. Assembly ;
using   Thrak. Core. Threading ;


namespace SixtyForth. Forms
   {
	public partial class MainForm : Thrak. Forms. Form, ILocalizable
  	   {
		// Various form windows
		private ForthShell		ForthShell ;		// A forth shell
		private ForthConsole		ForthConsole ;		// Forth console


		/*==============================================================================================================
		
			Class constructor.
		
		  ==============================================================================================================*/
		public MainForm ( )
		   {
			// Graphic initializations
			InitializeComponent ( ) ;

			// Initialization : User interface
			LocalizableUI. Register ( this ) ;
			LocalizableUI. Culture			=  Program. Settings. Language ;

			// Create needed forms
			ForthShell			=  new ForthShell ( ) ;		// Forth shell window
			ForthShell. MdiParent		=  this ;

			ForthConsole			=  new ForthConsole ( ) ;	// Forth console window
			ForthConsole. MdiParent		=  this ;

			// Reflect application setting values
			InitializeSettings ( ) ;
		    }


		# region Menu item handlers

		/*==============================================================================================================
		
			File menu items.
		  
		  ==============================================================================================================*/

		// File/Exit option
		private void MenuFileQuit_Click ( object sender, EventArgs e )
		   {
			Application. Exit ( ) ;
		    }


		/*==============================================================================================================
		
			Display menu items.
		  
		  ==============================================================================================================*/

		// Display 64th shell
		private void MenuDisplay64thShell_Click ( object sender, EventArgs e )
		   {
			Program. Settings. Show64thShell =  ! Program. Settings. Show64thShell ;
			Program. Settings. Save ( ) ;
			MenuDisplay64thShell. Checked	 =  Program. Settings. Show64thShell ;

			if  ( Program. Settings. Show64thShell )
				ForthShell. Show ( ) ;
			else
				ForthShell. Hide ( ) ;
		    }


		// Display 64th console window
		private void MenuDisplay64thConsole_Click ( object sender, EventArgs e )
		   {
			Program. Settings. Show64thConsole =  ! Program. Settings. Show64thConsole ;
			Program. Settings. Save ( ) ;
			MenuDisplay64thConsole. Checked	 =  Program. Settings. Show64thConsole ;

			if  ( Program. Settings. Show64thConsole )
				ForthConsole. Show ( ) ;
			else
				ForthConsole. Hide ( ) ;
		    }


		/*==============================================================================================================
		
			Settings/Language menu items.
		  
		  ==============================================================================================================*/

		// Settings/Language/English (en-US) option
		private void MenuSettingsLanguageEN_US_Click ( object sender, EventArgs e )
		   { LocalizableUI. Culture = "en-US" ; }


		// Settings/Language/French (fr-FR) option
		private void MenuSettingsLanguageFR_FR_Click ( object sender, EventArgs e )
		   { LocalizableUI. Culture = "fr-FR" ; }


		/*==============================================================================================================

			Help menu items.
		
		  ==============================================================================================================*/

		// Help/About option
		private void MenuHelpAbout_Click ( object sender, EventArgs e )
		   {
			new SixtyForth. Forms. AboutForm ( ). ShowDialog ( this ) ;
		    }

		# endregion


		# region Support functions
		/*===================================================================================================
		 *
		 *  InitializeSettings - 
		 *	Initializes the UI to reflect the application settings.
		 *
		 *===================================================================================================*/
		private void	InitializeSettings ( )
		   {
			// Forth console window
			if  ( Program. Settings. Show64thConsole )
			   {
				ForthConsole. Show ( ) ;
				MenuDisplay64thConsole. Checked	=  true ;
			     }
			else
				MenuDisplay64thConsole. Checked	=  false ;

			// Forth shell window
			if  ( Program. Settings. Show64thShell )
			   {
				ForthShell. Show ( ) ;
				MenuDisplay64thShell. Checked	=  true ;
			     }
			else
				MenuDisplay64thShell. Checked	=  false ;
		    }


		/*===================================================================================================
		 *
		 *  OnCultureChange - 
		 *	Handles culture change events (menu Options/Language) and updates the menu items accordingly.
		 *
		 *===================================================================================================*/
		public void OnCultureChange ( object  sender, LocalizableEventArgs  args )
		   {
			String			Culture		=  args. Culture ;

			// Window title
			this. Text					= Resources. Localization. Forms. MainForm. WindowTitle + " - V" + 
										ApplicationAssembly. VersionMajor + "." +
										ApplicationAssembly. VersionMinor + "." +
										ApplicationAssembly. VersionRevision ;

			// File menu
			this. MenuFile. Text				= Resources. Localization. Forms. MainForm. MenuFile ;
			this. MenuFileQuit. Text			= Resources. Localization. Forms. MainForm. MenuFileExit ;

			// Display menu
			this. MenuDisplay. Text				= Resources. Localization. Forms. MainForm. MenuDisplay ;
			this. MenuDisplay64thShell. Text		= Resources. Localization. Forms. MainForm. MenuDisplay64thShell ;
			this. MenuDisplay64thConsole. Text		= Resources. Localization. Forms. MainForm. MenuDisplay64thConsole ;

			// Options menu
			this. MenuSettings. Text			= Resources. Localization. Forms. MainForm. MenuSettings ;

			// Options/Language menu
			this. MenuSettingsLanguage. Text		= Resources. Localization. Forms. MainForm. MenuSettingsLanguage ;
			this. MenuSettingsLanguageEN_US. Text		= Resources. Localization. Forms. MainForm. MenuSettingsLanguageEN_US ;
			this. MenuSettingsLanguageFR_FR. Text		= Resources. Localization. Forms. MainForm. MenuSettingsLanguageFR_FR ;

			// Help menu
			this. MenuHelp. Text				= Resources. Localization. Forms. MainForm. MenuHelp ;
			this. MenuHelpAbout. Text			= Resources. Localization. Forms. MainForm. MenuHelpAbout ;

			// Change current flag in toolbar and checks/unchecks the related language options in the Options/Language menu
			switch ( Culture. ToLower ( ) )
			   {
				case	"fr-fr" :
					this. MenuSettingsLanguageEN_US. Checked	= false ;
					this. MenuSettingsLanguageFR_FR. Checked	= true ;
					this. LanguageLabel. Image			= Resources. SixtyForth. Flags_FR. ToBitmap ( ) ;
					break ;

				case	"en-us" :
				case	"" :
					this. MenuSettingsLanguageEN_US.Checked		= true ;
					this. MenuSettingsLanguageFR_FR. Checked	= false ;
					this. LanguageLabel. Image			= Resources. SixtyForth. Flags_US. ToBitmap ( ) ;
					break ;
			    }

			// Save the new language setting
			Properties. Settings. Default. Language = Culture ;
			Properties. Settings. Default. Save ( ) ;
		    }

		# endregion

	    }
     }
