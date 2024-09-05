// Decompiled with JetBrains decompiler
// Type: Network.Param.G0001GachaDetailType
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
  [Token(Token = "0x2001A5A")]
  [Serializable]
  public class G0001GachaDetailType
  {
    [Token(Token = "0x40070C5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string title;
    [Token(Token = "0x40070C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string description;
    [Token(Token = "0x40070C7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<G0000GachaGroupType> groups;
    [Token(Token = "0x40070C8")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<G0001GachaType> gachas;
    [Token(Token = "0x40070C9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<G0000GachaNewEntityType> new_entity;
    [Token(Token = "0x40070CA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<G0000GachaStepUpType> step_up;
    [Token(Token = "0x40070CB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool is_badge_enable;
    [Token(Token = "0x40070CC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<G0001GachaTargetType> targets;

    [Token(Token = "0x170018FB")]
    public string Title
    {
      [Token(Token = "0x60096E6"), Address(RVA = "0x48EF578", Offset = "0x48EF578", VA = "0x48EF578")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60096E7"), Address(RVA = "0x48EF580", Offset = "0x48EF580", VA = "0x48EF580")] set
      {
      }
    }

    [Token(Token = "0x170018FC")]
    public string Description
    {
      [Token(Token = "0x60096E8"), Address(RVA = "0x48EF588", Offset = "0x48EF588", VA = "0x48EF588")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60096E9"), Address(RVA = "0x48EF590", Offset = "0x48EF590", VA = "0x48EF590")] set
      {
      }
    }

    [Token(Token = "0x170018FD")]
    public List<G0000GachaGroupType> Groups
    {
      [Token(Token = "0x60096EA"), Address(RVA = "0x48EF598", Offset = "0x48EF598", VA = "0x48EF598")] get
      {
        return (List<G0000GachaGroupType>) null;
      }
      [Token(Token = "0x60096EB"), Address(RVA = "0x48EF5A0", Offset = "0x48EF5A0", VA = "0x48EF5A0")] set
      {
      }
    }

    [Token(Token = "0x170018FE")]
    public List<G0001GachaType> Gachas
    {
      [Token(Token = "0x60096EC"), Address(RVA = "0x48EF5A8", Offset = "0x48EF5A8", VA = "0x48EF5A8")] get
      {
        return (List<G0001GachaType>) null;
      }
      [Token(Token = "0x60096ED"), Address(RVA = "0x48EF5B0", Offset = "0x48EF5B0", VA = "0x48EF5B0")] set
      {
      }
    }

    [Token(Token = "0x170018FF")]
    public List<G0000GachaNewEntityType> NewEntity
    {
      [Token(Token = "0x60096EE"), Address(RVA = "0x48EF5B8", Offset = "0x48EF5B8", VA = "0x48EF5B8")] get
      {
        return (List<G0000GachaNewEntityType>) null;
      }
      [Token(Token = "0x60096EF"), Address(RVA = "0x48EF5C0", Offset = "0x48EF5C0", VA = "0x48EF5C0")] set
      {
      }
    }

    [Token(Token = "0x17001900")]
    public List<G0000GachaStepUpType> StepUp
    {
      [Token(Token = "0x60096F0"), Address(RVA = "0x48EF5C8", Offset = "0x48EF5C8", VA = "0x48EF5C8")] get
      {
        return (List<G0000GachaStepUpType>) null;
      }
      [Token(Token = "0x60096F1"), Address(RVA = "0x48EF5D0", Offset = "0x48EF5D0", VA = "0x48EF5D0")] set
      {
      }
    }

    [Token(Token = "0x17001901")]
    public bool IsBadgeEnable
    {
      [Token(Token = "0x60096F2"), Address(RVA = "0x48EF5D8", Offset = "0x48EF5D8", VA = "0x48EF5D8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60096F3"), Address(RVA = "0x48EF5E0", Offset = "0x48EF5E0", VA = "0x48EF5E0")] set
      {
      }
    }

    [Token(Token = "0x17001902")]
    public List<G0001GachaTargetType> Targets
    {
      [Token(Token = "0x60096F4"), Address(RVA = "0x48EF5EC", Offset = "0x48EF5EC", VA = "0x48EF5EC")] get
      {
        return (List<G0001GachaTargetType>) null;
      }
      [Token(Token = "0x60096F5"), Address(RVA = "0x48EF5F4", Offset = "0x48EF5F4", VA = "0x48EF5F4")] set
      {
      }
    }

    [Token(Token = "0x60096F6")]
    [Address(RVA = "0x48EF5FC", Offset = "0x48EF5FC", VA = "0x48EF5FC")]
    public G0001GachaDetailType()
    {
    }
  }
}
