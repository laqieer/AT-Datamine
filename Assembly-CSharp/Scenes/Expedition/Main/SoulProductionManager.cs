// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Main.SoulProductionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Expedition.Main
{
  [Token(Token = "0x2002CEE")]
  public class SoulProductionManager : SingletonMonoBehaviour<SoulProductionManager>
  {
    [Token(Token = "0x400C026")]
    [FieldOffset(Offset = "0x40")]
    private Action productionTimeUpdataAction;

    [Token(Token = "0x17003C5C")]
    public int ProductionTime
    {
      [Token(Token = "0x601194A"), Address(RVA = "0x46A1A5C", Offset = "0x46A1A5C", VA = "0x46A1A5C")] get
      {
        return new int();
      }
      [Token(Token = "0x601194B"), Address(RVA = "0x46A1A64", Offset = "0x46A1A64", VA = "0x46A1A64")] private set
      {
      }
    }

    [Token(Token = "0x17003C5D")]
    public float blueProductionValue
    {
      [Token(Token = "0x601194C"), Address(RVA = "0x46A1A6C", Offset = "0x46A1A6C", VA = "0x46A1A6C")] get
      {
        return new float();
      }
      [Token(Token = "0x601194D"), Address(RVA = "0x46A1A74", Offset = "0x46A1A74", VA = "0x46A1A74")] private set
      {
      }
    }

    [Token(Token = "0x17003C5E")]
    public float blueStorage
    {
      [Token(Token = "0x601194E"), Address(RVA = "0x46A1A7C", Offset = "0x46A1A7C", VA = "0x46A1A7C")] get
      {
        return new float();
      }
      [Token(Token = "0x601194F"), Address(RVA = "0x46A1A84", Offset = "0x46A1A84", VA = "0x46A1A84")] private set
      {
      }
    }

    [Token(Token = "0x17003C5F")]
    public int blueStorageMax
    {
      [Token(Token = "0x6011950"), Address(RVA = "0x46A1A8C", Offset = "0x46A1A8C", VA = "0x46A1A8C")] get
      {
        return new int();
      }
      [Token(Token = "0x6011951"), Address(RVA = "0x46A1A94", Offset = "0x46A1A94", VA = "0x46A1A94")] private set
      {
      }
    }

    [Token(Token = "0x17003C60")]
    public float redProductionValue
    {
      [Token(Token = "0x6011952"), Address(RVA = "0x46A1A9C", Offset = "0x46A1A9C", VA = "0x46A1A9C")] get
      {
        return new float();
      }
      [Token(Token = "0x6011953"), Address(RVA = "0x46A1AA4", Offset = "0x46A1AA4", VA = "0x46A1AA4")] private set
      {
      }
    }

    [Token(Token = "0x17003C61")]
    public float redStorage
    {
      [Token(Token = "0x6011954"), Address(RVA = "0x46A1AAC", Offset = "0x46A1AAC", VA = "0x46A1AAC")] get
      {
        return new float();
      }
      [Token(Token = "0x6011955"), Address(RVA = "0x46A1AB4", Offset = "0x46A1AB4", VA = "0x46A1AB4")] private set
      {
      }
    }

    [Token(Token = "0x17003C62")]
    public int redStorageMax
    {
      [Token(Token = "0x6011956"), Address(RVA = "0x46A1ABC", Offset = "0x46A1ABC", VA = "0x46A1ABC")] get
      {
        return new int();
      }
      [Token(Token = "0x6011957"), Address(RVA = "0x46A1AC4", Offset = "0x46A1AC4", VA = "0x46A1AC4")] private set
      {
      }
    }

    [Token(Token = "0x17003C63")]
    public float productionTimer
    {
      [Token(Token = "0x6011958"), Address(RVA = "0x46A1ACC", Offset = "0x46A1ACC", VA = "0x46A1ACC")] get
      {
        return new float();
      }
      [Token(Token = "0x6011959"), Address(RVA = "0x46A1AD4", Offset = "0x46A1AD4", VA = "0x46A1AD4")] private set
      {
      }
    }

    [Token(Token = "0x17003C64")]
    protected override bool IsDontDestroy
    {
      [Token(Token = "0x601195A"), Address(RVA = "0x46A1ADC", Offset = "0x46A1ADC", VA = "0x46A1ADC", Slot = "4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601195B")]
    [Address(RVA = "0x46A1AE4", Offset = "0x46A1AE4", VA = "0x46A1AE4", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x601195C")]
    [Address(RVA = "0x46A1AFC", Offset = "0x46A1AFC", VA = "0x46A1AFC")]
    public void SetProductionTimeUpdataAction(Action productionTimeUpdataAction)
    {
    }

    [Token(Token = "0x601195D")]
    [Address(RVA = "0x46A1B04", Offset = "0x46A1B04", VA = "0x46A1B04")]
    public void SetData(
      List<PlayerExpeditionStageType> stages,
      List<PlayerExpeditionSoulSpotType> soulSpots)
    {
    }

    [Token(Token = "0x601195E")]
    [Address(RVA = "0x46A217C", Offset = "0x46A217C", VA = "0x46A217C")]
    private void Update()
    {
    }

    [Token(Token = "0x601195F")]
    [Address(RVA = "0x46A2214", Offset = "0x46A2214", VA = "0x46A2214")]
    public SoulProductionManager()
    {
    }
  }
}
