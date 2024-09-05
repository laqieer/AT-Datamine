// Decompiled with JetBrains decompiler
// Type: FreeMap.Reward.ToasterViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.Reward
{
  [Token(Token = "0x2001852")]
  public class ToasterViewer : MonoBehaviour
  {
    [Token(Token = "0x4006A03")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text toasterText;
    [Token(Token = "0x4006A04")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup uITweenGroup;
    [Token(Token = "0x4006A05")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string showTweenName;

    [Token(Token = "0x6008980")]
    [Address(RVA = "0x43E5910", Offset = "0x43E5910", VA = "0x43E5910")]
    public void SetToasterText(string text)
    {
    }

    [Token(Token = "0x6008981")]
    [Address(RVA = "0x43E5934", Offset = "0x43E5934", VA = "0x43E5934")]
    public IEnumerator PlayToaster() => (IEnumerator) null;

    [Token(Token = "0x6008982")]
    [Address(RVA = "0x43E59C4", Offset = "0x43E59C4", VA = "0x43E59C4")]
    public ToasterViewer()
    {
    }
  }
}
