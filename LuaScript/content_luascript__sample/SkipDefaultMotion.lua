-- このluaスクリプトは、MA_01105_03.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("101011001",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("101009001",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack")
	template1()
-- ▼直接出力
hotdog = setup_prop_object(10102001)
-- ▲直接出力
-- ▼直接出力
hotdog_offset = {0,0,0.02,-20,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(hotdog,Actor001, "Loc_weapon_constrint_R", hotdog_offset)
-- ▲直接出力
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to EatIdle")
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:食べづら…！<br>かぶりつくのコレ…！？
	TalkTest(Actor001,"CHRNAME_GUINEVERE","speech","L","普通だとモーションが戻ってしまう")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:意外だな。ログレスはもっと<br>上品な食べ物が並んでるのかと思った
	TalkTest(Actor002,"CHRNAME_NOIR","speech","L","戻るな")

	change_face(Actor001,"Normal")



	SkipDefaultMotion(Actor001)

	PlayAction(Actor001,"to EatIdle")

	--★★ギネヴィア★★:ウチの王様のシュミなのよ<br>この手のジャンクな食べ物は
	TalkTest(Actor001,"CHRNAME_GUINEVERE","speech","L","だがスキップしたら別だ")


	--★★ノワール★★:食べたことないのか？
	TalkTest(Actor002,"CHRNAME_NOIR","speech","L","まじか")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:彼に歩み寄る気はさらさらないワケ<br>わたしが喜んで食べると思う？
	TalkTest(Actor001,"CHRNAME_GUINEVERE","speech","L","まじだ")

	change_face(Actor001,"Surprise")


	--★★ギネヴィア★★:ハァ、食べづら…！雑多な盛りつけして…！<br>ソースが溢れて服につくじゃない！
	TalkTest(Actor001,"CHRNAME_GUINEVERE","speech","L","そして次のモーションで動く")

	PlayAction(Actor001,"to Run")

	TalkTest(Actor001,"CHRNAME_GUINEVERE","speech","L","デフォルトにもどったらOK")


	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
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
function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack")
setup_prop_object_preload(10102001)
hotdog_offset = {0,0,0.02,-20,0,0}
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
