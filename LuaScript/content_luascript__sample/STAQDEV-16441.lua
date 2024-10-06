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




function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosT001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()

	camera = set_camera(0, 1.5, 2, 0, 180, 0, 45)

	Sewing = set_object("content_prop_10108001", "10108001_PropModel", true)
	set_object_name(Sewing,"target")

	Ef_warp = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
end

function Play()
	StartPlay()
	DontChangeRandomCamera(true)

	on_camera(camera)



	--★★ノワール★★:
	TalkTest(Actor001,"","speech","L","てすとです")

	on_active(Ef_warp) --初回のみでOK。同演出を1つのデモ内で2回以上使う場合、2回目以降はこの行は不要です。


	set_pos(Ef_warp, {0,1.5,0.2})

	play_particle(Ef_warp)
			
	wait_time(0.5)

	stop_particle(Ef_warp)


	TalkTest(Actor001,"","speech","L","再利用です")

	play_particle(Ef_warp)
			
	wait_time(0.5)

	stop_particle(Ef_warp)


	TalkTest(Actor001,"","speech","L","終わりです")

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
