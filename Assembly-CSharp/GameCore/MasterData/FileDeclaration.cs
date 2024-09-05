// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileDeclaration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013DE")]
  public class FileDeclaration
  {
    [Token(Token = "0x4005CC9")]
    [FieldOffset(Offset = "0x10")]
    public FileSpecifier Specifier;
    [Token(Token = "0x4005CCA")]
    [FieldOffset(Offset = "0x18")]
    public List<FileInitDeclarator> InitDeclarators;

    [Token(Token = "0x6006F71")]
    [Address(RVA = "0x4205888", Offset = "0x4205888", VA = "0x4205888")]
    public FileDeclaration(FileSpecifier specifier, List<FileInitDeclarator> initDeclarators)
    {
    }

    [Token(Token = "0x6006F72")]
    [Address(RVA = "0x42058B4", Offset = "0x42058B4", VA = "0x42058B4")]
    public FileDeclaration(FileSpecifier specifier, FileInitDeclarator initDeclarator)
    {
    }

    [Token(Token = "0x6006F73")]
    [Address(RVA = "0x42059BC", Offset = "0x42059BC", VA = "0x42059BC")]
    public FileDeclaration(FileReader reader)
    {
    }

    [Token(Token = "0x6006F74")]
    [Address(RVA = "0x4204D44", Offset = "0x4204D44", VA = "0x4204D44")]
    public void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F75")]
    [Address(RVA = "0x42059E8", Offset = "0x42059E8", VA = "0x42059E8")]
    public void Read(FileReader reader)
    {
    }
  }
}
