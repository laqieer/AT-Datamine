// Decompiled with JetBrains decompiler
// Type: Network.Param.G0001GachaTargetType
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
  [Token(Token = "0x2001A5C")]
  [Serializable]
  public class G0001GachaTargetType
  {
    [Token(Token = "0x40070D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int target_id;
    [Token(Token = "0x40070D2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<G0001GachaTargetOptionType> target_options;
    [Token(Token = "0x40070D3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int selected_target_option_id;
    [Token(Token = "0x40070D4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int target_count;
    [Token(Token = "0x40070D5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int current_target_count;

    [Token(Token = "0x17001907")]
    public int TargetId
    {
      [Token(Token = "0x6009700"), Address(RVA = "0x48EF64C", Offset = "0x48EF64C", VA = "0x48EF64C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009701"), Address(RVA = "0x48EF654", Offset = "0x48EF654", VA = "0x48EF654")] set
      {
      }
    }

    [Token(Token = "0x17001908")]
    public List<G0001GachaTargetOptionType> TargetOptions
    {
      [Token(Token = "0x6009702"), Address(RVA = "0x48EF65C", Offset = "0x48EF65C", VA = "0x48EF65C")] get
      {
        return (List<G0001GachaTargetOptionType>) null;
      }
      [Token(Token = "0x6009703"), Address(RVA = "0x48EF664", Offset = "0x48EF664", VA = "0x48EF664")] set
      {
      }
    }

    [Token(Token = "0x17001909")]
    public int SelectedTargetOptionId
    {
      [Token(Token = "0x6009704"), Address(RVA = "0x48EF66C", Offset = "0x48EF66C", VA = "0x48EF66C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009705"), Address(RVA = "0x48EF674", Offset = "0x48EF674", VA = "0x48EF674")] set
      {
      }
    }

    [Token(Token = "0x1700190A")]
    public int TargetCount
    {
      [Token(Token = "0x6009706"), Address(RVA = "0x48EF67C", Offset = "0x48EF67C", VA = "0x48EF67C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009707"), Address(RVA = "0x48EF684", Offset = "0x48EF684", VA = "0x48EF684")] set
      {
      }
    }

    [Token(Token = "0x1700190B")]
    public int CurrentTargetCount
    {
      [Token(Token = "0x6009708"), Address(RVA = "0x48EF68C", Offset = "0x48EF68C", VA = "0x48EF68C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009709"), Address(RVA = "0x48EF694", Offset = "0x48EF694", VA = "0x48EF694")] set
      {
      }
    }

    [Token(Token = "0x600970A")]
    [Address(RVA = "0x48EF69C", Offset = "0x48EF69C", VA = "0x48EF69C")]
    public G0001GachaTargetType()
    {
    }
  }
}
