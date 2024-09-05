// Decompiled with JetBrains decompiler
// Type: Battle.UI.WeaponTypeIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002430")]
  [Serializable]
  internal class WeaponTypeIconParam
  {
    [Token(Token = "0x4009AD8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private WeaponTypeEnum weaponType;
    [Token(Token = "0x4009AD9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string iconName;

    [Token(Token = "0x17002FA6")]
    public WeaponTypeEnum WeaponType
    {
      [Token(Token = "0x600DDBA"), Address(RVA = "0x1E2B2DC", Offset = "0x1E2B2DC", VA = "0x1E2B2DC")] get
      {
        return new WeaponTypeEnum();
      }
    }

    [Token(Token = "0x17002FA7")]
    public string IconName
    {
      [Token(Token = "0x600DDBB"), Address(RVA = "0x1E2B2E4", Offset = "0x1E2B2E4", VA = "0x1E2B2E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600DDBC")]
    [Address(RVA = "0x1E2B2EC", Offset = "0x1E2B2EC", VA = "0x1E2B2EC")]
    public WeaponTypeIconParam()
    {
    }
  }
}
