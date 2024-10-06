-- このluaスクリプトは、PT2_01B_12_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:なんつーかさ<br>世のなかってうまくいかねーもんだよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030002")


	--★★ガウェイン★★:ローマを退けて聖杯も手に入れて<br>ふつうなら大勝利ってとこなのに
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:まさかギネヴィアとマーリン様が<br>連れ去られるとか…こんなん予想できねーって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ふたりの身が心配だ<br>一刻も早く助けに行かないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0030005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そう焦んなって<br>向こうもすぐに危害を加えたりはしねーはずだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030006")


	--★★ガウェイン★★:それにスノードンであんだけの敵と戦ったんだ<br>少しは休まねーと身がもたねえぞ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そうだな<br>けど、この状況でゆっくり休めるかどうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:じゃあ、今度気晴らしにでも行こうぜ<br>トリスタンやラヴェインも誘ってよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030009")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラヴェイン…？<br>ああ、スノードンの戦いで会った人か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:学園の生徒会長だよ<br>つっても、ちょっと前まで留学してたんだけどな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030011")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:マジメでカタいヤツかと思ってたら<br>話してみると意外と気さくでノリがいーんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01B_12_0030012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか<br>今度、ちゃんと話してみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0030013")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
