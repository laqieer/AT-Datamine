// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileInitDeclarator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013DD")]
  public class FileInitDeclarator
  {
    [Token(Token = "0x4005CC7")]
    [FieldOffset(Offset = "0x10")]
    public FileDeclarator Declarator;
    [Token(Token = "0x4005CC8")]
    [FieldOffset(Offset = "0x18")]
    public FileInitializer Initializer;

    [Token(Token = "0x6006F6C")]
    [Address(RVA = "0x4205690", Offset = "0x4205690", VA = "0x4205690")]
    public FileInitDeclarator(FileDeclarator declarator, FileInitializer initializer = null)
    {
    }

    [Token(Token = "0x6006F6D")]
    [Address(RVA = "0x42056BC", Offset = "0x42056BC", VA = "0x42056BC")]
    public FileInitDeclarator(FileInitializer initializer)
    {
    }

    [Token(Token = "0x6006F6E")]
    [Address(RVA = "0x42056E4", Offset = "0x42056E4", VA = "0x42056E4")]
    public FileInitDeclarator(FileReader reader)
    {
    }

    [Token(Token = "0x6006F6F")]
    [Address(RVA = "0x4205800", Offset = "0x4205800", VA = "0x4205800")]
    public void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F70")]
    [Address(RVA = "0x4205710", Offset = "0x4205710", VA = "0x4205710")]
    public void Read(FileReader reader)
    {
    }
  }
}
