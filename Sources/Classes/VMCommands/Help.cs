/**************************************************************************************************************

    NAME
        Help.cs

    DESCRIPTION
        VM help command.
 
	Usage : help [command]

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/25]     [Author : CV]
        Initial version.

 **************************************************************************************************************/
using	System ;
using	System. Collections. Generic ;
using	System. Linq ;
using	System. Text ;


namespace SixtyForth. SixtyForthCommands
   {
	[VMCommand ( "help", "?", Usage = "help [command]", Help = "Displays VM command help." )]
	public class  VMHelpCommand	:  VMCommand
	   {
		public override int  Run ( VMCommands  cmd, int  argc, String []  argv )
		   {
			switch ( argc )
			   {
				// "help" with no command name : displays command list with their help
				case	1 :
					foreach  ( VMCommand  ivmc  in  cmd. Commands )
						cmd. stdout ( String. Format ( "{0,-16}  {1}\n", ivmc. Name, ivmc. Help ) ) ;

					return ( 0 ) ;


				// "help" with a command name
				case	2 :
					VMCommand	vmc	=  cmd. Search ( argv [1] ) ;

					if  ( vmc  ==  null )
					   {
						cmd. stderr ( "Unknown command \"" + argv [1] + "\".\n" ) ;
						return ( -1 ) ;
					    }

					cmd. stdout ( "Usage : " + vmc. Usage + "\n" ) ;
					cmd. stdout ( "\t" + vmc. Help + "\n" ) ;

					if  ( vmc. Aliases. Length  >  0 )
						cmd. stdout ( "\tAliases : " + String. Join ( ", ", vmc. Aliases ) + ".\n" ) ;

					return ( 0 ) ;


				// "help" with too many arguments
				default :
					cmd. stderr ( "Too many arguments specified.\n" ) ;
					return ( -1 ) ;
			    }
		    }
	    }
    }
