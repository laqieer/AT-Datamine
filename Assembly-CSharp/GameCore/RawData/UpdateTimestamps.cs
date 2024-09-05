// Decompiled with JetBrains decompiler
// Type: GameCore.RawData.UpdateTimestamps
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.RawData
{
  [Token(Token = "0x2000CB2")]
  [Serializable]
  public class UpdateTimestamps
  {
    [Token(Token = "0x400391F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string[] categories;
    [Token(Token = "0x4003920")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private long[] timestamps;
    [Token(Token = "0x4003921")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string[] movieCategories;
    [Token(Token = "0x4003922")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private long[] movieTimestamps;
    [Token(Token = "0x4003923")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, long> _timestampsDict;
    [Token(Token = "0x4003924")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<string, long> _movieTimestampsDict;

    [Token(Token = "0x6004935")]
    [Address(RVA = "0x3135804", Offset = "0x3135804", VA = "0x3135804")]
    public UpdateTimestamps()
    {
    }

    [Token(Token = "0x6004936")]
    [Address(RVA = "0x313580C", Offset = "0x313580C", VA = "0x313580C")]
    public UpdateTimestamps(string[] categories, long[] timestamps)
    {
    }

    [Token(Token = "0x6004937")]
    [Address(RVA = "0x3135838", Offset = "0x3135838", VA = "0x3135838")]
    public UpdateTimestamps(
      string[] categories,
      long[] timestamps,
      string[] movieCategories,
      long[] movieTimestamps)
    {
    }

    [Token(Token = "0x17000AB5")]
    public Dictionary<string, long> Timestamps
    {
      [Token(Token = "0x6004938"), Address(RVA = "0x3135878", Offset = "0x3135878", VA = "0x3135878")] get
      {
        return (Dictionary<string, long>) null;
      }
    }

    [Token(Token = "0x17000AB6")]
    public Dictionary<string, long> MovieTimestamps
    {
      [Token(Token = "0x6004939"), Address(RVA = "0x3135980", Offset = "0x3135980", VA = "0x3135980")] get
      {
        return (Dictionary<string, long>) null;
      }
    }
  }
}
