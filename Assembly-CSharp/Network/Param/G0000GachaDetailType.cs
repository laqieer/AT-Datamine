// Decompiled with JetBrains decompiler
// Type: Network.Param.G0000GachaDetailType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A55")]
  [Serializable]
  public class G0000GachaDetailType
  {
    [Token(Token = "0x40070A0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string title;
    [Token(Token = "0x40070A1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string description;
    [Token(Token = "0x40070A2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<G0000GachaGroupType> groups;
    [Token(Token = "0x40070A3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<G0000GachaType> gachas;
    [Token(Token = "0x40070A4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<G0000GachaNewEntityType> new_entity;
    [Token(Token = "0x40070A5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<G0000GachaStepUpType> step_up;
    [Token(Token = "0x40070A6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool is_badge_enable;

    [Token(Token = "0x170018D6")]
    public string Title
    {
      [Token(Token = "0x6009697"), Address(RVA = "0x48EF2F8", Offset = "0x48EF2F8", VA = "0x48EF2F8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009698"), Address(RVA = "0x48EF300", Offset = "0x48EF300", VA = "0x48EF300")] set
      {
      }
    }

    [Token(Token = "0x170018D7")]
    public string Description
    {
      [Token(Token = "0x6009699"), Address(RVA = "0x48EF308", Offset = "0x48EF308", VA = "0x48EF308")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600969A"), Address(RVA = "0x48EF310", Offset = "0x48EF310", VA = "0x48EF310")] set
      {
      }
    }

    [Token(Token = "0x170018D8")]
    public List<G0000GachaGroupType> Groups
    {
      [Token(Token = "0x600969B"), Address(RVA = "0x48EF318", Offset = "0x48EF318", VA = "0x48EF318")] get
      {
        return (List<G0000GachaGroupType>) null;
      }
      [Token(Token = "0x600969C"), Address(RVA = "0x48EF320", Offset = "0x48EF320", VA = "0x48EF320")] set
      {
      }
    }

    [Token(Token = "0x170018D9")]
    public List<G0000GachaType> Gachas
    {
      [Token(Token = "0x600969D"), Address(RVA = "0x48EF328", Offset = "0x48EF328", VA = "0x48EF328")] get
      {
        return (List<G0000GachaType>) null;
      }
      [Token(Token = "0x600969E"), Address(RVA = "0x48EF330", Offset = "0x48EF330", VA = "0x48EF330")] set
      {
      }
    }

    [Token(Token = "0x170018DA")]
    public List<G0000GachaNewEntityType> NewEntity
    {
      [Token(Token = "0x600969F"), Address(RVA = "0x48EF338", Offset = "0x48EF338", VA = "0x48EF338")] get
      {
        return (List<G0000GachaNewEntityType>) null;
      }
      [Token(Token = "0x60096A0"), Address(RVA = "0x48EF340", Offset = "0x48EF340", VA = "0x48EF340")] set
      {
      }
    }

    [Token(Token = "0x170018DB")]
    public List<G0000GachaStepUpType> StepUp
    {
      [Token(Token = "0x60096A1"), Address(RVA = "0x48EF348", Offset = "0x48EF348", VA = "0x48EF348")] get
      {
        return (List<G0000GachaStepUpType>) null;
      }
      [Token(Token = "0x60096A2"), Address(RVA = "0x48EF350", Offset = "0x48EF350", VA = "0x48EF350")] set
      {
      }
    }

    [Token(Token = "0x170018DC")]
    public bool IsBadgeEnable
    {
      [Token(Token = "0x60096A3"), Address(RVA = "0x48EF358", Offset = "0x48EF358", VA = "0x48EF358")] get
      {
        return new bool();
      }
      [Token(Token = "0x60096A4"), Address(RVA = "0x48EF360", Offset = "0x48EF360", VA = "0x48EF360")] set
      {
      }
    }

    [Token(Token = "0x60096A5")]
    [Address(RVA = "0x48EF36C", Offset = "0x48EF36C", VA = "0x48EF36C")]
    public G0000GachaDetailType()
    {
    }
  }
}
