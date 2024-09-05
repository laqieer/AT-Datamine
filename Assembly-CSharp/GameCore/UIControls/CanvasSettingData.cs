// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.CanvasSettingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BE5")]
  [Serializable]
  public class CanvasSettingData
  {
    [Token(Token = "0x40035FA")]
    private const string DefalutSettingName = "SubSceneCanvas";
    [Token(Token = "0x40035FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string settingName;

    [Token(Token = "0x170009DD")]
    public string SettingName
    {
      [Token(Token = "0x60043ED"), Address(RVA = "0x3644BF0", Offset = "0x3644BF0", VA = "0x3644BF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170009DE")]
    public int PlaneDistance
    {
      [Token(Token = "0x60043EE"), Address(RVA = "0x3644BF8", Offset = "0x3644BF8", VA = "0x3644BF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60043EF")]
    [Address(RVA = "0x3644CF0", Offset = "0x3644CF0", VA = "0x3644CF0")]
    public CanvasSettingData()
    {
    }
  }
}
