// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted.ConversionCompletedModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted
{
  [Token(Token = "0x2003C09")]
  public class ConversionCompletedModel
  {
    [Token(Token = "0x4010A02")]
    [FieldOffset(Offset = "0x10")]
    private readonly ConversionContext _context;

    [Token(Token = "0x601799A")]
    [Address(RVA = "0x237ECFC", Offset = "0x237ECFC", VA = "0x237ECFC")]
    public ConversionCompletedModel(ConversionContext context)
    {
    }

    [Token(Token = "0x17004CAC")]
    public MedalData MedalData
    {
      [Token(Token = "0x601799B"), Address(RVA = "0x237ED28", Offset = "0x237ED28", VA = "0x237ED28")] get
      {
        return (MedalData) null;
      }
    }

    [Token(Token = "0x17004CAD")]
    public int GetMedalNum
    {
      [Token(Token = "0x601799C"), Address(RVA = "0x237EDC4", Offset = "0x237EDC4", VA = "0x237EDC4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004CAE")]
    public int BeforeMedal
    {
      [Token(Token = "0x601799D"), Address(RVA = "0x237EDCC", Offset = "0x237EDCC", VA = "0x237EDCC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004CAF")]
    public int AfterMedalNum
    {
      [Token(Token = "0x601799E"), Address(RVA = "0x237EDD4", Offset = "0x237EDD4", VA = "0x237EDD4")] get
      {
        return new int();
      }
    }
  }
}
