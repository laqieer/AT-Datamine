// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapFlavorUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI;
using FreeMap.UI.ButtonEvent;
using FreeMap.UI.Control.Clip;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x200186C")]
  public class FreeMapFlavorUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x170015FF")]
    public override bool IsShowMap
    {
      [Token(Token = "0x6008A60"), Address(RVA = "0x4521764", Offset = "0x4521764", VA = "0x4521764", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001600")]
    public override ActionIconTypeEnum ActionIconType
    {
      [Token(Token = "0x6008A61"), Address(RVA = "0x452176C", Offset = "0x452176C", VA = "0x452176C", Slot = "6")] get
      {
        return new ActionIconTypeEnum();
      }
    }

    [Token(Token = "0x17001601")]
    public IReadOnlyList<StoryFreeActionFlavorObjectTextData> AdvList
    {
      [Token(Token = "0x6008A62"), Address(RVA = "0x4521AF0", Offset = "0x4521AF0", VA = "0x4521AF0")] get
      {
        return (IReadOnlyList<StoryFreeActionFlavorObjectTextData>) null;
      }
    }

    [Token(Token = "0x17001602")]
    public PlayAdvPatternEnum PlayPattern
    {
      [Token(Token = "0x6008A63"), Address(RVA = "0x4521AF8", Offset = "0x4521AF8", VA = "0x4521AF8")] private set
      {
      }
      [Token(Token = "0x6008A64"), Address(RVA = "0x4521B00", Offset = "0x4521B00", VA = "0x4521B00")] get
      {
        return new PlayAdvPatternEnum();
      }
    }

    [Token(Token = "0x6008A65")]
    [Address(RVA = "0x4521B08", Offset = "0x4521B08", VA = "0x4521B08")]
    public FreeMapFlavorUIParam(
      int objectID,
      Vector3 iconOffset,
      int tableID,
      PlayAdvPatternEnum playPattern,
      int cameraMoveID,
      int playerMoveID)
    {
    }

    [Token(Token = "0x6008A66")]
    [Address(RVA = "0x4521C28", Offset = "0x4521C28", VA = "0x4521C28", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008A67")]
    [Address(RVA = "0x4521C30", Offset = "0x4521C30", VA = "0x4521C30", Slot = "12")]
    public override IFreeMapUIClip CreateClipClass(FreeMapUITransformHolder uiTransformHolder)
    {
      return (IFreeMapUIClip) null;
    }

    [Token(Token = "0x6008A68")]
    [Address(RVA = "0x4521788", Offset = "0x4521788", VA = "0x4521788")]
    public bool CheckAlreadyRead() => new bool();

    [Token(Token = "0x6008A69")]
    [Address(RVA = "0x4521CC8", Offset = "0x4521CC8", VA = "0x4521CC8", Slot = "13")]
    public override IFreeMapIconButtonEvent CreateEvent(FreeMapCommonElement commonElement)
    {
      return (IFreeMapIconButtonEvent) null;
    }
  }
}
