-- このluaスクリプトは、PT4_01_08_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ガラハッドじゃないかそれにアステラも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:おはよう、ノワール
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040003")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アステラ", "肯定")
-- ▲直接出力

	--★★アステラ★★:おはよう休日なのに早起きなのね
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力

	--★★ガラハッド★★:アステラがいつも遅いだけじゃないのか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アステラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アステラ★★:そうともいうわね
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040006")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ！ところでガラハッド、学園生活はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0040007")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:どうだと言われてもな初めてのことばかりで、なんと答えていいものか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("アステラ", "喜び")
-- ▲直接出力

	--★★アステラ★★:うんうん、いいわね♪
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040009")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:な、なんだアステラ藪から棒に…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040010")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★アステラ★★:こういうときに、なんて答えればいいのかそれを勉強するいい機会よ
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:これが、勉強…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アステラ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アステラ★★:そう。あなたはコルベニック城のなかの生活しか知らないから
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040013")


	--★★アステラ★★:こういった機会に外の世界の生活を学んでおくべきよ
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040014")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力

	--★★ガラハッド★★:そういうものなのか。ガラハッドはずっとコルベニック城にいるのでもいいのだが
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アステラの言うとおりかもな誰しもいつかは独り立ちするときが来るから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0040016")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:むっ！ひょっとしてガラハッドを子供扱いしているのか！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:甘く見るなノワール！ガラハッドはもう子供ではない！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:悪い、そんなつもりじゃなかったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0040019")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アステラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アステラ★★:ほらほらガラハッドノワールを困らせちゃダメじゃない
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","PT4_01_08_0040020")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:だいたいアステラがそうやってだな…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","PT4_01_08_0040021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:たはは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0040022")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
