// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileIdentifierDeclarator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D7")]
  public class FileIdentifierDeclarator : FileDeclarator
  {
    [Token(Token = "0x4005CC0")]
    [FieldOffset(Offset = "0x10")]
    public string Identifier;

    [Token(Token = "0x6006F57")]
    [Address(RVA = "0x420517C", Offset = "0x420517C", VA = "0x420517C")]
    public FileIdentifierDeclarator(FileReader reader)
    {
    }

    [Token(Token = "0x6006F58")]
    [Address(RVA = "0x42051B0", Offset = "0x42051B0", VA = "0x42051B0")]
    public FileIdentifierDeclarator(string identifier)
    {
    }

    [Token(Token = "0x6006F59")]
    [Address(RVA = "0x42051D8", Offset = "0x42051D8", VA = "0x42051D8", Slot = "4")]
    public override void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F5A")]
    [Address(RVA = "0x4205260", Offset = "0x4205260", VA = "0x4205260", Slot = "5")]
    public override void Read(FileReader reader)
    {
    }
  }
}
