-- このluaスクリプトは、MA_01A110_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor004,{-3.733,0,1.2})
set_rot(Actor004,{0,90,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101090013)
	Actor001 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モーロノエー", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モーロノエー★★:なんの真似事か知らないけれど
	Talk(Actor001,"CHRNAME_SISTERS_1","speech","L","MA_01A110_070002")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "怒り")
-- ▲直接出力

	--★★グリートーネア★★:ネアはなにもしていませんけど
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070003")

-- ▼直接出力
 --PlayPartVoice("グリーテン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★グリーテン★★:マゾエーたちが順調に事を運んでるから<br>オマエも抜け駆けしようってわけ？
	Talk(Actor003,"CHRNAME_SISTERS_3","speech","L","MA_01A110_070004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定3")
-- ▲直接出力

	--★★グリートーネア★★:お姉様たちは<br>ここで喰っちゃ寝していればいいです
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリーテン", "落胆")
-- ▲直接出力

	--★★グリーテン★★:ワタシたちは群体<br>オマエの意志は思い込みよ
	Talk(Actor003,"CHRNAME_SISTERS_3","speech","L","MA_01A110_070007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モーロノエー", "怒り")
-- ▲直接出力

	--★★モーロノエー★★:大姉様の悲願を忘れないで<br>グリートーネア
	Talk(Actor001,"CHRNAME_SISTERS_1","speech","L","MA_01A110_070008")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
Hide(Actor003)
Camera002 = setup_small_camera_resetting(Actor002,CharaPos004,CameraPos004)

 --PlayActionDirect(Actor004,"to  Std_Sad01")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)


 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "落胆")
-- ▲直接出力

	--★★グリートーネア★★:…どうせ尽くすならネアはもっと<br>尽くしがいのある御方に尽くしたいもの
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070010")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★グリートーネア★★:フフフ…だからネアはちゃあんと<br>ローマの戦力を増やしてあげました
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070011")

	PlayAction(Actor002,"to  Std_Joy")

	--★★グリートーネア★★:ルーシャス様は<br>ネアがいないとダメみたいですから
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070012")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera090)
Appear(Actor004)
set_enable_auto_lookat(Actor002, true)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-0.533,0,1.2},2.0)
wait_time(2.0)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ローラ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ローラ★★:…時間がない<br>このままじゃ、あの人は
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01A110_070014")


	--★★ローラ★★:いったい、どうしたら…
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01A110_070016")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★グリートーネア★★:「あの人」──…って、だあれ？
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070017")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to  Std_Joy")
change_face(Actor004,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
turn_chara(Actor004, 126.566, 0)
-- ▲直接出力

	--★★グリートーネア★★:まさかルーシャス様のことじゃないですよねえ？<br>その焦りよう…フレンでもなさそうな──
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070019")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ローラ", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ローラ★★:………あなたには関係ありません
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01A110_070020")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★グリートーネア★★:「お姉ちゃ～ん♪」に甘えたら？
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ローラ", "激怒")
-- ▲直接出力

	--★★ローラ★★:…あなたみたいな人から<br>お姉ちゃんを守りたくてここまで来たんです
	Talk(Actor004,"CHRNAME_LOLA","speech","L","MA_01A110_070022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★グリートーネア★★:でしたらネアみたいな人から<br>アドバイスを聞くのが肝要ですよ？
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070023")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★グリートーネア★★:名案があるのです
	Talk(Actor002,"CHRNAME_SISTERS_4","speech","L","MA_01A110_070024")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101090013)
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
