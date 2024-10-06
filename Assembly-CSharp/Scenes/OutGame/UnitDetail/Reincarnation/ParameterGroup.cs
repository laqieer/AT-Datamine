// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Reincarnation.ParameterGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnitDetail.Customize;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Reincarnation
{
  [Token(Token = "0x20032DE")]
  public class ParameterGroup : MonoBehaviour
  {
    [Token(Token = "0x400DB71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ParameterCell[] parameterCells;
    [Token(Token = "0x400DB72")]
    [FieldOffset(Offset = "0x20")]
    private Action<int> onChangeToggle;
    [Token(Token = "0x400DB73")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<ParameterTypeEnum, BasicParameterType> parameterMap;

    [Token(Token = "0x1700430A")]
    public int CellCount
    {
      [Token(Token = "0x6013FB6"), Address(RVA = "0x2346C40", Offset = "0x2346C40", VA = "0x2346C40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700430B")]
    public bool IsAllOff
    {
      [Token(Token = "0x6013FB7"), Address(RVA = "0x2346414", Offset = "0x2346414", VA = "0x2346414")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6013FB8")]
    [Address(RVA = "0x23469AC", Offset = "0x23469AC", VA = "0x23469AC")]
    public void SetData(
      ParameterGroup.Parameter parameter,
      Style style,
      Action<int> onChangeToggle = null)
    {
    }

    [Token(Token = "0x6013FB9")]
    [Address(RVA = "0x2347288", Offset = "0x2347288", VA = "0x2347288")]
    public void SetSelectedParameterType(ParameterTypeEnum? parameterType)
    {
    }

    [Token(Token = "0x6013FBA")]
    [Address(RVA = "0x2346C5C", Offset = "0x2346C5C", VA = "0x2346C5C")]
    public void SetBeforePinAverage(float[] pinAverages)
    {
    }

    [Token(Token = "0x6013FBB")]
    [Address(RVA = "0x23477C0", Offset = "0x23477C0", VA = "0x23477C0")]
    public void OnClickToChangeToggle(int index)
    {
    }

    [Token(Token = "0x6013FBC")]
    [Address(RVA = "0x234789C", Offset = "0x234789C", VA = "0x234789C")]
    public ParameterGroup()
    {
    }

    [Token(Token = "0x20032DF")]
    public class Parameter
    {
      [Token(Token = "0x1700430C")]
      public int Life
      {
        [Token(Token = "0x6013FBD"), Address(RVA = "0x2347918", Offset = "0x2347918", VA = "0x2347918")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FBE"), Address(RVA = "0x2347920", Offset = "0x2347920", VA = "0x2347920")] private set
        {
        }
      }

      [Token(Token = "0x1700430D")]
      public int Strength
      {
        [Token(Token = "0x6013FBF"), Address(RVA = "0x2347928", Offset = "0x2347928", VA = "0x2347928")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FC0"), Address(RVA = "0x2347930", Offset = "0x2347930", VA = "0x2347930")] private set
        {
        }
      }

      [Token(Token = "0x1700430E")]
      public int Intelligence
      {
        [Token(Token = "0x6013FC1"), Address(RVA = "0x2347938", Offset = "0x2347938", VA = "0x2347938")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FC2"), Address(RVA = "0x2347940", Offset = "0x2347940", VA = "0x2347940")] private set
        {
        }
      }

      [Token(Token = "0x1700430F")]
      public int Vitality
      {
        [Token(Token = "0x6013FC3"), Address(RVA = "0x2347948", Offset = "0x2347948", VA = "0x2347948")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FC4"), Address(RVA = "0x2347950", Offset = "0x2347950", VA = "0x2347950")] private set
        {
        }
      }

      [Token(Token = "0x17004310")]
      public int Mind
      {
        [Token(Token = "0x6013FC5"), Address(RVA = "0x2347958", Offset = "0x2347958", VA = "0x2347958")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FC6"), Address(RVA = "0x2347960", Offset = "0x2347960", VA = "0x2347960")] private set
        {
        }
      }

      [Token(Token = "0x17004311")]
      public int Agility
      {
        [Token(Token = "0x6013FC7"), Address(RVA = "0x2347968", Offset = "0x2347968", VA = "0x2347968")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FC8"), Address(RVA = "0x2347970", Offset = "0x2347970", VA = "0x2347970")] private set
        {
        }
      }

      [Token(Token = "0x17004312")]
      public int Dexterity
      {
        [Token(Token = "0x6013FC9"), Address(RVA = "0x2347978", Offset = "0x2347978", VA = "0x2347978")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FCA"), Address(RVA = "0x2347980", Offset = "0x2347980", VA = "0x2347980")] private set
        {
        }
      }

      [Token(Token = "0x17004313")]
      public int Lucky
      {
        [Token(Token = "0x6013FCB"), Address(RVA = "0x2347988", Offset = "0x2347988", VA = "0x2347988")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FCC"), Address(RVA = "0x2347990", Offset = "0x2347990", VA = "0x2347990")] private set
        {
        }
      }

      [Token(Token = "0x17004314")]
      public int Exp
      {
        [Token(Token = "0x6013FCD"), Address(RVA = "0x2347998", Offset = "0x2347998", VA = "0x2347998")] get
        {
          return new int();
        }
        [Token(Token = "0x6013FCE"), Address(RVA = "0x23479A0", Offset = "0x23479A0", VA = "0x23479A0")] private set
        {
        }
      }

      [Token(Token = "0x6013FCF")]
      [Address(RVA = "0x23468C8", Offset = "0x23468C8", VA = "0x23468C8")]
      public void SetNowParam(Style style)
      {
      }

      [Token(Token = "0x6013FD0")]
      [Address(RVA = "0x23471BC", Offset = "0x23471BC", VA = "0x23471BC")]
      public void SetReincarnationParam(Style style)
      {
      }

      [Token(Token = "0x6013FD1")]
      [Address(RVA = "0x2347A0C", Offset = "0x2347A0C", VA = "0x2347A0C")]
      public void SetMemoryParam(
        ReincarnationMemory.MemoryParameter memoryParameter,
        Style style)
      {
      }

      [Token(Token = "0x6013FD2")]
      [Address(RVA = "0x2347754", Offset = "0x2347754", VA = "0x2347754")]
      public int GetParam(BasicParameterType type) => new int();

      [Token(Token = "0x6013FD3")]
      [Address(RVA = "0x23479A8", Offset = "0x23479A8", VA = "0x23479A8")]
      private void SetParam(BasicParameterType type, int param)
      {
      }

      [Token(Token = "0x6013FD4")]
      [Address(RVA = "0x23468C0", Offset = "0x23468C0", VA = "0x23468C0")]
      public Parameter()
      {
      }
    }
  }
}
