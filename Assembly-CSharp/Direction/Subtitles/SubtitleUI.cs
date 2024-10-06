// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.SubtitleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F28")]
  public class SubtitleUI : MonoBehaviour, ISubtitleUI
  {
    [Token(Token = "0x40085A1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text text;

    [Token(Token = "0x600B900")]
    [Address(RVA = "0x2138B04", Offset = "0x2138B04", VA = "0x2138B04", Slot = "4")]
    public void Init()
    {
    }

    [Token(Token = "0x600B901")]
    [Address(RVA = "0x2138BF4", Offset = "0x2138BF4", VA = "0x2138BF4", Slot = "5")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600B902")]
    [Address(RVA = "0x2138B54", Offset = "0x2138B54", VA = "0x2138B54", Slot = "6")]
    public void SetSubtitle(string subtitle)
    {
    }

    [Token(Token = "0x600B903")]
    [Address(RVA = "0x2138C1C", Offset = "0x2138C1C", VA = "0x2138C1C", Slot = "7")]
    public void SetTalkerAndSubtitle(string talker, string subtitle)
    {
    }

    [Token(Token = "0x600B904")]
    [Address(RVA = "0x2138CBC", Offset = "0x2138CBC", VA = "0x2138CBC")]
    public SubtitleUI()
    {
    }
  }
}
