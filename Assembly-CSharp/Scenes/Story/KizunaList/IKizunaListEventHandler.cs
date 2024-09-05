// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.IKizunaListEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E8B")]
  public interface IKizunaListEventHandler
  {
    [Token(Token = "0x60122D6")]
    void OnClose();

    [Token(Token = "0x60122D7")]
    void FastTravel(KizunaQuestInfo.KizunaQuestCharacterInfo info);
  }
}
