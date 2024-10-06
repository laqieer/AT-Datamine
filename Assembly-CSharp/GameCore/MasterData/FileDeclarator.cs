// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileDeclarator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D6")]
  public class FileDeclarator
  {
    [Token(Token = "0x6006F52")]
    [Address(RVA = "0x4205080", Offset = "0x4205080", VA = "0x4205080")]
    public FileDeclarator()
    {
    }

    [Token(Token = "0x6006F53")]
    [Address(RVA = "0x4205088", Offset = "0x4205088", VA = "0x4205088")]
    public FileDeclarator(FileReader reader)
    {
    }

    [Token(Token = "0x6006F54")]
    [Address(RVA = "0x42050BC", Offset = "0x42050BC", VA = "0x42050BC", Slot = "4")]
    public virtual void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F55")]
    [Address(RVA = "0x420510C", Offset = "0x420510C", VA = "0x420510C")]
    public static void WriteNull(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F56")]
    [Address(RVA = "0x420512C", Offset = "0x420512C", VA = "0x420512C", Slot = "5")]
    public virtual void Read(FileReader reader)
    {
    }
  }
}
