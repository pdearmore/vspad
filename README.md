# VsPad
VsPad aims to bring some of the simple functionality of LINQPad to visual studio.

LINQPad is a .NET language playground that quickly and easily allows you to type in or paste code for testing and refining without having to go through the trouble of creating a Visual Studio project.  I highly recommend it and it can save you a lot of time.  It is an excellent piece of software.

However, as I was seriously considering what type of license I should try to ask my company to reimburse me for, I was mentally going through the benefits of each one and realized that I would need the premium version.  Syntax highlighting, autocompletion, outlining, code snippets, NuGet integration, integrated debugger, etc... Sound familiar?  Why not just use Visual Studio, I thought?  The main difference is that there's a lot more overhead to firing it up.  Nothing can be done about that.  There are also the built-in LINQPad extension methods, such as Dump, which displays a very nice tabular display of the object or primitive that you need to view.

But with those benefits aside, I felt it was a bit much to ask my company to pay for this software when they are already very generously providing an MSDN subscription. Not that the Premium license fee is a huge financial burden, but still... So I went about seeing if there was a way to get some of the convenience of LINQPad back into Visual Studio.

VsPad is what I have come up with so far.  It still has a much larger footprint than LINQPad, but thanks to a clever extension method from _Noctis_ at CodeProject to provide the Dump() functionality, I can get most of the benefits of a premium license.  Not to mention that I have access to any other feature of Visual Studio and whatever other third-party add-ons I have, such as ReSharper.  

To use VsPad, clone it or download the solution file and open it up in visual studio.  It requires the Newtonsoft JSON package for displaying the Dump() results, or of course you can just use Console.WriteLine().  I recommend running it in the debugger after setting a breakpoint or start it with Ctrl-F5 (which will run the console program and leave the console window open until a key is pressed, so you can see the results). 
