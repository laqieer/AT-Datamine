// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013D0")]
  public class FileExpression
  {
    [Token(Token = "0x6006F42")]
    [Address(RVA = "0x4712740", Offset = "0x4712740", VA = "0x4712740", Slot = "4")]
    public virtual void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F43")]
    [Address(RVA = "0x4712790", Offset = "0x4712790", VA = "0x4712790", Slot = "5")]
    public virtual void Read(FileReader reader)
    {
    }

    [Token(Token = "0x6006F44")]
    [Address(RVA = "0x47127E0", Offset = "0x47127E0", VA = "0x47127E0")]
    public static void WriteNull(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F45")]
    [Address(RVA = "0x4712800", Offset = "0x4712800", VA = "0x4712800")]
    public FileExpression()
    {
    }
  }
}
