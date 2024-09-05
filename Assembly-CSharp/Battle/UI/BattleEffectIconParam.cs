// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleEffectIconParam
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
  [Token(Token = "0x200242C")]
  [Serializable]
  internal class BattleEffectIconParam
  {
    [Token(Token = "0x4009AD1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private BattleEffectTypeEnum battleEffect;
    [Token(Token = "0x4009AD2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string iconName;

    [Token(Token = "0x17002F9F")]
    public BattleEffectTypeEnum BattleEffect
    {
      [Token(Token = "0x600DDAC"), Address(RVA = "0x1E2B16C", Offset = "0x1E2B16C", VA = "0x1E2B16C")] get
      {
        return new BattleEffectTypeEnum();
      }
    }

    [Token(Token = "0x17002FA0")]
    public string IconName
    {
      [Token(Token = "0x600DDAD"), Address(RVA = "0x1E2B174", Offset = "0x1E2B174", VA = "0x1E2B174")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002FA1")]
    public Sprite Icon
    {
      [Token(Token = "0x600DDAE"), Address(RVA = "0x1E2B17C", Offset = "0x1E2B17C", VA = "0x1E2B17C")] get
      {
        return (Sprite) null;
      }
      [Token(Token = "0x600DDAF"), Address(RVA = "0x1E2B184", Offset = "0x1E2B184", VA = "0x1E2B184")] set
      {
      }
    }

    [Token(Token = "0x600DDB0")]
    [Address(RVA = "0x1E2B18C", Offset = "0x1E2B18C", VA = "0x1E2B18C")]
    public BattleEffectIconParam()
    {
    }
  }
}
