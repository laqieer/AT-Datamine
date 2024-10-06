// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaQuestEventMissionUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003941")]
  public class AreaQuestEventMissionUtility
  {
    [Token(Token = "0x400FA42")]
    public const string SubSceneAssetBundleName = "ui_page_areaeventquest_prefab";
    [Token(Token = "0x400FA43")]
    public const string SubSceneAssetName = "CollaborationEventMissionSubScene";
    [Token(Token = "0x400FA44")]
    private const string ViewAssetBundleName = "content_areaquestevent_{0}_eventmission";
    [Token(Token = "0x400FA45")]
    private const string ViewAssetName = "EventMission_View";
    [Token(Token = "0x400FA46")]
    private const string AssetBundleMissionProgressLabel = "content_areaquestevent_{0}_eventmission_texture";
    [Token(Token = "0x400FA47")]
    private const string AssetBundleMissionProgressName = "Img_icon{0}";

    [Token(Token = "0x601681C")]
    [Address(RVA = "0x42E7A10", Offset = "0x42E7A10", VA = "0x42E7A10")]
    public static (string, string) GetSubSceneName() => ();

    [Token(Token = "0x601681D")]
    [Address(RVA = "0x42E9FB0", Offset = "0x42E9FB0", VA = "0x42E9FB0")]
    public static (string, string) GetViewName(int eventPageId) => ();

    [Token(Token = "0x601681E")]
    [Address(RVA = "0x42E7FF4", Offset = "0x42E7FF4", VA = "0x42E7FF4")]
    public static AreaQuestEventPageData GetEventPageData(int id) => (AreaQuestEventPageData) null;

    [Token(Token = "0x601681F")]
    [Address(RVA = "0x42EABD0", Offset = "0x42EABD0", VA = "0x42EABD0")]
    public static (string, string) GetEventProgressRankIconAsset(int eventPageId, int rank) => ();

    [Token(Token = "0x6016820")]
    [Address(RVA = "0x42E39B8", Offset = "0x42E39B8", VA = "0x42E39B8")]
    public static bool IsNowScheduleMission(int eventPageId) => new bool();

    [Token(Token = "0x6016821")]
    [Address(RVA = "0x42E3E70", Offset = "0x42E3E70", VA = "0x42E3E70")]
    public static bool IsNowScheduleStore(int eventPageId) => new bool();

    [Token(Token = "0x6016822")]
    [Address(RVA = "0x42EACD8", Offset = "0x42EACD8", VA = "0x42EACD8")]
    public AreaQuestEventMissionUtility()
    {
    }
  }
}
