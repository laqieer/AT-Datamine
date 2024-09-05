// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2Placement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E5A")]
  public class Adv2Placement : ScriptableObject
  {
    [Token(Token = "0x40111B5")]
    [FieldOffset(Offset = "0x18")]
    public List<string> HumanKey;
    [Token(Token = "0x40111B6")]
    [FieldOffset(Offset = "0x20")]
    public List<string> ObjectKey;
    [Token(Token = "0x40111B7")]
    [FieldOffset(Offset = "0x28")]
    public List<Adv2Placement.HumanParam> HumanValue;
    [Token(Token = "0x40111B8")]
    [FieldOffset(Offset = "0x30")]
    public List<Adv2Placement.ObjectParam> ObjectValue;

    [Token(Token = "0x60191AF")]
    [Address(RVA = "0x2CF0C14", Offset = "0x2CF0C14", VA = "0x2CF0C14")]
    public Adv2Placement()
    {
    }

    [Token(Token = "0x2003E5B")]
    [Serializable]
    public class HumanParam
    {
      [Token(Token = "0x40111B9")]
      [FieldOffset(Offset = "0x10")]
      public float PositionX;
      [Token(Token = "0x40111BA")]
      [FieldOffset(Offset = "0x14")]
      public float PositionZ;
      [Token(Token = "0x40111BB")]
      [FieldOffset(Offset = "0x18")]
      public float EulerAngleY;
      [Token(Token = "0x40111BC")]
      [FieldOffset(Offset = "0x1C")]
      public Adv2Placement.HumanParam.Style EntryStyle;

      [Token(Token = "0x60191B0")]
      [Address(RVA = "0x2CF0D3C", Offset = "0x2CF0D3C", VA = "0x2CF0D3C")]
      public HumanParam()
      {
      }

      [Token(Token = "0x2003E5C")]
      public enum Style
      {
        [Token(Token = "0x40111BE")] Free,
        [Token(Token = "0x40111BF")] Standing,
        [Token(Token = "0x40111C0")] Sitting,
      }
    }

    [Token(Token = "0x2003E5D")]
    [Serializable]
    public class ObjectParam
    {
      [Token(Token = "0x40111C1")]
      [FieldOffset(Offset = "0x10")]
      public Vector3 Position;
      [Token(Token = "0x40111C2")]
      [FieldOffset(Offset = "0x1C")]
      public Vector3 EulerAngles;

      [Token(Token = "0x60191B1")]
      [Address(RVA = "0x2CF0D44", Offset = "0x2CF0D44", VA = "0x2CF0D44")]
      public ObjectParam()
      {
      }
    }
  }
}
