// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleUnitSimplePanelConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002429")]
  [CreateAssetMenu(fileName = "BattleUnitSimplePanelConfig", menuName = "ScriptableObjects/BattleUnitSimplePanelConfig")]
  public sealed class BattleUnitSimplePanelConfig : ScriptableObject
  {
    [Token(Token = "0x4009AC3")]
    private const string elementSpriteAssetName = "element";
    [Token(Token = "0x4009AC4")]
    private const string weaponTypeSpriteAssetName = "weaponType";
    [Token(Token = "0x4009AC5")]
    private const string badStatusSpriteAssetName = "condition";
    [Token(Token = "0x4009AC6")]
    private const string battleEffectSpriteAssetName = "battleEffect";
    [Token(Token = "0x4009AC7")]
    [FieldOffset(Offset = "0x18")]
    private SpriteAtlas elementIconSpriteAtlas;
    [Token(Token = "0x4009AC8")]
    [FieldOffset(Offset = "0x20")]
    private SpriteAtlas weaponTypeIconSpriteAtlas;
    [Token(Token = "0x4009AC9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ElementIconSpriteSetter elementSetter;
    [Token(Token = "0x4009ACA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private WeaponTypeIconSpriteSetter weaponTypeSetter;
    [Token(Token = "0x4009ACB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private BadStatusIconSpriteSetter badStatusSetter;
    [Token(Token = "0x4009ACC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BattleEffectIconSpriteSetter battleEffectSetter;

    [Token(Token = "0x17002F95")]
    internal IReadOnlyList<ElementIconParam> ElementIconParams
    {
      [Token(Token = "0x600DD9C"), Address(RVA = "0x1E2A884", Offset = "0x1E2A884", VA = "0x1E2A884")] get
      {
        return (IReadOnlyList<ElementIconParam>) null;
      }
    }

    [Token(Token = "0x17002F96")]
    internal SpriteAtlas ElementIconSpriteAtlas
    {
      [Token(Token = "0x600DD9D"), Address(RVA = "0x1E2A8A4", Offset = "0x1E2A8A4", VA = "0x1E2A8A4")] get
      {
        return (SpriteAtlas) null;
      }
    }

    [Token(Token = "0x17002F97")]
    internal IReadOnlyList<WeaponTypeIconParam> WeaponTypeIconParams
    {
      [Token(Token = "0x600DD9E"), Address(RVA = "0x1E2A8AC", Offset = "0x1E2A8AC", VA = "0x1E2A8AC")] get
      {
        return (IReadOnlyList<WeaponTypeIconParam>) null;
      }
    }

    [Token(Token = "0x17002F98")]
    internal SpriteAtlas WeaponTypeIconSpriteAtlas
    {
      [Token(Token = "0x600DD9F"), Address(RVA = "0x1E2A8CC", Offset = "0x1E2A8CC", VA = "0x1E2A8CC")] get
      {
        return (SpriteAtlas) null;
      }
    }

    [Token(Token = "0x17002F99")]
    internal IReadOnlyList<BadStatusIconParam> BadStatusIconParams
    {
      [Token(Token = "0x600DDA0"), Address(RVA = "0x1E2A8D4", Offset = "0x1E2A8D4", VA = "0x1E2A8D4")] get
      {
        return (IReadOnlyList<BadStatusIconParam>) null;
      }
    }

    [Token(Token = "0x17002F9A")]
    internal IReadOnlyList<BattleEffectIconParam> BattleEffectIconParams
    {
      [Token(Token = "0x600DDA1"), Address(RVA = "0x1E2A8F4", Offset = "0x1E2A8F4", VA = "0x1E2A8F4")] get
      {
        return (IReadOnlyList<BattleEffectIconParam>) null;
      }
    }

    [Token(Token = "0x600DDA2")]
    [Address(RVA = "0x1E2A914", Offset = "0x1E2A914", VA = "0x1E2A914")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600DDA3")]
    [Address(RVA = "0x1E2B0A4", Offset = "0x1E2B0A4", VA = "0x1E2B0A4")]
    public BattleUnitSimplePanelConfig()
    {
    }
  }
}
