// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapAnimationClipPlaySEEventReceiver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x200190B")]
  public class FreeMapAnimationClipPlaySEEventReceiver : MonoBehaviour
  {
    [Token(Token = "0x1400012C")]
    public event System.Action<string> Listener
    {
      [Token(Token = "0x6008E6A"), Address(RVA = "0x4AFCFB8", Offset = "0x4AFCFB8", VA = "0x4AFCFB8")] add
      {
      }
      [Token(Token = "0x6008E6B"), Address(RVA = "0x4AFCF00", Offset = "0x4AFCF00", VA = "0x4AFCF00")] remove
      {
      }
    }

    [Token(Token = "0x6008E6C")]
    [Address(RVA = "0x4B01C1C", Offset = "0x4B01C1C", VA = "0x4B01C1C")]
    private void PlaySE(string seName)
    {
    }

    [Token(Token = "0x6008E6D")]
    [Address(RVA = "0x4B01C38", Offset = "0x4B01C38", VA = "0x4B01C38")]
    public FreeMapAnimationClipPlaySEEventReceiver()
    {
    }
  }
}
