
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")

function InitializeTables()
	actorTable = {}
	charaCameraTable = {}
end

function AddActorTable(label,actor)
	actorTable[label] = actor
end

function Load()
	InitializeTables()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit02_Loop")
	PlayActionDirect(Actor001,"to Sit02_Loop")
	Actor002 = InitializeCharacter("101010","001","101010001",CharaPos017,"101010001","Chr_001_01_StdController","to Std_Loop")

	Actor003 = InitializeCharacter("101018","001","101018001",CharaPos016,"101018001","Com_f_SitController","to Sit02_Loop")
	PlayActionDirect(Actor003,"to Sit02_Loop")

	Actor004 = InitializeCharacter("101011","001","101011001",CharaPos001,"101011001","Com_f_SitController","to Sit02_Loop")
	PlayActionDirect(Actor004,"to Sit02_Loop")

	Actor005 = InitializeCharacter("101013","001","101013001",CharaPos015,"101013001","Chr_003_01_SitController","to Sit02_Loop")
	PlayActionDirect(Actor005,"to Sit02_Loop")

	Actor006 = InitializeCharacter("101001","001","101001001",CharaPos006,"101001001","Com_f_SitController","to Sit02_Loop")
	PlayActionDirect(Actor006,"to Sit02_Loop")

	Camera001 = InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor001)
	Camera002 = InitializeCharaCamera(CameraAssetBundleName,CameraPos017,Actor002)
	Camera003 = InitializeCharaCamera(CameraAssetBundleName,CameraPos016,Actor003)
	Camera004 = InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor004)
	Camera005 = InitializeCharaCamera(CameraAssetBundleName,CameraPos015,Actor005)
	Camera006 = InitializeCharaCamera(CameraAssetBundleName,CameraPos006,Actor006)
	InitializeTemplateRandomCamera()
	InitializeTemplate()
end


template1 = {
	{"101009002",nil,CharaPos005,"Com_m_SitController","to Sit02_Loop",CameraAssetBundleName,CameraPos005},
	{"101010001",nil,CharaPos017,"Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName,CameraPos017},
	{"101018001",nil,CharaPos016,"Com_f_SitController","to Sit02_Loop",CameraAssetBundleName,CameraPos016},
	{"101011001",nil,CharaPos001,"Com_f_SitController","to Sit02_Loop",CameraAssetBundleName,CameraPos001},


	--Chr_002_01_StdController

}


function SetTemplate(templateData)
	local label = template[1]

	local actor = table.find(actorTable, label)

	-- なかったらしらん

	-- 向き設定
	if template[2] ~= nil then
		set_rot(actor, {0,template[2],0})
	end

	-- 位置設定
	set_pos(actor,template[3])

	-- こんとローラー設定
--	set_animationcontroller(actor,template[4],template[5])

	-- カメラ設定
end





function templateTest(template)

	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","ここまできた1")

--	Actor001.CheckControllerName("Chr_002_01_StdController")

	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","ちぇっくした")


	set_animationcontroller(Actor001, "Chr_002_01_StdController","to Std_Loop")

	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","ここまできた2")


	PlayAction(Actor001,"to  Std_Talk")


	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","デージョブかよ")

end


function Play()
	StartPlay()

	--★★ランスロット★★:ＧＳを済ませると<br>武器であるキラーズには銘が与えられる
	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","ランダムカメラを止めるテスト")

	DontChangeRandomCamera(true)

--	templateTest(template1)

	--★★ランスロット★★:銘はマスター側の因子の記憶に<br>刻まれているとされているもので
	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","7秒たっても切り替わらなければOK")


	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","戻す")

	DontChangeRandomCamera(false)

	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","7秒たって切り替わればOK")


	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","ランダムカメラに固定する")

	DontChangeRandomCamera(true)

	on_camera(RndCamera003)

	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","7秒たっても切り替わらなければOK")

	DontChangeRandomCamera(false)

	TalkTest(Actor002,"CHRNAME_LANCELOT","speech","L","戻そう")

	
	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","コントローラーを差し替える")

	set_animationcontroller(Actor001, "Chr_002_01_StdController","to Std_Loop")

	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","立ち上がればOK")


	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","動くかテスト")

	PlayAction(Actor001,"to  Std_Talk")

	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","動いたらOK")


	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","ランスOFF")

	off_active(Actor002)

	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","教壇に移動")

	SetPositionAndCamera(Actor001, CharaPos017, Camera002)

	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","移動したらOK")


	TalkTest(Actor001,"CHRNAME_LANCELOT","speech","L","終わりです")


	EndPlay()
end


function TalkTest(controllerId, talkerNameTag, frameType, dir, textId)
	-- 必要があれば前回開いたウインドウを閉じる
	if CheckIfNeedClose(controllerId, frameType, dir) == true then
		CloseTalkWindow()
	end

	if manager ~= nil then
		-- カメラワークのための通知
		manager.CloseupUpExclusiveCamera(controllerId)
	end

	-- 必要があればウインドウを開く
	if CheckIfNeedOpen(controllerId, frameType, dir) == true then
		OpenTalkWindow(talkerNameTag, controllerId, frameType, dir)
	end

	lastTalkControllerId = controllerId

    PlayReservedPlayAction()

    PlayBranchPoint(textId)
    
	-- テスト用
	message_direct(textId)
	-- 本番用
    --message(textId)

	EndBranchPoint()

	-- しゃべった人のモーションを戻す
	animator_default_motion_if_need(lastTalkControllerId)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_Preload("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101010","001","101010001",CharaPos017,"101010001","Chr_001_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101018","001","101018001",CharaPos016,"101018001","Com_f_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101011","001","101011001",CharaPos001,"101011001","Com_f_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101013","001","101013001",CharaPos015,"101013001","Chr_003_01_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101001","001","101001001",CharaPos006,"101001001","Com_f_SitController","to Sit02_Loop")
	system.PreLoadRequest(CameraAssetBundleName)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
