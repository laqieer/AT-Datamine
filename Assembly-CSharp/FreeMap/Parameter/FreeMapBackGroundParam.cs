// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.FreeMapBackGroundParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Parameter
{
  [Token(Token = "0x2001861")]
  public struct FreeMapBackGroundParam
  {
    [Token(Token = "0x4006A3E")]
    [FieldOffset(Offset = "0x0")]
    private int backGroundID;
    [Token(Token = "0x4006A3F")]
    [FieldOffset(Offset = "0x4")]
    private int placementID;
    [Token(Token = "0x4006A40")]
    private const string BackGroundSceneNameFormat = "Area{0}";
    [Token(Token = "0x4006A41")]
    private const string PlacementSceneNameFormat = "Place{0}{1}";

    [Token(Token = "0x60089E8")]
    [Address(RVA = "0x451EE4C", Offset = "0x451EE4C", VA = "0x451EE4C")]
    public FreeMapBackGroundParam(StoryFreeActionBackgroundData backGround)
    {
    }

    [Token(Token = "0x60089E9")]
    [Address(RVA = "0x451E9B4", Offset = "0x451E9B4", VA = "0x451E9B4")]
    public FreeMapBackGroundParam(int backGroundID, int placementID)
    {
    }

    [Token(Token = "0x170015D7")]
    public string BackGroundIDString
    {
      [Token(Token = "0x60089EA"), Address(RVA = "0x451E0E4", Offset = "0x451E0E4", VA = "0x451E0E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D8")]
    public string BackGroundSceneName
    {
      [Token(Token = "0x60089EB"), Address(RVA = "0x451E184", Offset = "0x451E184", VA = "0x451E184")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015D9")]
    public string BackGroundAssetBundleLabel
    {
      [Token(Token = "0x60089EC"), Address(RVA = "0x451E1FC", Offset = "0x451E1FC", VA = "0x451E1FC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015DA")]
    public string PlacementIDString
    {
      [Token(Token = "0x60089ED"), Address(RVA = "0x451EE70", Offset = "0x451EE70", VA = "0x451EE70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015DB")]
    public string PlacementObjectName
    {
      [Token(Token = "0x60089EE"), Address(RVA = "0x451E22C", Offset = "0x451E22C", VA = "0x451E22C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170015DC")]
    public string PlacementAssetBundleLabel
    {
      [Token(Token = "0x60089EF"), Address(RVA = "0x451E2B4", Offset = "0x451E2B4", VA = "0x451E2B4")] get
      {
        return (string) null;
      }
    }
  }
}
