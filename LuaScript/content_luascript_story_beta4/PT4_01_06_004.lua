-- このluaスクリプトは、PT4_01_06_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:マルディサント今度行くグラストンベリーってどんなところ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0040002")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:はぁ？んだよいきなり
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01_06_0040003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:俺も聞きたいな初めて行く場所だし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルディサント★★:別にどこにでもあるフツーの田舎町だよ緑が多くてそこそこキレーだけどな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01_06_0040005")

-- ▼直接出力
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力

	--★★ディナタン★★:へえ～自然に囲まれた町かぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0040006")


	--★★ディナタン★★:北のほうにあるって聞いたけどログレスより涼しいのかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0040007")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:体感でもわかるくらいは違うと思うぜ金持ち連中が避暑地として利用したりするし
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01_06_0040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうなのかそれなら食べ物も美味しそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0040009")


	--★★マルディサント★★:もう聞いてると思うけど名産物っつったらリンゴだな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01_06_0040010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:モルガンせんせの別荘の周りにもリンゴの樹がたくさんあるぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","PT4_01_06_0040011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:あっ、ウワサのモルガン先生のリンゴ！このあいだのおすそわけ食べられなかったんだ～
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0040012")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
set_enable_auto_lookat(Actor001, true)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:今度こそ食べたいね、兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0040013")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。せっかくだし久しぶりにゆっくりしたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0040014")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
