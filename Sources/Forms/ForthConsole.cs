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
using	System. Windows. Forms ;


using   Thrak. Core ;
using	Thrak. Core. Assembly ;
using   Thrak. Forms ;


namespace SixtyForth. Forms
   {
	public partial class ForthConsole : Thrak. Forms. ShellForm, ILocalizable
	   {
		public VMCommands		Commands ;


		/// <summary>
		/// Class constructor.
		/// </summary>
		public ForthConsole ( )
	  	   {
			InitializeComponent ( ) ;

			// Initialization : User interface
			LocalizableUI. Register ( this ) ;
			LocalizableUI. Culture			=  Program. Settings. Language ;

			// Welcome message
			String  WelcomeString	=  String. Format (
					Resources. Localization. Forms. ForthConsole. WelcomeMessage + "\n",
					ApplicationAssembly. ApplicationTitle, ApplicationAssembly. Version,
					ApplicationAssembly. Description, ApplicationAssembly. Copyright ) ;

			Write ( WelcomeString, Color. LightSeaGreen ) ;

			// Collect commands
			Commands	=  new VMCommands ( this ) ;

			// Add our command processor
			ShellCommandInput += OnCommand ;
		    }


		/// <summary>
		/// Start the interpreter loop.
		/// </summary>
		private void ForthConsole_Load ( object sender, EventArgs e )
		   {
			Run ( ) ;
		    }


		/// <summary>
		/// Processes the specified command.
		/// </summary>
		private void  OnCommand ( ShellForm  sender, CommandInputEventArgs  e )
		   {
			VMCommand		cmd		=  Commands. Search ( e. Argv [0] ) ;

			if  ( cmd  ==  null )
				e. Handled	=  false ;
			else
			   {
				int		status  =  Commands. Run ( cmd, e. Argc, e.Argv ) ;

				e. Handled	=  true ;

				if  ( status  !=  0 )
					Write ( "[status = " + status. ToString ( ) + "]\n", ErrorColor ) ;
			    }
		    }


		/// <summary>
		/// Handles a culture change.
		/// </summary>
		public void OnCultureChange ( object  sender, LocalizableEventArgs  args )
		   {
			String			Culture		=  args. Culture ;

			this. Text		=  Resources. Localization. Forms. ForthConsole. Title ;
			this. Prompt. Text	=  Resources. Localization. Forms. ForthConsole. Prompt ;
		    }

	    }
    }
