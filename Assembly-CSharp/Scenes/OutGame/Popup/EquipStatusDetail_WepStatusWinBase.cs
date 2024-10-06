// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.EquipStatusDetail_WepStatusWinBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x200345F")]
  public class EquipStatusDetail_WepStatusWinBase : MonoBehaviour
  {
    [Token(Token = "0x400E3D2")]
    [FieldOffset(Offset = "0x18")]
    public UniqueID uniqueId;
    [Token(Token = "0x400E3D3")]
    [FieldOffset(Offset = "0x20")]
    public CommonButton changeBtn;
    [Token(Token = "0x400E3D4")]
    [FieldOffset(Offset = "0x28")]
    public bool StartDisp;
    [Token(Token = "0x400E3D5")]
    [FieldOffset(Offset = "0x30")]
    public EquipStatusDetail_WepStatusWinBase pair;
    [Token(Token = "0x400E3D6")]
    [FieldOffset(Offset = "0x38")]
    public List<Text> param;
    [Token(Token = "0x400E3D7")]
    public const string nothingValue = "--";

    [Token(Token = "0x60148E5")]
    [Address(RVA = "0x1AA4B60", Offset = "0x1AA4B60", VA = "0x1AA4B60", Slot = "4")]
    public virtual void Initialize(UniqueID id)
    {
    }

    [Token(Token = "0x60148E6")]
    [Address(RVA = "0x1AA4B64", Offset = "0x1AA4B64", VA = "0x1AA4B64")]
    private void Start()
    {
    }

    [Token(Token = "0x60148E7")]
    [Address(RVA = "0x1AA06EC", Offset = "0x1AA06EC", VA = "0x1AA06EC")]
    public string SetValue(int value) => (string) null;

    [Token(Token = "0x60148E8")]
    [Address(RVA = "0x1AA0754", Offset = "0x1AA0754", VA = "0x1AA0754")]
    public EquipStatusDetail_WepStatusWinBase()
    {
    }
  }
}
