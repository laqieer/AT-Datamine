// Decompiled with JetBrains decompiler
// Type: Story.Prop.PropControllerElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.Prop
{
  [Token(Token = "0x2000667")]
  [Serializable]
  public class PropControllerElement
  {
    [Token(Token = "0x4001F09")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string name;
    [Token(Token = "0x4001F0A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AnimatorControllerParameterType type;
    [Token(Token = "0x4001F0B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private float defaultFloat;
    [Token(Token = "0x4001F0C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int defaultInt;
    [Token(Token = "0x4001F0D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool defaultBool;

    [Token(Token = "0x17000553")]
    public string Name
    {
      [Token(Token = "0x60024C1"), Address(RVA = "0x2F34170", Offset = "0x2F34170", VA = "0x2F34170")] set
      {
      }
      [Token(Token = "0x60024C2"), Address(RVA = "0x2F34178", Offset = "0x2F34178", VA = "0x2F34178")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000554")]
    public AnimatorControllerParameterType Type
    {
      [Token(Token = "0x60024C3"), Address(RVA = "0x2F34180", Offset = "0x2F34180", VA = "0x2F34180")] set
      {
      }
      [Token(Token = "0x60024C4"), Address(RVA = "0x2F34188", Offset = "0x2F34188", VA = "0x2F34188")] get
      {
        return new AnimatorControllerParameterType();
      }
    }

    [Token(Token = "0x17000555")]
    public float DefaultFloat
    {
      [Token(Token = "0x60024C5"), Address(RVA = "0x2F34190", Offset = "0x2F34190", VA = "0x2F34190")] set
      {
      }
      [Token(Token = "0x60024C6"), Address(RVA = "0x2F34198", Offset = "0x2F34198", VA = "0x2F34198")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000556")]
    public int DefaultInt
    {
      [Token(Token = "0x60024C7"), Address(RVA = "0x2F341A0", Offset = "0x2F341A0", VA = "0x2F341A0")] set
      {
      }
      [Token(Token = "0x60024C8"), Address(RVA = "0x2F341A8", Offset = "0x2F341A8", VA = "0x2F341A8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000557")]
    public bool DefaultBool
    {
      [Token(Token = "0x60024C9"), Address(RVA = "0x2F341B0", Offset = "0x2F341B0", VA = "0x2F341B0")] set
      {
      }
      [Token(Token = "0x60024CA"), Address(RVA = "0x2F341BC", Offset = "0x2F341BC", VA = "0x2F341BC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60024CB")]
    [Address(RVA = "0x2F341C4", Offset = "0x2F341C4", VA = "0x2F341C4")]
    public void ReflectParameter(Animator animator)
    {
    }

    [Token(Token = "0x60024CC")]
    [Address(RVA = "0x2F34278", Offset = "0x2F34278", VA = "0x2F34278")]
    public PropControllerElement()
    {
    }
  }
}
