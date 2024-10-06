// Decompiled with JetBrains decompiler
// Type: UI.Common.LpIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x200091C")]
  public class LpIcon : MonoBehaviour
  {
    [Token(Token = "0x4002A75")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject _baseObj;
    [Token(Token = "0x4002A76")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject _onObj;
    [Token(Token = "0x4002A77")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject _eftObj;

    [Token(Token = "0x6003352")]
    [Address(RVA = "0x36266B0", Offset = "0x36266B0", VA = "0x36266B0")]
    public void Set(bool isOn)
    {
    }

    [Token(Token = "0x6003353")]
    [Address(RVA = "0x36266F8", Offset = "0x36266F8", VA = "0x36266F8")]
    public void PlayEffect(bool isPlay)
    {
    }

    [Token(Token = "0x6003354")]
    [Address(RVA = "0x3626704", Offset = "0x3626704", VA = "0x3626704")]
    public void PlayEffect()
    {
    }

    [Token(Token = "0x6003355")]
    [Address(RVA = "0x3626724", Offset = "0x3626724", VA = "0x3626724")]
    public void StopEffect()
    {
    }

    [Token(Token = "0x6003356")]
    [Address(RVA = "0x3625D48", Offset = "0x3625D48", VA = "0x3625D48")]
    public void SetOnAndPlayEffect(bool isPlay)
    {
    }

    [Token(Token = "0x6003357")]
    [Address(RVA = "0x3625D80", Offset = "0x3625D80", VA = "0x3625D80")]
    public void UnsetAndStopEffect()
    {
    }

    [Token(Token = "0x6003358")]
    [Address(RVA = "0x3626744", Offset = "0x3626744", VA = "0x3626744")]
    public LpIcon()
    {
    }
  }
}
