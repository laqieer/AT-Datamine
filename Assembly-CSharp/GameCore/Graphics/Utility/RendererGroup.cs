// Decompiled with JetBrains decompiler
// Type: GameCore.Graphics.Utility.RendererGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Graphics.Utility
{
  [Token(Token = "0x200145C")]
  public class RendererGroup : MonoBehaviour
  {
    [Token(Token = "0x1700119E")]
    public Material Material
    {
      [Token(Token = "0x60072CF"), Address(RVA = "0x40526F0", Offset = "0x40526F0", VA = "0x40526F0")] get
      {
        return (Material) null;
      }
      [Token(Token = "0x60072D0"), Address(RVA = "0x40526F8", Offset = "0x40526F8", VA = "0x40526F8")] private set
      {
      }
    }

    [Token(Token = "0x1700119F")]
    private Dictionary<int, Material> materials
    {
      [Token(Token = "0x60072D1"), Address(RVA = "0x4052700", Offset = "0x4052700", VA = "0x4052700")] get
      {
        return (Dictionary<int, Material>) null;
      }
    }

    [Token(Token = "0x60072D2")]
    [Address(RVA = "0x4052708", Offset = "0x4052708", VA = "0x4052708")]
    private void Start()
    {
    }

    [Token(Token = "0x60072D3")]
    [Address(RVA = "0x4052DDC", Offset = "0x4052DDC", VA = "0x4052DDC")]
    public Material TryGetValue(int instanceID) => (Material) null;

    [Token(Token = "0x60072D4")]
    [Address(RVA = "0x4052E54", Offset = "0x4052E54", VA = "0x4052E54")]
    public RendererGroup()
    {
    }
  }
}
