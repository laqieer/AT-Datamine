// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.FreeMapInstancePlaySESubscribeHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance.Action;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x2001900")]
  public class FreeMapInstancePlaySESubscribeHelper
  {
    [Token(Token = "0x4006C0A")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapAnimationClipPlaySEEventReceiver receiver;
    [Token(Token = "0x4006C0B")]
    [FieldOffset(Offset = "0x18")]
    private bool mute;

    [Token(Token = "0x170016BE")]
    public string SE
    {
      [Token(Token = "0x6008E01"), Address(RVA = "0x4AFCE0C", Offset = "0x4AFCE0C", VA = "0x4AFCE0C")] private get
      {
        return (string) null;
      }
      [Token(Token = "0x6008E02"), Address(RVA = "0x4AFCE14", Offset = "0x4AFCE14", VA = "0x4AFCE14")] set
      {
      }
    }

    [Token(Token = "0x6008E03")]
    [Address(RVA = "0x4AFCE1C", Offset = "0x4AFCE1C", VA = "0x4AFCE1C")]
    private void PlaySE(string sename)
    {
    }

    [Token(Token = "0x6008E04")]
    [Address(RVA = "0x4AFCEF4", Offset = "0x4AFCEF4", VA = "0x4AFCEF4")]
    public void Mute(bool mute)
    {
    }

    [Token(Token = "0x6008E05")]
    [Address(RVA = "0x4AFCB14", Offset = "0x4AFCB14", VA = "0x4AFCB14")]
    public void UnSubScribe()
    {
    }

    [Token(Token = "0x6008E06")]
    [Address(RVA = "0x4AFC960", Offset = "0x4AFC960", VA = "0x4AFC960")]
    public static FreeMapInstancePlaySESubscribeHelper SubScribe(Animator animator)
    {
      return (FreeMapInstancePlaySESubscribeHelper) null;
    }

    [Token(Token = "0x6008E07")]
    [Address(RVA = "0x4AFCFB0", Offset = "0x4AFCFB0", VA = "0x4AFCFB0")]
    public FreeMapInstancePlaySESubscribeHelper()
    {
    }
  }
}
