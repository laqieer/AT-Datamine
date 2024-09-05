// Decompiled with JetBrains decompiler
// Type: Battle.Data.TransformConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026EF")]
  [Serializable]
  public class TransformConfig
  {
    [Token(Token = "0x400A683")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Tooltip("座標")]
    private Vector3 offsetPosition;
    [Token(Token = "0x400A684")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Tooltip("角度")]
    private Vector3 offsetRotation;
    [Token(Token = "0x400A685")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Tooltip("スケール値")]
    private Vector3 offsetScale;

    [Token(Token = "0x170032E1")]
    public Vector3 OffsetPosition
    {
      [Token(Token = "0x600F0DB"), Address(RVA = "0x41ABBFC", Offset = "0x41ABBFC", VA = "0x41ABBFC")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170032E2")]
    public Vector3 OffsetRotation
    {
      [Token(Token = "0x600F0DC"), Address(RVA = "0x41ABC08", Offset = "0x41ABC08", VA = "0x41ABC08")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x170032E3")]
    public Vector3 OffsetScale
    {
      [Token(Token = "0x600F0DD"), Address(RVA = "0x41ABC14", Offset = "0x41ABC14", VA = "0x41ABC14")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x600F0DE")]
    [Address(RVA = "0x41ABC20", Offset = "0x41ABC20", VA = "0x41ABC20")]
    public TransformConfig()
    {
    }
  }
}
