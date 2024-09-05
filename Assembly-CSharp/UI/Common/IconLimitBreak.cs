// Decompiled with JetBrains decompiler
// Type: UI.Common.IconLimitBreak
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x200091A")]
  public class IconLimitBreak : MonoBehaviour
  {
    [Token(Token = "0x4002A72")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle _gemToggle;
    [Token(Token = "0x4002A73")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject _enhance;

    [Token(Token = "0x600334A")]
    [Address(RVA = "0x3626408", Offset = "0x3626408", VA = "0x3626408")]
    public void SetOn(bool enhance = false)
    {
    }

    [Token(Token = "0x600334B")]
    [Address(RVA = "0x362655C", Offset = "0x362655C", VA = "0x362655C")]
    public void SetOff()
    {
    }

    [Token(Token = "0x600334C")]
    [Address(RVA = "0x3626434", Offset = "0x3626434", VA = "0x3626434")]
    public void SetGem(bool isOn)
    {
    }

    [Token(Token = "0x600334D")]
    [Address(RVA = "0x36264C8", Offset = "0x36264C8", VA = "0x36264C8")]
    public void SetEnhance(bool isOn)
    {
    }

    [Token(Token = "0x600334E")]
    [Address(RVA = "0x362657C", Offset = "0x362657C", VA = "0x362657C")]
    public IconLimitBreak()
    {
    }
  }
}
