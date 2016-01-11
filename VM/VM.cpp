/**************************************************************************************************************

    NAME
        VM.cpp

    DESCRIPTION
        Main DLL entry point.

    AUTHOR
        Christian Vigh, 10/2012.

    HISTORY
    [Version : 1.0]    [Date : 2012/10/13]     [Author : CV]
        Initial version.

 **************************************************************************************************************/

# include	"stdafx.h"
# include	"Vroom.h"


BOOL APIENTRY DllMain  ( HMODULE hModule, DWORD  ul_reason_for_call, LPVOID  lpReserved )
   {
	switch (ul_reason_for_call)
	   {
		case DLL_PROCESS_ATTACH :
		case DLL_THREAD_ATTACH  :
		case DLL_THREAD_DETACH  :
		case DLL_PROCESS_DETACH :
			break ;
	    }

	return ( TRUE ) ;
    }