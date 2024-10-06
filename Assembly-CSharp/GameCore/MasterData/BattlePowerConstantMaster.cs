// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattlePowerConstantMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E22")]
  [Serializable]
  public sealed class BattlePowerConstantMaster : BaseMaster<BattlePowerConstantData>
  {
    [Token(Token = "0x6005619")]
    [Address(RVA = "0x3E31BD8", Offset = "0x3E31BD8", VA = "0x3E31BD8")]
    public IReadOnlyDictionary<int, BattlePowerConstantData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattlePowerConstantData>) null;
    }

    [Token(Token = "0x600561A")]
    [Address(RVA = "0x3E31BE0", Offset = "0x3E31BE0", VA = "0x3E31BE0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600561B")]
    [Address(RVA = "0x3E31C40", Offset = "0x3E31C40", VA = "0x3E31C40", Slot = "5")]
    protected override BattlePowerConstantData LoadEntity(IMasterDataReader reader)
    {
      return (BattlePowerConstantData) null;
    }

    [Token(Token = "0x600561C")]
    [Address(RVA = "0x3E31C98", Offset = "0x3E31C98", VA = "0x3E31C98")]
    public BattlePowerConstantData GetOne() => (BattlePowerConstantData) null;

    [Token(Token = "0x17000C59")]
    public float CoefficientA
    {
      [Token(Token = "0x600561D"), Address(RVA = "0x3E31CF4", Offset = "0x3E31CF4", VA = "0x3E31CF4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C5A")]
    public float CoefficientB
    {
      [Token(Token = "0x600561E"), Address(RVA = "0x3E31D14", Offset = "0x3E31D14", VA = "0x3E31D14")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C5B")]
    public float CoefficientC
    {
      [Token(Token = "0x600561F"), Address(RVA = "0x3E31D34", Offset = "0x3E31D34", VA = "0x3E31D34")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C5C")]
    public float CoefficientD
    {
      [Token(Token = "0x6005620"), Address(RVA = "0x3E31D54", Offset = "0x3E31D54", VA = "0x3E31D54")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C5D")]
    public float CoefficientE
    {
      [Token(Token = "0x6005621"), Address(RVA = "0x3E31D70", Offset = "0x3E31D70", VA = "0x3E31D70")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C5E")]
    public float CoefficientF
    {
      [Token(Token = "0x6005622"), Address(RVA = "0x3E31D90", Offset = "0x3E31D90", VA = "0x3E31D90")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C5F")]
    public float[] CoefficientAtoF
    {
      [Token(Token = "0x6005623"), Address(RVA = "0x3E31DAC", Offset = "0x3E31DAC", VA = "0x3E31DAC")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x17000C60")]
    public int HpLevel1
    {
      [Token(Token = "0x6005624"), Address(RVA = "0x3E31E8C", Offset = "0x3E31E8C", VA = "0x3E31E8C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C61")]
    public int HpLevel2
    {
      [Token(Token = "0x6005625"), Address(RVA = "0x3E31EA8", Offset = "0x3E31EA8", VA = "0x3E31EA8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C62")]
    public float HpRate1
    {
      [Token(Token = "0x6005626"), Address(RVA = "0x3E31EC4", Offset = "0x3E31EC4", VA = "0x3E31EC4")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17000C63")]
    public float HpRate2
    {
      [Token(Token = "0x6005627"), Address(RVA = "0x3E31EE0", Offset = "0x3E31EE0", VA = "0x3E31EE0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6005628")]
    [Address(RVA = "0x3E31EFC", Offset = "0x3E31EFC", VA = "0x3E31EFC")]
    public BattlePowerConstantMaster()
    {
    }
  }
}
