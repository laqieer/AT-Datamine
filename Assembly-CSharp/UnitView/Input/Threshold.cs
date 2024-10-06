// Decompiled with JetBrains decompiler
// Type: UnitView.Input.Threshold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitView.Input
{
  [Token(Token = "0x20003F8")]
  [Serializable]
  public class Threshold
  {
    [Token(Token = "0x40016BE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Threshold.Range distance;
    [Token(Token = "0x40016BF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float time;

    [Token(Token = "0x17000287")]
    public Threshold.Range Distance
    {
      [Token(Token = "0x60016D4"), Address(RVA = "0x248934C", Offset = "0x248934C", VA = "0x248934C")] get
      {
        return (Threshold.Range) null;
      }
    }

    [Token(Token = "0x17000288")]
    public float Time
    {
      [Token(Token = "0x60016D5"), Address(RVA = "0x2489354", Offset = "0x2489354", VA = "0x2489354")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x60016D6")]
    [Address(RVA = "0x248935C", Offset = "0x248935C", VA = "0x248935C")]
    public Threshold()
    {
    }

    [Token(Token = "0x20003F9")]
    [Serializable]
    public class Range
    {
      [Token(Token = "0x40016C0")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      [Header("有効最小値(cm)")]
      private float min;
      [Token(Token = "0x40016C1")]
      [FieldOffset(Offset = "0x14")]
      [Header("有効最大値(cm)")]
      [SerializeField]
      private float max;

      [Token(Token = "0x60016D7")]
      [Address(RVA = "0x2488E3C", Offset = "0x2488E3C", VA = "0x2488E3C")]
      public bool IsValid(float length) => new bool();

      [Token(Token = "0x60016D8")]
      [Address(RVA = "0x24893C4", Offset = "0x24893C4", VA = "0x24893C4")]
      public Range()
      {
      }
    }
  }
}
