// Decompiled with JetBrains decompiler
// Type: Battle.Unit.ActorBadStatusViewData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022DD")]
  public class ActorBadStatusViewData : ActorViewDataBase
  {
    [Token(Token = "0x4009363")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<string, string> Duel2FieldUnitLocatorMap;
    [Token(Token = "0x4009364")]
    [FieldOffset(Offset = "0x10")]
    private string initiationEffectPrefabName;
    [Token(Token = "0x4009365")]
    [FieldOffset(Offset = "0x18")]
    private string initiationEffectLocatorObjectName;
    [Token(Token = "0x4009366")]
    [FieldOffset(Offset = "0x20")]
    private string loopEffectPrefabName;
    [Token(Token = "0x4009367")]
    [FieldOffset(Offset = "0x28")]
    private string loopEffectLocatorObjectName;
    [Token(Token = "0x4009368")]
    [FieldOffset(Offset = "0x30")]
    private float monochrome;
    [Token(Token = "0x4009369")]
    [FieldOffset(Offset = "0x34")]
    private float hardlightBlend;
    [Token(Token = "0x400936A")]
    [FieldOffset(Offset = "0x38")]
    private Color hardlightBlendColor;

    [Token(Token = "0x17002DFC")]
    public string InitiationEffectPrefabName
    {
      [Token(Token = "0x600D4B9"), Address(RVA = "0x19E85C8", Offset = "0x19E85C8", VA = "0x19E85C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002DFD")]
    public string InitiationEffectLocatorObjectName
    {
      [Token(Token = "0x600D4BA"), Address(RVA = "0x19E85D0", Offset = "0x19E85D0", VA = "0x19E85D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002DFE")]
    public string LoopEffectPrefabName
    {
      [Token(Token = "0x600D4BB"), Address(RVA = "0x19E85D8", Offset = "0x19E85D8", VA = "0x19E85D8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002DFF")]
    public string LoopEffectLocatorObjectName
    {
      [Token(Token = "0x600D4BC"), Address(RVA = "0x19E85E0", Offset = "0x19E85E0", VA = "0x19E85E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002E00")]
    public float Monochrome
    {
      [Token(Token = "0x600D4BD"), Address(RVA = "0x19E85E8", Offset = "0x19E85E8", VA = "0x19E85E8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002E01")]
    public float HardlightBlend
    {
      [Token(Token = "0x600D4BE"), Address(RVA = "0x19E85F0", Offset = "0x19E85F0", VA = "0x19E85F0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002E02")]
    public Color HardlightBlendColor
    {
      [Token(Token = "0x600D4BF"), Address(RVA = "0x19E85F8", Offset = "0x19E85F8", VA = "0x19E85F8")] get
      {
        return new Color();
      }
    }

    [Token(Token = "0x600D4C0")]
    [Address(RVA = "0x19E8604", Offset = "0x19E8604", VA = "0x19E8604")]
    public ActorBadStatusViewData(DuelAbnormalStateEffectData duelSetting)
    {
    }

    [Token(Token = "0x600D4C1")]
    [Address(RVA = "0x19E8858", Offset = "0x19E8858", VA = "0x19E8858")]
    private static string ConvertDuel2FieldUnitLocatorName(string duelLocatorName) => (string) null;

    [Token(Token = "0x600D4C2")]
    [Address(RVA = "0x19E88F8", Offset = "0x19E88F8", VA = "0x19E88F8")]
    static ActorBadStatusViewData()
    {
    }
  }
}
