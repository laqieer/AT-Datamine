// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileSpecifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D2")]
  public class FileSpecifier
  {
    [Token(Token = "0x6006F46")]
    [Address(RVA = "0x4712808", Offset = "0x4712808", VA = "0x4712808")]
    public FileSpecifier()
    {
    }

    [Token(Token = "0x6006F47")]
    [Address(RVA = "0x4712810", Offset = "0x4712810", VA = "0x4712810")]
    public FileSpecifier(FileReader reader)
    {
    }

    [Token(Token = "0x6006F48")]
    [Address(RVA = "0x4712844", Offset = "0x4712844", VA = "0x4712844", Slot = "4")]
    public virtual void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F49")]
    [Address(RVA = "0x4712894", Offset = "0x4712894", VA = "0x4712894", Slot = "5")]
    public virtual void Read(FileReader reader)
    {
    }
  }
}
