// Decompiled with JetBrains decompiler
// Type: FreeMap.Scriptable.RangeClipScriptableData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Common.Attribute;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace FreeMap.Scriptable
{
  [Token(Token = "0x200184D")]
  [Serializable]
  public class RangeClipScriptableData
  {
    [Token(Token = "0x40069F3")]
    [FieldOffset(Offset = "0x10")]
    [Disable]
    [SerializeField]
    private string name;
    [Token(Token = "0x40069F4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Disable]
    private Vector3 position;
    [Token(Token = "0x40069F5")]
    [FieldOffset(Offset = "0x24")]
    [Disable]
    [SerializeField]
    private Quaternion rotation;
    [Token(Token = "0x40069F6")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Disable]
    private Vector3 center;
    [Token(Token = "0x40069F7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Disable]
    private Vector3 size;

    [Token(Token = "0x600896E")]
    [Address(RVA = "0x43E46F4", Offset = "0x43E46F4", VA = "0x43E46F4")]
    public RangeClipScriptableData(BoxCollider boxCollider)
    {
    }

    [Token(Token = "0x600896F")]
    [Address(RVA = "0x43E4CAC", Offset = "0x43E4CAC", VA = "0x43E4CAC")]
    public BoxCollider CreateBoxCollider(Transform parent) => (BoxCollider) null;
  }
}
