// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.StatusSetContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipDetail
{
  [Token(Token = "0x2000469")]
  [Serializable]
  public class StatusSetContainer
  {
    [Token(Token = "0x400181E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform root;
    [Token(Token = "0x400181F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StatusSet basicParameters;
    [Token(Token = "0x4001820")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StatusSet resistances;

    [Token(Token = "0x170002FA")]
    public StatusSet BasicParameters
    {
      [Token(Token = "0x60018EC"), Address(RVA = "0x2493468", Offset = "0x2493468", VA = "0x2493468")] get
      {
        return (StatusSet) null;
      }
    }

    [Token(Token = "0x170002FB")]
    public StatusSet Resistances
    {
      [Token(Token = "0x60018ED"), Address(RVA = "0x2493470", Offset = "0x2493470", VA = "0x2493470")] get
      {
        return (StatusSet) null;
      }
    }

    [Token(Token = "0x60018EE")]
    [Address(RVA = "0x249339C", Offset = "0x249339C", VA = "0x249339C")]
    public void Clear()
    {
    }

    [Token(Token = "0x60018EF")]
    [Address(RVA = "0x24931F4", Offset = "0x24931F4", VA = "0x24931F4")]
    public void ReSizing()
    {
    }

    [Token(Token = "0x60018F0")]
    [Address(RVA = "0x249361C", Offset = "0x249361C", VA = "0x249361C")]
    public StatusSetContainer()
    {
    }
  }
}
