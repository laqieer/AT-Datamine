// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.StatusUICache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipChange
{
  [Token(Token = "0x2000483")]
  public class StatusUICache
  {
    [Token(Token = "0x400184D")]
    [FieldOffset(Offset = "0x10")]
    private Queue<WeaponsEquipChangeStatusUI> caches;
    [Token(Token = "0x400184E")]
    [FieldOffset(Offset = "0x18")]
    private GameObject asset;

    [Token(Token = "0x6001943")]
    [Address(RVA = "0x24949C8", Offset = "0x24949C8", VA = "0x24949C8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001944")]
    [Address(RVA = "0x2494770", Offset = "0x2494770", VA = "0x2494770")]
    public WeaponsEquipChangeStatusUI Get() => (WeaponsEquipChangeStatusUI) null;

    [Token(Token = "0x6001945")]
    [Address(RVA = "0x2494AD4", Offset = "0x2494AD4", VA = "0x2494AD4")]
    public void Release(WeaponsEquipChangeStatusUI ui)
    {
    }

    [Token(Token = "0x6001946")]
    [Address(RVA = "0x24949CC", Offset = "0x24949CC", VA = "0x24949CC")]
    private void LoadAsset()
    {
    }

    [Token(Token = "0x6001947")]
    [Address(RVA = "0x249494C", Offset = "0x249494C", VA = "0x249494C")]
    public StatusUICache()
    {
    }
  }
}
