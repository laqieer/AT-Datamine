// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterClipActionFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x200191B")]
  public static class FreeMapCharacterClipActionFactory
  {
    [Token(Token = "0x6008EBA")]
    [Address(RVA = "0x4B03B6C", Offset = "0x4B03B6C", VA = "0x4B03B6C")]
    public static IFreeMapClipActionHandler PlayClipAction(
      FreeMapCharacter character,
      CharacterClipActionType type)
    {
      return (IFreeMapClipActionHandler) null;
    }

    [Token(Token = "0x6008EBB")]
    [Address(RVA = "0x4B03C0C", Offset = "0x4B03C0C", VA = "0x4B03C0C")]
    public static void PlayClipAction(FreeMapCharacter character, FreeMapClipActionBase action)
    {
    }

    [Token(Token = "0x6008EBC")]
    [Address(RVA = "0x4B03C2C", Offset = "0x4B03C2C", VA = "0x4B03C2C")]
    public static IFreeMapClipActionHandler PlayNPCDefault(
      FreeMapCharacter character,
      string startActionName)
    {
      return (IFreeMapClipActionHandler) null;
    }

    [Token(Token = "0x6008EBD")]
    [Address(RVA = "0x4B03BA4", Offset = "0x4B03BA4", VA = "0x4B03BA4")]
    private static FreeMapClipActionBase CreateClipAction(CharacterClipActionType type)
    {
      return (FreeMapClipActionBase) null;
    }
  }
}
