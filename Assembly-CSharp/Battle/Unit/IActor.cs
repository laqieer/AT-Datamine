// Decompiled with JetBrains decompiler
// Type: Battle.Unit.IActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E8")]
  public interface IActor
  {
    [Token(Token = "0x600D55F")]
    void Show();

    [Token(Token = "0x600D560")]
    void Hide();

    [Token(Token = "0x600D561")]
    void PlayIdle(bool reset = true);

    [Token(Token = "0x600D562")]
    void PlaySquat(bool reset = true);

    [Token(Token = "0x600D563")]
    void PlayMove(bool reset = true);

    [Token(Token = "0x600D564")]
    void PlayAttack(bool reset = true);

    [Token(Token = "0x600D565")]
    void PlayMagic(bool reset = true);

    [Token(Token = "0x600D566")]
    void PlayKnockback(bool reset = true);

    [Token(Token = "0x600D567")]
    void PlayBuff(bool reset = true);

    [Token(Token = "0x600D568")]
    void PlayDown(bool reset = true);

    [Token(Token = "0x600D569")]
    void PlayWin(bool reset = true);

    [Token(Token = "0x600D56A")]
    void TurnTo(Actor.Direction direction, bool reset = true);

    [Token(Token = "0x600D56B")]
    void PlayWithDirection(Actor.AnimationType animation, Actor.Direction direction, bool reset = true);

    [Token(Token = "0x600D56C")]
    void PlayDefaultAnimation();

    [Token(Token = "0x600D56D")]
    void ForceModifiedAnimation();

    [Token(Token = "0x600D56E")]
    void UpdateUnitAlpha(float alpha);

    [Token(Token = "0x600D56F")]
    void ResetBadStatusShaderProperty();

    [Token(Token = "0x600D570")]
    void UpdateUnitColor(Color color);

    [Token(Token = "0x600D571")]
    void UpdateUnitMonochrome(float enable);

    [Token(Token = "0x600D572")]
    void UpdateUnitHardlightBlend(float blend);

    [Token(Token = "0x600D573")]
    void UpdateUnitHardlightColor(Color color);

    [Token(Token = "0x600D574")]
    void ForceUpdateUnitMaterial();

    [Token(Token = "0x17002E27")]
    Actor.AnimationType CurrentAnimation { [Token(Token = "0x600D575")] get; }

    [Token(Token = "0x17002E28")]
    Actor.Direction CurrentDirection { [Token(Token = "0x600D576")] get; }

    [Token(Token = "0x17002E29")]
    Actor.Direction DefaultDirection { [Token(Token = "0x600D577")] get; }

    [Token(Token = "0x17002E2A")]
    bool IsPlayingAnimation { [Token(Token = "0x600D578")] get; }

    [Token(Token = "0x600D579")]
    void ChangeMotions(IDotWeaponAssetData weaponAssetData);

    [Token(Token = "0x17002E2B")]
    Transform transform { [Token(Token = "0x600D57A")] get; }

    [Token(Token = "0x17002E2C")]
    Transform LocatorEffectHead { [Token(Token = "0x600D57B")] get; }

    [Token(Token = "0x17002E2D")]
    Transform LocatorEffectBody { [Token(Token = "0x600D57C")] get; }

    [Token(Token = "0x17002E2E")]
    Transform LocatorEffectBottom { [Token(Token = "0x600D57D")] get; }

    [Token(Token = "0x17002E2F")]
    Transform LocatorEffectWeapon { [Token(Token = "0x600D57E")] get; }
  }
}
