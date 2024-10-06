// Decompiled with JetBrains decompiler
// Type: Scenes.Story.KizunaList.KizunaListChangeSceneParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Scene;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.KizunaList
{
  [Token(Token = "0x2002E8D")]
  public class KizunaListChangeSceneParam : ChangeSceneParameter
  {
    [Token(Token = "0x400C795")]
    [FieldOffset(Offset = "0x14")]
    public KizunaListBackDestination BackType;
    [Token(Token = "0x400C796")]
    [FieldOffset(Offset = "0x18")]
    public IKizunaListBackHandler KizunaListBackHandler;
    [Token(Token = "0x400C797")]
    [FieldOffset(Offset = "0x20")]
    public IKizunaListEventHandler KizunaListEventHandler;
    [Token(Token = "0x400C798")]
    [FieldOffset(Offset = "0x28")]
    public int CurrentSequenceId;

    [Token(Token = "0x60122D8")]
    [Address(RVA = "0x459179C", Offset = "0x459179C", VA = "0x459179C")]
    public KizunaListChangeSceneParam()
    {
    }
  }
}
