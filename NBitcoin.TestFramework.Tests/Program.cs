using NBitcoin.Tests;
using System;

namespace NBitcoin.TestFramework.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
			var builder = NodeBuilder.Create(version: "0.13.1");

			builder.CreateNode(true);
        }
    }
}
