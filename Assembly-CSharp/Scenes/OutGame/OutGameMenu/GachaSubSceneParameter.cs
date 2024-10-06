// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GachaSubSceneParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039E7")]
  public class GachaSubSceneParameter : ChangeSceneParameter
  {
    [Token(Token = "0x17004AB9")]
    public int? firstViewGachaNumber
    {
      [Token(Token = "0x6016BCE"), Address(RVA = "0x3F6FF10", Offset = "0x3F6FF10", VA = "0x3F6FF10")] get
      {
        return new int?();
      }
    }

    [Token(Token = "0x6016BCF")]
    [Address(RVA = "0x3F6FF18", Offset = "0x3F6FF18", VA = "0x3F6FF18")]
    public GachaSubSceneParameter(int? firstViewGachaNumber)
    {
    }
  }
}
