// Decompiled with JetBrains decompiler
// Type: UnitDetail.SimpleProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitDetail
{
  [Token(Token = "0x20004A0")]
  [Serializable]
  public class SimpleProfile
  {
    [Token(Token = "0x400187E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text englishName;
    [Token(Token = "0x400187F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text name;
    [Token(Token = "0x4001880")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image rarity;

    [Token(Token = "0x60019DD")]
    [Address(RVA = "0x2C24224", Offset = "0x2C24224", VA = "0x2C24224")]
    public void Update(UnitDetailInfo unitDetailInfo)
    {
    }

    [Token(Token = "0x60019DE")]
    [Address(RVA = "0x2C243A8", Offset = "0x2C243A8", VA = "0x2C243A8")]
    public SimpleProfile()
    {
    }
  }
}
