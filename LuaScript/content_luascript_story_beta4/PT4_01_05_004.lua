-- このluaスクリプトは、PT4_01_05_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",242,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:ノワールちょうどいいところに来たな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT4_01_05_0040002")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？俺になにか用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0040003")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:今、キャメリアードを無事に取り返せたときのお祝いの料理をなににするか考えてるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT4_01_05_0040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リオネス★★:あたしは肉料理がいいと思う！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","PT4_01_05_0040005")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:せっかくだからサプライズにしたいんだけどノワール、ギネヴィアの好物を知らないか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT4_01_05_0040006")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力

	--★★リオネス★★:ギネヴィアはなんの肉が好きなんだ！？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","PT4_01_05_0040007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや…ごめんちょっとわからないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力

	--★★ガレス★★:そうか～ノワールもわからないか～
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT4_01_05_0040009")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:困ったなどうしよう…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT4_01_05_0040010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "悩む")
-- ▲直接出力

	--★★リオネス★★:古今東西の肉料理を集めてみるっていうのはどうだ！？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","PT4_01_05_0040011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:たはは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0040012")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだ。ギネマウアさんに聞いてみるのは？事情を話せば教えてくれると思うぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0040013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:おっ、それはいいアイディアだな～♪あとで聞きに行ってみよう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","PT4_01_05_0040014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
