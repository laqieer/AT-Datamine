// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableMobAnchorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Common.Attribute;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x2002840")]
  [Serializable]
  public class MovableMobAnchorData : IMovableMobAnchorData
  {
    [Token(Token = "0x400AB9C")]
    [FieldOffset(Offset = "0x10")]
    [Disable]
    [SerializeField]
    private string anchorName;
    [Token(Token = "0x400AB9D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Disable]
    private Vector3 anchorPosition;
    [Token(Token = "0x400AB9E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [Disable]
    private float fadeRadius;

    [Token(Token = "0x170037C0")]
    public string AnchorName
    {
      [Token(Token = "0x600FD67"), Address(RVA = "0x442E3A0", Offset = "0x442E3A0", VA = "0x442E3A0", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037C1")]
    public Vector3 AnchorPosition
    {
      [Token(Token = "0x600FD68"), Address(RVA = "0x442E3A8", Offset = "0x442E3A8", VA = "0x442E3A8", Slot = "5")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170037C2")]
    public float FadeRadius
    {
      [Token(Token = "0x600FD69"), Address(RVA = "0x442E3B4", Offset = "0x442E3B4", VA = "0x442E3B4", Slot = "6")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600FD6A")]
    [Address(RVA = "0x442B2F0", Offset = "0x442B2F0", VA = "0x442B2F0")]
    public MovableMobAnchorData(string name, Vector3 position, float radius)
    {
    }
  }
}
