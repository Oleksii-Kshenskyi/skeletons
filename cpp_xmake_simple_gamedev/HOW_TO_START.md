# Simple C++ / Raylib / EnTT skeleton, built with XMake

To build this, you need:
- xmake installed on your system;
- Version of clang/LLVM (the compiler) that supports C++23 (> 22.1 preferably);
- clangd installed on your system for intellisense;
- The LLDB debugger for the debugging experience in VS Code;
- VS Code as the IDE to run this.


You get:
- Autofetch/autobuild of dependencies;
- Nice intellisense of C++;
- It should suggest you to install the following VS Code plugins: CodeLLDB + clangd + xmake VS Code plugin, and to disable the default Microsoft C++ plugin so it doesn't conflict with this setup. Do all of that.
- F5 runs a nice LLDB-based debugger in VS Code.
- XMake extension can build / rebuild / clean / run the application.

To build/run the skeleton (and your application in the future):
- `xmake f -m debug -y` # for debug build, configure step
- `xmake` # actually builds everything
- `xmake run mygame` # runs the executable

After you configure and build for the first time, you should be able to build/run everything in VS Code via the XMake plugin.
Try setting a breakpoint in the main.cpp file and pressing F5 to check if the debugger works.