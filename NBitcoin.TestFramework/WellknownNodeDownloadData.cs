﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NBitcoin.Tests
{
	public partial class NodeDownloadData
	{
		public class BitcoinNodeDownloadData
		{
			public NodeDownloadData v0_13_1 = new NodeDownloadData()
			{
				Version = "0.13.1",
				Linux = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					DownloadLink = "https://bitcoin.org/bin/bitcoin-core-{0}/bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "2293de5682375b8edfde612d9e152b42344d25d3852663ba36f7f472b27954a4"
				},
				Mac = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-osx64.tar.gz",
					DownloadLink = "https://bitcoin.org/bin/bitcoin-core-{0}/bitcoin-{0}-osx64.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "499be4f48c933d92c43468ee2853dddaba4af7e1a17f767a85023b69a21b6e77"
				},
				Windows = new NodeOSDownloadData()
				{
					Executable = "bitcoin-{0}/bin/bitcoind.exe",
					DownloadLink = "https://bitcoin.org/bin/bitcoin-core-{0}/bitcoin-{0}-win32.zip",
					Archive = "bitcoin-{0}-win32.zip",
					Hash = "fcf6089fc013b175e3c5e32580afb3cb4310c62d2e133e992b8a9d2e0cbbafaa"
				}
			};

			public NodeDownloadData v0_16_0 = new NodeDownloadData()
			{
				Version = "0.16.0",
				Linux = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					DownloadLink = "https://bitcoin.org/bin/bitcoin-core-{0}/bitcoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "e6322c69bcc974a29e6a715e0ecb8799d2d21691d683eeb8fef65fc5f6a66477"
				},
				Mac = new NodeOSDownloadData()
				{
					Archive = "bitcoin-{0}-osx64.tar.gz",
					DownloadLink = "https://bitcoin.org/bin/bitcoin-core-{0}/bitcoin-{0}-osx64.tar.gz",
					Executable = "bitcoin-{0}/bin/bitcoind",
					Hash = "ade85a8e39de8c36a134721c3da9853a80f29a8625048e0c2a5295ca8b23a88c"
				},
				Windows = new NodeOSDownloadData()
				{
					Executable = "bitcoin-{0}/bin/bitcoind.exe",
					DownloadLink = "https://bitcoin.org/bin/bitcoin-core-{0}/bitcoin-{0}-win32.zip",
					Archive = "bitcoin-{0}-win32.zip",
					Hash = "60d65d6e57f42164e1c04bb5bb65156d87f0433825a1c1f1f5f6aebf5c8df424"
				}
			};
		}

		public class LitecoinNodeDownloadData
		{
			public NodeDownloadData v0_14_2 = new NodeDownloadData()
			{
				Version = "0.14.2",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/win/litecoin-{0}-win64.zip",
					Archive = "litecoin-{0}-win64.zip",
					Executable = "litecoin-{0}/bin/litecoind.exe",
					Hash = "c47b196a45f64dbfc9d13b66b50d4da82a263d95b36577e64b31c37590f718b2"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/linux/litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind",
					Hash = "05f409ee57ce83124f2463a3277dc8d46fca18637052d1021130e4deaca07b3c"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/osx/litecoin-{0}-osx64.tar.gz",
					Archive = "litecoin-{0}-osx64.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind"
				}
			};

			public NodeDownloadData v0_15_1 = new NodeDownloadData()
			{
				Version = "0.15.1",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/win/litecoin-{0}-win64.zip",
					Archive = "litecoin-{0}-win64.zip",
					Executable = "litecoin-{0}/bin/litecoind.exe",
					Hash = "eae66242ef66ee22f403ade0c2795ff74f6654bf3fc546e99bde2e6e4c9e148f"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/linux/litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "litecoin-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind",
					Hash = "77062f7bad781dd6667854b3c094dbf51094b33405c6cd25c36d07e0dd5e92e5"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.litecoin.org/litecoin-{0}/osx/litecoin-{0}-osx64.tar.gz",
					Archive = "litecoin-{0}-osx64.tar.gz",
					Executable = "litecoin-{0}/bin/litecoind",
					Hash = "2bb565a77779be4ed5b186c93891bc0a12352c94316a1fc44388898f7afb7bc2"
				}
			};
		}

		public class BCashNodeDownloadData
		{
			public NodeDownloadData v0_16_2 = new NodeDownloadData()
			{
				Version = "0.16.2",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.bitcoinabc.org/{0}/win/bitcoin-abc-{0}-win64.zip",
					Archive = "bitcoin-abc-{0}-win64.zip",
					Executable = "bitcoin-abc-{0}/bin/bitcoind.exe",
					Hash = "af022ccdb7d55fdffd1ddddabc2bcde9d72614a4c8412a74456954bacac0e729"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.bitcoinabc.org/{0}/linux/bitcoin-abc-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "bitcoin-abc-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "bitcoin-abc-{0}/bin/bitcoind",
					Hash = "5eeadea9c23069e08d18e0743f4a86a9774db7574197440c6d795fad5cad2084"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://download.bitcoinabc.org/{0}/osx/bitcoin-abc-{0}-osx64.tar.gz",
					Archive = "bitcoin-abc-{0}-osx64.tar.gz",
					Executable = "bitcoin-abc-{0}/bin/bitcoind",
					Hash = "5a655ddd8eb6b869b902780efe4ec12de24bbede3f6bf2edc3922048928053e5"
				},
			};
		}
		public class PolisNodeDownloadData
		{
			public NodeDownloadData v1_3_0 = new NodeDownloadData()
			{
				Version = "1.3.0",
				Windows = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/polispay/polis/releases/download/v{0}/poliscore-{0}-win64.zip",
					Archive = "poliscore-{0}-win64.zip",
					Executable = "poliscore-{0}/bin/polisd.exe",
					Hash = "af022ccdb7d55fdffd1ddddabc2bcde9d72614a4c8412a74456954bacac0e729"
				},
				Linux = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/polispay/polis/releases/download/v{0}/poliscore-{0}-x86_64-linux-gnu.tar.gz",
					Archive = "poliscore-{0}-x86_64-linux-gnu.tar.gz",
					Executable = "poliscore-{0}/bin/polisd",
					Hash = "50c3599645fbcfdfa35f4704ed742bbb5fa1ca432067f9b2368deea9784ec771"
				},
				Mac = new NodeOSDownloadData()
				{
					DownloadLink = "https://github.com/polispay/polis/releases/download/v{0}/poliscore-{0}-osx64.tar.gz",
					Archive = "poliscore-{0}-osx64.tar.gz",
					Executable = "poliscore-{0}/bin/polisd",
					Hash = "5a655ddd8eb6b869b902780efe4ec12de24bbede3f6bf2edc3922048928053e5"
				},
			};
		}

		public static BitcoinNodeDownloadData Bitcoin
		{
			get; set;
		} = new BitcoinNodeDownloadData();

		public static LitecoinNodeDownloadData Litecoin
		{
			get; set;
		} = new LitecoinNodeDownloadData();

		public static BCashNodeDownloadData BCash
		{
			get; set;
		} = new BCashNodeDownloadData();

		public static PolisNodeDownloadData BCash
		{
			get; set;
		} = new PolisNodeDownloadData();
	}
}
