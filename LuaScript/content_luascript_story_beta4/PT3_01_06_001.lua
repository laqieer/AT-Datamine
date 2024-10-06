-- このluaスクリプトは、PT3_01_06_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:兄さん、おはよ――
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あれ？ちょっと顔が赤くない？<br>熱でもあるんじゃない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、いつもと変わらないよ<br>今日は少し暑いからじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0010005")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:本当に？<br>なにかあってからじゃ遅いよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010006")


	--★★ディナタン★★:念のため<br>モルガン先生に診てもらったら？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん、そうだなあ<br>本当に具合が悪くなったら行ってみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:もう少し早ければ<br>美味しいリンゴ食べに行きなよって言えたのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:リンゴ？<br>なんだそれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0010010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:別荘で獲れたリンゴが<br>少しだけ送られてきたんだって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010011")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:療養院を訪れた生徒に<br>おすそわけしてたみたいなんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010012")


	--★★ディナタン★★:美味しいってウワサが広まって<br>生徒がみんな押し寄せちゃって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あっという間になくなっちゃったの<br>私も食べられなかった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:マルディサントはそれを聞いて大騒ぎしてた<br>先生のリンゴ、すごく食べたかったみたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01_06_0010015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ、ちょっと興味湧いてきたよ<br>いつか食べられるといいな、そのリンゴ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0010016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
