// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovablePartialRouteParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x2002842")]
  [Serializable]
  public class MovablePartialRouteParameter
  {
    [Token(Token = "0x400ABA5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string routeName;
    [Token(Token = "0x400ABA6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private float moveSpeed;
    [Token(Token = "0x400ABA7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private float popMobFrequencyTime;
    [Token(Token = "0x400ABA8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private float popMobRandomRangeMin;
    [Token(Token = "0x400ABA9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private float popMobRandomRangeMax;
    [Token(Token = "0x400ABAA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int maxPopMobCount;
    [Token(Token = "0x400ABAB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private MovablePartialRouteParameter.MobOffsetParameter mobOffset;

    [Token(Token = "0x170037C8")]
    public List<MovableMobInstanceDataBase> PopMobTable
    {
      [Token(Token = "0x600FD78"), Address(RVA = "0x442F518", Offset = "0x442F518", VA = "0x442F518")] get
      {
        return (List<MovableMobInstanceDataBase>) null;
      }
      [Token(Token = "0x600FD79"), Address(RVA = "0x442F520", Offset = "0x442F520", VA = "0x442F520")] private set
      {
      }
    }

    [Token(Token = "0x170037C9")]
    public int SpawnMobGroupID
    {
      [Token(Token = "0x600FD7A"), Address(RVA = "0x442F528", Offset = "0x442F528", VA = "0x442F528")] get
      {
        return new int();
      }
      [Token(Token = "0x600FD7B"), Address(RVA = "0x442F530", Offset = "0x442F530", VA = "0x442F530")] private set
      {
      }
    }

    [Token(Token = "0x170037CA")]
    public int SoundMobGroupID
    {
      [Token(Token = "0x600FD7C"), Address(RVA = "0x442F538", Offset = "0x442F538", VA = "0x442F538")] get
      {
        return new int();
      }
      [Token(Token = "0x600FD7D"), Address(RVA = "0x442F540", Offset = "0x442F540", VA = "0x442F540")] private set
      {
      }
    }

    [Token(Token = "0x170037CB")]
    public string RouteName
    {
      [Token(Token = "0x600FD7E"), Address(RVA = "0x442F548", Offset = "0x442F548", VA = "0x442F548")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170037CC")]
    public float MoveSpeed
    {
      [Token(Token = "0x600FD7F"), Address(RVA = "0x442F550", Offset = "0x442F550", VA = "0x442F550")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170037CD")]
    public float PopMobFrequencyTime
    {
      [Token(Token = "0x600FD80"), Address(RVA = "0x442F558", Offset = "0x442F558", VA = "0x442F558")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170037CE")]
    public float PopMobRandomRangeMin
    {
      [Token(Token = "0x600FD81"), Address(RVA = "0x442F560", Offset = "0x442F560", VA = "0x442F560")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170037CF")]
    public float PopMobRandomRangeMax
    {
      [Token(Token = "0x600FD82"), Address(RVA = "0x442F568", Offset = "0x442F568", VA = "0x442F568")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170037D0")]
    public int MaxPopMobCount
    {
      [Token(Token = "0x600FD83"), Address(RVA = "0x442F570", Offset = "0x442F570", VA = "0x442F570")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170037D1")]
    public MovablePartialRouteParameter.MobOffsetParameter MobOffset
    {
      [Token(Token = "0x600FD84"), Address(RVA = "0x442F578", Offset = "0x442F578", VA = "0x442F578")] get
      {
        return (MovablePartialRouteParameter.MobOffsetParameter) null;
      }
    }

    [Token(Token = "0x600FD85")]
    [Address(RVA = "0x442F580", Offset = "0x442F580", VA = "0x442F580")]
    public MovablePartialRouteParameter(string routeName, int spawnMobID, int soundMobID)
    {
    }

    [Token(Token = "0x600FD86")]
    [Address(RVA = "0x442906C", Offset = "0x442906C", VA = "0x442906C")]
    public void SetParameter(
      float moveSpeed,
      float popMobTime,
      float popMinTime,
      float popMaxTime,
      int maxPopCount)
    {
    }

    [Token(Token = "0x600FD87")]
    [Address(RVA = "0x442F5D0", Offset = "0x442F5D0", VA = "0x442F5D0")]
    public void SetMoveSpeed(float moveSpeed)
    {
    }

    [Token(Token = "0x600FD88")]
    [Address(RVA = "0x442907C", Offset = "0x442907C", VA = "0x442907C")]
    public void SetPopTimes(float popMobTime, float popMinTime, float popMaxTime)
    {
    }

    [Token(Token = "0x600FD89")]
    [Address(RVA = "0x442F5D8", Offset = "0x442F5D8", VA = "0x442F5D8")]
    public void SetMaxPopCount(int maxPopCount)
    {
    }

    [Token(Token = "0x600FD8A")]
    [Address(RVA = "0x442F5E0", Offset = "0x442F5E0", VA = "0x442F5E0")]
    public void SetMobOffset(
      MovablePartialRouteParameter.MobOffsetParameter mobOffset)
    {
    }

    [Token(Token = "0x600FD8B")]
    [Address(RVA = "0x442F5E8", Offset = "0x442F5E8", VA = "0x442F5E8")]
    public void SetPopMobTable(List<MovableMobInstanceDataBase> list)
    {
    }

    [Token(Token = "0x2002843")]
    [Serializable]
    public class FloatMinMaxProperty
    {
      [Token(Token = "0x400ABAC")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private float min;
      [Token(Token = "0x400ABAD")]
      [FieldOffset(Offset = "0x14")]
      [SerializeField]
      private float max;

      [Token(Token = "0x170037D2")]
      public float Min
      {
        [Token(Token = "0x600FD8C"), Address(RVA = "0x442F5F0", Offset = "0x442F5F0", VA = "0x442F5F0")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x170037D3")]
      public float Max
      {
        [Token(Token = "0x600FD8D"), Address(RVA = "0x442F5F8", Offset = "0x442F5F8", VA = "0x442F5F8")] get
        {
          return new float();
        }
      }

      [Token(Token = "0x600FD8E")]
      [Address(RVA = "0x442F600", Offset = "0x442F600", VA = "0x442F600")]
      public FloatMinMaxProperty(float min, float max)
      {
      }

      [Token(Token = "0x600FD8F")]
      [Address(RVA = "0x442D920", Offset = "0x442D920", VA = "0x442D920")]
      public float RandomRange() => new float();
    }

    [Token(Token = "0x2002844")]
    [Serializable]
    public class MobOffsetParameter
    {
      [Token(Token = "0x400ABAE")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private MovablePartialRouteParameter.FloatMinMaxProperty singleMobXPosition;
      [Token(Token = "0x400ABAF")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private MovablePartialRouteParameter.FloatMinMaxProperty pairMobXDistance;
      [Token(Token = "0x400ABB0")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private MovablePartialRouteParameter.FloatMinMaxProperty pairMobZDistance;

      [Token(Token = "0x170037D4")]
      public MovablePartialRouteParameter.FloatMinMaxProperty SingleMobXPosition
      {
        [Token(Token = "0x600FD90"), Address(RVA = "0x442F638", Offset = "0x442F638", VA = "0x442F638")] get
        {
          return (MovablePartialRouteParameter.FloatMinMaxProperty) null;
        }
      }

      [Token(Token = "0x170037D5")]
      public MovablePartialRouteParameter.FloatMinMaxProperty PairMobXDistance
      {
        [Token(Token = "0x600FD91"), Address(RVA = "0x442F640", Offset = "0x442F640", VA = "0x442F640")] get
        {
          return (MovablePartialRouteParameter.FloatMinMaxProperty) null;
        }
      }

      [Token(Token = "0x170037D6")]
      public MovablePartialRouteParameter.FloatMinMaxProperty PairMobZDistance
      {
        [Token(Token = "0x600FD92"), Address(RVA = "0x442F648", Offset = "0x442F648", VA = "0x442F648")] get
        {
          return (MovablePartialRouteParameter.FloatMinMaxProperty) null;
        }
      }

      [Token(Token = "0x600FD93")]
      [Address(RVA = "0x442F650", Offset = "0x442F650", VA = "0x442F650")]
      public MobOffsetParameter(
        MovablePartialRouteParameter.FloatMinMaxProperty singleMobXPosition,
        MovablePartialRouteParameter.FloatMinMaxProperty pairMobXDistance,
        MovablePartialRouteParameter.FloatMinMaxProperty pairMobZDistance)
      {
      }
    }
  }
}
