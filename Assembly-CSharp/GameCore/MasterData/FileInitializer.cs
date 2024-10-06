// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileInitializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013DA")]
  public class FileInitializer
  {
    [Token(Token = "0x6006F5F")]
    [Address(RVA = "0x42054CC", Offset = "0x42054CC", VA = "0x42054CC")]
    public FileInitializer()
    {
    }

    [Token(Token = "0x6006F60")]
    [Address(RVA = "0x42054D4", Offset = "0x42054D4", VA = "0x42054D4")]
    public FileInitializer(FileReader reader)
    {
    }

    [Token(Token = "0x6006F61")]
    [Address(RVA = "0x4205508", Offset = "0x4205508", VA = "0x4205508", Slot = "4")]
    public virtual void Write(BinaryWriter writer)
    {
    }

    [Token(Token = "0x6006F62")]
    [Address(RVA = "0x4205558", Offset = "0x4205558", VA = "0x4205558", Slot = "5")]
    public virtual void Read(FileReader reader)
    {
    }

    [Token(Token = "0x6006F63")]
    [Address(RVA = "0x42055A8", Offset = "0x42055A8", VA = "0x42055A8")]
    public static void WriteNull(BinaryWriter writer)
    {
    }
  }
}
