// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.OrdinalBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BF2")]
  [Serializable]
  public class OrdinalBadge
  {
    [Token(Token = "0x4003631")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image badge;
    [Token(Token = "0x4003632")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI text;

    [Token(Token = "0x170009E9")]
    public GameObject gameObject
    {
      [Token(Token = "0x600446D"), Address(RVA = "0x3646E2C", Offset = "0x3646E2C", VA = "0x3646E2C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x600446E")]
    [Address(RVA = "0x3646E48", Offset = "0x3646E48", VA = "0x3646E48")]
    public void Set(int number)
    {
    }

    [Token(Token = "0x600446F")]
    [Address(RVA = "0x36494F4", Offset = "0x36494F4", VA = "0x36494F4")]
    public OrdinalBadge()
    {
    }
  }
}
