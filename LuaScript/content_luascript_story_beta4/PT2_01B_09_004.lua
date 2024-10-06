-- このluaスクリプトは、PT2_01B_09_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("キッス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あら、おはようラビットちゃん♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040002")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:キッスさん？また珍しいところで会うな<br>どうしてここに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:少し学園に用があったついでにね
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キッス★★:こういう機会でもないと<br>寮の中ってなかなか見れないでしょ
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁ…そうかもな<br>学園にはなんの用事で？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0040006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ケイ卿からのお願いでね<br>国葬の準備を手伝ってたの
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040007")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:遺族の方々に国葬のことを知らせるにも<br>なにしろ数が数でしょ
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なるほど<br>エージェント・キッスの出番だったわけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0040009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:そういうこと
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:言ってくれれば手伝ったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0040011")

-- ▼直接出力
PlayPartVoice("キッス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:手伝わせるつもりだったんだけど<br>ケイ卿に止められちゃったのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040012")


	--★★キッス★★:「円卓の騎士はあなたの小間使いではない！」<br>って、もうカンカン
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040013")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キッス★★:１件１ブリテンコインで、１週間で３００件…<br>ラビットちゃんなら余裕だと思ったんだけど
	Talk(Actor002,"CHRNAME_KISS","speech","L","PT2_01B_09_0040014")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:余裕じゃないよ…<br>（ありがとう、ケイ）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0040015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
