/**************************************************************************************************************

    NAME
        ForthShell.cs

    DESCRIPTION
        Implements a Forth shell Window.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/17]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. ComponentModel ;
using	System. Data ;
using	System. Drawing ;
using	System. Text ;
using   System. Threading ;
using	System. Windows. Forms ;


using   Thrak. Core ;
using	Thrak. Core. Assembly ;
using   Thrak. Forms ;


namespace SixtyForth. Forms
   {
	public partial class ForthShell : Thrak. Forms. ShellForm, ILocalizable 
	   {
		/// <summary>
		/// Class constructor.
		/// </summary>
		public ForthShell ( )
	  	   {
			InitializeComponent ( ) ;

			// Initialization : User interface
			LocalizableUI. Register ( this ) ;
			LocalizableUI. Culture			=  Program. Settings. Language ;

			// Welcome message
			String  WelcomeString	=  String. Format (
					Resources. Localization. Forms. ForthShell. WelcomeMessage + "\n" ,
					ApplicationAssembly. ApplicationTitle, ApplicationAssembly. Version,
					ApplicationAssembly. Description, ApplicationAssembly. Copyright ) ;

			Write ( WelcomeString, Color. White ) ;
		    }


		/// <summary>
		/// Load event : starts the interpreter task.
		/// </summary>
		private void ForthShell_Load ( object sender, EventArgs e )
		   {
			Run ( new ThreadStart ( this. Interpreter ) ) ;
		    }


		/// <summary>
		/// Interpreter loop.
		/// </summary>
		private void  Interpreter ( )
		   {
			int	value ;

			while  ( ( value  =  InterpreterRead ( ) )  !=  EOF )
			   {
				char		ch		=  ( char ) value ;

				InterpreterWrite ( ch. ToString ( ), OutputColor ) ;
			    }
		    }


		/// <summary>
		/// Handles a culture change.
		/// </summary>
		public void OnCultureChange ( object  sender, LocalizableEventArgs  args )
		   {
			String			Culture		=  args. Culture ;

			this. Text		=  Resources. Localization. Forms. ForthShell. Title ;
		    }
	    }
    }
