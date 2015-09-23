# WHAT IS 64th ? #

**64th** is a not-that-useful, experimental attempt to implement a multi-threaded 64-bits Forth interpreter/compiler in Intel 64-bits assembly language.

# CURRENT IMPLEMENTATION #

The current implementation just provides a framework to progressively build the Forth machine ; it contains :

- A Command-line parameters analyzer
- A read/write/execute loop, which implements a very few primitives of the original Forth language
- A bunch of utility routines (mainly for string manipulation)
- A set of system calls that interface with the Window API for file management, memory management and so on
- Some debugging utility routines

There is also a subproject named **AsmTest**, which allows for some unit testing.


# DESIGN ISSUES #

Currently, the following design issues are not yet answered :
- Will the final application be able to generate .EXE files, including only the needed subroutines ?
- Will there be a notion of *workspace*, allowing an executable file to load external components (DLLs for example) ?
- Since the final application is to be multi-threaded, will 64th memory layout be the same as the original Forth language, or will there be provisions for handling multi-tasking and separating some portions of Forth workspace so that some parts of the data remain private ?

