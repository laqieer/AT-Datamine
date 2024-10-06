// Decompiled with JetBrains decompiler
// Type: StaqPostProcessData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200032D")]
public class StaqPostProcessData : ScriptableObject
{
  [Token(Token = "0x40012E6")]
  [FieldOffset(Offset = "0x18")]
  public StaqPostProcessData.ShaderResources shaders;
  [Token(Token = "0x40012E7")]
  [FieldOffset(Offset = "0x20")]
  public StaqPostProcessData.TextureResources textures;

  [Token(Token = "0x60012D5")]
  [Address(RVA = "0x285EC2C", Offset = "0x285EC2C", VA = "0x285EC2C")]
  public StaqPostProcessData()
  {
  }

  [Token(Token = "0x200032E")]
  [Serializable]
  public class ShaderResources
  {
    [Token(Token = "0x40012E8")]
    [FieldOffset(Offset = "0x10")]
    public Shader skycover;
    [Token(Token = "0x40012E9")]
    [FieldOffset(Offset = "0x18")]
    public Shader glare;
    [Token(Token = "0x40012EA")]
    [FieldOffset(Offset = "0x20")]
    public Shader composite;
    [Token(Token = "0x40012EB")]
    [FieldOffset(Offset = "0x28")]
    public Shader linearblur;
    [Token(Token = "0x40012EC")]
    [FieldOffset(Offset = "0x30")]
    public Shader blit;
    [Token(Token = "0x40012ED")]
    [FieldOffset(Offset = "0x38")]
    public Shader diffution;

    [Token(Token = "0x60012D6")]
    [Address(RVA = "0x285EC34", Offset = "0x285EC34", VA = "0x285EC34")]
    public ShaderResources()
    {
    }
  }

  [Token(Token = "0x200032F")]
  [Serializable]
  public class TextureResources
  {
    [Token(Token = "0x60012D7")]
    [Address(RVA = "0x285EC3C", Offset = "0x285EC3C", VA = "0x285EC3C")]
    public TextureResources()
    {
    }
  }
}
