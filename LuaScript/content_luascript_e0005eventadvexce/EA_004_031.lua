-- このluaスクリプトは、EA_004_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{0.2,0,-3.62})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-2.02, 0, -3.53,   12})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-2.64, 0, -2.67,   36})
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera004
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:なぁ、ちょっといいか<br>学園祭の出し物についてなんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310004")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.3)
wait_time(0.1)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.3)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("男子1","0037")
-- ▲直接出力

	--★★男子生徒A★★:悪い、ノワール。ちょっと忙しいんだ<br>授業の準備しないと
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_004_0310005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:授業の準備？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310006")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★男子生徒B★★:ほら、俺たち<br>エクセリアと同じチームになったろ？
	Talk(Actor003,"NPCNAME_0153","speech","N","EA_004_0310007")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2","落胆")
-- ▲直接出力

	--★★男子生徒B★★:俺たちの力量で彼女の作戦をこなすには<br>休み時間も特訓しなきゃ間に合わないんだよ
	Talk(Actor003,"NPCNAME_0153","speech","N","EA_004_0310008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そ、そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1","肯定2")
-- ▲直接出力

	--★★男子生徒A★★:俺たちも本当は学園祭の準備したいんだけど<br>実力不足って言われるのも嫌だしさ
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_004_0310010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★男子生徒A★★:…それに、ガウェインとラグネルが欠けた今<br>少しでも戦力にならないと
	Talk(Actor002,"NPCNAME_0151","speech","N","EA_004_0310011")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor003,"to Wlk")
wait_time(1.7)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
Hide(Actor002)
Hide(Actor003)
setup_small_camera_start(RndCamera005)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310013")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_active(Actor004)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004,CharaPos110011_01_008[1],CharaPos110011_01_008[2],CharaPos110011_01_008[3],0)
slidemove(Actor004,CharaPos110011_01_008[1],CharaPos110011_01_008[2],CharaPos110011_01_008[3] ,1.6)
wait_time(1.6)
turn_lookat(Actor004,Actor001,0.3)
wait_time(0.3)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット","挨拶")
-- ▲直接出力

	--★★ランスロット★★:ノワール、学園祭の出し物は決まったのか<br>まだ申請が出ていないようだが…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0310015")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたってタイミングがいいんだか<br>悪いんだかよくわからないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310016")


	--★★ランスロット★★:？<br>言っている意味がよくわからないが…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0310017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:流石に、いい加減焦ったほうがいい<br>他のクラスはもう準備を始めているぞ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0310018")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ランスロット★★:ただでさえ、このクラスは――
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0310019")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:人手が足りない、だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310020")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:…そうだ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0310021")

-- ▼直接出力
PlayPartVoice("ランスロット","落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:<dot>太陽が隠れた</dot>影響は大きい<br>お前にも負担をかけることになるが…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","EA_004_0310022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:わかってるって<br>俺に出来ることなら、なんだってするさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:まずはこの学園祭を通して<br>少しは空気をよくできればって思うけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310025")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor005)
on_active(Actor006)
PlayActionDirect(Actor005,"to Wlk")
PlayActionDirect(Actor006,"to Wlk")
turn_lookat_position(Actor005,CharaPos110011_01_006[1],CharaPos110011_01_006[2],CharaPos110011_01_006[3],0)
turn_lookat_position(Actor006,CharaPos110011_01_007[1],CharaPos110011_01_007[2],CharaPos110011_01_007[3],0)
slidemove(Actor005,CharaPos110011_01_006[1],CharaPos110011_01_006[2],CharaPos110011_01_006[3] ,3.0)
slidemove(Actor006,0.889,0,-2.628 ,3.0)
setup_small_camera_start()
wait_time(2.5)
if manager ~= nil then
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor005)
DontChangeRandomCamera(true)
end
wait_time(0.5)
turn_lookat(Actor005,Actor001,0.3)
wait_time(0.3)
PlayActionDirect(Actor005,"to Std_Loop")
turn_lookat(Actor006,Actor001,0.3)
wait_time(0.3)
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor001,255,0.2)
turn_lookat(Actor004,Actor005,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:ノワール
	Talk(Actor005,"CHRNAME_EXCELIA","speech","L","EA_004_0310027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エクセリアにリリアーナ？どうしたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定2")
-- ▲直接出力

	--★★リリアーナ★★:そろそろアダンの授業だから呼びにきたんです<br>私はそんなに急かさなくてもと言ったんですが…
	Talk(Actor006,"CHRNAME_LILIANA","speech","L","EA_004_0310029")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:早く行きましょう<br>今日の戦術について説明もしたいから
	Talk(Actor005,"CHRNAME_EXCELIA","speech","L","EA_004_0310030")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,260,0.2)
wait_time(0.2)
slidemove(Actor005,-2.53,0,-3.2 ,3.0)
wait_time(1.2)
PlayActionDirect(Actor006,"to Wlk")
wait_time(0.1)
turn_chara(Actor006,265,0.2)
wait_time(0.2)
slidemove(Actor006,-1.77,0,-2.628 ,2.3)
wait_time(2.3)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")

	--★★ノワール★★:ちょ、待てって…！ああ、もう…<br>ランスロット、出し物の件はまた後で！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0310033")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera004
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
