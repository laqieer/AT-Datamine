// Decompiled with JetBrains decompiler
// Type: Battle.Data.IDotWeaponAssetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x20026FE")]
  public interface IDotWeaponAssetData
  {
    [Token(Token = "0x17003335")]
    GameObject SubWeaponModel { [Token(Token = "0x600F194")] get; }

    [Token(Token = "0x17003336")]
    GameObject MainWeaponModel { [Token(Token = "0x600F195")] get; }

    [Token(Token = "0x17003337")]
    AnimationClip AttackMotionLeft { [Token(Token = "0x600F196")] get; }

    [Token(Token = "0x17003338")]
    AnimationClip AttackMotionRight { [Token(Token = "0x600F197")] get; }

    [Token(Token = "0x17003339")]
    AnimationClip AttackMotionUp { [Token(Token = "0x600F198")] get; }

    [Token(Token = "0x1700333A")]
    AnimationClip AttackMotionDown { [Token(Token = "0x600F199")] get; }

    [Token(Token = "0x1700333B")]
    AnimationClip IdleMotionLeft { [Token(Token = "0x600F19A")] get; }

    [Token(Token = "0x1700333C")]
    AnimationClip IdleMotionRight { [Token(Token = "0x600F19B")] get; }

    [Token(Token = "0x1700333D")]
    AnimationClip MagicMotionLeft { [Token(Token = "0x600F19C")] get; }

    [Token(Token = "0x1700333E")]
    AnimationClip MagicMotionRight { [Token(Token = "0x600F19D")] get; }

    [Token(Token = "0x1700333F")]
    AnimationClip MagicMotionUp { [Token(Token = "0x600F19E")] get; }

    [Token(Token = "0x17003340")]
    AnimationClip MagicMotionDown { [Token(Token = "0x600F19F")] get; }
  }
}
