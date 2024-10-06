-- このluaスクリプトは、MA_01A111_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_pos(Actor002,{-1.237, 0.5,18.039})
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("女子2","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★キャメロット騎士学術院（女）★★:ギネヴィア様！<br>おはようございます！
	Talk(Actor004,"NPCNAME_0146","speech","N","MA_01A111_090002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:ごきげんよう<br>今日もイイ日ね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090003")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("女子1","笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★キャメロット騎士学術院（男）★★:ギネヴィア様！<br>今日もお美しい！
	Talk(Actor005,"NPCNAME_0151","speech","N","MA_01A111_090004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にしし♪ありがとうっ<br>あなたも髪型がキマってるわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090005")

	PlayAction(Actor006,"to  Std_Appl")
-- ▼直接出力
 --PlayPartVoice("女子1","喜び")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★キャメロット騎士学術院（男）②★★:ギネヴィア様！<br>ヨッ！ギネヴィア様！ヨッ！
	Talk(Actor006,"NPCNAME_0153","speech","N","MA_01A111_090006")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力

	--★★ギネヴィア★★:やあやあどうもどうも
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090007")

-- ▼直接出力
Appear(Actor002)
character_in_move_run(Actor002,CharaPos007,0.8,0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★エレイン★★:おはようございます！<br>ギネヴィアさん！
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","MA_01A111_090009")

-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor003,Actor002,0)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:………エレイン、今、なんて？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力

	--★★エレイン★★:「おはようございます！」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_090012")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ギネヴィア★★:そのあと！そのあと！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:………「ギネヴィア、さん」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_090015")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:え、え、えれいん、さぁぁぁん…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090017")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:どう、でしょう…？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_090018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:いい！いいに決まってるじゃん！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:宛名に…様、と書くと<br>ちょっとかしこまり過ぎてしまうなと…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_090021")

	change_face(Actor002,"Shy")

	--★★エレイン★★:呼びかた、変えてしまいました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_090022")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C109_01_Bell")
wait_time(1.5)
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:げ。遅刻だ<br>急ご、エレイン！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:はいっ、ギネヴィアさん！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_090025")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:…いつの間に、あの子
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_090027")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:なにしてんのよ<br>行くよ、お姉ちゃん！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_090029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力

	--★★ギネマウア★★:………はい。ギネヴィア様
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_090031")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
