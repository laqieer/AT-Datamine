// Decompiled with JetBrains decompiler
// Type: UnitView.UI.ProfileInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI
{
  [Token(Token = "0x2000408")]
  [Serializable]
  public class ProfileInfo
  {
    [Token(Token = "0x4001705")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text[] charaNames;
    [Token(Token = "0x4001706")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text unitName;
    [Token(Token = "0x4001707")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image rarityImage;

    [Token(Token = "0x60016FC")]
    [Address(RVA = "0x248A064", Offset = "0x248A064", VA = "0x248A064")]
    public void Update(Style style)
    {
    }

    [Token(Token = "0x60016FD")]
    [Address(RVA = "0x248A11C", Offset = "0x248A11C", VA = "0x248A11C")]
    public ProfileInfo()
    {
    }
  }
}
