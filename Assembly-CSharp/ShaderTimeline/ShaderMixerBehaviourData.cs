// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.ShaderMixerBehaviourData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x200076E")]
  public class ShaderMixerBehaviourData
  {
    [Token(Token = "0x40021F9")]
    [FieldOffset(Offset = "0x10")]
    public List<Material> PrevMaterials;
    [Token(Token = "0x40021FA")]
    [FieldOffset(Offset = "0x18")]
    public List<Material> Materials;
    [Token(Token = "0x40021FB")]
    [FieldOffset(Offset = "0x20")]
    public ShaderPlayableValue.ComponentType ComponentType;
    [Token(Token = "0x40021FC")]
    [FieldOffset(Offset = "0x28")]
    public Renderer Renderer;
    [Token(Token = "0x40021FD")]
    [FieldOffset(Offset = "0x30")]
    public Graphic Graphic;

    [Token(Token = "0x6002985")]
    [Address(RVA = "0x3681DB8", Offset = "0x3681DB8", VA = "0x3681DB8")]
    public ShaderMixerBehaviourData()
    {
    }
  }
}
