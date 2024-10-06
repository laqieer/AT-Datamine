-- このluaスクリプトは、kubitest.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")

CharaPosT001 = {0, 0, 0 ,0.0}

CharaPosT010 = { 1, 0, 0.3, 0, 0}
CharaPosT011 = {-1, 0, 0.3, 0, 0}
CharaPosT012 = { 1, 0, -1, 0, 0}
CharaPosT013 = { 0, 0, -1, 0, 0}
CharaPosT014 = {-1, 0, -1, 0, 0}

CharaPosT020 = {-1, 0, -1, 0, 0}
CharaPosT021 = {-1, 0, -1, 0, 0}
CharaPosT022 = {-1, 0, -1, 0, 0}



function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosT001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosT010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosT011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPosT013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)

	Camera006 = SetTemplate("Actor006",nil,CharaPosT020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPosT021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPosT022,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)

	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101043","001","101043001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor008")





	template1()

	camera = set_camera(0, 1.5, 2, 0, 180, 0, 45)

	Sewing = set_object("content_prop_10108001", "10108001_PropModel", true)
	set_object_name(Sewing,"target")
end

function Play()
	StartPlay()
	DontChangeRandomCamera(true)

	on_camera(camera)

	test()

	TalkTest(Actor001,"","speech","L","終わりです")

	EndPlay()
end


function test()
	while true do
		open_select_window_direct(nil, "Normal", "ノワール・ランス", "魔女", "親密度", "終了")
		if is_select(1) then
			test1()
		elseif is_select(2) then
			test2()
		elseif is_select(3) then
--			test3()
			rankuptest()
		else
			break
		end
	end
end

function rankuptest()
	while true do
		open_select_window_direct(nil, "Normal", "魔女1", "魔女2", "魔女3", "ランス")
		if is_select(1) then
			test3(Actor006)
		elseif is_select(2) then
			test3(Actor007)
		elseif is_select(3) then
			test3(Actor008)
		else
			test3(Actor005)
			break
		end
	end

end

function test1()
	--★★ノワール★★:
	TalkTest(Actor005,"","speech","L","Lてすとです")

	TalkTest(Actor005,"","speech","R","Rてすとです")

	TalkTest(Actor001,"","speech","L","ノワール")

	TalkTest(Actor001,"","speech","R","終わりです")
end

function test2()
	TalkTest(Actor006,"","speech","L","てすとです")
	TalkTest(Actor006,"","speech","R","てすとです")

	TalkTest(Actor007,"","speech","L","てすとです")
	TalkTest(Actor007,"","speech","R","てすとです")

	TalkTest(Actor008,"","speech","L","てすとです")
	TalkTest(Actor008,"","speech","R","てすとです")

end

function test3(target)

	set_int("ランスロット_コミュランク", 3)	-- ダミー
	set_int("ランスロット_親密度", 22)	-- ダミー
	RankupComuTest(target, "ランスロット_コミュランク", "ランスロット_親密度")
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
    else
        -- ウインドウを開いたまま名前を変更する
        if lastTalkControllerId == controllerId and lastNameTag ~= talkerNameTag then 
            local onSimple = lastTalkFrameType == "simple"
            local validTalker = (talkerNameTag ~= nil)
            set_name_tag(talkerNameTag, onSimple, validTalker)     
	    end
	end

	lastTalkControllerId = controllerId
    lastNameTag = talkerNameTag

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

function RankupComuTest(TargetCharacter, ComuRankName, ComuPointName)

--	message_direct("ランクアップコミュイベントのテストを開始します")
	local trustParam = set_communication_rankup(ComuRankName, ComuPointName)
	trustParam.UpdateRankup()
	-- ランクアップ演出
	TalkTest(Actor001,"","speech","L","ランクアップ演出です")
	open_trust_rank_up(TargetCharacter, trustParam)

	-- 親密度ゲージ演出
	TalkTest(Actor001,"","speech","L","ランクアップゲージです")
	open_trust_gauge(TargetCharacter, trustParam)

--	message_direct("イベントのテストを終了します")
end
