﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardNodeIconData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001351")]
  [Serializable]
  public sealed class AbilityBoardNodeIconData : IMasterDataEntity
  {
    [Token(Token = "0x4005AD9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005ADA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int resource;

    [Token(Token = "0x1700106B")]
    public int Key
    {
      [Token(Token = "0x6006CDE"), Address(RVA = "0x46F7840", Offset = "0x46F7840", VA = "0x46F7840", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CDF")]
    [Address(RVA = "0x46F7848", Offset = "0x46F7848", VA = "0x46F7848", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CE0")]
    [Address(RVA = "0x46F7954", Offset = "0x46F7954", VA = "0x46F7954", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CE1")]
    [Address(RVA = "0x46F79D8", Offset = "0x46F79D8", VA = "0x46F79D8")]
    public AbilityBoardNodeIconData()
    {
    }
  }
}
