﻿#region -- License Terms --
//
// MessagePack for CLI
//
// Copyright (C) 2010 FUJIWARA, Yusuke
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
#endregion -- License Terms --

using System;
using System.IO;
using NUnit.Framework;

namespace MsgPack.Rpc.Client
{
	[TestFixture]
	public class FileSystemTest
	{
		[Test]
		public void TestEscapeInvalidPathChars_InvalidFileNameCharsAreAllReplaced()
		{
			Assert.That(
				FileSystem.EscapeInvalidPathChars( String.Concat( Path.GetInvalidFileNameChars() ), "_" ),
				Is.EqualTo( new String( '_', Path.GetInvalidFileNameChars().Length ))
			);
		}

		[Test]
		public void TestEscapeInvalidPathChars_InvalidPathCharsAreAllReplaced()
		{
			Assert.That(
				FileSystem.EscapeInvalidPathChars( String.Concat( Path.GetInvalidPathChars() ), "_" ),
				Is.EqualTo( new String( '_', Path.GetInvalidPathChars().Length ) )
			);
		}
	}
}
