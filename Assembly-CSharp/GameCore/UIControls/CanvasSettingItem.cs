// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.CanvasSettingItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BE8")]
  [Serializable]
  public class CanvasSettingItem
  {
    [Token(Token = "0x4003600")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string name;
    [Token(Token = "0x4003601")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Range(1f, 999f)]
    private int planeDistance;

    [Token(Token = "0x170009E1")]
    public string Name
    {
      [Token(Token = "0x60043F6"), Address(RVA = "0x3644E5C", Offset = "0x3644E5C", VA = "0x3644E5C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170009E2")]
    public int PlaneDistance
    {
      [Token(Token = "0x60043F7"), Address(RVA = "0x3644E64", Offset = "0x3644E64", VA = "0x3644E64")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60043F8")]
    [Address(RVA = "0x3644E6C", Offset = "0x3644E6C", VA = "0x3644E6C")]
    public CanvasSettingItem()
    {
    }
  }
}
