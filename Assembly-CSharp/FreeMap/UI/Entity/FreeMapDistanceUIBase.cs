// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Entity.FreeMapDistanceUIBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Entity
{
  [Token(Token = "0x2001694")]
  public abstract class FreeMapDistanceUIBase : FreeMapUIBase
  {
    [Token(Token = "0x400655C")]
    [FieldOffset(Offset = "0x48")]
    protected float thresholdDistance;
    [Token(Token = "0x400655D")]
    [FieldOffset(Offset = "0x4C")]
    protected FreeMapDistanceUIBase.PlayerDistanceState currentPlayerDistanceState;
    [Token(Token = "0x400655E")]
    [FieldOffset(Offset = "0x50")]
    private FreeMapDistanceUIBase.TransStatus preTransStatus;
    [Token(Token = "0x400655F")]
    [FieldOffset(Offset = "0x54")]
    private FreeMapDistanceUIBase.TransStatus nowTransStatus;
    [Token(Token = "0x4006560")]
    [FieldOffset(Offset = "0x58")]
    private float transCTTimer;
    [Token(Token = "0x4006561")]
    [FieldOffset(Offset = "0x5C")]
    protected float toTransAlpha;

    [Token(Token = "0x6007F6F")]
    [Address(RVA = "0x21B6AB0", Offset = "0x21B6AB0", VA = "0x21B6AB0", Slot = "16")]
    protected virtual void UpdatePlayerDistanceState(FreeMapPlayerInstance player)
    {
    }

    [Token(Token = "0x6007F70")]
    [Address(RVA = "0x21B5188", Offset = "0x21B5188", VA = "0x21B5188")]
    protected void UpdateClip(
      Camera usingCamera,
      FreeMapPlayerInstance player,
      bool enableClipLogic)
    {
    }

    [Token(Token = "0x6007F71")]
    [Address(RVA = "0x21B4CC0", Offset = "0x21B4CC0", VA = "0x21B4CC0")]
    protected void UpdateTransparent(
      FreeMapPlayerInstance player,
      ActionIconTypeEnum type,
      bool alwaysOpacity)
    {
    }

    [Token(Token = "0x6007F72")]
    protected abstract void ChangeDefaultDisplayUI();

    [Token(Token = "0x6007F73")]
    protected abstract void ChangeNearDisplayUI();

    [Token(Token = "0x6007F74")]
    protected abstract void ChangeTransparentAlphaUI(float toAlpha);

    [Token(Token = "0x6007F75")]
    [Address(RVA = "0x21B654C", Offset = "0x21B654C", VA = "0x21B654C")]
    protected FreeMapDistanceUIBase()
    {
    }

    [Token(Token = "0x2001695")]
    public enum PlayerDistanceState
    {
      [Token(Token = "0x4006563")] Default,
      [Token(Token = "0x4006564")] Near,
    }

    [Token(Token = "0x2001696")]
    private enum TransStatus
    {
      [Token(Token = "0x4006566")] Def,
      [Token(Token = "0x4006567")] Near,
      [Token(Token = "0x4006568")] Far,
      [Token(Token = "0x4006569")] Hide,
      [Token(Token = "0x400656A")] None,
    }
  }
}
