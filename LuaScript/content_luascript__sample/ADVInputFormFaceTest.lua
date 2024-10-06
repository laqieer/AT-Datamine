-- このluaスクリプトは、adv_event_small_base.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter("101009","001","101009001",CharaPos001,"101009001","Chr_002_01_StdController")
	Actor002 = InitializeCharacter("101011","001","101011001",CharaPos002,"101011001","Chr_502_01_StdController")
	Actor003 = InitializeCharacter("101010","001","101010001",CharaPos003,"101010001","Chr_001_01_SitController")
	PlayAction(Actor003,"to Sit02_Loop")
	Actor004 = InitializeCharacter("401006","001","401006001",CharaPos004,"","Chr_501_01_StdController")
	Actor005 = InitializeCharacter("101015","001","101015001",CharaPos005,"101015001","Chr_005_01_StdController")
	Actor006 = InitializeCharacter("101012","001","101012001",CharaPos006,"101012001","Chr_501_01_StdController")
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor001)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos002,Actor002)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos003,Actor003)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos004,Actor004)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor005)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos006,Actor006)
	RndCamera001 = InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos001)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos002)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos003)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos004)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos005)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos006)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos007)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos008)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos009)
	InitializeRandomCamera(CameraAssetBundleName, RandomCameraPos010)
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:意外だな
	TalkDirect(Actor001,"CHRNAME_NOIR","speech","R","MA_01104_420002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
wait_time(1.20)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのお転婆王妃殿下なら/ごねそうなもんなのに
	TalkDirect(Actor001,"CHRNAME_NOIR","speech","R","MA_01104_420003")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ノワール★★:「お祭りなんていいから/早くキャメリアード取り戻しましょ」とかさ
	TalkDirect(Actor001,"CHRNAME_NOIR","mind","R","MA_01104_420005")

	PlayAction(Actor005,"to  Std_Talk")

	--★★アーサー★★:あの国のなか、どうなっちまってんだろうな/取り戻そうにも…制圧されてずいぶんなんだろ？
	TalkDirect(Actor005,"NPCNAME_0003","speech","R","MA_01104_420006")

	PlayAction(Actor005,"to  Std_Talk")

	--★★アーサー★★:どうなってんのか誰もわかんねえから/誰も言わねえようにしてんのかな
	TalkDirect(Actor005,"NPCNAME_0003","speech","R","MA_01104_420007")

	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:マルディサント
	TalkDirect(Actor002,"CHRNAME_GUINEVERE","speech","R","MA_01104_420008")


	--★★ギネヴィア★★:まー五月祭自体？軍備を整える猶予でやる/戦意高揚のイベントみてえなもんなんだろうが
	TalkDirect(Actor002,"CHRNAME_GUINEVERE","mind","R","MA_01104_420009")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:マルディサント
	TalkDirect(Actor002,"CHRNAME_GUINEVERE","speech","R","MA_01104_420010")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Sad")

	--★★アーサー★★:一国まるごと取り戻さなきゃなんねえ/負けりゃ学園ごとバルバロイにパクりだ
	TalkDirect(Actor005,"NPCNAME_0003","narration","R","MA_01104_420011")

	EndPlay()
end

function TalkDirect(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end
	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
	end
	-- カメラワークのための通知
	manager.CloseupUpExclusiveCamera(controllerId)
	lastTalkControllerId = controllerId

	-- テスト用
	message_direct(textId)
	-- 本番用
    -- message(textId)

	-- しゃべった人のモーションを戻す
	PlayAction(lastTalkControllerId, "to Std_Loop")
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_Preload("101009","001","101009001",CharaPos001,"101009001","Chr_002_01_StdController")
	InitializeCharacter_Preload("101011","001","101011001",CharaPos002,"101011001","Chr_502_01_StdController")
	InitializeCharacter_Preload("101010","001","101010001",CharaPos003,"101010001","Chr_001_01_SitController")
	InitializeCharacter_Preload("401006","001","401006001",CharaPos004,"","Chr_501_01_StdController")
	InitializeCharacter_Preload("101015","001","101015001",CharaPos005,"101015001","Chr_005_01_StdController")
	InitializeCharacter_Preload("101012","001","101012001",CharaPos006,"101012001","Chr_501_01_StdController")
end
