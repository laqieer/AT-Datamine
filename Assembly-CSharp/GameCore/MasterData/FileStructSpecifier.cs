// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileStructSpecifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D4")]
  public class FileStructSpecifier : FileSpecifier
  {
    [Token(Token = "0x4005CBB")]
    [FieldOffset(Offset = "0x10")]
    public List<FileDeclaration> Declarations;

    [Token(Token = "0x6006F4E")]
    [Address(RVA = "0x4204B80", Offset = "0x4204B80", VA = "0x4204B80")]
    public FileStructSpecifier(FileReader reader)
    {
    }

    [Token(Token = "0x6006F4F")]
    [Address(RVA = "0x4204B88", Offset = "0x4204B88", VA = "0x4204B88")]
    public FileStructSpecifier(List<FileDeclaration> declarations)
    {
    }

    [Token(Token = "0x6006F50")]
    [Address(RVA = "0x4204BB0", Offset = "0x4204BB0", VA = "0x4204BB0", Slot = "4")]
    public override void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F51")]
    [Address(RVA = "0x4204EDC", Offset = "0x4204EDC", VA = "0x4204EDC", Slot = "5")]
    public override void Read(FileReader reader)
    {
    }
  }
}
