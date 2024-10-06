-- このluaスクリプトは、PT2_01B_11_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:おはようございます、ノワール様
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おはようございます…って、マーリンさん？<br>寮になにか用ですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0050003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:多忙のアーサー様に代わって<br>みなさんの様子を見に来ました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほど、そうでしたか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0050005")


	--★★ノワール★★:…あの、マーリンさん<br>少し聞きたいことがあるんですけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0050006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:どうぞ<br>私に答えられることであれば
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050007")

-- ▼直接出力
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ローマだけでなく銀卓騎士団にも近づいて<br>魔女はなにをしようとしてるんでしょうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0050008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:魔女の目的が<br>バルバロイを使ってブリテンを支配することなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0050009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ローマと組むだけで事足りると思うんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0050010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:魔女が銀卓騎士団に近づいた理由は<br>残念ながら私にもわかりません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050011")


	--★★マーリン★★:ペレス王や銀卓騎士団が<br>魔女にとって利用価値のある存在なのか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050012")


	--★★マーリン★★:逆に、フィエナ様の言われたとおり<br>ペレス王側になにかしらの思惑があるのか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:それを見極めることが<br>今後の戦いで重要になりそうですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0050014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
