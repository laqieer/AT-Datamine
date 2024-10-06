// Decompiled with JetBrains decompiler
// Type: StaqData.ReincarnationMemory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020FD")]
  public class ReincarnationMemory
  {
    [Token(Token = "0x4008BC7")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<int, ReincarnationMemory.MemoryParameter> memoryMap;

    [Token(Token = "0x17002B5B")]
    public UniqueID UniqueID
    {
      [Token(Token = "0x600C872"), Address(RVA = "0x1CE29B0", Offset = "0x1CE29B0", VA = "0x1CE29B0")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600C873"), Address(RVA = "0x1CE29B8", Offset = "0x1CE29B8", VA = "0x1CE29B8")] private set
      {
      }
    }

    [Token(Token = "0x600C874")]
    [Address(RVA = "0x1CE29C0", Offset = "0x1CE29C0", VA = "0x1CE29C0")]
    private void Reset()
    {
    }

    [Token(Token = "0x600C875")]
    [Address(RVA = "0x1CE2A14", Offset = "0x1CE2A14", VA = "0x1CE2A14")]
    public ReincarnationMemory.MemoryParameter GetMemory(UniqueID uniqueId, int index = 0)
    {
      return (ReincarnationMemory.MemoryParameter) null;
    }

    [Token(Token = "0x600C876")]
    [Address(RVA = "0x1CE2B08", Offset = "0x1CE2B08", VA = "0x1CE2B08")]
    public void Apply(
      PlayerUnitReincarnationMemoryType playerUnitReincarnationMemoryType)
    {
    }

    [Token(Token = "0x600C877")]
    [Address(RVA = "0x1CE2E14", Offset = "0x1CE2E14", VA = "0x1CE2E14")]
    public ReincarnationMemory()
    {
    }

    [Token(Token = "0x20020FE")]
    public class MemoryParameter
    {
      [Token(Token = "0x17002B5C")]
      public int Life
      {
        [Token(Token = "0x600C878"), Address(RVA = "0x1CE2E90", Offset = "0x1CE2E90", VA = "0x1CE2E90")] get
        {
          return new int();
        }
        [Token(Token = "0x600C879"), Address(RVA = "0x1CE2E98", Offset = "0x1CE2E98", VA = "0x1CE2E98")] private set
        {
        }
      }

      [Token(Token = "0x17002B5D")]
      public int Strength
      {
        [Token(Token = "0x600C87A"), Address(RVA = "0x1CE2EA0", Offset = "0x1CE2EA0", VA = "0x1CE2EA0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C87B"), Address(RVA = "0x1CE2EA8", Offset = "0x1CE2EA8", VA = "0x1CE2EA8")] private set
        {
        }
      }

      [Token(Token = "0x17002B5E")]
      public int Intelligence
      {
        [Token(Token = "0x600C87C"), Address(RVA = "0x1CE2EB0", Offset = "0x1CE2EB0", VA = "0x1CE2EB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C87D"), Address(RVA = "0x1CE2EB8", Offset = "0x1CE2EB8", VA = "0x1CE2EB8")] private set
        {
        }
      }

      [Token(Token = "0x17002B5F")]
      public int Vitality
      {
        [Token(Token = "0x600C87E"), Address(RVA = "0x1CE2EC0", Offset = "0x1CE2EC0", VA = "0x1CE2EC0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C87F"), Address(RVA = "0x1CE2EC8", Offset = "0x1CE2EC8", VA = "0x1CE2EC8")] private set
        {
        }
      }

      [Token(Token = "0x17002B60")]
      public int Mind
      {
        [Token(Token = "0x600C880"), Address(RVA = "0x1CE2ED0", Offset = "0x1CE2ED0", VA = "0x1CE2ED0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C881"), Address(RVA = "0x1CE2ED8", Offset = "0x1CE2ED8", VA = "0x1CE2ED8")] private set
        {
        }
      }

      [Token(Token = "0x17002B61")]
      public int Agility
      {
        [Token(Token = "0x600C882"), Address(RVA = "0x1CE2EE0", Offset = "0x1CE2EE0", VA = "0x1CE2EE0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C883"), Address(RVA = "0x1CE2EE8", Offset = "0x1CE2EE8", VA = "0x1CE2EE8")] private set
        {
        }
      }

      [Token(Token = "0x17002B62")]
      public int Dexterity
      {
        [Token(Token = "0x600C884"), Address(RVA = "0x1CE2EF0", Offset = "0x1CE2EF0", VA = "0x1CE2EF0")] get
        {
          return new int();
        }
        [Token(Token = "0x600C885"), Address(RVA = "0x1CE2EF8", Offset = "0x1CE2EF8", VA = "0x1CE2EF8")] private set
        {
        }
      }

      [Token(Token = "0x17002B63")]
      public int Lucky
      {
        [Token(Token = "0x600C886"), Address(RVA = "0x1CE2F00", Offset = "0x1CE2F00", VA = "0x1CE2F00")] get
        {
          return new int();
        }
        [Token(Token = "0x600C887"), Address(RVA = "0x1CE2F08", Offset = "0x1CE2F08", VA = "0x1CE2F08")] private set
        {
        }
      }

      [Token(Token = "0x17002B64")]
      public int Exp
      {
        [Token(Token = "0x600C888"), Address(RVA = "0x1CE2F10", Offset = "0x1CE2F10", VA = "0x1CE2F10")] get
        {
          return new int();
        }
        [Token(Token = "0x600C889"), Address(RVA = "0x1CE2F18", Offset = "0x1CE2F18", VA = "0x1CE2F18")] private set
        {
        }
      }

      [Token(Token = "0x600C88A")]
      [Address(RVA = "0x1CE2B00", Offset = "0x1CE2B00", VA = "0x1CE2B00")]
      public MemoryParameter()
      {
      }

      [Token(Token = "0x600C88B")]
      [Address(RVA = "0x1CE2D9C", Offset = "0x1CE2D9C", VA = "0x1CE2D9C")]
      public MemoryParameter(
        int life,
        int strength,
        int intelligence,
        int vitality,
        int mind,
        int agility,
        int dexterity,
        int lucky,
        int exp)
      {
      }

      [Token(Token = "0x600C88C")]
      [Address(RVA = "0x1CE2F20", Offset = "0x1CE2F20", VA = "0x1CE2F20")]
      public bool Equal(Style style) => new bool();

      [Token(Token = "0x600C88D")]
      [Address(RVA = "0x1CE2FCC", Offset = "0x1CE2FCC", VA = "0x1CE2FCC")]
      public int GetParam(BasicParameterType type) => new int();

      [Token(Token = "0x600C88E")]
      [Address(RVA = "0x1CE3038", Offset = "0x1CE3038", VA = "0x1CE3038")]
      public int Level(int initRarityStar) => new int();

      [Token(Token = "0x600C88F")]
      [Address(RVA = "0x1CE313C", Offset = "0x1CE313C", VA = "0x1CE313C")]
      public float[] AveragePIN(int level) => (float[]) null;
    }
  }
}
