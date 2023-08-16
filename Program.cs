// See https://aka.ms/new-console-template for more information

using AsyncAwaitTest;

Console.WriteLine("Hello, World!");


var test = new Test();

_ = await test.FirstMethodAsync();

