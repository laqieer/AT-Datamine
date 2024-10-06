// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.WeaponPreviewImageProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000457")]
  [Serializable]
  public class WeaponPreviewImageProvider : Singleton<WeaponPreviewImageProvider>
  {
    [Token(Token = "0x40017E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SpriteContainer images;

    [Token(Token = "0x170002E5")]
    public SpriteContainer Images
    {
      [Token(Token = "0x600189B"), Address(RVA = "0x249150C", Offset = "0x249150C", VA = "0x249150C")] get
      {
        return (SpriteContainer) null;
      }
    }

    [Token(Token = "0x600189C")]
    [Address(RVA = "0x2491514", Offset = "0x2491514", VA = "0x2491514")]
    public WeaponPreviewImageProvider()
    {
    }
  }
}
