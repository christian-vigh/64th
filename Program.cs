/**************************************************************************************************************

    NAME
        Program.cs

    DESCRIPTION
        Main 64th program.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/12]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using   System. Collections ;
using	System. Globalization ;
using	System. Runtime. InteropServices ;
using   System. Text ;
using	System. Threading ;
using	System. Windows. Forms ;


using	Thrak ;
using   Thrak. Core ;
using   Thrak. Core. Runtime ;
using   Thrak. Structures ;

using   Thrak. Forms ;
using	Thrak. WinAPI ;
using	Thrak. WinAPI. DLL ;
using   Thrak. WinAPI. Callbacks ;
using   Thrak. WinAPI. Enums ;
using   Thrak. WinAPI. Structures ;


namespace SixtyForth
   {
	static class Program
	   {
		// Shortcut to application settings
		public static Properties. Settings		Settings ;
		// Log object
		public static Log				Log ;
 

		/*==============================================================================================================
		
		    Application entry point.
		
		  ==============================================================================================================*/
		[STAThread]
		static void Main ( )
		   {
			// Initialize the Thrak library
			Thrak. Library. Initialize ( ) ;

			// Initialize settings shortcut
			Program. Settings	=  Properties. Settings. Default ;

			// Create log file
			Program. Log		=  new Log ( Program. Settings. LogFile, 
								Program. Settings. LogLevel,
								Program. Settings. LogAppend ) ;

			// Then dotNet UI stuff
			Application. EnableVisualStyles ( ) ;
			Application. SetCompatibleTextRenderingDefault ( false ) ;

			// Show the main form. 
			SixtyForth. Forms. MainForm		MainForm	=  new SixtyForth. Forms. MainForm ( ) ;

			// Run the application
			Application. Run ( MainForm ) ;
		    }
	    }
    }
