// Decompiled with JetBrains decompiler
// Type: StaqData.FacilityWorkMediation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020BA")]
  public class FacilityWorkMediation
  {
    [Token(Token = "0x4008B06")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, FacilityWorkMediation.Work> works;
    [Token(Token = "0x4008B07")]
    [FieldOffset(Offset = "0x18")]
    private List<FacilityWorkMediation.StoryAbilityEffect> effects;

    [Token(Token = "0x17002A6F")]
    public IEnumerable<FacilityWorkMediation.Work> Works
    {
      [Token(Token = "0x600C630"), Address(RVA = "0x1CD59DC", Offset = "0x1CD59DC", VA = "0x1CD59DC")] get
      {
        return (IEnumerable<FacilityWorkMediation.Work>) null;
      }
    }

    [Token(Token = "0x17002A70")]
    public IEnumerable<FacilityWorkMediation.Work> ActiveWorks
    {
      [Token(Token = "0x600C631"), Address(RVA = "0x1CD5A2C", Offset = "0x1CD5A2C", VA = "0x1CD5A2C")] get
      {
        return (IEnumerable<FacilityWorkMediation.Work>) null;
      }
    }

    [Token(Token = "0x600C632")]
    [Address(RVA = "0x1CD43B4", Offset = "0x1CD43B4", VA = "0x1CD43B4")]
    public void Initialize(int facilityID)
    {
    }

    [Token(Token = "0x600C633")]
    [Address(RVA = "0x1CD5B88", Offset = "0x1CD5B88", VA = "0x1CD5B88")]
    public FacilityWorkMediation.Work GetWork(int workID) => (FacilityWorkMediation.Work) null;

    [Token(Token = "0x600C634")]
    [Address(RVA = "0x1CD5C00", Offset = "0x1CD5C00", VA = "0x1CD5C00")]
    public bool CanSelect() => new bool();

    [Token(Token = "0x600C635")]
    [Address(RVA = "0x1CD5C24", Offset = "0x1CD5C24", VA = "0x1CD5C24")]
    private FacilityWorkMediation.StoryAbilityEffect GetCurrent()
    {
      return (FacilityWorkMediation.StoryAbilityEffect) null;
    }

    [Token(Token = "0x600C636")]
    [Address(RVA = "0x1CD42F4", Offset = "0x1CD42F4", VA = "0x1CD42F4")]
    public FacilityWorkMediation()
    {
    }

    [Token(Token = "0x20020BB")]
    public class Work
    {
      [Token(Token = "0x4008B08")]
      [FieldOffset(Offset = "0x10")]
      private StoryFacilityWorkData masterData;

      [Token(Token = "0x600C637")]
      [Address(RVA = "0x1CD5B38", Offset = "0x1CD5B38", VA = "0x1CD5B38")]
      public Work(StoryFacilityWorkData masterData)
      {
      }

      [Token(Token = "0x17002A71")]
      public int ID
      {
        [Token(Token = "0x600C638"), Address(RVA = "0x1CD5E14", Offset = "0x1CD5E14", VA = "0x1CD5E14")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A72")]
      public string Name
      {
        [Token(Token = "0x600C639"), Address(RVA = "0x1CD5E30", Offset = "0x1CD5E30", VA = "0x1CD5E30")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600C63A")]
      [Address(RVA = "0x1CD5E4C", Offset = "0x1CD5E4C", VA = "0x1CD5E4C")]
      public bool IsContainsGotStoryAbility() => new bool();
    }

    [Token(Token = "0x20020BC")]
    private class StoryAbilityEffect
    {
      [Token(Token = "0x4008B09")]
      [FieldOffset(Offset = "0x10")]
      private StoryFacilityWorkAbilityEffectData masterData;

      [Token(Token = "0x600C63B")]
      [Address(RVA = "0x1CD5B60", Offset = "0x1CD5B60", VA = "0x1CD5B60")]
      public StoryAbilityEffect(StoryFacilityWorkAbilityEffectData masterData)
      {
      }

      [Token(Token = "0x600C63C")]
      [Address(RVA = "0x1CD5EEC", Offset = "0x1CD5EEC", VA = "0x1CD5EEC")]
      public bool IsContainsGotStoryAbility() => new bool();

      [Token(Token = "0x600C63D")]
      [Address(RVA = "0x1CD5DF8", Offset = "0x1CD5DF8", VA = "0x1CD5DF8")]
      public bool CanSelect() => new bool();

      [Token(Token = "0x17002A73")]
      public int Priority
      {
        [Token(Token = "0x600C63E"), Address(RVA = "0x1CD5F68", Offset = "0x1CD5F68", VA = "0x1CD5F68")] get
        {
          return new int();
        }
      }
    }
  }
}
