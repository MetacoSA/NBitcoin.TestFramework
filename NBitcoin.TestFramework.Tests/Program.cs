using NBitcoin.Tests;
using System;

namespace NBitcoin.TestFramework.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
			var builder = NodeBuilder.Create(NodeDownloadData.BCash.v0_16_2);

			builder.CreateNode(true);
        }
    }
}
