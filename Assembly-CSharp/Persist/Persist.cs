// Decompiled with JetBrains decompiler
// Type: Persist.Persist
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Persist
{
  [Token(Token = "0x20009E6")]
  public static class Persist
  {
    [Token(Token = "0x4002DE2")]
    [FieldOffset(Offset = "0x0")]
    public static Persist.Persist<Persist.Persist.DLC> dlc;

    [Token(Token = "0x600385C")]
    [Address(RVA = "0x310BE70", Offset = "0x310BE70", VA = "0x310BE70")]
    static Persist()
    {
    }

    [Token(Token = "0x20009E7")]
    [Serializable]
    public class DLC
    {
      [Token(Token = "0x4002DE3")]
      [FieldOffset(Offset = "0x10")]
      public string Version;
      [Token(Token = "0x4002DE4")]
      [FieldOffset(Offset = "0x18")]
      public bool UpdateAssetBundleInfo;

      [Token(Token = "0x600385D")]
      [Address(RVA = "0x310BF14", Offset = "0x310BF14", VA = "0x310BF14")]
      public DLC()
      {
      }

      [Token(Token = "0x600385E")]
      [Address(RVA = "0x310BF90", Offset = "0x310BF90", VA = "0x310BF90")]
      public void Reset()
      {
      }

      [Token(Token = "0x600385F")]
      [Address(RVA = "0x310BF30", Offset = "0x310BF30", VA = "0x310BF30")]
      public void SetDefault()
      {
      }
    }
  }
}
