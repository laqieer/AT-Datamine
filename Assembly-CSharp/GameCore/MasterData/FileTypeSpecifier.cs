// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileTypeSpecifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D3")]
  public class FileTypeSpecifier : FileSpecifier
  {
    [Token(Token = "0x4005CBA")]
    [FieldOffset(Offset = "0x10")]
    public FileFormatType Type;

    [Token(Token = "0x6006F4A")]
    [Address(RVA = "0x47128E4", Offset = "0x47128E4", VA = "0x47128E4")]
    public FileTypeSpecifier(FileFormatType type)
    {
    }

    [Token(Token = "0x6006F4B")]
    [Address(RVA = "0x471290C", Offset = "0x471290C", VA = "0x471290C")]
    public FileTypeSpecifier(FileReader reader)
    {
    }

    [Token(Token = "0x6006F4C")]
    [Address(RVA = "0x4712940", Offset = "0x4712940", VA = "0x4712940", Slot = "4")]
    public override void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F4D")]
    [Address(RVA = "0x4712988", Offset = "0x4712988", VA = "0x4712988", Slot = "5")]
    public override void Read(FileReader reader)
    {
    }
  }
}
