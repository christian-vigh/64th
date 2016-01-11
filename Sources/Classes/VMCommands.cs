/**************************************************************************************************************

    NAME
        VMCommands.cs

    DESCRIPTION
        Implements VM console commands.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using   System. IO ;
using	System. Reflection ;
using	System. Text ;
using	System. Windows. Forms ;


using	Thrak. Forms ;

namespace SixtyForth
   {
	# region VM command attributes
	/// <summary>
	/// Attribute that declares a class to be a VM command.
	/// </summary>
	[AttributeUsage ( AttributeTargets. Class )]
	public class   VMCommandAttribute : Attribute
	   {
		public  String		Name ;
		public  String []	Aliases ;
		public  String		Usage ;
		public  String		Help ;


		/// <summary>
		/// Builds a VMCommand attribute.
		/// </summary>
		public VMCommandAttribute ( String  name, params String []  aliases )
		   {
			this. Name	=  name ;
			this. Aliases	=  aliases ;
		    }
	    }
	# endregion

	   
	#  region VMCommand class
	/// <summary>
	/// Implements a VM command.
	/// </summary>
	public abstract class  VMCommand	:  IComparable
	   {
		// Private data members
		public String		Name		=  null ;	// Command name
		public String []	Aliases		=  null ;	// Optional aliases
		public String		Usage		=  "" ;		// Command usage
		public String		Help		=  "" ;		// Command help


		/// <summary>
		/// Runs the command.
		/// </summary>
		public abstract int  Run ( VMCommands  cmd, int  argc, String []  argv ) ;


		/// <summary>
		/// Compares two VMCommand objects.
		/// </summary>
		public int CompareTo ( object obj )
		   {
			VMCommand	other	=  obj as VMCommand ;

			return ( String. Compare ( Name, other. Name, true ) ) ;
		    }
	   }
	# endregion


	# region VMCommands class
	/// <summary>
	/// A class for collecting command specifications defined throughout the application.
	/// </summary>
	public class VMCommands
	   {
		// List of commands collected through the loaded assemblies (ie, classes that have the VMCommandAttribute attribute)
		internal List<VMCommand>		Commands		=  new List<VMCommand> ( ) ;
		// Parent shell form
		private  ShellForm			ParentShell ;


		/// <summary>
		/// Builds a VMCommand object to be used with the specified ShellForm.
		/// </summary>
		public  VMCommands ( ShellForm   parent )
		   {
			ParentShell	=  parent ;
			CollectCommands ( ) ;
			Commands. Sort ( ) ;
		    }


		/// <summary>
		/// Writes a message to "standard output", ie, using the standard output colors.
		/// </summary>
		/// <param name="message">Message to be written.</param>
		public void  stdout ( String  message )
		   {
			ParentShell. Write ( message, ParentShell. OutputColor ) ;
		    }


		/// <summary>
		/// Writes a message to "standard error", ie, using the standard error colors.
		/// </summary>
		/// <param name="message">Message to be written.</param>
		public void  stderr ( String  message )
		   {
			ParentShell. Write ( message, ParentShell. ErrorColor ) ;
		    }


		/// <summary>
		/// Searchs a command having the specified name or alias.
		/// </summary>
		public VMCommand  Search ( String  name )
		   {
			foreach  ( VMCommand  cmd  in  Commands )
			   {
				if  ( String. Compare ( name, cmd. Name, true )  ==  0 )
					return ( cmd ) ;

				foreach  ( String  alias  in  cmd. Aliases )
				   {
					if  ( String. Compare ( name, alias, true )  ==  0 )
						return ( cmd ) ;
				    }
			    }

			return ( null ) ;
		    }


		/// <summary>
		/// Executes a command using the specified parameters.
		/// </summary>
		/// <param name="cmd">VMCommand object.</param>
		/// <param name="argc">Parameter count, including the command name.</param>
		/// <param name="argv">Parameter values, including the command name.</param>
		/// <returns>The status of the executed VMCommand.</returns>
		public int  Run ( VMCommand  cmd, int  argc, String []  argv )
		   {
			int	status		=  cmd. Run ( this, argc, argv ) ;

			return ( status ) ;
		    }


		/// <summary>
		/// Collects all the classes derived from the VMCommand class to build the available command list.
		/// </summary>
		private void  CollectCommands ( )
		   {
			// Get all the loaded assemblies
			Assembly []		asmlist		=  AppDomain. CurrentDomain. GetAssemblies ( ) ;

			// Loop through assemblies
			foreach  ( Assembly  asm  in  asmlist )
			   {
				// Get types defined in the current assembly
				Type []		types	=  asm. GetTypes ( ) ;

				// Loop through type
				foreach  ( Type  type  in  types ) 
				   {
					// Retain only classes whose base class is VMCommand
					if  ( type. BaseType  ==  typeof ( VMCommand ) )
					   {
						// Get the (optional) VMCommandAttribute attribute
						VMCommandAttribute	attr	=  ( VMCommandAttribute ) Attribute. GetCustomAttribute ( type, 
												typeof ( VMCommandAttribute ) ) ;
						// Instanciate an object from the found VMCommand-derived class
						VMCommand		cmd	=  ( VMCommand ) Activator. CreateInstance ( type ) ;
						
						// If an attribute has been specified, use the specified values to initialize the instance
						// If no attribute, it will be the responsibility of the class constructor itself to do it
						if  ( attr  !=  null )
						   {
							cmd. Name		=  attr. Name ;
							cmd. Aliases		=  attr. Aliases ;
							cmd. Usage		=  attr. Usage ;
							cmd. Help		=  attr. Help ;
						    }

						// For now, we silently ignore bad classes where no command name is defined
						if  ( cmd. Name  !=  null )
							Commands. Add ( cmd ) ;
					    }
				    }
			    }
		    }
	    }
	# endregion
    }
