// Decompiled with JetBrains decompiler
// Type: Network.ResumeClockAdjuster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A34")]
  public class ResumeClockAdjuster : MonoBehaviour
  {
    [Token(Token = "0x6009573")]
    [Address(RVA = "0x48EDCC0", Offset = "0x48EDCC0", VA = "0x48EDCC0")]
    public void Start()
    {
    }

    [Token(Token = "0x6009574")]
    [Address(RVA = "0x48E9028", Offset = "0x48E9028", VA = "0x48E9028")]
    public IEnumerator AdjustAsync() => (IEnumerator) null;

    [Token(Token = "0x6009575")]
    [Address(RVA = "0x48EDD54", Offset = "0x48EDD54", VA = "0x48EDD54")]
    private void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x6009576")]
    [Address(RVA = "0x48EDDE8", Offset = "0x48EDDE8", VA = "0x48EDDE8")]
    private void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x6009577")]
    [Address(RVA = "0x48EDE7C", Offset = "0x48EDE7C", VA = "0x48EDE7C")]
    public ResumeClockAdjuster()
    {
    }
  }
}
