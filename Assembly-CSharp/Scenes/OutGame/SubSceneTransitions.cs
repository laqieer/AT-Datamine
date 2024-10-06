// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SubSceneTransitions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003205")]
  public class SubSceneTransitions
  {
    [Token(Token = "0x1700411A")]
    public SubSceneTransitions.TransitionData Home
    {
      [Token(Token = "0x6013879"), Address(RVA = "0x49C03E8", Offset = "0x49C03E8", VA = "0x49C03E8")] get
      {
        return new SubSceneTransitions.TransitionData();
      }
    }

    [Token(Token = "0x1700411B")]
    public SubSceneTransitions.TransitionData UnitView
    {
      [Token(Token = "0x601387A"), Address(RVA = "0x49C03F4", Offset = "0x49C03F4", VA = "0x49C03F4")] get
      {
        return new SubSceneTransitions.TransitionData();
      }
    }

    [Token(Token = "0x1700411C")]
    public SubSceneTransitions.TransitionData EquipmentModify
    {
      [Token(Token = "0x601387B"), Address(RVA = "0x49C0400", Offset = "0x49C0400", VA = "0x49C0400")] get
      {
        return new SubSceneTransitions.TransitionData();
      }
    }

    [Token(Token = "0x1700411D")]
    public SubSceneTransitions.TransitionData UnitListPartyEdit
    {
      [Token(Token = "0x601387C"), Address(RVA = "0x49C040C", Offset = "0x49C040C", VA = "0x49C040C")] get
      {
        return new SubSceneTransitions.TransitionData();
      }
    }

    [Token(Token = "0x601387D")]
    [Address(RVA = "0x49C02E4", Offset = "0x49C02E4", VA = "0x49C02E4")]
    public SubSceneTransitions()
    {
    }

    [Token(Token = "0x2003206")]
    public struct TransitionData
    {
      [Token(Token = "0x1700411E")]
      public readonly string AssetBundleName
      {
        [Token(Token = "0x601387E"), Address(RVA = "0x49C0420", Offset = "0x49C0420", VA = "0x49C0420")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700411F")]
      public readonly string SceneName
      {
        [Token(Token = "0x601387F"), Address(RVA = "0x49C0428", Offset = "0x49C0428", VA = "0x49C0428")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6013880")]
      [Address(RVA = "0x49C0418", Offset = "0x49C0418", VA = "0x49C0418")]
      public TransitionData(string assetBundleName, string sceneName)
      {
      }
    }
  }
}
