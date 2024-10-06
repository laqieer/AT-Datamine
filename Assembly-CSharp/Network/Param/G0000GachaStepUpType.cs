// Decompiled with JetBrains decompiler
// Type: Network.Param.G0000GachaStepUpType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A58")]
  [Serializable]
  public class G0000GachaStepUpType
  {
    [Token(Token = "0x40070B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int group_id;
    [Token(Token = "0x40070B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int current_count;
    [Token(Token = "0x40070B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int total_count;

    [Token(Token = "0x170018E6")]
    public int GroupId
    {
      [Token(Token = "0x60096BA"), Address(RVA = "0x48EF414", Offset = "0x48EF414", VA = "0x48EF414")] get
      {
        return new int();
      }
      [Token(Token = "0x60096BB"), Address(RVA = "0x48EF41C", Offset = "0x48EF41C", VA = "0x48EF41C")] set
      {
      }
    }

    [Token(Token = "0x170018E7")]
    public int CurrentCount
    {
      [Token(Token = "0x60096BC"), Address(RVA = "0x48EF424", Offset = "0x48EF424", VA = "0x48EF424")] get
      {
        return new int();
      }
      [Token(Token = "0x60096BD"), Address(RVA = "0x48EF42C", Offset = "0x48EF42C", VA = "0x48EF42C")] set
      {
      }
    }

    [Token(Token = "0x170018E8")]
    public int TotalCount
    {
      [Token(Token = "0x60096BE"), Address(RVA = "0x48EF434", Offset = "0x48EF434", VA = "0x48EF434")] get
      {
        return new int();
      }
      [Token(Token = "0x60096BF"), Address(RVA = "0x48EF43C", Offset = "0x48EF43C", VA = "0x48EF43C")] set
      {
      }
    }

    [Token(Token = "0x60096C0")]
    [Address(RVA = "0x48EF444", Offset = "0x48EF444", VA = "0x48EF444")]
    public G0000GachaStepUpType()
    {
    }
  }
}
